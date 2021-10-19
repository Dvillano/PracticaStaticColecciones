
namespace WindowsAppColecciones
{
    partial class frmPublicador
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
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.dataPublicadores = new System.Windows.Forms.DataGridView();
            this.btnGuardarPublicador = new System.Windows.Forms.Button();
            this.btnEliminarPublicador = new System.Windows.Forms.Button();
            this.btnListarPublicadores = new System.Windows.Forms.Button();
            this.txtEliminarId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataPublicadores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(67, 31);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(54, 66);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(54, 104);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(22, 141);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(108, 13);
            this.lblFechaNacimiento.TabIndex = 3;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(56, 172);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(40, 13);
            this.lblCiudad.TabIndex = 4;
            this.lblCiudad.Text = "Ciudad";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(145, 28);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.txtNombre.Location = new System.Drawing.Point(145, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(145, 97);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 7;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(145, 134);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.txtFechaNacimiento.TabIndex = 8;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(145, 165);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(100, 20);
            this.txtCiudad.TabIndex = 9;
            // 
            // dataPublicadores
            // 
            this.dataPublicadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPublicadores.Location = new System.Drawing.Point(12, 279);
            this.dataPublicadores.Name = "dataPublicadores";
            this.dataPublicadores.Size = new System.Drawing.Size(628, 150);
            this.dataPublicadores.TabIndex = 10;
            // 
            // btnGuardarPublicador
            // 
            this.btnGuardarPublicador.Location = new System.Drawing.Point(25, 228);
            this.btnGuardarPublicador.Name = "btnGuardarPublicador";
            this.btnGuardarPublicador.Size = new System.Drawing.Size(152, 23);
            this.btnGuardarPublicador.TabIndex = 11;
            this.btnGuardarPublicador.Text = "Guardar";
            this.btnGuardarPublicador.UseVisualStyleBackColor = true;
            this.btnGuardarPublicador.Click += new System.EventHandler(this.btnGuardarPublicador_Click);
            // 
            // btnEliminarPublicador
            // 
            this.btnEliminarPublicador.Location = new System.Drawing.Point(464, 228);
            this.btnEliminarPublicador.Name = "btnEliminarPublicador";
            this.btnEliminarPublicador.Size = new System.Drawing.Size(176, 23);
            this.btnEliminarPublicador.TabIndex = 12;
            this.btnEliminarPublicador.Text = "Eliminar";
            this.btnEliminarPublicador.UseVisualStyleBackColor = true;
            this.btnEliminarPublicador.Click += new System.EventHandler(this.btnEliminarPublicador_Click);
            // 
            // btnListarPublicadores
            // 
            this.btnListarPublicadores.Location = new System.Drawing.Point(234, 228);
            this.btnListarPublicadores.Name = "btnListarPublicadores";
            this.btnListarPublicadores.Size = new System.Drawing.Size(167, 23);
            this.btnListarPublicadores.TabIndex = 13;
            this.btnListarPublicadores.Text = "Listar publicadores";
            this.btnListarPublicadores.UseVisualStyleBackColor = true;
            this.btnListarPublicadores.Click += new System.EventHandler(this.btnListarPublicadores_Click);
            // 
            // txtEliminarId
            // 
            this.txtEliminarId.Location = new System.Drawing.Point(502, 202);
            this.txtEliminarId.Name = "txtEliminarId";
            this.txtEliminarId.Size = new System.Drawing.Size(100, 20);
            this.txtEliminarId.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(461, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
            // 
            // frmPublicador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEliminarId);
            this.Controls.Add(this.btnListarPublicadores);
            this.Controls.Add(this.btnEliminarPublicador);
            this.Controls.Add(this.btnGuardarPublicador);
            this.Controls.Add(this.dataPublicadores);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblId);
            this.Name = "frmPublicador";
            this.Text = "frmPublicador";
            this.Load += new System.EventHandler(this.frmPublicador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPublicadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.DataGridView dataPublicadores;
        private System.Windows.Forms.Button btnGuardarPublicador;
        private System.Windows.Forms.Button btnEliminarPublicador;
        private System.Windows.Forms.Button btnListarPublicadores;
        private System.Windows.Forms.TextBox txtEliminarId;
        private System.Windows.Forms.Label label1;
    }
}