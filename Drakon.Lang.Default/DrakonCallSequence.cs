using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using Drakon.Core.Coding;
using Drakon.Core.Common.ObservableBase;
using Drakon.Core.Containers.Coding;

namespace Drakon.Lang.Default
{
    public class DrakonCallSequence : Observable, ICallSequence
    {
        /// <inheritdoc />
        public IEnumerator<string> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <inheritdoc />
        public int Count { get; }

        /// <inheritdoc />
        public void Push(string item)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public string Pop()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        /// <inheritdoc />
        public void AddToSequence(params ICodePrimitive[] code)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void RemoveFromSequence(ICodePrimitive code)
        {
            throw new NotImplementedException();
        }
    }
}
