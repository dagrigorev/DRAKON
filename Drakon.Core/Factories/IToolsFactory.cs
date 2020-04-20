using Drakon.Core.Tools;

namespace Drakon.Core.Factories
{
    /// <summary>
    /// Tools factory contract
    /// </summary>
    public interface IToolsFactory
    {
        /// <summary>
        /// Creates point tool
        /// </summary>
        /// <returns></returns>
        ITool CreatePointTool();

        /// <summary>
        /// Creates tools collection
        /// </summary>
        /// <returns></returns>
        IToolsCollection CreateDefaultToolsCollection();
    }
}