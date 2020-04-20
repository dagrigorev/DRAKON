using System;
using System.Drawing;
using Drakon.Core;
using Drakon.Core.Editor;
using Prism.Mvvm;

namespace Drakon.App.ViewModels
{
    public class OptionsControlViewModel : BindableBase
    {
        private IEditorOptions _options;

        public IEditorOptions Options
        {
            get => _options;
            set => SetProperty(ref _options, value);
        }

        public OptionsControlViewModel()
        {
        }
    }
}