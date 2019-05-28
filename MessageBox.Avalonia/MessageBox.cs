using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Media.Imaging;

namespace Messagebox.Avalonia
{
    public class MessageBox : Window
    {
        private MessageBox()
        {
        }
        private class MsgBx 
        {
            [DllImport("User32.dll", CharSet = CharSet.Auto)]
            public static extern int MessageBox(IntPtr ptr, string text, string title, int type);
        }

        public MessageBoxResult Res { get; set; }

        public enum MessageBoxButtons
        {
            Ok,
            OkCancel,
            YesNo,
            YesNoCancel
        }

        public class WindowSize
        {
            public int Height { get; set; }
            public int Width { get; set; }
        }

        public enum MessageBoxResult
        {
            Ok,
            Cancel,
            Yes,
            No
        }

        private static MessageBox CreateWindow(string title, string text,
            MessageBoxButtons buttons = MessageBoxButtons.Ok, WindowSize windowSize = null, Bitmap bitmap = null)
        {
            var messageBox = new MessageBox();
            if (windowSize == null)
            {
                messageBox.Height = 100;
                messageBox.Width = 300;
            }
            else
            {
                messageBox.Height = windowSize.Height;
                messageBox.Width = windowSize.Width;
            }

            messageBox.Content = CreateBaseMsgBox(text, buttons, messageBox);
            if (bitmap != null)
            {
                try
                {
                    messageBox.Icon = new WindowIcon(bitmap);
                }
                catch
                {
                    throw new ArgumentException("Invalid bitmap for icon");
                }
            }

            messageBox.CanResize = false;
            return messageBox;
        }
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

        private static Button GetButton(MessageBox window, MessageBoxResult result)
        {
            var btn = new Button();
            btn.Content =" "+ result+" ";
            btn.Click += (_, __) =>
            {
                window.Res = result;
                window.Close();
            };
            return btn;
        }

        private static Grid GetButtonGrid(params Button[] buttons)
        {
            var grid = new Grid();
            List<ColumnDefinition> definitions = new List<ColumnDefinition>();
            definitions.Add(new ColumnDefinition {Width = new GridLength(1, GridUnitType.Star)});
            for (int i = 0; i < buttons.Length; i++)
            {
                definitions.Add(new ColumnDefinition {Width = new GridLength(5)});
                definitions.Add(new ColumnDefinition {Width = new GridLength(1, GridUnitType.Auto)});
            }

            definitions.Add(new ColumnDefinition {Width = new GridLength(5)});
            grid.ColumnDefinitions.AddRange(definitions);
            var j = 2;
            foreach (var btn in buttons)
            {
                Grid.SetColumn(btn, j);
                j += 2;
                grid.Children.Add(btn);
            }

            return grid;
        }

        private static Grid CreateBaseMsgBox(string text, MessageBoxButtons buttons, MessageBox window)
        {

            var grid = new Grid();
            var row1 = new RowDefinition();
            var row2 = new RowDefinition();
            var row3 = new RowDefinition();
            var row4 = new RowDefinition();
            var row5 = new RowDefinition();
            var textBlock = new TextBlock();
            textBlock.Text = text;
            textBlock.TextAlignment = TextAlignment.Center;
            textBlock.TextWrapping = TextWrapping.Wrap;
            textBlock.FontSize = 14;
            textBlock.FontWeight = FontWeight.Bold;
            row1.Height = new GridLength(1, GridUnitType.Star);
            row2.Height = new GridLength(1, GridUnitType.Auto);
            row3.Height = new GridLength(1, GridUnitType.Star);
            row4.Height = new GridLength(1, GridUnitType.Auto);
            row5.Height = new GridLength(5);

            grid.RowDefinitions.AddRange(new[] {row1, row2, row3, row4, row5});
            Grid.SetRow(textBlock, 1);
            grid.Children.Add(textBlock);
            switch (buttons)
            {
                case MessageBoxButtons.Ok:
                {
                    var btnGrid = GetButtonGrid(GetButton(window, MessageBoxResult.Ok));
                    Grid.SetRow(btnGrid, 3);
                    grid.Children.Add(btnGrid);
                }
                    break;
                case MessageBoxButtons.OkCancel:
                {
                    var btnGrid = GetButtonGrid(GetButton(window, MessageBoxResult.Ok),
                        GetButton(window, MessageBoxResult.Cancel));
                    Grid.SetRow(btnGrid, 3);
                    grid.Children.Add(btnGrid);
                }
                    break;
                case MessageBoxButtons.YesNo:
                {
                    var btnGrid = GetButtonGrid(GetButton(window, MessageBoxResult.Yes),
                        GetButton(window, MessageBoxResult.No));
                    Grid.SetRow(btnGrid, 3);
                    grid.Children.Add(btnGrid);
                }
                    break;
                case MessageBoxButtons.YesNoCancel:
                {
                    var btnGrid = GetButtonGrid(GetButton(window, MessageBoxResult.Yes),
                        GetButton(window, MessageBoxResult.No),
                        GetButton(window, MessageBoxResult.Cancel));
                    Grid.SetRow(btnGrid, 3);
                    grid.Children.Add(btnGrid);
                }
                    break;
            }

            return grid;
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
                        case MessageBoxButtons.Ok:
                            buttonNumb = 0;
                            break;
                        case MessageBoxButtons.OkCancel:
                            buttonNumb = 1;
                            break;
                        case MessageBoxButtons.YesNo:
                            buttonNumb = 5;
                            break;
                        case MessageBoxButtons.YesNoCancel:
                            buttonNumb = 3;
                            break;
                    }

                    var result = MsgBx.MessageBox((IntPtr) 0, text, title, type: buttonNumb);
                    MessageBoxResult boxResult;
                    var tcs = new TaskCompletionSource<MessageBoxResult>();
                    switch (result)
                    {
                        case 1:
                            boxResult = MessageBoxResult.Ok;
                            break;
                        case 2:
                            boxResult = MessageBoxResult.Cancel;
                            break;
                        case 6:
                            boxResult = MessageBoxResult.Yes;
                            break;
                        case 7:
                            boxResult = MessageBoxResult.No;
                            break;
                        default:
                            boxResult = MessageBoxResult.Ok;
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
