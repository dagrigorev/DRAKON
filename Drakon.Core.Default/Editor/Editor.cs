using System;
using System.Collections.Generic;
using Drakon.Core.Common.ObservableBase;
using Drakon.Core.Default.Producers;
using Drakon.Core.Editor;
using Drakon.Core.Factories;
using Drakon.Core.Logger;
using Drakon.Core.Tools;
using Prism.Ioc;

namespace Drakon.Core.Default.Editor
{
    /// <summary>
    /// Editor implementation
    /// </summary>
    public class Editor : Observable, IEditorSkeleton
    {
        private ILogger _logger;
        private IEditorOptions _options;
        private IProjectManager _projectManager;
        private IToolsCollection _tools;
        private IRenderManager _renderManager;
        private IToolsFactory _toolsFactory;

        public IEditorOptions Options
        {
            get => _options;
            set => SetProperty(ref _options, value);
        }

        public IProjectManager ProjectManager
        {
            get => _projectManager;
            set => SetProperty(ref _projectManager, value);
        }

        /// <inheritdoc />
        public IRenderManager RenderManager
        {
            get => _renderManager; 
            set => SetProperty(ref _renderManager, value);
        }

        /// <inheritdoc />
        public ILogger Logger
        {
            get => _logger;
            set => SetProperty(ref _logger, value);
        }

        public IToolsCollection Tools
        {
            get => _tools;  
            set => SetProperty(ref _tools, value);
        }

        public void Initialize(IContainerProvider container)
        {
            if (container != null)
            {
                Logger = container.Resolve<ILogger>();
                Options = container.Resolve<IEditorOptions>();

                _toolsFactory = container.Resolve<IToolsFactory>();
                Tools = _toolsFactory.CreateDefaultToolsCollection();
                ProjectManager = container.Resolve<IProjectManager>();
            } 
            else 
                throw new NullReferenceException("Container cannot be null");
        }

        public void SaveState()
        {
            throw new System.NotImplementedException();
        }

        public void LoadState()
        {
            throw new System.NotImplementedException();
        }
    }
}