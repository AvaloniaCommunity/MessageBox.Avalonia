using System;

namespace MessageBox.Avalonia.Exceptions
{
    public class InvalidUrlException : Exception
    {
        public InvalidUrlException(string message) : base(message)
        {
        }
    }
}