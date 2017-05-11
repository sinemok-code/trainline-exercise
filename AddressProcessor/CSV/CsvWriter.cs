using AddressProcessing.CSV.Abstractions;
using System.IO;
using System.Linq;

namespace AddressProcessing.CSV
{
    public class CsvWriter : ICsvWriter
    {
        private StreamWriter _writerStream;
        public void Open(string fileName)
        {
            var fileInfo = new FileInfo(fileName);
            _writerStream = fileInfo.CreateText();
        }
        public void Write(params string[] columns)
        {
            var line = columns.Aggregate((current, next) => current + '\t' + next);
            _writerStream.WriteLine(line); 
        }
        public void Close()
        {
            _writerStream?.Close();
        }
    }
}
