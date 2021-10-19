using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaColecciones.Models;

namespace WindowsAppColecciones
{
    public partial class frmAutor : Form
    {
        List<Autor> listaAutores = new List<Autor>();

        public frmAutor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            precargarAutores();
        }

        private void precargarAutores()
        {
            Autor autor1 = new Autor("1", "Perez", "Pedro", DateTime.Parse("20/10/1985"), "Argentino", "Cordoba");
            Autor autor2 = new Autor("2", "Fernandez", "Luisa", DateTime.Parse("30/03/1989"), "Peruana", "Lima");
            Autor autor3 = new Autor("3", "Messi", "Luis", DateTime.Parse("20/03/1978"), "Canadiense", "Toronto");
            listaAutores.Add(autor1);
            listaAutores.Add(autor2);
            listaAutores.Add(autor3);

            gridAutores.DataSource = listaAutores;
        }

        private void btnGuardarAutor_Click(object sender, EventArgs e)
        {
            insertarAutor();
        }

        private void insertarAutor()
        {
            Autor autor = new Autor(txtId.Text, txtApellido.Text, txtNombre.Text, DateTime.Parse(txtFechaNacimiento.Text), txtNacionalidad.Text, txtCiudad.Text);
            listaAutores.Add(autor);

            MessageBox.Show("Nuevo autor guardado");

            txtId.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtFechaNacimiento.Clear();
            txtNacionalidad.Clear();
            txtCiudad.Clear();
        }

        private void btnListarAutores_Click(object sender, EventArgs e)
        {
            gridAutores.DataSource = null;
            gridAutores.DataSource = listaAutores;
        }

        private void btnTraerPorCiudad_Click(object sender, EventArgs e)
        {
            listarAutorPorCiudad();
        }

        private void listarAutorPorCiudad()
        {
            List<Autor> listaAutoresPorCiudad = new List<Autor>();

            foreach (Autor item in listaAutores)
            {
                if (item.Ciudad == txtBuscarCiudad.Text)
                {
                    listaAutoresPorCiudad.Add(item);
                }
            }

            gridAutores.DataSource = listaAutoresPorCiudad;
        }
    }
}
