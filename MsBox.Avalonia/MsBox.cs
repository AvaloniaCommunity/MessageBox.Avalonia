using System;
using System.Threading.Tasks;
using Avalonia.Controls;
using DialogHostAvalonia;
using MsBox.Avalonia.Base;
using MsBox.Avalonia.Windows;

namespace MsBox.Avalonia;

public class MsBox<V, VM, T> : IMsBox<T> where V : UserControl, IFullApi<T>, ISetCloseAction where VM : ISetFullApi<T>
{
    private readonly V _view;
    private readonly VM _viewModel;

    public MsBox(V view, VM viewModel)
    {
        _view = view;
        _viewModel = viewModel;
    }

    public Task<T> ShowAsync()
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

    public Task<T> ShowDialogAsync(Window owner)
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

    public Task<T> ShowAsPopupAsync(ContentControl owner)
    {
        owner.Styles.Add(new DialogHostStyles());
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
        });
        DialogHost.Show(_view, dh.Identifier);
        return tcs.Task;
    }

    public Task<T> ShowAsPopupAsync(Window owner)
    {
        return ShowAsPopupAsync(owner as ContentControl);
    }
}