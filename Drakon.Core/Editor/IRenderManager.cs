using System;
using Drakon.Core.Common.ObservableBase;
using Drakon.Core.Renderers;
using Prism.Ioc;

namespace Drakon.Core.Editor
{
    /// <summary>
    /// Render manager contract
    /// </summary>
    public interface IRenderManager : IObservable
    {
        IRenderer CurrentRenderer { get; set; }

        /// <summary>
        /// Initializes default renderers
        /// </summary>
        /// <param name="serviceProvider"></param>
        void Initialize();

        /// <summary>
        /// Gets all registered renderers
        /// </summary>
        /// <returns></returns>
        IRenderer[] GetRenderers();
    }
}