using Drakon.App.ViewModels.Base;

using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.Drakon.App.ViewModels.Common
{
    /// <summary>
    /// Sample view model base implementation.
    /// </summary>
    class SampleViewModelBase : ViewModelBase
    {
        private string name;
        private int lifetime;

        // some random props ...
        public string Name { get => name; set => Update(ref name, value); }
        public int Lifetime { get => lifetime; set => Update(ref lifetime, value); }

        public SampleViewModelBase()
        {
        }
    }
}
