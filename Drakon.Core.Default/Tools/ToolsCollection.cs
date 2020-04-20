using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Drakon.Core.Common.ObservableBase;
using Drakon.Core.Containers.Coding;
using Drakon.Core.Tools;

namespace Drakon.Core.Default.Tools
{
    /// <summary>
    /// Tools collection implementation
    /// </summary>
    [Serializable]
    public class ToolsCollection : Observable, ICollection<ITool>, IToolsCollection, IObservable, INotifyCollectionChanged
    {
        private IObservable _parent;
        private string _name;
        private string _id;
        private ObservableCollection<ITool> _toolsCollection;

        public ToolsCollection()
        {
            _toolsCollection = new ObservableCollection<ITool>();
            _toolsCollection.CollectionChanged += (sender, args) => CollectionChanged?.Invoke(sender, args);
        }

        public ToolsCollection(ITool[] range)
            : this()
        {
            AddRange(range);
        }

        public IEnumerator<ITool> GetEnumerator()
        {
            return _toolsCollection.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void AddRange(ITool[] range)
        {
            foreach (var tool in range)
                _toolsCollection.Add(tool);
        }

        public void Add(ITool item)
        {
            _toolsCollection.Add(item);
        }

        public void Clear()
        {
            _toolsCollection.Clear();
        }

        public bool Contains(ITool item)
        {
            return _toolsCollection.Contains(item);
        }

        public void CopyTo(ITool[] array, int arrayIndex)
        {
            _toolsCollection.CopyTo(array, arrayIndex);
        }

        public bool Remove(ITool item)
        {
            return _toolsCollection.Remove(item);
        }

        public int Count => _toolsCollection.Count;
        public bool IsReadOnly => false;

        public event NotifyCollectionChangedEventHandler CollectionChanged;
        
        public ITool GetTool(ICodePrimitive primitive)
        {
            throw new NotImplementedException();
        }
    }
}
