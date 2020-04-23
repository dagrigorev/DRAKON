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
        /// Main render method
        /// </summary>
        /// <param name="obj"></param>
        void Render(object canvas, IObservable obj);

        /// <summary>
        /// Renders point shape
        /// </summary>
        /// <param name="shape"></param>
        void Render(IPointShape shape);

        /// <summary>
        /// Enables or disables renderer in scene rendering sequence
        /// </summary>
        bool Enabled { get; set; }

        /// <summary>
        /// Initializes renderer
        /// </summary>
        void Initialize();
    }
}