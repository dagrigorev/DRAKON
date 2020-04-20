using System;
using System.Collections.Generic;
using System.Text;
using Drakon.Core.Visual.Shapes;

namespace Drakon.Core.Factories
{
    public interface IShapeFactory
    {
        IPointShape CreatePointShape(int x, int y);
        IRectangleShape CreateRectangleShape(int topLeftX, int topLeftY, int bottomRightX, int bottomRightY);
    }
}
