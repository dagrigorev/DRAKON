using Drakon.Core.Containers.Coding;

namespace Drakon.Lang.Primitives
{
    /// <summary>
    /// Conditional operator primitive
    /// </summary>
    public interface IConditionalPrimitive : ICodePrimitive
    {
        /// <summary>
        /// Checks that condition string is correct
        /// </summary>
        /// <returns></returns>
        bool IsConditionCorrect();
    }
}