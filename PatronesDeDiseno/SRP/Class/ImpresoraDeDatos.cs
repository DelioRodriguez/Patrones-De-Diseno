

namespace SRP.Class
{
    public class ImpresoraDeDatos
    {
        public void ImprimirDatos(Persona persona)
        {
            Console.WriteLine($"Nombre : {persona.Nombre}");
            Console.WriteLine($"Edad: {persona.Edad}");
            Console.WriteLine($"Direccion: {persona.Direccion}");
            Console.WriteLine($"Correro Electronico: {persona.CorreoElectronico}");

        }

    }
}
