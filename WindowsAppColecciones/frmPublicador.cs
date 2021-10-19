using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaColecciones.AdminPublicadores;
using LibreriaColecciones.Models;

namespace WindowsAppColecciones
{
    public partial class frmPublicador : Form
    {
        public frmPublicador()
        {
            InitializeComponent();
        }

        private void frmPublicador_Load(object sender, EventArgs e)
        {
            dataPublicadores.DataSource = AdminPublicador.listar();
        }

        private void btnGuardarPublicador_Click(object sender, EventArgs e)
        {
            agregarPublicador();
            borrarCampos();
        }

        private void btnListarPublicadores_Click(object sender, EventArgs e)
        {
            dataPublicadores.DataSource = null;
            dataPublicadores.DataSource = AdminPublicador.listar();
        }

        private void btnEliminarPublicador_Click(object sender, EventArgs e)
        {
            eliminarPublicador();
        }

        private void agregarPublicador()
        {
            int respuesta = AdminPublicador.insertar(new Publicador(txtId.Text, txtApellido.Text, txtNombre.Text, DateTime.Parse(txtFechaNacimiento.Text), txtCiudad.Text));

            if (respuesta == 1)
            {
                MessageBox.Show("Se agrego publicador con exito");
            }
            else
            {
                MessageBox.Show("No se pudo agregar publicador");
            }
        }

        private void borrarCampos()
        {
            txtId.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtFechaNacimiento.Clear();
            txtCiudad.Clear();
        }

        private void eliminarPublicador()
        {
            if (txtEliminarId.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un ID a eliminar");
            }
            else
            {
                int respuesta = AdminPublicador.eliminar(int.Parse(txtEliminarId.Text));
                if (respuesta == 1)
                {
                    MessageBox.Show("Se elimino publicador ID: " + txtEliminarId.Text);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar publicador");
                }
                txtEliminarId.Clear();
            }
        }
    }
}
