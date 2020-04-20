using System;
using System.Runtime.Serialization;
using Drakon.Core.Containers;
using Drakon.Core.IO;

namespace Drakon.Core.Editor
{
    /// <summary>
    /// Project manager contract
    /// </summary>
    public interface IProjectManager
    {
        event Action<object, IDocumentContainer> OnDocumentSelected;

        /// <summary>
        /// Current project path
        /// </summary>
        string ProjectPath { get; set; }

        /// <summary>
        /// Flag indicates that project has an unsaved changes
        /// </summary>
        bool IsProjectUnsaved { get; set; }

        /// <summary>
        /// Project writer
        /// </summary>
        IProjectWriter ProjectWriter { get; set; }

        /// <summary>
        /// Current project
        /// </summary>
        IProjectContainer CurrentProject { get; set; }
        
        /// <summary>
        /// Opens project
        /// </summary>
        /// <param name="arg"></param>
        void Open(object arg);

        /// <summary>
        /// Saves project
        /// </summary>
        /// <param name="arg"></param>
        void Save(object arg);
    }
}