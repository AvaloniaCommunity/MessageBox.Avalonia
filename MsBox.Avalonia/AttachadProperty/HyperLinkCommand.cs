using System.Reactive;
using System.Windows.Input;
using Avalonia;
using Avalonia.Data;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace MsBox.Avalonia.AttachadProperty;

public class HyperLinkCommand : AvaloniaObject
{
    static HyperLinkCommand()
    {
        CommandProperty.Changed.Subscribe(new AnonymousObserver<AvaloniaPropertyChangedEventArgs<ICommand>>(x =>
            HandleCommandChanged(x.Sender, x.NewValue.GetValueOrDefault<ICommand>())));
    }

    public static readonly AttachedProperty<ICommand> CommandProperty =
        AvaloniaProperty.RegisterAttached<HyperLinkCommand, Interactive, ICommand>(
            "Command", default(ICommand), false, BindingMode.OneWay);

    private static void HandleCommandChanged(AvaloniaObject element, ICommand commandValue)
    {
        if (element is Interactive interactElem)
        {
            if (commandValue != null)
            {
                // Add non-null value
                interactElem.AddHandler(InputElement.PointerPressedEvent, Handler);
            }
            else
            {
                // remove prev value
                interactElem.RemoveHandler(InputElement.PointerPressedEvent, Handler);
            }
        }

        // local handler fcn
        static void Handler(object s, RoutedEventArgs e)
        {
            if (s is Interactive interactElem)
            {
                // This is how we get the parameter off of the gui element.
                var commandValue = interactElem.GetValue(CommandProperty);
                commandValue.Execute(null);
            }
        }
    }

    /// <summary>
    /// Accessor for Attached property <see cref="CommandProperty"/>.
    /// </summary>
    public static void SetCommand(AvaloniaObject element, ICommand commandValue)
    {
        element.SetValue(CommandProperty, commandValue);
    }

    /// <summary>
    /// Accessor for Attached property <see cref="CommandProperty"/>.
    /// </summary>
    public static ICommand GetCommand(AvaloniaObject element)
    {
        return element.GetValue(CommandProperty);
    }
}