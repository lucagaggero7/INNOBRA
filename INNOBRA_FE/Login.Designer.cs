using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace INNOBRA_FE
{
    public partial class Login
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
            this.txtNombredeusuario = new System.Windows.Forms.TextBox();
            this.labelBienvenido = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.chkRecordar = new System.Windows.Forms.CheckBox();
            this.PanelBarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnCerrar.Location = new System.Drawing.Point(507, 0);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMinimizar.Location = new System.Drawing.Point(465, 0);
            // 
            // PanelBarraTitulo
            // 
            this.PanelBarraTitulo.Size = new System.Drawing.Size(549, 34);
            // 
            // txtNombredeusuario
            // 
            this.txtNombredeusuario.BackColor = System.Drawing.Color.Lavender;
            this.txtNombredeusuario.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombredeusuario.ForeColor = System.Drawing.Color.DarkGray;
            this.txtNombredeusuario.Location = new System.Drawing.Point(177, 162);
            this.txtNombredeusuario.Name = "txtNombredeusuario";
            this.txtNombredeusuario.Size = new System.Drawing.Size(157, 24);
            this.txtNombredeusuario.TabIndex = 2;
            this.txtNombredeusuario.Text = "Nombre de usuario";
            this.txtNombredeusuario.Click += new System.EventHandler(this.txtNombredeusuario_Click);
            this.txtNombredeusuario.TextChanged += new System.EventHandler(this.txtNombredeusuario_TextChanged);
            // 
            // labelBienvenido
            // 
            this.labelBienvenido.AutoSize = true;
            this.labelBienvenido.Font = new System.Drawing.Font("Verdana", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenido.Location = new System.Drawing.Point(173, 108);
            this.labelBienvenido.Name = "labelBienvenido";
            this.labelBienvenido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelBienvenido.Size = new System.Drawing.Size(183, 28);
            this.labelBienvenido.TabIndex = 33;
            this.labelBienvenido.Text = "BIENVENIDO";
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.Lavender;
            this.txtContraseña.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.DarkGray;
            this.txtContraseña.Location = new System.Drawing.Point(177, 198);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(157, 24);
            this.txtContraseña.TabIndex = 3;
            this.txtContraseña.Text = "Contraseña";
            this.txtContraseña.Click += new System.EventHandler(this.txtContraseña_Click);
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            this.txtContraseña.DoubleClick += new System.EventHandler(this.txtContraseña_DoubleClick);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.Lavender;
            this.btnIniciarSesion.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIniciarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnIniciarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.Black;
            this.btnIniciarSesion.Location = new System.Drawing.Point(178, 240);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(156, 37);
            this.btnIniciarSesion.TabIndex = 4;
            this.btnIniciarSesion.Text = "INICIAR SESION";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // chkRecordar
            // 
            this.chkRecordar.AutoSize = true;
            this.chkRecordar.Location = new System.Drawing.Point(178, 310);
            this.chkRecordar.Name = "chkRecordar";
            this.chkRecordar.Size = new System.Drawing.Size(115, 17);
            this.chkRecordar.TabIndex = 34;
            this.chkRecordar.Text = "Recordar Usuario?";
            this.chkRecordar.UseVisualStyleBackColor = true;
            this.chkRecordar.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(549, 472);
            this.Controls.Add(this.chkRecordar);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.labelBienvenido);
            this.Controls.Add(this.txtNombredeusuario);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Controls.SetChildIndex(this.PanelBarraTitulo, 0);
            this.Controls.SetChildIndex(this.txtNombredeusuario, 0);
            this.Controls.SetChildIndex(this.labelBienvenido, 0);
            this.Controls.SetChildIndex(this.txtContraseña, 0);
            this.Controls.SetChildIndex(this.btnIniciarSesion, 0);
            this.Controls.SetChildIndex(this.chkRecordar, 0);
            this.PanelBarraTitulo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox txtNombredeusuario;
        private Label labelBienvenido;
        public TextBox txtContraseña;
        private Button btnIniciarSesion;
        private CheckBox chkRecordar;
    }

}