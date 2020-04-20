using System;
using System.Collections.Generic;
using System.Text;

namespace Drakon.Core.Visual.Shapes
{
    /// <summary>
    /// Simple circle contract
    /// </summary>
    public interface ICircleShape : IShape
    {
        IPointShape Center { get; set; }
        uint Radius { get; set; }
        uint AnglesCount { get; set; }
    }
}
