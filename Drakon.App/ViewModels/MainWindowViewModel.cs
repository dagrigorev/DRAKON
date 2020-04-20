using System.Collections.ObjectModel;
using System.Windows.Input;
using Drakon.Core;
using Drakon.Core.Containers;
using Drakon.Core.Editor;
using Prism.Mvvm;

namespace Drakon.App.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private IEditorSkeleton _editor;
        private string _title;
        private ObservableCollection<IDocumentContainer> _openedDocs;

        public ICommand NewFileCommand { get; set; }
        public ICommand OpenFileCommand { get; set; }
        public ICommand SaveFileCommand { get; set; }
        public ICommand ExitCommand { get; set; }

        /// <summary>
        /// Editor binding property
        /// </summary>
        public IEditorSkeleton Editor
        {
            get => _editor;
            set => SetProperty(ref _editor, value);
        }

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public ObservableCollection<IDocumentContainer> OpenedDocuments
        {
            get => _openedDocs;
            set => SetProperty(ref _openedDocs, value);
        }

        public MainWindowViewModel()
        {
            Title = "DRAKON";
            _openedDocs = new ObservableCollection<IDocumentContainer>();
        }
    }
}
