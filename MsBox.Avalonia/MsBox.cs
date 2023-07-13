using System;
using System.Linq;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using DialogHostAvalonia;
using MsBox.Avalonia.Base;
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
        if (Application.Current != null &&
            Application.Current.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            return ShowWindowAsync();
        }

        if (Application.Current != null &&
            Application.Current.ApplicationLifetime is ISingleViewApplicationLifetime lifetime)
        {
            return ShowAsPopupAsync(lifetime.MainView as ContentControl);
        }

        throw new NotSupportedException("ApplicationLifetime is not supported");
    }

    /// <summary>
    ///  Show messagebox as window
    /// </summary>
    /// <returns></returns>
    public Task<T> ShowWindowAsync()
    {
        _viewModel.SetFullApi(_view);
        var window = new MsBoxWindow();
        window.Content = _view;
        window.DataContext = _viewModel;

        var tcs = new TaskCompletionSource<T>();

        _view.SetCloseAction(() =>
        {
            tcs.TrySetResult(_view.GetButtonResult());
            window.Close();
        });

        window.Show();
        return tcs.Task;
    }

    /// <summary>
    ///  Show messagebox as window with owner
    /// </summary>
    /// <param name="owner">Window owner </param>
    /// <returns></returns>
    public Task<T> ShowWindowDialogAsync(Window owner)
    {
        _viewModel.SetFullApi(_view);
        var window = new MsBoxWindow();
        window.Content = _view;
        window.DataContext = _viewModel;

        var tcs = new TaskCompletionSource<T>();

        _view.SetCloseAction(() =>
        {
            tcs.TrySetResult(_view.GetButtonResult());
            window.Close();
        });

        window.ShowDialog(owner);
        return tcs.Task;
    }

    /// <summary>
    ///  Show messagebox as popup
    /// </summary>
    /// <param name="owner"></param>
    /// <returns></returns>
    public Task<T> ShowAsPopupAsync(ContentControl owner)
    {
        DialogHostStyles style = null;
        if (!owner.Styles.OfType<DialogHostStyles>().Any())
        {
            style = new DialogHostStyles();
            owner.Styles.Add(style);
        }


        var parentContent = owner.Content;
        var dh = new DialogHost();
        dh.Identifier = "MsBoxIdentifier" + Guid.NewGuid();
        _viewModel.SetFullApi(_view);
        owner.Content = null;
        dh.Content = parentContent;
        dh.CloseOnClickAway = false;
        owner.Content = dh;
        var tcs = new TaskCompletionSource<T>();
        _view.SetCloseAction(() =>
        {
            tcs.TrySetResult(_view.GetButtonResult());
            DialogHost.Close(dh.Identifier);
            owner.Content = null;
            dh.Content = null;
            owner.Content = parentContent;
            if (style != null)
            {
                owner.Styles.Remove(style);
            }
        });
        DialogHost.Show(_view, dh.Identifier);
        return tcs.Task;
    }

    /// <summary>
    /// Show messagebox as popup with owner
    /// </summary>
    /// <param name="owner"></param>
    /// <returns></returns>
    public Task<T> ShowAsPopupAsync(Window owner)
    {
        return ShowAsPopupAsync(owner as ContentControl);
    }
}