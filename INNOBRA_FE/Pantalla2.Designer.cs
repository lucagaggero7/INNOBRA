namespace INNOBRA_FE
{
    partial class Pantalla2
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
            this.components = new System.ComponentModel.Container();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtObra = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.datagridMaquinas = new System.Windows.Forms.DataGridView();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.errorMarca = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorModelo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorObra = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorId = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelDiseño = new System.Windows.Forms.Panel();
            this.pictureboxLogo = new System.Windows.Forms.PictureBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnMaquinas = new System.Windows.Forms.Button();
            this.PanelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridMaquinas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorObra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorId)).BeginInit();
            this.panelDiseño.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnCerrar.Location = new System.Drawing.Point(1297, 0);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMaximizar.Location = new System.Drawing.Point(1255, 0);
            // 
            // PanelBarraTitulo
            // 
            this.PanelBarraTitulo.Size = new System.Drawing.Size(1339, 34);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMinimizar.Location = new System.Drawing.Point(1213, 0);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.AliceBlue;
            this.txtId.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.LightGray;
            this.txtId.Location = new System.Drawing.Point(617, 526);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 24);
            this.txtId.TabIndex = 61;
            this.txtId.Text = "Id";
            this.txtId.Click += new System.EventHandler(this.txtId_Click);
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            this.txtId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtId_KeyDown);
            this.txtId.Leave += new System.EventHandler(this.txtId_Leave);
            // 
            // txtObra
            // 
            this.txtObra.BackColor = System.Drawing.Color.AliceBlue;
            this.txtObra.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObra.ForeColor = System.Drawing.Color.LightGray;
            this.txtObra.Location = new System.Drawing.Point(617, 433);
            this.txtObra.Name = "txtObra";
            this.txtObra.Size = new System.Drawing.Size(100, 24);
            this.txtObra.TabIndex = 60;
            this.txtObra.Text = "Obra";
            this.txtObra.Click += new System.EventHandler(this.txtObra_Click);
            this.txtObra.TextChanged += new System.EventHandler(this.txtObra_TextChanged);
            this.txtObra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtObra_KeyDown);
            this.txtObra.Leave += new System.EventHandler(this.txtObra_Leave);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.AliceBlue;
            this.txtDescripcion.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.LightGray;
            this.txtDescripcion.Location = new System.Drawing.Point(617, 403);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 24);
            this.txtDescripcion.TabIndex = 59;
            this.txtDescripcion.Text = "Descripcion";
            this.txtDescripcion.Click += new System.EventHandler(this.txtDescripcion_Click);
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            this.txtDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescripcion_KeyDown);
            this.txtDescripcion.Leave += new System.EventHandler(this.txtDescripcion_Leave);
            // 
            // txtModelo
            // 
            this.txtModelo.BackColor = System.Drawing.Color.AliceBlue;
            this.txtModelo.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.ForeColor = System.Drawing.Color.LightGray;
            this.txtModelo.Location = new System.Drawing.Point(617, 373);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 24);
            this.txtModelo.TabIndex = 58;
            this.txtModelo.Text = "Modelo";
            this.txtModelo.Click += new System.EventHandler(this.txtModelo_Click);
            this.txtModelo.TextChanged += new System.EventHandler(this.txtModelo_TextChanged);
            this.txtModelo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtModelo_KeyDown);
            this.txtModelo.Leave += new System.EventHandler(this.txtModelo_Leave);
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.AliceBlue;
            this.txtMarca.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.ForeColor = System.Drawing.Color.LightGray;
            this.txtMarca.Location = new System.Drawing.Point(617, 343);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 24);
            this.txtMarca.TabIndex = 57;
            this.txtMarca.Text = "Marca";
            this.txtMarca.Click += new System.EventHandler(this.txtMarca_Click);
            this.txtMarca.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            this.txtMarca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMarca_KeyDown);
            this.txtMarca.Leave += new System.EventHandler(this.txtMarca_Leave);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Lavender;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(617, 556);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(97, 44);
            this.btnBuscar.TabIndex = 56;
            this.btnBuscar.Text = "BUSCAR MAQUINA";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Lavender;
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.Black;
            this.btnBorrar.Location = new System.Drawing.Point(720, 556);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(97, 44);
            this.btnBorrar.TabIndex = 55;
            this.btnBorrar.Text = "BORRAR MAQUINA";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Lavender;
            this.btnCargar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnCargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.Black;
            this.btnCargar.Location = new System.Drawing.Point(617, 463);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(97, 44);
            this.btnCargar.TabIndex = 54;
            this.btnCargar.Text = "CARGAR MAQUINA";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // datagridMaquinas
            // 
            this.datagridMaquinas.AllowUserToAddRows = false;
            this.datagridMaquinas.AllowUserToDeleteRows = false;
            this.datagridMaquinas.AllowUserToResizeColumns = false;
            this.datagridMaquinas.AllowUserToResizeRows = false;
            this.datagridMaquinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridMaquinas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridMaquinas.Location = new System.Drawing.Point(75, 330);
            this.datagridMaquinas.MaximumSize = new System.Drawing.Size(510, 200);
            this.datagridMaquinas.MultiSelect = false;
            this.datagridMaquinas.Name = "datagridMaquinas";
            this.datagridMaquinas.ReadOnly = true;
            this.datagridMaquinas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.datagridMaquinas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridMaquinas.Size = new System.Drawing.Size(510, 200);
            this.datagridMaquinas.TabIndex = 53;
            this.datagridMaquinas.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Lavender;
            this.btnCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Black;
            this.btnCerrarSesion.Location = new System.Drawing.Point(1169, 72);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(143, 32);
            this.btnCerrarSesion.TabIndex = 65;
            this.btnCerrarSesion.Text = "CERRAR SESION";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // errorMarca
            // 
            this.errorMarca.ContainerControl = this;
            // 
            // errorModelo
            // 
            this.errorModelo.ContainerControl = this;
            // 
            // errorDescripcion
            // 
            this.errorDescripcion.ContainerControl = this;
            // 
            // errorObra
            // 
            this.errorObra.ContainerControl = this;
            // 
            // errorId
            // 
            this.errorId.ContainerControl = this;
            // 
            // panelDiseño
            // 
            this.panelDiseño.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(25)))), ((int)(((byte)(67)))));
            this.panelDiseño.Controls.Add(this.btnMaquinas);
            this.panelDiseño.Controls.Add(this.btnEmpleados);
            this.panelDiseño.Controls.Add(this.pictureboxLogo);
            this.panelDiseño.Controls.Add(this.labelUsuario);
            this.panelDiseño.Controls.Add(this.labelFecha);
            this.panelDiseño.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDiseño.Location = new System.Drawing.Point(0, 34);
            this.panelDiseño.Name = "panelDiseño";
            this.panelDiseño.Size = new System.Drawing.Size(1339, 273);
            this.panelDiseño.TabIndex = 66;
            // 
            // pictureboxLogo
            // 
            this.pictureboxLogo.Image = global::INNOBRA_FE.Properties.Resources.WhatsApp_Image_2024_04_20_at_23_03_58;
            this.pictureboxLogo.Location = new System.Drawing.Point(1133, 96);
            this.pictureboxLogo.Name = "pictureboxLogo";
            this.pictureboxLogo.Size = new System.Drawing.Size(194, 177);
            this.pictureboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxLogo.TabIndex = 54;
            this.pictureboxLogo.TabStop = false;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUsuario.Location = new System.Drawing.Point(72, 140);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(123, 39);
            this.labelUsuario.TabIndex = 1;
            this.labelUsuario.Text = "Usuario:";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFecha.Location = new System.Drawing.Point(72, 77);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(191, 39);
            this.labelFecha.TabIndex = 0;
            this.labelFecha.Text = "Fecha de hoy:";
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.Lavender;
            this.btnEmpleados.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.Black;
            this.btnEmpleados.Location = new System.Drawing.Point(75, 219);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(110, 44);
            this.btnEmpleados.TabIndex = 56;
            this.btnEmpleados.Text = "EMPLEADOS";
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnMaquinas
            // 
            this.btnMaquinas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMaquinas.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMaquinas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnMaquinas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMaquinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaquinas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaquinas.ForeColor = System.Drawing.Color.Black;
            this.btnMaquinas.Location = new System.Drawing.Point(203, 219);
            this.btnMaquinas.Name = "btnMaquinas";
            this.btnMaquinas.Size = new System.Drawing.Size(110, 44);
            this.btnMaquinas.TabIndex = 57;
            this.btnMaquinas.Text = "MAQUINAS";
            this.btnMaquinas.UseVisualStyleBackColor = false;
            // 
            // Pantalla2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 612);
            this.Controls.Add(this.panelDiseño);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtObra);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.datagridMaquinas);
            this.Name = "Pantalla2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla2";
            this.Load += new System.EventHandler(this.Pantalla2_Load);
            this.Click += new System.EventHandler(this.Pantalla2_Click);
            this.Controls.SetChildIndex(this.PanelBarraTitulo, 0);
            this.Controls.SetChildIndex(this.datagridMaquinas, 0);
            this.Controls.SetChildIndex(this.btnCargar, 0);
            this.Controls.SetChildIndex(this.btnBorrar, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.txtMarca, 0);
            this.Controls.SetChildIndex(this.txtModelo, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.txtObra, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.btnCerrarSesion, 0);
            this.Controls.SetChildIndex(this.panelDiseño, 0);
            this.PanelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridMaquinas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorObra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorId)).EndInit();
            this.panelDiseño.ResumeLayout(false);
            this.panelDiseño.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.TextBox txtObra;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.TextBox txtModelo;
        public System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DataGridView datagridMaquinas;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.ErrorProvider errorMarca;
        private System.Windows.Forms.ErrorProvider errorModelo;
        private System.Windows.Forms.ErrorProvider errorDescripcion;
        private System.Windows.Forms.ErrorProvider errorObra;
        private System.Windows.Forms.ErrorProvider errorId;
        private System.Windows.Forms.Panel panelDiseño;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.PictureBox pictureboxLogo;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnMaquinas;
    }
}