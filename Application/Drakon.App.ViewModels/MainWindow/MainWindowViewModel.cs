using Drakon.App.ViewModels.Base;
using Drakon.Domain.Base;
using Drakon.Domain.ProjectServices;

using System;
using System.Windows.Input;

namespace Drakon.App.ViewModels.MainWindow
{
    /// <summary>
    /// Main window view model implementation.
    /// </summary>
    public class MainWindowViewModel : ViewModelBase
    {
        private IProjectManager _projectManager;
        private ICommand _fileCreateCommand;
        private ICommand _fileOpenCommand;
        private ICommand _fileSaveCommand;
        private ICommand _exitCommand;

        /// <summary>
        /// Main window title.
        /// </summary>
        public string Title => "DRAKON Editor.";

        /// <summary>
        /// Create file command.
        /// </summary>
        public ICommand FileCreateCommand { get => _fileCreateCommand; set => Update(ref _fileCreateCommand, value); }

        /// <summary>
        /// Open file command.
        /// </summary>
        public ICommand FileOpenCommand { get => _fileOpenCommand; set => Update(ref _fileOpenCommand, value); }

        /// <summary>
        /// Save file command.
        /// </summary>
        public ICommand FileSaveCommand { get => _fileSaveCommand; set => Update(ref _fileSaveCommand, value); }

        /// <summary>
        /// Exit command.
        /// </summary>
        public ICommand ExitCommand { get => _exitCommand; set => Update(ref _exitCommand, value); }

        public MainWindowViewModel(IContainerProvider provider)
        {
            if (provider == null)
                throw new ArgumentNullException($"{nameof(provider)} cannot be null");

            _projectManager = provider.Resolve<IProjectManager>();

            FileCreateCommand = new DelegateCommand(p => _projectManager?.CreateNewProject());
            FileOpenCommand = new DelegateCommand(p => _projectManager?.OpenProjectFile(p as string));
            FileSaveCommand = new DelegateCommand(p => _projectManager?.SaveProject());
            ExitCommand = new DelegateCommand(p => _projectManager?.CloseProject());
        }
    }
}
