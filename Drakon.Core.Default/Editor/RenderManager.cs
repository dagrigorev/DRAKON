using System;
using System.Linq;
using Drakon.Core.Common.ObservableBase;
using Drakon.Core.Editor;
using Drakon.Core.Renderers;
using Prism.Ioc;

namespace Drakon.Core.Default.Editor
{
    /// <summary>
    /// Render manager implementation
    /// </summary>
    public class RenderManager : Observable, IRenderManager
    {
        private IContainerProvider _containerProvider;

        /// <inheritdoc />
        public IRenderer CurrentRenderer { get; set; }

        public RenderManager(IContainerProvider container)
        {
            _containerProvider = container;
        }

        /// <inheritdoc />
        public void Initialize()
        {
            var renderers = GetRenderers();
            foreach (var renderer in renderers)
                renderer.Initialize();
        }

        /// <inheritdoc />
        public IRenderer[] GetRenderers()
        {
            return _containerProvider.Resolve<IRenderer[]>();
        }
    }
}