using System;
using System.Collections.Generic;
using System.Text;
using Drakon.Core.Common.ObservableBase;
using Drakon.Core.Containers.Coding;
using Drakon.Core.Visual.Shapes;

namespace Drakon.Core.Tools
{
    public interface ITool : IObservable
    {
        ICodePrimitive Primitive { get; set; }
        IShape Shape { get; set; }
    }
}
