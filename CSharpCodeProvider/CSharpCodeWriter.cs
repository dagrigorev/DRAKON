using System;
using System.Collections.Generic;
using System.Text;
using Drakon.Core.Common.ObservableBase;
using Drakon.Core.IO.Coding;

namespace Drakon.Core.Coding.CSharp
{
    public class CSharpCodeWriter : Observable, ICodeWriter
    {
        private string _fileExtension;

        /// <inheritdoc />
        public string FileExtension
        {
            get => _fileExtension;
            set => SetProperty(ref _fileExtension, value);
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public CSharpCodeWriter()
        {
            FileExtension = "cs";
        }

        /// <inheritdoc />
        public void Write(string name)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void Read(string name)
        {
            throw new NotImplementedException();
        }
    }
}
