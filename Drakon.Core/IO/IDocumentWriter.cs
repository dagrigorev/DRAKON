using Drakon.Core.Containers;

namespace Drakon.Core.IO
{
    public interface IDocumentWriter : IFileWriter
    {
        void SaveDocument(IDocumentContainer document);
        void LoadDocument(string fileName);
    }
}