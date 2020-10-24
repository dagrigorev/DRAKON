using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace Drakon.Domain.ProjectServices.ProjectChanges
{
    /// <summary>
    /// Internal project changes collection.
    /// </summary>
    interface IProjectChangesTracker : INotifyCollectionChanged, IReadOnlyCollection<IProjectChange>
    {
        /// <summary>
        /// Applies project change.
        /// </summary>
        /// <param name="change"></param>
        void DoChange(IProjectChange change);

        /// <summary>
        /// Cancel the change.
        /// </summary>
        /// <param name="change"></param>
        void UnDoChange(IProjectChange change);

        /// <summary>
        /// Re-apply project change;
        /// </summary>
        /// <param name="change"></param>
        void ReDoChange(IProjectChange change);
    }
}
