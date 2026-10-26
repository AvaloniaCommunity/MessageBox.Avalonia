using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Media;

using DialogHostAvalonia;

using MsBox.Avalonia.Base;
using MsBox.Avalonia.ViewModels;
using MsBox.Avalonia.Windows;

namespace MsBox.Avalonia;

public class MsBox<V, VM, T> : IMsBox<T> where V : UserControl, IFullApi<T>, ISetCloseAction where VM : ISetFullApi<T>, IInput
{
    private readonly V _view;
    private readonly VM _viewModel;

    public string InputValue { get { return _viewModel.InputValue; } }

    public MsBox(V view, VM viewModel)
    {
        _view = view;
        _viewModel = viewModel;

        if (_viewModel is AbstractMsBoxViewModel abv)
        {
            foreach (var cls in abv.Classes)
            {
                _view.Classes.Add(cls);
            }
        }
    }

    /// <summary>
    /// Show messagebox depending on the type of application
    /// If application is SingleViewApplicationLifetime (Mobile or Browses) then show messagebox as popup
    /// If application is ClassicDesktopStyleApplicationLifetime (Desktop) then show messagebox as window
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotSupportedException"></exception>
    public Task<T> ShowAsync()
    {
        var lifetime = Application.Current?.ApplicationLifetime;

        if (lifetime is IClassicDesktopStyleApplicationLifetime)
        {
            return ShowWindowAsync();
        }

        ContentControl? host = null;
        if (lifetime is ISingleViewApplicationLifetime singleView)
        {
            host = singleView.MainView as ContentControl
                   ?? TopLevel.GetTopLevel(singleView.MainView) as ContentControl;
        }

        if (host == null)
        {
            throw new NotSupportedException("ApplicationLifetime is not supported");
        }

        return ShowAsPopupAsync(host);
    }

    /// <summary>
    ///  Show messagebox as window
    /// </summary>
    /// <returns></returns>
    public Task<T> ShowWindowAsync()
    {
        return ShowWindowCore(null);
    }

    /// <summary>
    ///  Show messagebox as non-modal window with owner
    /// </summary>
    /// <param name="owner">Window owner </param>
    /// <returns></returns>
    public Task<T> ShowWindowAsync(Window owner)
    {
        return ShowWindowCore(owner);
    }

    private Task<T> ShowWindowCore(Window? owner)
    {
        var window = CreateWindow();
        var tcs = new TaskCompletionSource<T>();

        _view.SetCloseAction(() =>
        {
            tcs.TrySetResult(_view.GetButtonResult());
            window.Close();
        });

        if (owner != null)
        {
            window.Show(owner);
        }
        else
        {
            window.Show();
        }

        return tcs.Task;
    }

    /// <summary>
    ///  Show messagebox as window with owner
    /// </summary>
    /// <param name="owner">Window owner </param>
    /// <returns></returns>
    public async Task<T> ShowWindowDialogAsync(Window owner)
    {
        var window = CreateWindow();
        var tcs = new TaskCompletionSource<T>();

        _view.SetCloseAction(() =>
        {
            tcs.TrySetResult(_view.GetButtonResult());
            window.Close();
        });

        await window.ShowDialog(owner);
        return await tcs.Task;
    }

    private MsBoxWindow CreateWindow()
    {
        _viewModel.SetFullApi(_view);
        var window = new MsBoxWindow
        {
            Content = _view,
            DataContext = _viewModel
        };
        window.Closed += _view.CloseWindow;

        if (_viewModel is AbstractMsBoxViewModel abv)
        {
            if (abv.Background != null)
            {
                window.Background = abv.Background;
            }

            if (abv.Position is { } position)
            {
                window.WindowStartupLocation = WindowStartupLocation.Manual;
                window.Position = position;
            }
        }

        return window;
    }

    /// <summary>
    /// Close messagebox from code
    /// </summary>
    public void Close()
    {
        _view.Close();
    }

    private const string ClickAwayParam = "MsBoxIdentifier_Cancel";

    /// <summary>
    ///  Show messagebox as popup
    /// </summary>
    /// <param name="owner"></param>
    /// <returns></returns>
    public Task<T> ShowAsPopupAsync(ContentControl owner)
    {
        DialogHostStyles? style = null;
        if (!owner.Styles.OfType<DialogHostStyles>().Any())
        {
            style = [];
            owner.Styles.Add(style);
        }

        var parentContent = owner.Content;
        var dh = new DialogHost
        {
            Identifier = "MsBoxIdentifier" + Guid.NewGuid()
        };
        owner.Content = null;
        dh.Content = parentContent;
        owner.Content = dh;

        return ShowInHost(dh, () =>
        {
            owner.Content = null;
            dh.Content = null;
            owner.Content = parentContent;
            if (style != null)
            {
                owner.Styles.Remove(style);
            }
        });
    }

    /// <summary>
    ///  Show messagebox as popup in existing dialog host
    /// </summary>
    /// <param name="dh"></param>
    /// <returns></returns>
    public Task<T> ShowAsPopupAsync(DialogHost dh)
    {
        return ShowInHost(dh, null);
    }

    /// <summary>
    /// Show messagebox as popup with owner
    /// </summary>
    /// <param name="owner"></param>
    /// <returns></returns>
    public Task<T> ShowAsPopupAsync(Window owner)
    {
        return ShowAsPopupAsync((ContentControl)owner);
    }

    private void ApplyPopupBackground()
    {
        if (_viewModel is AbstractMsBoxViewModel { Background: { } background })
        {
            _view.Background = background;
            return;
        }

        if (_view.Background != null)
        {
            return;
        }

        var app = Application.Current;
        foreach (var key in new[] { "SystemRegionBrush", "ThemeBackgroundBrush" })
        {
            if (app != null && app.TryGetResource(key, app.ActualThemeVariant, out var resource) &&
                resource is IBrush brush)
            {
                _view.Background = brush;
                return;
            }
        }

        _view.Background = Brushes.White;
    }

    private Task<T> ShowInHost(DialogHost dh, Action? cleanup)
    {
        _viewModel.SetFullApi(_view);
        _view.Classes.Add("MsBoxPopup");
        ApplyPopupBackground();

        dh.CloseOnClickAway = _viewModel is AbstractMsBoxViewModel { CloseOnClickAway: true };
        dh.CloseOnClickAwayParameter = ClickAwayParam;

        void OnClosing(object? sender, DialogClosingEventArgs e)
        {
            if (e.Parameter?.ToString() == ClickAwayParam)
            {
                _view.Close();
            }
        }

        dh.DialogClosing += OnClosing;

        var tcs = new TaskCompletionSource<T>();
        _view.SetCloseAction(() =>
        {
            var result = _view.GetButtonResult();
            dh.DialogClosing -= OnClosing;

            if (dh.CurrentSession is { IsEnded: false })
            {
                dh.CurrentSession.Close();
            }

            _view.Classes.Remove("MsBoxPopup");
            cleanup?.Invoke();
            tcs.TrySetResult(result);
        });

        _ = DialogHost.Show(_view, dh);
        return tcs.Task;
    }
}
