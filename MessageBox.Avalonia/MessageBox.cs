using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Media.Imaging;

namespace MessageBox.Avalonia
{
    public class MessageBox : Window
    {
        private MessageBox()
        {
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
                messageBox.Height = 200;
                messageBox.Width = 300;
            }
            else
            {
                messageBox.Height = windowSize.Height;
                messageBox.Width = windowSize.Width;
            }
            messageBox.Content = CreateBaseMsgBox(text, buttons, messageBox);
            if (bitmap == null)
            {
                var assembly = Assembly.GetExecutingAssembly();
                var stream = assembly.GetManifestResourceStream("AvaloniaMsg.avalonia-logo.ico");
                messageBox.Icon = new WindowIcon(stream);
            }
            else
            {
                messageBox.Icon = new WindowIcon(bitmap);
            }

            return messageBox;
        }
        public static Task<MessageBoxResult> ShowForResult(string title, string text,MessageBoxButtons buttons=MessageBoxButtons.Ok,WindowSize windowSize=null,Bitmap bitmap = null)
        {

            var messageBox = CreateWindow(title, text, buttons, windowSize, bitmap);
            var tcs = new TaskCompletionSource<MessageBoxResult>();
            messageBox.Title = title;
            messageBox.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            messageBox.Closed += delegate { tcs.TrySetResult(messageBox.Res); };
            messageBox.Show();
            return tcs.Task;
        } 
        public static Task<MessageBoxResult> ShowDialog(string title, string text,Window parent,MessageBoxButtons buttons=MessageBoxButtons.Ok,WindowSize windowSize=null,Bitmap bitmap = null)
        {
            
            var messageBox = CreateWindow(title, text, buttons, windowSize, bitmap);
            var tcs = new TaskCompletionSource<MessageBoxResult>();
            messageBox.Title = title;
            messageBox.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            messageBox.Closed += delegate { tcs.TrySetResult(messageBox.Res); };
            messageBox.ShowDialog(parent);
            return tcs.Task;
        } 

        public static void Show(string title, string text,WindowSize windowSize=null,Bitmap bitmap = null)
        {
            
            var messageBox = CreateWindow(title, text, MessageBoxButtons.Ok, windowSize, bitmap);
            messageBox.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            messageBox.Title = title;
            
            messageBox.Show();
        }

        private static Button GetButton(MessageBox window,MessageBoxResult result)
        {
           var btn = new Button();
           btn.Content = result.ToString();
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
            for (int i = 0; i < buttons.Length; i++)
            {
                definitions.Add(new ColumnDefinition{Width = new GridLength(5)});
                definitions.Add(new ColumnDefinition{Width = new GridLength(1,GridUnitType.Star)});
            }
            definitions.Add(new ColumnDefinition{Width = new GridLength(5)});
            grid.ColumnDefinitions.AddRange(definitions);
             var j = 1;
            foreach (var btn in buttons)
            {
                Grid.SetColumn(btn,j);
                j += 2;
                grid.Children.Add(btn);
            }

            return grid;
        }

        private static Grid CreateBaseMsgBox(string text,MessageBoxButtons buttons,MessageBox window)
        {
           
            var grid = new Grid();
            var row1 = new RowDefinition();
            var row2 = new RowDefinition();
            var textBlock = new TextBlock();
            textBlock.Text = text;
            textBlock.TextAlignment = TextAlignment.Center;
            textBlock.TextWrapping = TextWrapping.Wrap;
            row1.Height = new GridLength(1, GridUnitType.Star);
            row2.Height = new GridLength(1, GridUnitType.Auto);
            grid.RowDefinitions.AddRange(new[] {row1, row2});
            Grid.SetRow(textBlock,0);
            grid.Children.Add(textBlock);
            switch (buttons)
            {
                case MessageBoxButtons.Ok:
                {
                    var btnGrid = GetButtonGrid(GetButton(window, MessageBoxResult.Ok));
                    Grid.SetRow(btnGrid,1);
                    grid.Children.Add(btnGrid);
                }
                    break;
                case MessageBoxButtons.OkCancel:
                {
                    var btnGrid = GetButtonGrid(GetButton(window, MessageBoxResult.Ok),
                        GetButton(window,MessageBoxResult.Cancel));
                    Grid.SetRow(btnGrid,1);
                    grid.Children.Add(btnGrid);
                }
                    break;
                case MessageBoxButtons.YesNo:
                {
                    var btnGrid = GetButtonGrid(GetButton(window, MessageBoxResult.Yes),
                        GetButton(window,MessageBoxResult.No));
                    Grid.SetRow(btnGrid,1);
                    grid.Children.Add(btnGrid);
                }
                    break;
                case MessageBoxButtons.YesNoCancel:
                {
                    var btnGrid = GetButtonGrid(GetButton(window, MessageBoxResult.Yes),
                        GetButton(window,MessageBoxResult.No),
                        GetButton(window,MessageBoxResult.Cancel));
                    Grid.SetRow(btnGrid,1);
                    grid.Children.Add(btnGrid);
                }
                    break;
            }
            return grid;
        }
        

    }
}
