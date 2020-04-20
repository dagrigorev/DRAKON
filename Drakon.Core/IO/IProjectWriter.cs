using Drakon.Core.Containers;

namespace Drakon.Core.IO
{
    public interface IProjectWriter : IFileWriter
    {
        IDocumentWriter DocumentWriter { get; set; }

        void SaveProject(IProjectContainer projectContainer);
        void LoadProject(string fileName);
    }
}