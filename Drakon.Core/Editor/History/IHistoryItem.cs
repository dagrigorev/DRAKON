using System;

namespace Drakon.Core.Editor.History
{
    /// <summary>
    /// History item contract
    /// </summary>
    public interface IHistoryItem
    {
        /// <summary>
        /// Created time
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Change instance
        /// </summary>
        public object Change { get; set; }
    }
}