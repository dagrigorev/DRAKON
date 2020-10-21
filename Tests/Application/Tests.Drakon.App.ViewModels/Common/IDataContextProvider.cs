using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.Drakon.App.ViewModels.Common
{
    interface IDataContextProvider
    {
        object DataContext { get; set; }
    }
}
