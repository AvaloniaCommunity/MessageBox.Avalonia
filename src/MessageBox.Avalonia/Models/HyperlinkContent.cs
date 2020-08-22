using System;
using System.Collections.Generic;
using System.Text;

namespace MessageBox.Avalonia.Models
{
    public class HyperlinkContent
    {
        /// <summary>
        /// Url what would be displayed
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// Alias what would be clickable if set,else raw url would be displayed
        /// </summary>
        public string Alias { get; set; }
    }
}
