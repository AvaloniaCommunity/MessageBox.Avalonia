using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Media.Imaging;

namespace ClassLibrary1
{
    public partial class MessageBox : Window
    {
        /// <summary>
        /// Show window, wich return button result
        /// </summary>
        /// <param name="title"></param>
        /// <param name="text"></param>
        /// <param name="buttons"></param>
        /// <param name="windowSize"></param>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public static Task<MessageBoxResult> ShowForResult(string title, string text,
            MessageBoxButtons buttons = MessageBoxButtons.Ok, WindowSize windowSize = null, Bitmap bitmap = null)
        {

            var messageBox = CreateWindow(title, text, buttons, windowSize, bitmap);
            var tcs = new TaskCompletionSource<MessageBoxResult>();
            messageBox.Title = title;
            messageBox.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            messageBox.Closed += delegate { tcs.TrySetResult(messageBox.Res); };
            messageBox.Show();
            return tcs.Task;
        }

        /// <summary>
        /// Show dialog window, wich return button result
        /// </summary>
        /// <param name="title"></param>
        /// <param name="text"></param>
        /// <param name="parent"></param>
        /// <param name="buttons"></param>
        /// <param name="windowSize"></param>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public static Task<MessageBoxResult> ShowDialog(string title, string text, Window parent,
            MessageBoxButtons buttons = MessageBoxButtons.Ok, WindowSize windowSize = null, Bitmap bitmap = null)
        {

            var messageBox = CreateWindow(title, text, buttons, windowSize, bitmap);
            var tcs = new TaskCompletionSource<MessageBoxResult>();
            messageBox.Title = title;
            messageBox.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            messageBox.Closed += delegate { tcs.TrySetResult(messageBox.Res); };
            messageBox.ShowDialog(parent);
            return tcs.Task;
        }

        /// <summary>
        /// show window with ok button and ignore result
        /// </summary>
        /// <param name="title"></param>
        /// <param name="text"></param>
        /// <param name="windowSize"></param>
        /// <param name="bitmap"></param>
        public static void Show(string title, string text, WindowSize windowSize = null, Bitmap bitmap = null)
        {

            var messageBox = CreateWindow(title, text, MessageBoxButtons.Ok, windowSize, bitmap);
            messageBox.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            messageBox.Title = title;

            messageBox.Show();
        }

        /// <summary>
        /// try to show native messagebox and return result
        /// if failed use method showdialog 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="text"></param>
        /// <param name="buttons"></param>
        /// <returns></returns>
        public static Task<MessageBoxResult> ShowNative(string title, string text,
            MessageBoxButtons buttons = MessageBoxButtons.Ok)
        {
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                try
                {
                    int buttonNumb = 0;
                    switch (buttons)
                    {
                        case MessageBox.MessageBoxButtons.Ok:
                            buttonNumb = 0;
                            break;
                        case MessageBox.MessageBoxButtons.OkCancel:
                            buttonNumb = 1;
                            break;
                        case MessageBox.MessageBoxButtons.YesNo:
                            buttonNumb = 5;
                            break;
                        case MessageBox.MessageBoxButtons.YesNoCancel:
                            buttonNumb = 3;
                            break;
                    }

                    var result = MsgBx.MessageBox((IntPtr) 0, text, title, type: buttonNumb);
                    MessageBox.MessageBoxResult boxResult;
                    var tcs = new TaskCompletionSource<MessageBox.MessageBoxResult>();
                    switch (result)
                    {
                        case 1:
                            boxResult = MessageBox.MessageBoxResult.Ok;
                            break;
                        case 2:
                            boxResult = MessageBox.MessageBoxResult.Cancel;
                            break;
                        case 6:
                            boxResult = MessageBox.MessageBoxResult.Yes;
                            break;
                        case 7:
                            boxResult = MessageBox.MessageBoxResult.No;
                            break;
                        default:
                            boxResult = MessageBox.MessageBoxResult.Ok;
                            break;
                    }

                    tcs.TrySetResult(boxResult);

                    return tcs.Task;
                }
                catch
                {
                    // ignored
                }
            }

            return ShowForResult(title, text, buttons);
        }
    }

}