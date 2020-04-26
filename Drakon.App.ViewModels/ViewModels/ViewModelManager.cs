using System;
using System.Collections.Generic;
using System.Text;
using Drakon.Core.Base.Providers;
using Drakon.Core.Editor;
using Drakon.Core.Factories;
using Drakon.Core.Tools;
using Prism.Ioc;

namespace Drakon.App.ViewModels
{
    /// <summary>
    /// View models manager
    /// </summary>
    public class ViewModelManager
    {
        private IContainerProvider _containerProvider;

        /// <summary>
        /// Register all view models into container
        /// </summary>
        /// <param name="container"></param>
        public void Configure(IContainerRegistry container)
        {
            _containerProvider = container as IContainerProvider;

            container.RegisterInstance(typeof(CanvasControlViewModel), CreateCanvasControlViewModel());
            container.RegisterInstance(typeof(OptionsControlViewModel), CreateOptionsControlViewModel());
            container.RegisterInstance(typeof(MainWindowViewModel), CreateMainWindowViewModel());
            container.RegisterInstance(typeof(ToolsControlViewModel), CreateToolControlViewModel());
        }

        private ToolsControlViewModel CreateToolControlViewModel()
        {
            return new ToolsControlViewModel()
            {
                Tools = _containerProvider.Resolve<IToolsCollection>()
            };
        }

        private CanvasControlViewModel CreateCanvasControlViewModel()
        {
            var canvasControlVm = new CanvasControlViewModel();
            foreach (var renderer in _containerProvider.Resolve<IRenderManager>().GetRenderers())
                canvasControlVm.RegisterRenderer(renderer);
            
            // TODO: Replace this by something better
            _containerProvider.Resolve<IProjectManager>().OnProjectLoaded += (o, container) =>
            {
                canvasControlVm.CurrentProject = container;
            };

            return canvasControlVm;
        }

        private OptionsControlViewModel CreateOptionsControlViewModel()
        {
            return new OptionsControlViewModel()
            {
                Options = _containerProvider.Resolve<IEditorOptions>()
            };
        }

        private MainWindowViewModel CreateMainWindowViewModel()
        {
            return new MainWindowViewModel()
            {
                Editor = _containerProvider.Resolve<IEditorSkeleton>(),
                Title = _containerProvider.Resolve<IEditorOptions>().DefaultTitle
            };
        }

        /// <summary>
        /// Configure <see cref="MainWindowViewModel"/>.
        /// </summary>
        /// <param name="mainWindowViewModel"></param>
        /// <param name="container"></param>
        public void Configure(MainWindowViewModel mainWindowViewModel, IContainerProvider container)
        {
            mainWindowViewModel.Editor = container.Resolve<IEditorSkeleton>();
            mainWindowViewModel.Title = container.Resolve<IEditorSkeleton>().Options.DefaultTitle;
        }

        /// <summary>
        /// Configure <see cref="OptionsControlViewModel"/>
        /// </summary>
        /// <param name="optionsViewModel"></param>
        /// <param name="container"></param>
        public void Configure(OptionsControlViewModel optionsViewModel, IContainerProvider container)
        {
            optionsViewModel.Options = container.Resolve<IEditorOptions>();
        }
    }
}
