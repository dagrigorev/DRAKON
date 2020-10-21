using Autofac;

using Drakon.Domain.ProjectServices;
using Drakon.Infrastructure.ProjectServices;

namespace Drakon.Bootstrapper.Modules
{
    /// <summary>
    /// Project module.
    /// </summary>
    class ProjectModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterInstance(new ProjectContainer()).As<IProjectContainer>();
            builder.RegisterInstance(new ProjectManager()).As<IProjectManager>();
            builder.RegisterInstance(new ProjectContainerFactory()).As<IProjectContainerFactory>();
        }
    }
}
