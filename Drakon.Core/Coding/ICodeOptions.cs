using Drakon.Core.Common.ObservableBase;

namespace Drakon.Core.Coding
{
    /// <summary>
    /// Coding primitives and style options
    /// </summary>
    public interface ICodeOptions : IObservable
    {
        /// <summary>
        /// Argument naming convention
        /// </summary>
        string ArgumentPrefix { get; set; }

        /// <summary>
        /// Function naming convention
        /// </summary>
        string FunctionPrefix { get; set; }

        /// <summary>
        /// Argument map name
        /// </summary>
        string ArgumentMapName { get; set; }

        /// <summary>
        /// Call sequence name
        /// </summary>
        string CallSequenceName { get; set; }
    }
}