using System;
using System.Globalization;
using System.Reflection;
using Prism.Ioc;
using Drakon.App.Views;
using System.Windows;
using Drakon.Core;
using Drakon.Bootstrapper;
using Drakon.App.ViewModels;
using Drakon.Core.Editor;
using Prism.Mvvm;

namespace Drakon.App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        public IBootstrapper Loader { get; private set; }
        public ViewModelManager _vmManager;

        private void InitializeLoader(IContainerRegistry container)
        {
            Loader = new ImplementationLoader(container);
            Loader?.Register();
            _vmManager = new ViewModelManager();
            _vmManager.Configure(container);

            LoadAll();
        }

        /// <summary>
        /// Loads all registered component
        /// </summary>
        private void LoadAll()
        {
            Loader?.ResolvableContainer.Resolve<IEditorSkeleton>().Initialize(Loader.ResolvableContainer);
        }

        protected override Window CreateShell()
        {
            var mainWindow = Container.Resolve<MainWindow>();
            _vmManager.Configure(mainWindow.DataContext as MainWindowViewModel, Loader.ResolvableContainer);
            return mainWindow;
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            InitializeLoader(containerRegistry);
        }

        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();

            ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver((viewType) =>
            {
                return Type.GetType($"Drakon.App.ViewModels.{viewType.Name}ViewModel");
            });
        }
    }
}
