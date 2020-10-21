using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Drakon.App.ViewModels.Base
{
    /// <summary>
    /// View model location service implementation.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Binds 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="defaultViewModel"></param>
        /// <param name="binderCallerName"></param>
        public void BindViewModel<T>(T defaultViewModel, [CallerMemberName] string binderCallerName = "")
        {

        }
    }
}
