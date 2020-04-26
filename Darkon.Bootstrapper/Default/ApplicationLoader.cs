using System;
using System.Diagnostics;
using System.Windows;
using Drakon.Core;
using Drakon.Core.Default.Editor;
using Drakon.Core.Default.Factories;
using Drakon.Core.Default.Logger;
using Drakon.Core.Default.Producers;
using Drakon.Core.Default.Renderers;
using Drakon.Core.Editor;
using Drakon.Core.Factories;
using Drakon.Core.Logger;
using Drakon.Core.Renderers;
using Drakon.Core.Tools;
using Prism.Ioc;

namespace Drakon.Bootstrapper
{
    public class ApplicationLoader : IBootstrapper
    {
        private IContainerRegistry _container;
        public IContainerProvider ResolvableContainer { get; set; }

        public ApplicationLoader(IContainerRegistry container)
        {
            _container = container;
        }

        private void Register(IContainerRegistry container)
        {
            try
            {
                _container.RegisterInstance(typeof(ILogger), new Logger());
                _container.RegisterInstance(typeof(IEditorOptions), new EditorOptions());
                _container.RegisterInstance(typeof(IEditorSkeleton), new Editor());
                _container.RegisterInstance(typeof(IProjectManager), new ProjectManager());

                var shapeFactory = new ShapeFactory();
                var codeFactory = new CodePrimitiveFactory();
                var toolsFactory = new ToolsFactory(codeFactory, shapeFactory);

                _container.RegisterInstance(typeof(IShapeFactory), shapeFactory);
                _container.RegisterInstance(typeof(ICodePrimitiveFactory), codeFactory);
                _container.RegisterInstance(typeof(IToolsFactory), toolsFactory);
                _container.RegisterInstance(typeof(IToolsCollection), toolsFactory.CreateDefaultToolsCollection());

                _container.RegisterInstance(typeof(IRenderer[]), new IRenderer[]
                {
                    new DefaultRenderer()
                    // TODO: Add other renderers here
                });
                _container.RegisterInstance(typeof(IRenderManager),
                    new RenderManager(_container as IContainerProvider));
                
                ResolvableContainer = _container as IContainerProvider;
            }
            catch(Exception ex)
            {
#if DEBUG
                Debug.WriteLine($"Exception raised: {ex.Message}");
#endif
            }
        }

        /// <summary>
        /// Loads application
        /// </summary>
        public void Register()
        {
            try
            {
                Register(_container);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error loading Drakon", ex.Message, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
