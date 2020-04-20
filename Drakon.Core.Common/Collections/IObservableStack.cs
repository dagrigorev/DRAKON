using System.Collections.Specialized;
using Drakon.Core.Common.ObservableBase;

namespace Drakon.Core.Common.Collections
{
    /// <summary>
    /// Observable stack contract
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IObservableStack<T> : IObservable, IStack<T>, INotifyCollectionChanged
    {
    }
}