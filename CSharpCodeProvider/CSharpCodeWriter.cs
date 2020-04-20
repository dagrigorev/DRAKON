using System;
using System.Collections.Generic;
using System.Text;
using Drakon.Core.IO.Coding;

namespace Drakon.Core.Coding.CSharp
{
    public class CSharpCodeWriter : Observable, ICodeWriter
    {
        private string _fileExtension;

        public string FileExtension
        {
            get => _fileExtension;
            set => SetProperty(ref _fileExtension, value);
        }

        public CSharpCodeWriter()
        {
            FileExtension = "cs";
        }

        public void Write(string name)
        {
            throw new NotImplementedException();
        }

        public void Read(string name)
        {
            throw new NotImplementedException();
        }
    }
}
