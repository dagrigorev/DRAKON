using Drakon.Core.Coding;
using Drakon.Core.Containers.Coding;

namespace Drakon.Core.Factories
{
    /// <summary>
    /// Code primitive factory contract
    /// </summary>
    public interface ICodePrimitiveFactory
    {
        ICodePrimitive CreateCodePrimitive();
        ICodeArgument CreateArgumentContainer();
    }
}