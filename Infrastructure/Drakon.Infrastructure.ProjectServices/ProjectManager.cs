using Drakon.Domain.ProjectServices;

using System;
using System.Collections.Generic;
using System.Text;

namespace Drakon.Infrastructure.ProjectServices
{
    /// <summary>
    /// Project manager implementation.
    /// </summary>
    public class ProjectManager : IProjectManager
    {
        /// <inheritdoc/>
        public IProjectContainer CurrentProject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <inheritdoc/>
        public void CreateNewProject()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void OpenProjectFile(string projectFileName)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void SaveProject()
        {
            throw new NotImplementedException();
        }
    }
}
