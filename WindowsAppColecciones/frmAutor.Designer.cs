
namespace WindowsAppColecciones
{
    partial class frmAutor
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTraerPorCiudad = new System.Windows.Forms.Button();
            this.btnGuardarAutor = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.gridAutores = new System.Windows.Forms.DataGridView();
            this.btnListarAutores = new System.Windows.Forms.Button();
            this.txtBuscarCiudad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autor";
            // 
            // btnTraerPorCiudad
            // 
            this.btnTraerPorCiudad.Location = new System.Drawing.Point(30, 212);
            this.btnTraerPorCiudad.Name = "btnTraerPorCiudad";
            this.btnTraerPorCiudad.Size = new System.Drawing.Size(145, 23);
            this.btnTraerPorCiudad.TabIndex = 1;
            this.btnTraerPorCiudad.Text = "Traer por ciudad";
            this.btnTraerPorCiudad.UseVisualStyleBackColor = true;
            this.btnTraerPorCiudad.Click += new System.EventHandler(this.btnTraerPorCiudad_Click);
            // 
            // btnGuardarAutor
            // 
            this.btnGuardarAutor.Location = new System.Drawing.Point(352, 212);
            this.btnGuardarAutor.Name = "btnGuardarAutor";
            this.btnGuardarAutor.Size = new System.Drawing.Size(145, 23);
            this.btnGuardarAutor.TabIndex = 2;
            this.btnGuardarAutor.Text = "Guardar autor";
            this.btnGuardarAutor.UseVisualStyleBackColor = true;
            this.btnGuardarAutor.Click += new System.EventHandler(this.btnGuardarAutor_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(352, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(145, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(257, 74);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(257, 100);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(352, 97);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(145, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(223, 126);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(110, 13);
            this.lblFechaNacimiento.TabIndex = 8;
            this.lblFechaNacimiento.Text = "Fecha De Nacimiento";
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(352, 123);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(145, 20);
            this.txtFechaNacimiento.TabIndex = 7;
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(248, 152);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(69, 13);
            this.lblNacionalidad.TabIndex = 10;
            this.lblNacionalidad.Text = "Nacionalidad";
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(352, 149);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(145, 20);
            this.txtNacionalidad.TabIndex = 9;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(257, 178);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(40, 13);
            this.lblCiudad.TabIndex = 12;
            this.lblCiudad.Text = "Ciudad";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(352, 175);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(145, 20);
            this.txtCiudad.TabIndex = 11;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(268, 48);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 14;
            this.lblId.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(352, 45);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(145, 20);
            this.txtId.TabIndex = 13;
            // 
            // gridAutores
            // 
            this.gridAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAutores.Location = new System.Drawing.Point(30, 252);
            this.gridAutores.Name = "gridAutores";
            this.gridAutores.Size = new System.Drawing.Size(764, 150);
            this.gridAutores.TabIndex = 15;
            // 
            // btnListarAutores
            // 
            this.btnListarAutores.Location = new System.Drawing.Point(649, 212);
            this.btnListarAutores.Name = "btnListarAutores";
            this.btnListarAutores.Size = new System.Drawing.Size(145, 23);
            this.btnListarAutores.TabIndex = 16;
            this.btnListarAutores.Text = "Listar Autores";
            this.btnListarAutores.UseVisualStyleBackColor = true;
            this.btnListarAutores.Click += new System.EventHandler(this.btnListarAutores_Click);
            // 
            // txtBuscarCiudad
            // 
            this.txtBuscarCiudad.Location = new System.Drawing.Point(30, 186);
            this.txtBuscarCiudad.Name = "txtBuscarCiudad";
            this.txtBuscarCiudad.Size = new System.Drawing.Size(145, 20);
            this.txtBuscarCiudad.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 414);
            this.Controls.Add(this.txtBuscarCiudad);
            this.Controls.Add(this.btnListarAutores);
            this.Controls.Add(this.gridAutores);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnGuardarAutor);
            this.Controls.Add(this.btnTraerPorCiudad);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAutores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTraerPorCiudad;
        private System.Windows.Forms.Button btnGuardarAutor;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView gridAutores;
        private System.Windows.Forms.Button btnListarAutores;
        private System.Windows.Forms.TextBox txtBuscarCiudad;
    }
}

