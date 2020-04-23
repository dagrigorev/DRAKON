using System;
using Drakon.Core.Common.ObservableBase;
using Drakon.Core.Containers.Coding;
using Drakon.Core.IO.Coding;

namespace Drakon.Core.Coding.CSharp
{
    /// <summary>
    /// C# code provider implementation
    /// </summary>
    public class CSharpCodeProvider : Observable, ICodeProvider
    {
        /// <inheritdoc />
        public ICodePrimitivesRepository Primitives { get; }

        /// <inheritdoc />
        public ICallSequence CallSequence { get; set; }

        /// <inheritdoc />
        public ICodeWriter Writer { get; set; }

        /// <inheritdoc />
        public ICodeChecker Checker { get; set; }

        /// <inheritdoc />
        public ICodeOptions Options { get; set; }

        /// <inheritdoc />
        public string SourceCode { get; }

        /// <inheritdoc />
        public void AddToCall(ICodePrimitive code)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void RemoveFromCall(ICodePrimitive code)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void Check()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void Build()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
