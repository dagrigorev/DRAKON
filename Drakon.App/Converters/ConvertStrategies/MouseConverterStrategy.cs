using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using Drakon.App.Input;
using Drakon.Core.Base;
using Drakon.Core.Common.ObservableBase;

namespace Drakon.App.Converters.ConvertStrategies
{
    /// <summary>
    /// Mouse input event arguments converting strategy implementation
    /// </summary>
    public class MouseConverterStrategy : Observable, IStrategy, IConverter<MouseEventArgs, InputArgs>
    {
        private IStrategy _nextStrategy;

        /// <summary>
        /// Default constructor
        /// </summary>
        public MouseConverterStrategy()
        {
            _nextStrategy = default;
        }

        public MouseConverterStrategy(object parent)
        {
            Parent = parent;
        }

        /// <summary>
        /// Adds next strategy
        /// </summary>
        /// <param name="nextStep"></param>
        /// <returns></returns>
        public IStrategy AddStrategy(IStrategy nextStep)
        {
            _nextStrategy = nextStep;
            return this;
        }

        /// <summary>
        /// Converts <see cref="MouseEventArgs"/> to <see cref="InputArgs"/>.
        /// </summary>
        /// <param name="sourceValue"></param>
        /// <returns><see cref="InputArgs"/> instance</returns>
        public InputArgs Convert(MouseEventArgs sourceValue, UserControl control)
        {
            var pos = control.PointToScreen(sourceValue.GetPosition(sourceValue.Source as IInputElement));
            return new InputArgs()
            {
                MousePosition = pos
            };
        }

        public InputArgs Convert(MouseEventArgs sourceValue)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Converts source value (passed MouseEventArgs or MouseButtonEventArgs) to inner <see cref="InputArgs"/>.
        /// Parent must represent the control.
        /// </summary>
        /// <param name="sourceValue"></param>
        /// <returns></returns>
        public object Convert(object sourceValue)
        {
            if (((Observable)Parent).Parent is UserControl control && 
                (sourceValue is MouseEventArgs args))
            {
                return Convert(args, control);
            }

            return default;
        }
    }
}
