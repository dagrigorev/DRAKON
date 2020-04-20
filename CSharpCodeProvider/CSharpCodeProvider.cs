using System;
using Drakon.Core.Containers.Coding;
using Drakon.Core.IO.Coding;

namespace Drakon.Core.Coding.CSharp
{
    /// <summary>
    /// C# code provider implementation
    /// </summary>
    public class CSharpCodeProvider : Observable, ICodeProvider
    {
        public ICodePrimitivesRepository Primitives { get; }
        public ICallSequence CallSequence { get; set; }
        public ICodeWriter Writer { get; set; }
        public ICodeChecker Checker { get; set; }
        public ICodeOptions Options { get; set; }
        public string SourceCode { get; }




        public void AddToCall(ICodePrimitive code)
        {
            throw new NotImplementedException();
        }

        public void RemoveFromCall(ICodePrimitive code)
        {
            throw new NotImplementedException();
        }

        public void Check()
        {
            throw new NotImplementedException();
        }

        public void Build()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
