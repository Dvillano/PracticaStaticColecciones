using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaColecciones.Models
{
    public class Publicador
    {
        public Publicador(string id, string apellido, string nombre, DateTime fechaNacimiento, string ciudad)
        {
            Id = id;
            Apellido = apellido;
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            Ciudad = ciudad;
        }

        public string Id { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Ciudad { get; set; }
    }
}
