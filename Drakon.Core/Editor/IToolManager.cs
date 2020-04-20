using Drakon.Core.Tools;

namespace Drakon.Core.Editor
{
    /// <summary>
    /// Tools manager contract
    /// </summary>
    public interface IToolManager
    {
        /// <summary>
        /// Tools library storing path
        /// </summary>
        string ToolsPath { get; set; }

        /// <summary>
        /// Selected tool
        /// </summary>
        ITool SelectedTool { get; set; }
        
        /// <summary>
        /// Available tools
        /// </summary>
        IToolsCollection Tools { get; set; }

        /// <summary>
        /// Removes specified tool from list
        /// </summary>
        /// <param name="id"></param>
        void RemoveTool(string id);

        /// <summary>
        /// Loads tools list
        /// </summary>
        void LoadTools(string name = "");

        /// <summary>
        /// Saves tools list
        /// </summary>
        void SaveTools(string name = "");
    }
}