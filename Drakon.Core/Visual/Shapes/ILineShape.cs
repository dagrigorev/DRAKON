namespace Drakon.Core.Visual.Shapes
{
    public interface ILineShape : IShape
    {
        bool IsSquared { get; set; }
        int Size { get; set; }
        IPointShape Begin { get; set; }
        IPointShape End { get; set; }
    }
}