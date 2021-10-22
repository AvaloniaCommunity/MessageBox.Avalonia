using System.Collections.Generic;
using Avalonia.Media.Imaging;
using MessageBox.Avalonia.Models;

namespace MessageBox.Avalonia.DTO
{
    public class MessageBoxCustomParamsWithImage : AbstractMessageBoxParams
    {
        /// <summary>
        /// Image of window
        /// </summary>
        public Bitmap Icon { get; set; }

        /// <summary>
        /// Buttons
        /// </summary>
        public IEnumerable<ButtonDefinition> ButtonDefinitions { get; set; }
    }
}