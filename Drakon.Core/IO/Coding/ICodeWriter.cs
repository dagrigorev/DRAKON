using System;
using System.Collections.Generic;
using System.Text;
using Drakon.Core.Common.ObservableBase;

namespace Drakon.Core.IO.Coding
{
    public interface ICodeWriter : IObservable
    {
        string FileExtension { get; set; }
        void Write(string name);
        void Read(string name);
    }
}
