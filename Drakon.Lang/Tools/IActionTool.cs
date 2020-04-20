using System;
using Drakon.Core.Tools;
using Drakon.Core.Visual.Shapes;

namespace Drakon.Lang.Tools
{
    /// <summary>
    /// Simple action tool contract
    /// </summary>
    public interface IActionTool : ITool
    {
        string SourceCode { get; set; }
    }
}
