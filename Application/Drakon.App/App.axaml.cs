using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

using Drakon.App.ViewModels.Base;
using Drakon.App.ViewModels.MainWindow;
using Drakon.Bootstrapper;
using Drakon.Domain.Base;

namespace Drakon.App
{
    public class App : Application
    {
        private ViewModelLocator _vmLocator;
        private IContainerProvider _provider;

        public override void Initialize()
        {
            _vmLocator = new ViewModelLocator();
            
            var bootstrapper = new DrakonBootstrapper();
            _provider = bootstrapper.Load();

            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                InitializeApp(desktop);
            }

            base.OnFrameworkInitializationCompleted();
        }

        private void InitializeApp(IClassicDesktopStyleApplicationLifetime desktop)
        {
            var mainWindowView = new MainWindow();
            _vmLocator.BindViewModel(mainWindowView, new MainWindowViewModel(_provider));

            desktop.MainWindow = mainWindowView;

            
        }
    }
}
