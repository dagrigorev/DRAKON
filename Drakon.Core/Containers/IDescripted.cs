using Drakon.Core.Common.ObservableBase;

namespace Drakon.Core.Containers
{
    /// <summary>
    /// Descripted item contract
    /// </summary>
    public interface IDescripted : IObservable
    {
        /// <summary>
        /// Description text
        /// </summary>
        string Description { get; set; }
    }
}