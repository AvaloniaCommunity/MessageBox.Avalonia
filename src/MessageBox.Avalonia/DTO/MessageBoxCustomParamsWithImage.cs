using System.Collections.Generic;
using Avalonia.Media.Imaging;
using MessageBox.Avalonia.Models;

namespace MessageBox.Avalonia.DTO
{
    public class MessageBoxCustomParamsWithImage:AbstractMessageBoxParams
    {
        public Bitmap Icon { get; set; } 
        public IEnumerable<ButtonDefinition> ButtonDefinitions { get; set; }
    }
}