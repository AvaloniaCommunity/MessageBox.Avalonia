using System;

namespace MessageBox.Avalonia.Enums
{
    /// <summary>
    /// Result on click in message box button
    /// </summary>
    [Flags]
    public enum ButtonResult
    {
        Ok,
        Yes,
        No,
        Abort,
        Cancel,
        None
    }
}