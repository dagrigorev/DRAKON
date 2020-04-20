using System;

namespace Drakon.Core.Editor.History
{
    public interface IHistoryItemKey : IEquatable<IHistoryItemKey>
    {
        string Name { get; set; }
        DateTime CreatedAt { get; set; }
    }
}