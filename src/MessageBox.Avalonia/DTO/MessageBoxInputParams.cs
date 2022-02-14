using MessageBox.Avalonia.Enums;

namespace MessageBox.Avalonia.DTO
{
    public class MessageBoxInputParams : MessageBoxCustomParams
    {
        /// <summary>
        /// Hide input letters
        /// </summary>
        public bool IsPassword { get; set; } = false;

        public PasswordRevealModes PasswordRevealMode { get; set; } = PasswordRevealModes.Hold;

        /// <summary>
        /// Watermark text
        /// </summary>
        public string WatermarkText { get; set; } = null;

        /// <summary>
        /// Multiline in input
        /// </summary>
        public bool Multiline { get; set; }

        /// <summary>
        /// Default result of input
        /// </summary>
        public string InputDefaultValue { get; set; }
    }
}