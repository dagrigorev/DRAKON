using Drakon.Core.Containers.Coding;
using Drakon.Core.Tools;

namespace Drakon.Lang.Primitives
{
    /// <summary>
    /// Start primitive contract
    /// </summary>
    public interface IStartPrimitive : ICodePrimitive
    {
        /// <summary>
        /// Starting program name
        /// </summary>
        string ProgramName { get; set; }
    }
}