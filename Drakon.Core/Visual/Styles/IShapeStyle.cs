using System;
using System.Drawing;
using Drakon.Core.Common.ObservableBase;

namespace Drakon.Core.Visual.Styles
{
    /// <summary>
    /// Shape style contract
    /// </summary>
    public interface IShapeStyle : IObservable
    {
        /// <summary>
        /// Rotation angle
        /// </summary>
        int Rotation { get; set; }

        /// <summary>
        /// Fills the shape
        /// </summary>
        bool IsFilled { get; set; }

        bool IsSelected { get; set; }
        
        /// <summary>
        /// Border thickness value
        /// </summary>
        int BorderThickness { get; set; }

        /// <summary>
        /// Fill color
        /// </summary>
        Color FillColor { get; set; }

        /// <summary>
        /// Border color
        /// </summary>
        Color BorderColor { get; set; }

        /// <summary>
        /// Font family
        /// </summary>
        string FontFamily { get; set; }

        /// <summary>
        /// Font family
        /// </summary>
        int FontSize { get; set; }
    }
}