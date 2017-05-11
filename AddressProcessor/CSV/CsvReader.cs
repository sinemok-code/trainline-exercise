using AddressProcessing.CSV.Abstractions;
using System.IO;

namespace AddressProcessing.CSV
{
    public class CsvReader : ICsvReader
    {
        private StreamReader _readerStream;
        public void Open(string fileName)
        {
            // Initially thought of checking if file exists, 
            // but then found out that File.OpenText already does that.
            _readerStream = File.OpenText(fileName);        
        }
        public bool Read(out string column1, out string column2)
        {
            string line;
            string[] columns;

            char[] separator = { '\t' };

            line = _readerStream.ReadLine();

            if (line == null)
            {
                column1 = null;
                column2 = null;

                return false;
            }

            columns = line.Split(separator);

            if (columns.Length == 0)
            {
                column1 = null;
                column2 = null;

                return false;
            }
            else
            {
                column1 = columns[0];
                column2 = columns[1];

                return true;
            }
        }
        public void Close()
        {
            _readerStream?.Close();  
        }
    }
}
