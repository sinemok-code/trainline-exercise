namespace AddressProcessing.CSV.Abstractions
{
    public interface ICsvWriter
    {
        void Close();
        void Open(string fileName);
        void Write(params string[] columns);
    }
}