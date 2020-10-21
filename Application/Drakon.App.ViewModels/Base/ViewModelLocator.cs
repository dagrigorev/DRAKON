using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace Drakon.App.ViewModels.Base
{
    /// <summary>
    /// View model location service implementation.
    /// </summary>
    public class ViewModelLocator
    {
        private Regex _viewNameMatchingPattern;

        /// <summary>
        /// Enables/disables seraching view model type in current assembly only.
        /// Enabled by default.
        /// </summary>
        public bool CurrentAssemblyOnly { get; set; } = true;

        public ViewModelLocator()
        {
            _viewNameMatchingPattern = new Regex(@"(^[A-Z]+[A-Z|a-z|0-9|_]+)?View");
        }

        /// <summary>
        /// Binds view model for specific view.
        /// </summary>
        /// <typeparam name="T">View type.</typeparam>
        /// <param name="defaultViewModel"></param>
        /// <param name="binderCallerName"></param>
        public void BindViewModel<T>(T view, object defaultViewModel,
            [CallerMemberName] string binderCallerName = "",
            [CallerFilePath] string callerFilePath = "")
        {
            if (defaultViewModel == null)
                throw new ArgumentNullException($"{nameof(defaultViewModel)} cannot be null");
            if (view == null)
                throw new ArgumentNullException($"{nameof(view)} cannot be null");

            var groups = _viewNameMatchingPattern.Match(typeof(T).Name).Groups;
            var viewModelTypeName = "";

            if (groups != null && groups.Count > 1)
                viewModelTypeName = groups[1].Value + "ViewModel";

            var viewModelType = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name.Equals(viewModelTypeName));
            if (viewModelType == null)
                TryBind(view, defaultViewModel, out _);
            else
                TryBind(view, Activator.CreateInstance(viewModelType), out _);
        }

        /// <summary>
        /// Checks that view has a `DataContext` property.
        /// </summary>
        /// <typeparam name="T">View type.</typeparam>
        /// <returns></returns>
        private bool HasDataContext<T>()
        {
            return typeof(T).GetProperties().Any(p => p.PropertyType.Equals(typeof(object)) &&
            p.Name.Equals("DataContext"));
        }

        /// <summary>
        /// Tries to bind data context for generic view.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="view"></param>
        /// <param name="dataContext"></param>
        /// <param name="isBinded"></param>
        private void TryBind<T>(T view, object dataContext, out bool isBinded)
        {
            isBinded = false;

            if (HasDataContext<T>())
            {
                var prop = typeof(T).GetProperties().First(p => p.PropertyType.Equals(typeof(object)) &&
            p.Name.Equals("DataContext"));
                prop.SetValue(view, dataContext);

                isBinded = true;
            }
        }
    }
}
