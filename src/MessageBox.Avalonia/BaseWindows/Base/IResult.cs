using System;
using System.Collections.Generic;
using System.Text;

namespace MessageBox.Avalonia.BaseWindows.Base
{
    public interface IResult<T>
    {
        T GetResult();
    }
}
