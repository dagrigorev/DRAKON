using Autofac;

using Drakon.Bootstrapper.Modules;
using Drakon.Domain.Base;

using System;

namespace Drakon.Bootstrapper
{
    /// <summary>
    /// Drakon editor bootstrapper.
    /// </summary>
    public class DrakonBootstrapper
    {
        ContainerBuilder _builder;

        /// <summary>
        /// Registers application modules.
        /// </summary>
        public void RegisterModules()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new ProjectModule());

            _builder = builder;
        }

        /// <summary>
        /// Gets container from builder.
        /// </summary>
        /// <returns></returns>
        public IContainer GetContainer() => _builder.Build();

        /// <summary>
        /// Loads application.
        /// </summary>
        public IContainerProvider Load()
        {
            RegisterModules();
            
            return new ContainerProvider(GetContainer());
        }
    }
}
