
namespace WindowsAppColecciones
{
    partial class frmEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.gridEmpleado = new System.Windows.Forms.DataGridView();
            this.btnTraerPorId = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardarEmpleado = new System.Windows.Forms.Button();
            this.txtBuscarPoriD = new System.Windows.Forms.TextBox();
            this.btnListarEmpleados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(69, 27);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(56, 61);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(56, 100);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(24, 135);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(108, 13);
            this.lblFechaNacimiento.TabIndex = 3;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(44, 176);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(69, 13);
            this.lblNacionalidad.TabIndex = 4;
            this.lblNacionalidad.Text = "Nacionalidad";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(58, 214);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(40, 13);
            this.lblCiudad.TabIndex = 5;
            this.lblCiudad.Text = "Ciudad";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(172, 27);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(126, 20);
            this.txtId.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(172, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(126, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(172, 97);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(126, 20);
            this.txtApellido.TabIndex = 8;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(172, 132);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(126, 20);
            this.txtFechaNacimiento.TabIndex = 9;
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(172, 173);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(126, 20);
            this.txtNacionalidad.TabIndex = 10;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(172, 207);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(126, 20);
            this.txtCiudad.TabIndex = 11;
            // 
            // gridEmpleado
            // 
            this.gridEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmpleado.Location = new System.Drawing.Point(27, 264);
            this.gridEmpleado.Name = "gridEmpleado";
            this.gridEmpleado.Size = new System.Drawing.Size(694, 197);
            this.gridEmpleado.TabIndex = 12;
            // 
            // btnTraerPorId
            // 
            this.btnTraerPorId.Location = new System.Drawing.Point(443, 61);
            this.btnTraerPorId.Name = "btnTraerPorId";
            this.btnTraerPorId.Size = new System.Drawing.Size(187, 23);
            this.btnTraerPorId.TabIndex = 13;
            this.btnTraerPorId.Text = "Traer por ID";
            this.btnTraerPorId.UseVisualStyleBackColor = true;
            this.btnTraerPorId.Click += new System.EventHandler(this.btnTraerPorId_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(443, 166);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(187, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardarEmpleado
            // 
            this.btnGuardarEmpleado.Location = new System.Drawing.Point(443, 208);
            this.btnGuardarEmpleado.Name = "btnGuardarEmpleado";
            this.btnGuardarEmpleado.Size = new System.Drawing.Size(187, 23);
            this.btnGuardarEmpleado.TabIndex = 15;
            this.btnGuardarEmpleado.Text = "Guardar empleado";
            this.btnGuardarEmpleado.UseVisualStyleBackColor = true;
            this.btnGuardarEmpleado.Click += new System.EventHandler(this.btnGuardarEmpleado_Click);
            // 
            // txtBuscarPoriD
            // 
            this.txtBuscarPoriD.Location = new System.Drawing.Point(470, 27);
            this.txtBuscarPoriD.Name = "txtBuscarPoriD";
            this.txtBuscarPoriD.Size = new System.Drawing.Size(126, 20);
            this.txtBuscarPoriD.TabIndex = 16;
            // 
            // btnListarEmpleados
            // 
            this.btnListarEmpleados.Location = new System.Drawing.Point(443, 97);
            this.btnListarEmpleados.Name = "btnListarEmpleados";
            this.btnListarEmpleados.Size = new System.Drawing.Size(187, 23);
            this.btnListarEmpleados.TabIndex = 17;
            this.btnListarEmpleados.Text = "Listar empleados";
            this.btnListarEmpleados.UseVisualStyleBackColor = true;
            this.btnListarEmpleados.Click += new System.EventHandler(this.btnListarEmpleados_Click);
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 473);
            this.Controls.Add(this.btnListarEmpleados);
            this.Controls.Add(this.txtBuscarPoriD);
            this.Controls.Add(this.btnGuardarEmpleado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnTraerPorId);
            this.Controls.Add(this.gridEmpleado);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblId);
            this.Name = "frmEmpleado";
            this.Text = "frmEmpleado";
            this.Load += new System.EventHandler(this.frmEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.DataGridView gridEmpleado;
        private System.Windows.Forms.Button btnTraerPorId;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardarEmpleado;
        private System.Windows.Forms.TextBox txtBuscarPoriD;
        private System.Windows.Forms.Button btnListarEmpleados;
    }
}