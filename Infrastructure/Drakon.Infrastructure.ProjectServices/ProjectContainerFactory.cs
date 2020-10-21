using Drakon.Domain.ProjectServices;

namespace Drakon.Infrastructure.ProjectServices
{
    /// <summary>
    /// Project container factory implementation.
    /// </summary>
    public class ProjectContainerFactory : IProjectContainerFactory
    {
        /// <inheritdoc/>
        public IProjectContainer CreateNewProject()
        {
            return new ProjectContainer();
        }
    }
}
