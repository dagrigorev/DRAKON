using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Drakon.Core.Common.ObservableBase
{
    /// <summary>
    /// Default observable object implementation
    /// </summary>
    public class Observable : IObservable
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public object Parent { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }

        public Observable()
        {
            Name = string.Empty;
            Id = Guid.NewGuid().ToString();
        }

        public void SetProperty<T>(ref T property, T value, [CallerMemberName] string propertyName = null)
        {
            // check equality by reference here
            if ((object)property != (object)value)
            {
                property = value;
                Notify(property, propertyName);
            }
        }

        public void Notify(object property, [CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(property, new PropertyChangedEventArgs(name));
        }
    }
}
