namespace Drakon.Core.Base.Providers
{
    /// <summary>
    /// Base strategy provider contract
    /// </summary>
    /// <typeparam name="TStrategy"></typeparam>
    public interface IStrategyProvider<TStrategy>
        where TStrategy : IStrategy
    {
        /// <summary>
        /// Creates new strategy
        /// </summary>
        /// <returns></returns>
        TStrategy Create();
    }
}