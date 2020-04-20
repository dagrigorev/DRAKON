using System;

namespace Drakon.Core.Logger
{
    /// <summary>
    /// Default logger contract
    /// </summary>
    public interface ILogger
    {
        void Log(string source, string message);
        void Log(string message);
        void Log(Exception ex);
    }
}