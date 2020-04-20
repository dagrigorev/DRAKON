using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Drakon.Core.Common.ObservableBase;
using Drakon.Core.Visual.Styles;

namespace Drakon.Core.Visual.Shapes
{
    /// <summary>
    /// Base shape contract
    /// </summary>
    public interface IShape : IObservable
    {
        Point Position { get; set; }
        IShapeStyle Style { get; set; }
        string Label { get; set; }
        IShape ConnectedShape { get; set; }

        void Select();
        void Unselect();
    }
}
