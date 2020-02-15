using System;

namespace MessageBox.Avalonia.Enums
{
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