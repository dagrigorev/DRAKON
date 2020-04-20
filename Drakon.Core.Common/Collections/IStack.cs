using System.Collections.Generic;

namespace Drakon.Core.Common.Collections
{
    public interface IStack<T> : IReadOnlyCollection<T>
    {
        void Push(T item);
        T Pop();
    }
}