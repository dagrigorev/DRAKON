using Autofac;

using Drakon.Domain.Base;

using System;
using System.Collections.Generic;
using System.Text;

namespace Drakon.Bootstrapper
{

    /// <summary>
    /// Container provider immplementation.
    /// </summary>
    class ContainerProvider : IContainerProvider
    {
        private IContainer _container;

        public ContainerProvider(IContainer container)
        {
            if (container == null)
                throw new ArgumentNullException($"{nameof(container)} cannot be null");

            _container = container;
        }

        /// <inheritdoc/>
        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
