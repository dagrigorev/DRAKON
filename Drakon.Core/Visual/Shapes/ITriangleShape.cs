namespace Drakon.Core.Visual.Shapes
{
    /// <summary>
    /// Default triangle shape contract
    /// </summary>
    public interface ITriangleShape : IShape
    {
        IPointShape Top { get; set; }
        IPointShape Left { get; set; }
        IPointShape Right { get; set; }    
    }
}