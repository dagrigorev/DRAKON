using System;
using System.Collections.Generic;
using System.Text;
using Drakon.Core.Common.ObservableBase;
using Drakon.Core.Containers;

namespace Drakon.Core.Default.Containers
{
    /// <summary>
    /// Project container default implementation
    /// </summary>
    public class ProjectContainer : Observable, IProjectContainer
    {
        private string _description;
        private string _author;
        private Version _version;
        private IEnumerable<IDocumentContainer> _docs;
        private IDocumentContainer _currentDoc;

        /// <summary>
        /// Project description
        /// </summary>
        public string Description
        {
            get => _description; 
            set => SetProperty(ref _description, value);
        }

        /// <summary>
        /// Author label
        /// </summary>
        public string Author
        {
            get => _author; 
            set => SetProperty(ref _author, value);
        }

        /// <summary>
        /// Project default version
        /// </summary>
        public Version Ver
        {
            get => _version; 
            set => SetProperty(ref _version, value);
        }

        /// <summary>
        /// Documents collection
        /// </summary>
        public IEnumerable<IDocumentContainer> Documents
        {
            get => _docs; 
            set => SetProperty(ref _docs, value);
        }

        /// <summary>
        /// Current document
        /// </summary>
        public IDocumentContainer CurrentDocument
        {
            get => _currentDoc; 
            set => SetProperty(ref _currentDoc, value);
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public ProjectContainer()
        {
            Description = "Default project container";
            CurrentDocument = null;
        }
    }
}
