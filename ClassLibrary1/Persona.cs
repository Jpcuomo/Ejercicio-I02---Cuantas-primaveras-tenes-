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
            while (true)
            {
                if(DateTime.Now >= FechaNacimiento)
                {
                    TimeSpan cantidadDias = DateTime.Now - FechaNacimiento;
                    int edad = (int)(cantidadDias.TotalDays / 365.25);
                    return edad;
                }
                return -1;
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Fecha de nacimiento: {FechaNacimiento.ToString("dd-MM-yyyy")}");
            sb.AppendLine($"DNI: {Dni}");
            if(CalcularEdad() != -1)
            {
                sb.AppendLine($"Edad: {CalcularEdad()} años");
            }
            else
            {
                sb.AppendLine($"Edad: -");
            }
            sb.AppendLine(EsMayorDeEdad());
            return sb.ToString();
        }

        public string EsMayorDeEdad()
        {
            if (CalcularEdad() >= 18)
            {
                return "Es mayor de edad";
            }
            else if (CalcularEdad() < 0)
            {
                return  "Error en el cálculo de edad ";
            }
            return "Es menor";
        }
    }
}
