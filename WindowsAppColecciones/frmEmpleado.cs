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
    public partial class frmEmpleado : Form
    {
        List<Empleado> listaEmpleados = new List<Empleado>();

        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            precargarEmpleados();
        }

        private void precargarEmpleados()
        {
            Empleado empleado1 = new Empleado("1", "Perez", "Pedro", DateTime.Parse("20/10/1985"), "Argentino", "Cordoba");
            Empleado empleado2 = new Empleado("2", "Fernandez", "Luisa", DateTime.Parse("30/03/1989"), "Peruana", "Lima");
            Empleado empleado3 = new Empleado("3", "Messi", "Luis", DateTime.Parse("20/03/1978"), "Canadiense", "Toronto");
            listaEmpleados.Add(empleado1);
            listaEmpleados.Add(empleado2);
            listaEmpleados.Add(empleado3);

            gridEmpleado.DataSource = listaEmpleados;
        }

        private void btnGuardarEmpleado_Click(object sender, EventArgs e)
        {
            insertarEmpleado();
        }

        private void insertarEmpleado()
        {
            Empleado empleado = new Empleado(txtId.Text, txtApellido.Text, txtNombre.Text, DateTime.Parse(txtFechaNacimiento.Text), txtNacionalidad.Text, txtCiudad.Text);
            listaEmpleados.Add(empleado);

            MessageBox.Show("Nuevo empleado guardado");

            txtId.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtFechaNacimiento.Clear();
            txtNacionalidad.Clear();
            txtCiudad.Clear();
        }

        private void btnListarEmpleados_Click(object sender, EventArgs e)
        {
            gridEmpleado.DataSource = null;
            gridEmpleado.DataSource = listaEmpleados;
        }

        private void btnTraerPorId_Click(object sender, EventArgs e)
        {
            listarEmpleadosPorId();

        }

        private void listarEmpleadosPorId()
        {
            if (listaEmpleados != null)
            {
                foreach (Empleado item in listaEmpleados)
                {
                    if (item.Id == txtBuscarPoriD.Text)
                    {
                        MessageBox.Show("ID: " + item.Id +
                                        "\nNombre: " + item.Nombre +
                                        "\nApellido: " + item.Apellido +
                                        "\nFecha de Nacimiento: " + item.FechaNacimiento.ToShortDateString() +
                                        "\nNacionalidad: " + item.Nacionalidad +
                                        "\nCiudad: " + item.Ciudad);
                    }
                }
            }

            if (txtBuscarPoriD.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un ID");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarEmpleado();

        }

        private void eliminarEmpleado()
        {
            if (txtBuscarPoriD.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un ID");
            }
            else
            {
                Empleado empleadoRemover = new Empleado();

                foreach (Empleado item in listaEmpleados)
                {
                    if (item.Id == txtBuscarPoriD.Text)
                    {
                        empleadoRemover = item;
                    }
                }

                if (empleadoRemover.Id != null)
                {
                    listaEmpleados.Remove(empleadoRemover);
                    MessageBox.Show("Se elimino el empleado de ID: " + empleadoRemover.Id);
                  
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el empleado");
                }

                txtBuscarPoriD.Clear();
            }
        }
    }
}
