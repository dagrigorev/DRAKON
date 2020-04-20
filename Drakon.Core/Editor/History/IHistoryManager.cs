using System.Collections.Generic;

namespace Drakon.Core.Editor.History
{
    /// <summary>
    /// Changes history contract
    /// </summary>
    public interface IHistoryManager
    {
        /// <summary>
        /// Changes collection
        /// </summary>
        IDictionary<IHistoryItemKey, IHistoryItem> Items { get; }

        /// <summary>
        /// Undo changes
        /// </summary>
        void Undo();

        /// <summary>
        /// Redo changes
        /// </summary>
        void Redo();

        /// <summary>
        /// Save changes
        /// </summary>
        void Save();

        /// <summary>
        /// Register changes
        /// </summary>
        void Load();

        /// <summary>
        /// Returns last change (by date)
        /// </summary>
        /// <returns></returns>
        IHistoryItem GetLast();

        /// <summary>
        /// Removes last change (by date)
        /// </summary>
        /// <returns></returns>
        IHistoryItem RemoveLast();
    }
}