using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Drakon.Core.Common.ObservableBase
{
    /// <summary>
    /// Base observable object contract
    /// </summary>
    public interface IObservable : INotifyPropertyChanged
    {
        object Parent { get; set; }
        string Name { get; set; }
        string Id { get; set; }
        void SetProperty<T>(ref T property, T value, [CallerMemberName] string propertyName = null);
        void Notify(object property, [CallerMemberName] string name = "");
    }
}
