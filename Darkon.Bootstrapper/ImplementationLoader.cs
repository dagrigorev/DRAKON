using System;
using System.Collections.Generic;
using System.Text;
using Drakon.Core;
using Prism.Ioc;

namespace Drakon.Bootstrapper
{
    public class ImplementationLoader : IBootstrapper
    {
        public IBootstrapper AppLoader { get; set; }
        public IContainerProvider ResolvableContainer { get; set; }

        /// <summary>
        /// Loader constructor
        /// </summary>
        /// <param name="container"></param>
        public ImplementationLoader(IContainerRegistry container)
        {
            ResolvableContainer = container as IContainerProvider;
            AppLoader = new ApplicationLoader(ResolvableContainer as IContainerRegistry);
        }

        /// <summary>
        /// Loads implementation here. Change this method for loading your own implementation.
        /// </summary>
        public void Register()
        {
            AppLoader.Register();
        }
    }
}
