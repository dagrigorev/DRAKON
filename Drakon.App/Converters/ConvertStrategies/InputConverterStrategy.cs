using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Drakon.App.Input;
using Drakon.Core.Base;
using Drakon.Core.Common.ObservableBase;

namespace Drakon.App.Converters.ConvertStrategies
{
    /// <summary>
    /// Input event arguments converting strategy implementation
    /// </summary>
    public class InputConverterStrategy : Observable, IStrategy, IConverter<InputEventArgs, InputArgs>
    {
        public InputConverterStrategy()
        { }

        public InputConverterStrategy(object parent)
        {
            Parent = parent;
        }

        public IStrategy AddStrategy(IStrategy nextStep)
        {
            throw new NotImplementedException();
        }

        public InputArgs Convert(InputEventArgs sourceValue)
        {
            throw new NotImplementedException();
        }

        public object Convert(object sourceValue)
        {
            throw new NotImplementedException();
        }
    }
}
