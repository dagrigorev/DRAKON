using Drakon.Core.Containers.Coding;

namespace Drakon.Lang.Primitives
{
    /// <summary>
    /// Action code primitive contract
    /// </summary>
    public interface IActionPrimitive : ICodePrimitive
    {
        /// <summary>
        /// Checks that connected arguments are defined and used correctly 
        /// </summary>
        /// <returns></returns>
        bool IsArgsCorrect();
    }
}