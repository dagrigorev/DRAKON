using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.Drakon.App.ViewModels.Common
{
    class TestView : IDataContextProvider
    {
        public object DataContext { get; set; }
    }
}
