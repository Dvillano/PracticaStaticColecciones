using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaColecciones.Models
{
    public class Autor
    {
        public Autor(string id, string apellido, string nombre, DateTime fechaNacimiento, string nacionalidad, string ciudad)
        {
            Id = id;
            Apellido = apellido;
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            Nacionalidad = nacionalidad;
            Ciudad = ciudad;
        }

        public string Id { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public string Ciudad { get; set; }

    }
}
