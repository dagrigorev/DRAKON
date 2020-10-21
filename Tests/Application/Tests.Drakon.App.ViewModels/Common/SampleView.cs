using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.Drakon.App.ViewModels.Common
{
    class SampleView : IDataContextProvider
    {
        public string TestProperty { get; set; }
        public object DataContext { get; set; }
    }
}
