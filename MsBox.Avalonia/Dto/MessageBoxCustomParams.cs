using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Avalonia.Media.Imaging;
using MsBox.Avalonia.Models;
using MsBox.Avalonia.Enums;

namespace MsBox.Avalonia.Dto;

public class MessageBoxCustomParams : AbstractMessageBoxParams
{
    /// <summary>
    /// Image of window
    /// Only if Icon is None
    /// </summary>
    public Bitmap ImageIcon { get; set; }
    
    /// <summary>
    /// Icon of window
    /// Higher priority than ImageIcon
    /// </summary>
    public Icon Icon { get; set; } = Icon.None;

    /// <summary>
    /// Buttons
    /// </summary>
    public IEnumerable<ButtonDefinition> ButtonDefinitions { get; set; }
    
    /// <summary>
    /// Hyperlink
    /// </summary>
    public HyperLinkParams HyperLinkParams { get; set; }
}

public class HyperLinkParams
{
    /// <summary>
    ///  Hyperlink text
    /// </summary>
    public string Text { get; set; }
    
    /// <summary>
    /// Hyperlink callback
    /// </summary>
    public Action Action { get; set; }
}