using Drakon.Core.Common.ObservableBase;

namespace Drakon.Core.Coding
{
    /// <summary>
    /// Code checker contract
    /// </summary>
    public interface ICodeChecker : IObservable
    {
        /// <summary>
        /// Checks the code
        /// </summary>
        void CheckCode();

        /// <summary>
        /// Indicates that code has no errors
        /// </summary>
        /// <returns></returns>
        bool IsCodeCorrect();

        /// <summary>
        /// Error messages array
        /// </summary>
        string[] Errors { get; set; }

        /// <summary>
        /// Warnings array
        /// </summary>
        string[] Warnings { get; set; }
    }
}