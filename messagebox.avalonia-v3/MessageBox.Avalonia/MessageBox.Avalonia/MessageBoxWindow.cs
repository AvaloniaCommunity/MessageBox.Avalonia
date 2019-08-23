using System;
using System.Threading.Tasks;
using Avalonia.Controls;
using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Enums;

namespace MessageBox.Avalonia
{
    public partial class MessageBoxWindow
    {
        /// <summary>
        /// Show created window
        /// </summary>
        /// <returns>Return button id</returns>
        public  Task<string> Show()
        {
            var tcs = new TaskCompletionSource<string>();
            _window.Closed += delegate { tcs.TrySetResult(_window.ButtonResult); };
            _window.Show();
            return tcs.Task;
        }

        /// <summary>
        /// Show created window as dialog window
        /// </summary>
        /// <param name="ownerWindow">Parent window</param>
        /// <returns>Return button id</returns>
        public  Task<string> ShowDialog(Window ownerWindow)
        {
            var tcs = new TaskCompletionSource<string>();
            _window.Closed += delegate { tcs.TrySetResult(_window.ButtonResult); };
            _window.ShowDialog(ownerWindow);
            return tcs.Task;
        }

        /// <summary>
        /// Create new message box with your own custom buttons
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public static MessageBoxWindow CreateCustomWindow(MessageBoxCustomParams dto)
        {
            return new MessageBoxWindow(dto);
        }

        /// <summary>
        /// Create message box window with Ok button
        /// </summary>
        /// <param name="title"></param>
        /// <param name="message"></param>
        public MessageBoxWindow(string title, string message):this(CreateCustomParams(title,message))
        {
            
        }

        /// <summary>
        /// Create message box window 
        /// </summary>
        /// <param name="params"></param>
        /// <exception cref="NotImplementedException"></exception>
        public MessageBoxWindow(MessageBoxParams @params) : this(CreateCustomParams(@params))
        {
        }
    }
}