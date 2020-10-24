using Drakon.Data.Project;

namespace Drakon.Domain.ProjectServices
{
    /// <summary>
    /// New projects factory.
    /// </summary>
    public interface IProjectContainerFactory
    {
        /// <summary>
        /// Creates new project container.
        /// </summary>
        /// <returns>Project container instance.</returns>
        IProjectContainer CreateNewProject();
    }
}
