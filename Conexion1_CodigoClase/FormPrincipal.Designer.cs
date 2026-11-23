using System.Drawing;          // Point, Size, Font
using System.Windows.Forms;    // Label, Button, TextBox, DataGridView

namespace Conexion1_CodigoClase
{
    // Este archivo lo usa el DISEÑADOR de Visual Studio: aquí se crean y ubican los controles.
    // Normalmente no se escribe a mano: se arrastran los controles desde el Cuadro de herramientas.
    partial class FormPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            btnProbar = new Button();
            btnListar = new Button();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            btnBuscarSP = new Button();
            dgvDatos = new DataGridView();
            lblEstado = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Text = "Forma 1 · Cadena escrita en una clase";
            //
            // btnProbar
            //
            btnProbar.Location = new Point(12, 48);
            btnProbar.Name = "btnProbar";
            btnProbar.Size = new Size(170, 32);
            btnProbar.Text = "1. Probar conexión";
            btnProbar.Click += BtnProbar_Click;
            //
            // btnListar
            //
            btnListar.Location = new Point(192, 48);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(170, 32);
            btnListar.Text = "2. Listar clientes";
            btnListar.Click += BtnListar_Click;
            //
            // lblBuscar
            //
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(12, 95);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Text = "Nombre o apellido:";
            //
            // txtBuscar
            //
            txtBuscar.Location = new Point(140, 92);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(200, 23);
            txtBuscar.Text = "Rojas";
            //
            // btnBuscarSP
            //
            btnBuscarSP.Location = new Point(350, 88);
            btnBuscarSP.Name = "btnBuscarSP";
            btnBuscarSP.Size = new Size(290, 32);
            btnBuscarSP.Text = "3. Buscar con procedimiento almacenado";
            btnBuscarSP.Click += BtnBuscarSP_Click;
            //
            // dgvDatos
            //
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.Location = new Point(12, 132);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.Size = new Size(860, 340);
            //
            // lblEstado
            //
            lblEstado.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEstado.Location = new Point(12, 480);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(860, 40);
            lblEstado.Text = "Presiona un botón para empezar.";
            //
            // FormPrincipal
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 531);
            Controls.Add(lblTitulo);
            Controls.Add(btnProbar);
            Controls.Add(btnListar);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscarSP);
            Controls.Add(dgvDatos);
            Controls.Add(lblEstado);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TecnoHogar · Forma 1 · Cadena escrita en una clase";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitulo;
        private Button btnProbar;
        private Button btnListar;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private Button btnBuscarSP;
        private DataGridView dgvDatos;
        private Label lblEstado;
    }
}
