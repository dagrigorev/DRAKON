using System.Collections.Generic;
using Drakon.Core.Common.ObservableBase;
using Drakon.Core.Logger;
using Drakon.Core.Tools;
using Prism.Ioc;

namespace Drakon.Core.Editor
{
    /// <summary>
    /// Base editor skeleton
    /// </summary>
    public interface IEditorSkeleton : IObservable
    {
        /// <summary>
        /// Editor options
        /// </summary>
        IEditorOptions Options { get; set; }

        /// <summary>
        /// Projects manager object
        /// </summary>
        IProjectManager ProjectManager { get; set; }

        /// <summary>
        /// Editor logger
        /// </summary>
        ILogger Logger { get; set; }

        /// <summary>
        /// Loaded tools collection
        /// </summary>
        IToolsCollection Tools { get; set; }

        /// <summary>
        /// Initialize editor
        /// </summary>
        /// <param name="container"></param>
        void Initialize(IContainerProvider container);

        /// <summary>
        /// Saves editor state (e.g. Options, Project, Tools and etc.)
        /// </summary>
        void SaveState();

        /// <summary>
        /// Loads previously saved state
        /// </summary>
        void LoadState();
    }
}