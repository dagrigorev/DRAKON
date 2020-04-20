using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Drakon.Core.Common.ObservableBase;
using Drakon.Core.Default.Visual.Styles;
using Drakon.Core.Visual.Shapes;
using Drakon.Core.Visual.Styles;

namespace Drakon.Core.Default.Visual.Shapes
{
    public class PointShape : Observable, IPointShape
    {
        public Point Position { get; set; }
        public IShapeStyle Style { get; set; }
        public string Label { get; set; }
        public IShape ConnectedShape { get; set; }

        public PointShape()
        {
            Position = Point.Empty;
            Style = new PointShapeStyle()
            {
                BorderColor = Color.Black,
                BorderThickness = 1,
                FillColor = Color.Empty,
                FontFamily = "Arial",
                FontSize = 12,
                IsFilled = false,
                IsSelected = false
            };

            Label = "<new point>";

        }

        public PointShape(int x, int y)
            : this()
        {
            Position = new Point(x, y);
        }

        public void Select()
        {
            throw new NotImplementedException();
        }

        public void Unselect()
        {
            throw new NotImplementedException();
        }
    }
}
