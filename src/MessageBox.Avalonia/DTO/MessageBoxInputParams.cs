using MessageBox.Avalonia.Enums;

namespace MessageBox.Avalonia.DTO
{
    public class MessageBoxInputParams : MessageBoxCustomParams
    {
        public enum PasswordRevealModes : byte
        {
            /// <summary>
            /// Don't show the reveal button
            /// </summary>
            None,

            /// <summary>
            /// Left click to toggle the reveal password
            /// </summary>
            Toggle,

            /// <summary>
            /// Left or right click and hold to temporary reveal the password
            /// </summary>
            Hold,

            /// <summary>
            /// Left click to toggle the reveal password | Right click and hold will temporary reveal password
            /// </summary>
            Both,
        }
        public Icon Icon { get; set; } = Icon.None;
        public bool IsPassword { get; set; } = false;
        public PasswordRevealModes PasswordRevealMode { get; set; } = PasswordRevealModes.Hold;
        public string WatermarkText { get; set; } = null;
        public bool Multiline { get; set; }
    }
}