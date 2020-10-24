using Drakon.Data.Project;

using System;

namespace Drakon.Domain.RenderServices
{
    /// <summary>
    /// Project renderer service definition.
    /// </summary>
    public interface IProjectRenderer
    {
        /// <summary>
        /// Renderers project.
        /// </summary>
        /// <param name="project"></param>
        void Render(IProjectContainer project);
    }
}
