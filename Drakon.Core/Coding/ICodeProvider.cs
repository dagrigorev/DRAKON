using Drakon.Core.Common.ObservableBase;
using Drakon.Core.Containers.Coding;
using Drakon.Core.IO.Coding;

namespace Drakon.Core.Coding
{
    /// <summary>
    /// Code provider contract
    /// </summary>
    public interface ICodeProvider : IObservable
    {
        /// <summary>
        /// Primitives repository
        /// </summary>
        ICodePrimitivesRepository Primitives { get; }

        /// <summary>
        /// Call sequence
        /// </summary>
        ICallSequence CallSequence { get; set; }

        /// <summary>
        /// Code writer
        /// </summary>
        ICodeWriter Writer { get; set; }

        /// <summary>
        /// Code checker
        /// </summary>
        ICodeChecker Checker { get; set; }

        /// <summary>
        /// Code options
        /// </summary>
        ICodeOptions Options { get; set; }

        /// <summary>
        /// Returns builded source code
        /// </summary>
        string SourceCode { get; }

        /// <summary>
        /// Adds code primitive to call sequence
        /// </summary>
        /// <param name="code"></param>
        void AddToCall(ICodePrimitive code);

        /// <summary>
        /// Removes primitive from call sequence
        /// </summary>
        /// <param name="code"></param>
        void RemoveFromCall(ICodePrimitive code);

        /// <summary>
        /// Checks the code
        /// </summary>
        void Check();

        /// <summary>
        /// Builds full source code from primitives
        /// </summary>
        void Build();

        /// <summary>
        /// Executes the code
        /// </summary>
        void Execute();
    }
}