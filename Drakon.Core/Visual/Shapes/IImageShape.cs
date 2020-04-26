namespace Drakon.Core.Visual.Shapes
{
    /// <summary>
    /// IMage drawing mode
    /// </summary>
    public enum DrawMode
    {
        Stretch,
        Fill,
        Center,
        Litter
    }

    /// <summary>
    /// Image shape contract
    /// </summary>
    public interface IImageShape : IShape
    {
        /// <summary>
        /// Image width
        /// </summary>
        int Width { get; set; }

        /// <summary>
        /// Image height
        /// </summary>
        int Height { get; set; }

        /// <summary>
        /// Drawing mode
        /// </summary>
        DrawMode Mode { get; set; }

        /// <summary>
        /// Indicates that image will be rescaled on zoom factor changing
        /// </summary>
        bool IsRescaled { get; set; }
    }
}