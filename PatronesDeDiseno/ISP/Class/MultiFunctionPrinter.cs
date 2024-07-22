using ISP.Interfaces;


namespace ISP.Class
{
    public class MultiFunctionPrinter : IPrint, IScan
    {
        public void Print(Document document)
        {
            Console.WriteLine($"Printing document : {document.Name}");
        }

        public void Scan(Document document)
        {
            Console.WriteLine($"Scanning document: {document.Name}");
        }
    }
}
