using System;

namespace Drakon.Domain.Base
{
    /// <summary>
    /// IoC container provider.
    /// </summary>
    public interface IContainerProvider
    {
        /// <summary>
        /// Resolves container by contract.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T Resolve<T>();
    }
}
