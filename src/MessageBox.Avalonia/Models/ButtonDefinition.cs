using MessageBox.Avalonia.Enums;

namespace MessageBox.Avalonia.Models
{
    public class ButtonDefinition
    {
        /// <summary>
        /// Button type
        /// </summary>
        private ButtonType _type = ButtonType.Default;
        /// <summary>
        /// Text in button
        /// </summary>
        public string Name { get; set; } = "OK";
        
       

        public ButtonType Type
        {
            set { _type = value; }
        }

        public string TypeName => _type.ToString();

        /// <summary>
        /// When true and if ENTER key is pressed, the button will be called
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// When true and if ESC key is pressed, the button will be called
        /// </summary>
        public bool IsCancel { get; set; }
    }
}