using Drakon.Core.Common.Collections;

namespace Drakon.Core.Coding
{
    /// <summary>
    /// Arguments stack
    /// </summary>
    public interface IArgumentsStack : IObservableStack<ICodeArgument>
    {
        /// <summary>
        /// Adds argument
        /// </summary>
        /// <param name="arg"></param>
        void AddArgument(ICodeArgument arg);

        /// <summary>
        /// Removes argument
        /// </summary>
        /// <param name="arg"></param>
        void RemoveArgument(out ICodeArgument arg);
    }
}