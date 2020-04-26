using System.Drawing;

namespace Drakon.Core.Visual.Shapes
{
    /// <summary>
    /// Grid image shape contract
    /// </summary>
    public interface IGridShape : IImageShape
    {
        /// <summary>
        /// Grid cell width
        /// </summary>
        int GridCellWidth { get; set; }

        /// <summary>
        /// Grid cell height
        /// </summary>
        int GridCellHeight { get; set; }

        /// <summary>
        /// Grid color
        /// </summary>
        Color GridColor { get; set; }
    }
}