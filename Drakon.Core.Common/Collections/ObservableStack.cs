using Drakon.Core.Common.ObservableBase;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace Drakon.Core.Common.Collections
{
    /// <summary>
    /// Observable stack implementation
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ObservableStack<T> : Observable, IObservableStack<T>
    {
        private Stack<T> _args;

        /// <summary>
        /// Returns count of items
        /// </summary>
        public int Count => _args.Count;

        /// <summary>
        /// Notifies listeners that collection is changed
        /// </summary>
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        /// <summary>
        /// Default constructor
        /// </summary>
        public ObservableStack()
        {
            _args = new Stack<T>();
        }

        /// <summary>
        /// Returns <see cref="IEnumerator"/>
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            return _args.GetEnumerator();
        }

        /// <summary>
        /// Returns <see cref="IEnumerator"/>
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Pushes new item in stack
        /// </summary>
        /// <param name="item"></param>
        public void Push(T item)
        {
            _args.Push(item);
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add));
        }

        /// <summary>
        /// Returns item that removed from the top of the stack.
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove));
            return _args.Pop();
        }
    }
}
