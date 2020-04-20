using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Drakon.Core.Common.ObservableBase;
using Drakon.Core.Containers.Coding;
using Drakon.Core.Tools;
using Drakon.Core.Visual.Shapes;

namespace Drakon.Core.Default.Tools
{
    /// <summary>
    /// Default tools implementation
    /// </summary>
    public class Tool : Observable, ITool
    {
        public ICodePrimitive Primitive { get; set; }
        public IShape Shape { get; set; }

        public Tool(IShape shape)
        {
            this.Shape = shape;
        }
    }
}
