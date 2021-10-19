using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaColecciones.Models;

namespace LibreriaColecciones.AdminPublicadores
{
    public static class AdminPublicador
    {

        public static List<Publicador> listaPublicadores = new List<Publicador>()
        {
            new Publicador("1", "Perez", "Pedro", DateTime.Parse("20/02/1994"), "Buenos Aires"),
            new Publicador("2", "Suarez", "Luis", DateTime.Parse("05/05/1993"), "Montevideo"),
            new Publicador("3", "Fernandez", "Romina", DateTime.Parse("03/03/2001"), "Santiago")

        };

        public static List<Publicador> listar()
        {
            return listaPublicadores;
        }

        public static int insertar(Publicador publicador)
        {
            if(publicador != null)
            {
                listaPublicadores.Add(publicador);
                return 1;
            }
            else
            {
                return 0;
            }
     
            
        }

        public static int eliminar(int id)
        {
            Publicador publicadorRemover = new Publicador();

            foreach (Publicador item in listaPublicadores)
            {
                if (item.Id == id.ToString())
                {
                    publicadorRemover = item;
                }
            }

            if (publicadorRemover.Id != null)
            {
                listaPublicadores.Remove(publicadorRemover);
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }

        

        
}
