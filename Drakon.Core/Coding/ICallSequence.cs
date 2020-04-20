using Drakon.Core.Common.Collections;
using Drakon.Core.Containers.Coding;

namespace Drakon.Core.Coding
{
    /// <summary>
    /// Call sequence 
    /// </summary>
    public interface ICallSequence : IObservableStack<string>
    {
        /// <summary>
        /// Adds new primitives to call sequence. For several primitives will formed parallel call.
        /// </summary>
        /// <param name="code"></param>
        void AddToSequence(params ICodePrimitive[] code);

        /// <summary>
        /// Removes code from call sequence
        /// </summary>
        /// <param name="code"></param>
        void RemoveFromSequence(ICodePrimitive code);
    }
}