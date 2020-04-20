using Drakon.Core.Common.ObservableBase;

namespace Drakon.Core.Coding
{
    /// <summary>
    /// Simple argument contract
    /// </summary>
    public interface ICodeArgument : IObservable
    {
        /// <summary>
        /// Argument type name
        /// </summary>
        string TypeName { get; set; }

        /// <summary>
        /// Argument value
        /// </summary>
        object Value { get; set; }
    }
}