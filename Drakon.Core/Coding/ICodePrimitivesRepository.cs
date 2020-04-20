using System.Collections.Generic;
using System.ComponentModel;
using Drakon.Core.Common.Collections;
using Drakon.Core.Common.ObservableBase;
using Drakon.Core.Containers.Coding;

namespace Drakon.Core.Coding
{
    /// <summary>
    /// Code primitives repository
    /// </summary>
    public interface ICodePrimitivesRepository : IRepository<ICodeProvider>, IObservable, INotifyPropertyChanged
    {
        /// <summary>
        /// Returns all primitives
        /// </summary>
        /// <returns></returns>
        IEnumerable<ICodePrimitive> GetAll();

        /// <summary>
        /// Return primitive that filtered by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ICodePrimitive GetById(string id);

        /// <summary>
        /// Checks that primitive is exist
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool IsPrimitiveExist(string id);
    }
}