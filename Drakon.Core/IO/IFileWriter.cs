using Drakon.Core.Common.ObservableBase;

namespace Drakon.Core.IO
{
    /// <summary>
    /// File writer/reader contract
    /// </summary>
    public interface IFileWriter : IObservable
    {
        /// <summary>
        /// Writes file
        /// </summary>
        /// <param name="fileName"></param>
        void Write(string fileName);

        /// <summary>
        /// Reads file
        /// </summary>
        /// <param name="fileName"></param>
        void Read(string fileName);
    }
}