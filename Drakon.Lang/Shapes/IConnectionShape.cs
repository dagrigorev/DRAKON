using Drakon.Core.Visual.Shapes;

namespace Drakon.Lang.Shapes
{
    /// <summary>
    /// Block connection tool shape
    /// </summary>
    public interface IConnectionShape : ILineShape
    {
        /// <summary>
        /// Connection parallelization point
        /// </summary>
        IPointShape ParallelizePoint { get; set; }

        /// <summary>
        /// Parallel connections
        /// </summary>
        IConnectionShape[] ParallelConnections { get; set; }
    }
}