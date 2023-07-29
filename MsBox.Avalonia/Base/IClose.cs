using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace MsBox.Avalonia.Base;

public interface IClose
{
    void Close();

    void CloseWindow(object sender, EventArgs eventArgs);
}