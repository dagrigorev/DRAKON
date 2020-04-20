using System;
using System.Collections.Generic;
using System.Text;
using Drakon.Core.Visual.Shapes;
using Drakon.Core.Visual.Styles;

namespace Drakon.Lang.Shapes
{
    /// <summary>
    /// Action tool shape contract
    /// </summary>
    public interface IActionShape : IRectangleShape
    {
        /// <summary>
        /// Input points shapes
        /// </summary>
        IPointShape InputPoints { get; set; }

        /// <summary>
        /// Output point shape
        /// </summary>
        IPointShape OutputPoint { get; set; }
    }
}
