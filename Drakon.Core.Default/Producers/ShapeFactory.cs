using System;
using System.Collections.Generic;
using System.Text;
using Drakon.Core.Default.Visual.Shapes;
using Drakon.Core.Factories;
using Drakon.Core.Visual.Shapes;

namespace Drakon.Core.Default.Factories
{
    /// <summary>
    /// Default shape factory implementation
    /// </summary>
    public class ShapeFactory : IShapeFactory
    {
        /// <summary>
        /// Creats point shape
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public IPointShape CreatePointShape(int x, int y)
        {
            return new PointShape(x, y);
        }

        /// <summary>
        /// Creates rectangle shape
        /// </summary>
        /// <param name="topLeftX"></param>
        /// <param name="topLeftY"></param>
        /// <param name="bottomRightX"></param>
        /// <param name="bottomRightY"></param>
        /// <returns></returns>
        public IRectangleShape CreateRectangleShape(int topLeftX, int topLeftY, int bottomRightX, int bottomRightY)
        {
            throw new NotImplementedException();
        }
    }
}
