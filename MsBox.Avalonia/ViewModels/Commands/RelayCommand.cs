using System;
using System.Windows.Input;

namespace MsBox.Avalonia.ViewModels.Commands;

public class RelayCommand : ICommand
{
    private readonly Func<object, bool> canExecute;
    private readonly Action<object> execute;
    private EventHandler? _canExecuteChanged;

    public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
    {
        this.execute = execute;
        this.canExecute = canExecute;
    }

    public event EventHandler CanExecuteChanged
    {
        add => _canExecuteChanged += value;
        remove => _canExecuteChanged -= value;
    }

    public bool CanExecute(object parameter)
    {
        return this.canExecute == null || this.canExecute(parameter);
    }

    public void Execute(object parameter)
    {
        this.execute(parameter);
    }
}