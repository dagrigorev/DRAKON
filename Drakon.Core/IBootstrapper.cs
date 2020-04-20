using Prism.Ioc;

namespace Drakon.Core
{
    /// <summary>
    /// Default bootstrapper contract
    /// </summary>
    public interface IBootstrapper
    {
        /// <summary>
        /// Prism resolvable container
        /// </summary>
        IContainerProvider ResolvableContainer { get; set; } 

        /// <summary>
        /// All instances registrations starts here
        /// </summary>
        void Register();
    }
}