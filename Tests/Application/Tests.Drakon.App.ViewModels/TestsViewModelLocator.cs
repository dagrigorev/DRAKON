using Drakon.App.ViewModels.Base;
using Drakon.App.ViewModels.MainWindow;

using System;

using Tests.Drakon.App.ViewModels.Common;

using Xunit;

namespace Tests.Drakon.App.ViewModels
{
    public class TestsViewModelLocator
    {
        ViewModelLocator _locator;

        public TestsViewModelLocator()
        {
            _locator = new ViewModelLocator();
        }

        [Fact]
        public void TestAppliableDataContextBinding()
        {
            var view = new MainWindowView();
            _locator.BindViewModel(view, new DefaultViewModel());

            Assert.True(view.DataContext.GetType().Equals(typeof(MainWindowViewModel)));
        }

        [Fact]
        public void TestNotFoundViewModelBinding()
        {
            var view = new TestView();
            _locator.BindViewModel(view, new DefaultViewModel());

            Assert.True(view.DataContext.GetType().Equals(typeof(DefaultViewModel)));
        }

        [Fact]
        public void TestNullViewArgumentExceptionThrowing()
        {
            SampleView nullView = null;
            Assert.Throws<ArgumentNullException>(() => _locator.BindViewModel(nullView, new DefaultViewModel()));
        }

        [Fact]
        public void TestNullDefaultViewModelArgumentExceptionThrowing()
        {
            SampleView nullView = new SampleView();
            Assert.Throws<ArgumentNullException>(() => _locator.BindViewModel(nullView, null));
        }
    }
}
