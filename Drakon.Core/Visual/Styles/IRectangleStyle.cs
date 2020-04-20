using System;
using System.Collections.Generic;
using System.Text;

namespace Drakon.Core.Visual.Styles
{
    /// <summary>
    /// Rectangle style
    /// </summary>
    interface IRectangleStyle : IShapeStyle
    {
        /// <summary>
        /// Rectangle border radius
        /// </summary>
        int Radius { get; set; }

        /// <summary>
        /// Incline angle
        /// </summary>
        int InclineAngle { get; set; }

        /// <summary>
        /// Enables left side triangulation
        /// </summary>
        bool IsLeftSideTriangulated { get; set; }

        /// <summary>
        /// Enables right side triangulation
        /// </summary>
        bool IsRightSideTriangulated { get; set; }

        /// <summary>
        /// Enables top side triangulation
        /// </summary>
        bool IsTopSideTriangulated { get; set; }

        /// <summary>
        /// Enables bottom side triangulation 
        /// </summary>
        bool IsBottomSideTriangulated { get; set; }
    }
}
