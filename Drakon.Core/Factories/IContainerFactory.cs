using Drakon.Core.Containers;

namespace Drakon.Core.Factories
{
    /// <summary>
    /// Simple container factory contract
    /// </summary>
    public interface IContainerFactory
    {
        /// <summary>
        /// Creates new <see cref="IDocumentContainer"/> instance
        /// </summary>
        /// <returns></returns>
        IDocumentContainer CreateDocumentContainer();

        /// <summary>
        /// Creates new <see cref="IProjectContainer"/> instance
        /// </summary>
        /// <returns></returns>
        IProjectContainer CreateProjectContainer();
    }
}