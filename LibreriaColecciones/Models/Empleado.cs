using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaColecciones.Models
{
    public class Empleado
    {
        public Empleado(string apellido, string nombre, DateTime fechaNacimiento, string nacionalidad, string ciudad)
        {
            Apellido = apellido;
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            Nacionalidad = nacionalidad;
            Ciudad = ciudad;
        }

        public int Id { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public string Ciudad { get; set; }
    }
}
