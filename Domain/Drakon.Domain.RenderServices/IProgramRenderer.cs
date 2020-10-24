using Drakon.Data.Program;

using System;
using System.Collections.Generic;
using System.Text;

namespace Drakon.Domain.RenderServices
{
    /// <summary>
    /// DRAKON program renderer service definition.
    /// </summary>
    public interface IProgramRenderer
    {
        void Render(IProgram program);
    }
}
