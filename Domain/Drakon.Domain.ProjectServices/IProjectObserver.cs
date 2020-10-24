using Drakon.Domain.ProjectServices.ProjectChanges;

namespace Drakon.Domain.ProjectServices
{
    /// <summary>
    /// Project observer definition.
    /// </summary>
    interface IProjectObserver
    {
        /// <summary>
        /// Changes tracker for current active project.
        /// </summary>
        IProjectChangesTracker ChangesTracker { get; set; }


    }
}
