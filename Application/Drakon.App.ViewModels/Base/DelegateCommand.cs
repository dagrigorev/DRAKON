using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Input;

namespace Drakon.App.ViewModels.Base
{
    /// <summary>
    /// Delegate command implementation.
    /// </summary>
    public class DelegateCommand : ICommand
    {
        private Action<object> _commandAction;

        public event EventHandler CanExecuteChanged;

        public DelegateCommand(Action<object> action)
        {
            if (action == null)
                throw new ArgumentNullException($"{nameof(action)} cannot be null");

            _commandAction = action;
        }

        public bool CanExecute(object parameter)
        {
            return _commandAction != null;
        }

        public void Execute(object parameter)
        {
            _commandAction?.Invoke(parameter);
        }
    }
}
