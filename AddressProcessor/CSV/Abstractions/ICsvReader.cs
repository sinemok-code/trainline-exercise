namespace AddressProcessing.CSV.Abstractions
{
    public interface ICsvReader
    {
        void Close();
        void Open(string fileName);
        bool Read(out string column1, out string column2);
    }
}