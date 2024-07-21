
namespace SRP.Class
{
    public class Persona
    {
        private string nombre;
        private int edad;
        private string direccion;
        private string correoElectronico;

        public Persona(string nombre, int edad, string direccion, string correoElectronico)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.direccion = direccion;
            this.correoElectronico = correoElectronico;
        }
        public string Nombre => nombre;
        public int Edad => edad;
        public string Direccion => direccion;
        public string CorreoElectronico => correoElectronico;

    }
}
