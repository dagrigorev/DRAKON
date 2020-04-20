using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using Drakon.Core.Common.ObservableBase;
using Drakon.Core.Containers.Coding;

namespace Drakon.Core.Tools
{
    /// <summary>
    /// Tools collection contract
    /// </summary>
    public interface IToolsCollection : ICollection<ITool>, INotifyCollectionChanged, IObservable
    {
        /// <summary>
        /// Returns tools by specified code primitive
        /// </summary>
        /// <param name="primitive">Specified primitive</param>
        /// <returns></returns>
        ITool GetTool(ICodePrimitive primitive);
    }
}
