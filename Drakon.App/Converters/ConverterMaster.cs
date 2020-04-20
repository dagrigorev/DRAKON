using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using Drakon.App.Converters;
using Drakon.App.Converters.ConvertStrategies;
using Drakon.Core.Base;
using Drakon.Core.Common.ObservableBase;
using Type = System.Type;

namespace Drakon.App.Input
{
    /// <summary>
    /// User control event args to view model input args converter
    /// </summary>
    public class ConverterMaster : Observable, IValueConverter, IDisposable
    {
        private Dictionary<Type, IStrategy> _converters;

        public ConverterMaster()
        {
            _converters = new Dictionary<Type, IStrategy>();

            InitConverters();
        }

        /// <summary>
        /// Initialize all default converters
        /// </summary>
        public void InitConverters()
        {
            if (_converters != null)
            {
                RegisterStrategy(typeof(MouseEventArgs), new MouseConverterStrategy(this));
                RegisterStrategy(typeof(MouseButtonEventArgs), new MouseConverterStrategy(this));
            }
        }

        /// <summary>
        /// Registers new strategy
        /// </summary>
        /// <param name="inputValueType"></param>
        /// <param name="strategy"></param>
        public void RegisterStrategy(Type inputValueType, IStrategy strategy)
        {
            _converters.Add(inputValueType, strategy);
        }

        /// <summary>
        /// Removes strategy from registration
        /// </summary>
        /// <param name="inputValueType"></param>
        public void RemoveStrategy(Type inputValueType) => _converters.Remove(inputValueType);

        /// <summary>
        /// Returns new previously registered strategy
        /// </summary>
        /// <param name="inputType"></param>
        /// <returns></returns>
        public IStrategy GetStrategy(Type inputType)
        {
            if (!_converters.ContainsKey(inputType)) return default;

            return _converters[inputType];
        }
        

        /// <summary>
        /// Converts value to 
        /// </summary>
        /// <typeparam name="TOut"></typeparam>
        /// <typeparam name="TIn"></typeparam>
        /// <param name="input"></param>
        /// <returns></returns>
        public TOut Convert<TOut, TIn>(TIn input)
        {
            if (GetStrategy(typeof(TIn)) is IConverter<TIn, TOut> converter)
            {
                return converter.Convert(input);
            }
            else 
                return default;
        }

        public object Convert(object input)
        {
            if (GetStrategy(input.GetType()) is IConverter converter)
                return converter?.Convert(input);
            else
                return null;
        }

        /// <summary>
        /// <see cref="IValueConverter" /> default method
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Convert(value);
        }

        /// <summary>
        /// <see cref="IValueConverter" /> default method
        /// </summary>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ConvertBack(value);
        }

        /// <summary>
        /// Converts value back to source type
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private object ConvertBack(object value)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            Parent = null;
        }
    }
}
