using System;
using System.ComponentModel;
using Drakon.Core.Common.ObservableBase;
using Drakon.Core.Renderers;
using Drakon.Core.Tools;
using Drakon.Core.Visual.Shapes;

namespace Drakon.Core.Default.Renderers
{
    public class DefaultRenderer : Observable, IRenderer
    {
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

        public void Render(IPointShape shape)
        {
            throw new NotImplementedException();
        }
    }
}
