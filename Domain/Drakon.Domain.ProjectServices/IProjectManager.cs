using Drakon.Data.Project;

namespace Drakon.Domain.ProjectServices
{
    /// <summary>
    /// Drakon project manager definition.
    /// </summary>
    public interface IProjectManager
    {
        /// <summary>
        /// Enables project observing.
        /// </summary>
        bool EnableObserver { get; set; }

        /// <summary>
        /// Current active project instance.
        /// </summary>
        IProjectContainer CurrentProject { get; set; }

        /// <summary>
        /// Creates new DRAKON project.
        /// </summary>
        void CreateNewProject();

        /// <summary>
        /// Opens existed DRAKON project file.
        /// </summary>
        /// <param name="projectFileName"></param>
        void OpenProjectFile(string projectFileName);

        /// <summary>
        /// Saves current active DRAKON project.
        /// </summary>
        void SaveProject();

        /// <summary>
        /// Closes opened project file.
        /// </summary>
        void CloseProject();
    }
}
