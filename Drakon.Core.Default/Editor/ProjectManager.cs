using System;
using System.Collections.Generic;
using System.Text;
using Drakon.Core.Common.ObservableBase;
using Drakon.Core.Containers;
using Drakon.Core.Editor;
using Drakon.Core.IO;

namespace Drakon.Core.Default.Editor
{
    /// <summary>
    /// ProjectManager default implementation
    /// </summary>
    public class ProjectManager : Observable, IProjectManager
    {
        private string _projectPath;
        private bool _isProjectSaved;
        private IProjectWriter _writer;
        private IProjectContainer _currentProject;
        
        /// <summary>
        /// Document selection changing event
        /// </summary>
        public event Action<object, IDocumentContainer> OnDocumentSelected;

        /// <summary>
        /// Project directory
        /// </summary>
        public string ProjectPath
        {
            get => _projectPath;
            set => SetProperty(ref _projectPath, value);
        }

        /// <summary>
        /// Project dirty flag
        /// </summary>
        public bool IsProjectUnsaved
        {
            get => _isProjectSaved; 
            set => SetProperty(ref _isProjectSaved, value);
        }

        /// <summary>
        /// Project writer 
        /// </summary>
        public IProjectWriter ProjectWriter
        {
            get => _writer; 
            set => SetProperty(ref _writer, value);
        }

        /// <summary>
        /// Current active project
        /// </summary>
        public IProjectContainer CurrentProject
        {
            get => _currentProject;  
            set => SetProperty(ref _currentProject, value);
        }

        /// <summary>
        /// Opens project
        /// </summary>
        /// <param name="arg"></param>
        public void Open(object arg)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Saves project
        /// </summary>
        /// <param name="arg"></param>
        public void Save(object arg)
        {
            throw new NotImplementedException();
        }
    }
}
