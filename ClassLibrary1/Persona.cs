using System.Text;

namespace ClassLibrary1
{
    public class Persona
    {
        private string _nombre;
        private DateTime _fechaDeNacimiento;
        private string _dni;

        public Persona(string nombre, DateTime fechaNacimiento, string dni) 
        {
            _nombre = nombre;
            _fechaDeNacimiento = fechaNacimiento;
            _dni = dni;
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return _fechaDeNacimiento; }
            set
            {
                _fechaDeNacimiento = value;
            }            
        }

        public string Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        private int CalcularEdad()
        {
            TimeSpan cantidadDias = DateTime.Now - FechaNacimiento;
            int edad = (int)(cantidadDias.TotalDays / 365.25);
            return edad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Fecha de nacimiento: {FechaNacimiento.ToString("dd-MM-yyyy")}");
            sb.AppendLine($"DNI: {Dni}");
            sb.AppendLine($"Edad: {CalcularEdad()} años");
            sb.AppendLine(EsMayorDeEdad(CalcularEdad()));
            return sb.ToString();
        }

        public string EsMayorDeEdad(int edad)
        {
            if ( edad >= 18)
            {
                return "Es mayor de edad";
            }
            return "Es menor";
        }
    }
}
