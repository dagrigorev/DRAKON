using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Drakon.Core.Common.ObservableBase;
using Drakon.Core.Containers;
using Drakon.Core.Containers.Coding;

namespace Drakon.Core.Default.Containers
{
    /// <summary>
    /// Document default implementation
    /// </summary>
    public class DocumentContainer : Observable, IDocumentContainer
    {
        private string _description;
        private IEnumerable<ICodePrimitive> _primitives;

        /// <summary>
        /// Document description
        /// </summary>
        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }

        /// <summary>
        /// Added code primitives
        /// </summary>
        public IEnumerable<ICodePrimitive> CodePrimitives
        {
            get => _primitives; 
            set => SetProperty(ref _primitives, value);
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public DocumentContainer()
        {
            CodePrimitives = new ObservableCollection<ICodePrimitive>();
            Description = "Default document container";
        }
    }
}
