

using ISP.Class;
using ISP.Interfaces;

namespace ISP.Main
{
    public class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document { Name = "Reporte", Description = "Reporte de lectura sobre los perros" };

            IPrint simplePrinter = new SimplePrinter();
            simplePrinter.Print(document);

            IPrint multiFunctionPrinter = new MultiFunctionPrinter();  
            multiFunctionPrinter.Print(document);

            IScan scanner = new MultiFunctionPrinter();
            scanner.Scan(document);

        }
    }
}
