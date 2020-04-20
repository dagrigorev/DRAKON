using Drakon.Core.Common.ObservableBase;
using Drakon.Core.Tools;
using Drakon.Core.Visual.Shapes;

namespace Drakon.Core.Renderers
{
    /// <summary>
    /// Graphics renderer contract
    /// </summary>
    public interface IRenderer : IObservable
    {
        /// <summary>
        /// Renders point shape
        /// </summary>
        /// <param name="shape"></param>
        void Render(IPointShape shape);
    }
}