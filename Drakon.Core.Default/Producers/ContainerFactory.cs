using System;
using System.Collections.Generic;
using System.Text;
using Drakon.Core.Containers;
using Drakon.Core.Factories;

namespace Drakon.Core.Default.Producers
{
    /// <summary>
    /// Container factory implementation
    /// </summary>
    public class ContainerFactory : IContainerFactory
    {
        /// <summary>
        /// Creates new document
        /// </summary>
        /// <returns></returns>
        public IDocumentContainer CreateDocumentContainer()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates new project
        /// </summary>
        /// <returns></returns>
        public IProjectContainer CreateProjectContainer()
        {
            throw new NotImplementedException();
        }
    }
}
