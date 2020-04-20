using Drakon.Core.Visual.Shapes;

namespace Drakon.Lang.Shapes
{
    /// <summary>
    /// Start tool shape
    /// </summary>
    public interface IStartShape : IRectangleShape
    {
        /// <summary>
        /// Output point shape
        /// </summary>
        IPointShape OutputPoint { get; set; }
    }
}