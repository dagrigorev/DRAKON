using System.Linq.Expressions;
using Drakon.Core.Visual.Styles;

namespace Drakon.Core.Factories
{
    /// <summary>
    /// Shapes and other containers styles factory contract
    /// </summary>
    public interface IStyleFactory
    {
        /// <summary>
        /// Creates default style for PointShape
        /// </summary>
        /// <returns></returns>
        IShapeStyle CreatePointShapeStyle();

        /// <summary>
        /// Creates default line style 
        /// </summary>
        /// <returns></returns>
        IShapeStyle CreateLineShapeStyle();
    }
}