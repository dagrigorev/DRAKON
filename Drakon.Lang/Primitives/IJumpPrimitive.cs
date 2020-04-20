using Drakon.Core.Containers.Coding;

namespace Drakon.Lang.Primitives
{
    /// <summary>
    /// Jump code primitive contract
    /// </summary>
    public interface IJumpPrimitive : ICodePrimitive
    {
        /// <summary>
        /// Jump destination
        /// </summary>
        ICodePrimitive Destination { get; set; }
    }
}