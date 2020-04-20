using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Drakon.Core.Logger;

namespace Drakon.Core.Default.Logger
{
    /// <summary>
    /// Default logger implementation
    /// </summary>
    public class Logger : ILogger
    {
        public void Log(string source, string message)
        {
#if DEBUG
            Debug.WriteLine($"{DateTime.Now.ToLongDateString()}# From: {source} - {message}");
#endif
        }

        public void Log(string message)
        {
#if DEBUG
            Debug.WriteLine($"{DateTime.Now.ToLongDateString()}# {message}");
#endif
        }

        public void Log(Exception ex)
        {
            Log(ex.Source, ex.Message);
            //#if DEBUG
            //            Debug.WriteLine($"{DateTime.Now.ToLongDateString()}# From: {ex.Source} - {ex.Message}");
            //#endif
        }
    }
}
