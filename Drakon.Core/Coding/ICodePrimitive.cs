using Drakon.Core.Coding;
using Drakon.Core.Common.ObservableBase;

namespace Drakon.Core.Containers.Coding
{
    /// <summary>
    /// Code snippet primitive contract
    /// </summary>
    public interface ICodePrimitive : IObservable
    {
        /// <summary>
        /// Code arguments
        /// </summary>
        IArgumentsStack Arguments { get; }

        /// <summary>
        /// Included source code
        /// </summary>
        string SourceCode { get; set; }

        /// <summary>
        /// Return type name
        /// </summary>
        string ReturnType { get; set; }

        /// <summary>
        /// Returns primitive execution result
        /// </summary>
        string Result { get; }
    }
}