using ClassLibrary1;

namespace Ejercicio_I02___Cuántas_primaveras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = CargarDatosEInstanciarPersona();
            Console.WriteLine();
            Persona persona2 = CargarDatosEInstanciarPersona();
            Console.WriteLine();
            Persona persona3 = CargarDatosEInstanciarPersona();
            Console.WriteLine();
            Console.Clear();


            Console.WriteLine(persona1.Mostrar());
            Console.WriteLine(persona2.Mostrar());
            Console.WriteLine(persona3.Mostrar());
        }


        internal static Persona CargarDatosEInstanciarPersona()
        {
            string nombre = Validador.ValidarRetornarNombre();
            DateTime fechaNacimiento = Validador.ValidarRetornarFecha("nacimiento");
            string dni = Validador.ValidarRetornatDNI();

            Persona nombreInstancia = new Persona(nombre, fechaNacimiento, dni);
            return nombreInstancia;
        }
    }
}
