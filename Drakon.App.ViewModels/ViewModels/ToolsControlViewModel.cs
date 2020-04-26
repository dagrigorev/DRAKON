using System;
using System.Collections.Generic;
using System.Text;
using Drakon.Core.Tools;
using Prism.Mvvm;

namespace Drakon.App.ViewModels
{
    /// <summary>
    /// View model for tools control
    /// </summary>
    public class ToolsControlViewModel : BindableBase
    {
        private IToolsCollection _tools;

        /// <summary>
        /// Connected tools
        /// </summary>
        public IToolsCollection Tools
        {
            get => _tools;
            set => SetProperty(ref _tools, value);
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public ToolsControlViewModel()
        {
        }
    }
}
