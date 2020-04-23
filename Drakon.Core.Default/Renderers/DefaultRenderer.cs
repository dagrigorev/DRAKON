using System;
using System.ComponentModel;
using Drakon.Core.Common.ObservableBase;
using Drakon.Core.Renderers;
using Drakon.Core.Tools;
using Drakon.Core.Visual.Shapes;

namespace Drakon.Core.Default.Renderers
{
    /// <summary>
    /// Default renderer implementation
    /// </summary>
    public class DefaultRenderer : Observable, IRenderer
    {
        private bool _enabled;

        /// <inheritdoc />
        public bool Enabled
        {
            get => _enabled; 
            set => SetProperty(ref _enabled, value);
        }

        /// <inheritdoc />
        public void Initialize()
        {
            Enabled = true;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public DefaultRenderer() : base()
        {
        }

        public void Render(ITool tool)
        {
            throw new NotImplementedException();
        }

        public void Render(IShape shape)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void Render(object canvas, IObservable obj)
        {
            throw new NotImplementedException();
        }

        public void Render(IPointShape shape)
        {
            throw new NotImplementedException();
        }
    }
}
