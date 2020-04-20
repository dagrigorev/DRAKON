using System.Runtime.CompilerServices;

namespace Drakon.Core.Visual.Shapes
{
    /// <summary>
    /// Rectangle shape contract
    /// </summary>
    public interface IRectangleShape : IShape
    {
        IRectangleShape Style { get; set; }
        IPointShape TopLeft { get; set; }
        IPointShape BottomRight { get; set; }
    }
}