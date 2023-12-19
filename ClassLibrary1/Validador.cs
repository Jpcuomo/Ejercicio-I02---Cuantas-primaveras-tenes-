using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Validador
    {
        public static DateTime ValidarRetornarFecha(string tipoFecha)
        {
            string patron = @"^(0[1-9]|[12][0-9]|3[01])-(0[1-9]|1[0-2])-([0-9]{4})$";

            while (true)
            {
                Console.Write($"Ingrese fecha de {tipoFecha} (dd-MM-yyyy): ");
                string strFecha = Console.ReadLine();

                if (Regex.IsMatch(strFecha, patron) && DateTime.TryParseExact(strFecha, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fecha))
                {
                    Console.WriteLine("Fecha válida");
                    //Console.WriteLine("Presione una tecla...");
                    //Console.ReadKey();
                    //Console.Clear();
                    return fecha;
                }
                else
                {
                    Console.WriteLine("Error: Formato de fecha errroneo. Use el formato dd-MM-yyyy.");
                }
            }
        }

        public static string ValidarRetornarNombre()
        {
            string patron = @"^([A-Z][a-z]+)( [A-Z][a-z]+)*";
            while (true)
            {
                Console.Write("Ingrese su nombre: ");
                string nombre = Console.ReadLine();
                if (Regex.IsMatch(nombre, patron))
                {
                    Console.WriteLine("Nombre válido");
                    return nombre;
                }
                else
                {
                    Console.WriteLine("Error: Formato de nombre incorrecto");
                }
            }
        }

        public static string ValidarRetornatDNI()
        {
            string patron = @"^([1-9]*[0-9]+)\.([0-9]{3})\.([0-9]{3})$";
            while (true)
            {
                Console.Write("Ingrese su DNI: ");
                string dni = Console.ReadLine();
                if (Regex.IsMatch(dni, patron))
                {
                    Console.WriteLine("DNI válido");
                    return dni;
                }
                else
                {
                    Console.WriteLine("Error: Formato de DNI incorrecto");
                }
            }
        }

    }
}
