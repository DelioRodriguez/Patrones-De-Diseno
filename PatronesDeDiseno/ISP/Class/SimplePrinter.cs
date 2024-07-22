
using ISP.Interfaces;

namespace ISP.Class
{
    public class SimplePrinter : IPrint
    {
        public void Print(Document document)
        {
            Console.WriteLine($"Printing document: {document.Name}");
        }
    }
}
