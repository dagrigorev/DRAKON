using System;
using System.Collections.Generic;
using System.Text;
using Drakon.Core.Default.Tools;
using Drakon.Core.Factories;
using Drakon.Core.Tools;

namespace Drakon.Core.Default.Producers
{
    /// <summary>
    /// Tools factory implementation
    /// </summary>
    public class ToolsFactory : IToolsFactory
    {
        private ICodePrimitiveFactory _codeFactory;
        private IShapeFactory _shapeFactory;

        public ToolsFactory(ICodePrimitiveFactory codeFactory, IShapeFactory shapeFactory)
        {
            _codeFactory = codeFactory;
            _shapeFactory = shapeFactory;
        }

        /// <summary>
        /// Creates point tool
        /// </summary>
        /// <returns></returns>
        public ITool CreatePointTool()
        {
            return new PointTool()
            {
                Primitive = _codeFactory?.CreateCodePrimitive(),
                Shape = _shapeFactory?.CreatePointShape(0, 0),
                Name = "Point"
            };
        }

        /// <summary>
        /// Creates tools collection
        /// </summary>
        /// <returns></returns>
        public IToolsCollection CreateDefaultToolsCollection()
        {
            return new ToolsCollection(new ITool[]
            {
                CreatePointTool(),
                CreatePointTool(),
                CreatePointTool(),
                CreatePointTool(),
                CreatePointTool(),
                CreatePointTool(),
                CreatePointTool(),
                CreatePointTool(),
                CreatePointTool(),
                CreatePointTool(),
                CreatePointTool()
            });
        }
    }
}
