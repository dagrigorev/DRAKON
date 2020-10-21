using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.Drakon.App.ViewModels.Common
{
    class MainWindowView : IDataContextProvider
    {
        public object DataContext { get; set; }
    }
}
