using Drakon.Core.Visual.Shapes;

namespace Drakon.Lang.Shapes
{
    /// <summary>
    /// End tool shape
    /// </summary>
    public interface IEndShape : IRectangleShape
    {
        /// <summary>
        /// Input point shape
        /// </summary>
        IPointShape InputPoint { get; set; }
    }
}