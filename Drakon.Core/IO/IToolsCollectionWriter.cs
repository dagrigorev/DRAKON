namespace Drakon.Core.IO
{
    public interface IToolsCollectionWriter : IFileWriter
    {
        void SaveToolsList();
        void LoadToolsList();
    }
}