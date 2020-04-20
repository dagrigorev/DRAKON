using System;
using System.Collections.Generic;
using System.Text;
using Drakon.Core.Containers.Coding;

namespace Drakon.Core.Containers
{
    /// <summary>
    /// Project document container
    /// </summary>
    public interface IDocumentContainer : IDescripted
    {
        // TODO: define base project document contract here
        IEnumerable<ICodePrimitive> CodePrimitives { get; set; }
    }
}
