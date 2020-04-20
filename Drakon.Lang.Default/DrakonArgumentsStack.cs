using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Text;
using Drakon.Core;
using Drakon.Core.Coding;
using Drakon.Core.Common.Collections;

namespace Drakon.Lang.Default
{
    /// <summary>
    /// DRAKON arguments stack implementation
    /// </summary>
    public class DrakonArgumentsStack : ObservableStack<ICodeArgument>, IArgumentsStack
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public DrakonArgumentsStack()
        {
        }

        /// <summary>
        /// Adds new argument
        /// </summary>
        /// <param name="arg"></param>
        public void AddArgument(ICodeArgument arg)
        {
            Push(arg);
        }

        /// <summary>
        /// Removes argument at the top of the stack and return it 
        /// </summary>
        /// <param name="arg"></param>
        public void RemoveArgument(out ICodeArgument arg)
        {
            arg = default;
            if (Count > 0)
                arg = Pop();
        }
    }
}
