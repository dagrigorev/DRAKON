using Drakon.Core.Common.ObservableBase;
using Drakon.Core.Containers.Coding;
using Drakon.Core.Tools;
using Drakon.Core.Visual.Shapes;

namespace Drakon.Core.Default.Tools
{
    public class PointTool : Observable, ITool
    {
        private ICodePrimitive _primitive;
        private IShape _shape;

        public ICodePrimitive Primitive
        {
            get => _primitive; 
            set => SetProperty(ref _primitive, value);
        }

        public IShape Shape
        {
            get => _shape; 
            set => SetProperty(ref _shape, value);
        }

        public PointTool()
        {
            
        }
    }
}