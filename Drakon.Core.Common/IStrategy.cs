using Drakon.Core.Common.ObservableBase;

namespace Drakon.Core.Base
{
    /// <summary>
    /// Base strategy contract
    /// </summary>
    public interface IStrategy : IObservable
    {
        /// <summary>
        /// Adds new step for strategy
        /// </summary>
        /// <param name="nextStep"></param>
        /// <returns></returns>
        IStrategy AddStrategy(IStrategy nextStep);
    }
}