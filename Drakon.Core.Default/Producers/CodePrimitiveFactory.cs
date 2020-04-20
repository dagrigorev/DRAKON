using System;
using System.Collections.Generic;
using System.Text;
using Drakon.Core.Coding;
using Drakon.Core.Containers.Coding;
using Drakon.Core.Factories;

namespace Drakon.Core.Default.Producers
{
    /// <summary>
    /// Code primitive factory implementation
    /// </summary>
    public class CodePrimitiveFactory : ICodePrimitiveFactory
    {
        public ICodePrimitive CreateCodePrimitive()
        {
            // TODO: Implement Code primitive producing
            return default;
        }

        public ICodeArgument CreateArgumentContainer()
        {
            throw new NotImplementedException();
        }
    }
}
