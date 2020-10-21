using Drakon.Domain.ProjectServices;

namespace Drakon.Infrastructure.ProjectServices
{
    /// <summary>
    /// Project container implementation.
    /// </summary>
    public class ProjectContainer : IProjectContainer
    {
        private string _projectName;

        /// <inheritdoc />
        public string ProjectName { get => _projectName; set => _projectName = value; }
    }
}
