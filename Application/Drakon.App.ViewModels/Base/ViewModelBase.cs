using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Drakon.App.ViewModels.Base
{
    /// <summary>
    /// Base view model implementation.
    /// </summary>
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Update<T>(ref T prop, T val, [CallerMemberName] string propertyName = null)
        {
            if(prop == null || prop != null && !prop.Equals(val))
            {
                prop = val;
                OnPropertyChanged(propertyName);
            }
        }
    }
}
