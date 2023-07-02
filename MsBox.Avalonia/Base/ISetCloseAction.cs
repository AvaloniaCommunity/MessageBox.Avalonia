using System;

namespace MsBox.Avalonia.Base;

public interface ISetCloseAction
{
    void SetCloseAction(Action closeAction);
}