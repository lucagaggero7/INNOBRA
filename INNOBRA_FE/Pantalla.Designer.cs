﻿namespace INNOBRA_FE
{
    partial class Pantalla
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
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorApellido = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCargo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorObra = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorId = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtObra = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.datagridEmpleados = new System.Windows.Forms.DataGridView();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panelDiseño = new System.Windows.Forms.Panel();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.pictureboxLogo = new System.Windows.Forms.PictureBox();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnMaquinas = new System.Windows.Forms.Button();
            this.PanelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorObra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridEmpleados)).BeginInit();
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
            this.PanelBarraTitulo.Location = new System.Drawing.Point(0, 273);
            this.PanelBarraTitulo.Size = new System.Drawing.Size(1339, 34);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMinimizar.Location = new System.Drawing.Point(1213, 0);
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            // 
            // errorApellido
            // 
            this.errorApellido.ContainerControl = this;
            // 
            // errorCargo
            // 
            this.errorCargo.ContainerControl = this;
            // 
            // errorObra
            // 
            this.errorObra.ContainerControl = this;
            // 
            // errorId
            // 
            this.errorId.ContainerControl = this;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.AliceBlue;
            this.txtId.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.LightGray;
            this.txtId.Location = new System.Drawing.Point(617, 526);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 24);
            this.txtId.TabIndex = 49;
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
            this.txtObra.TabIndex = 48;
            this.txtObra.Text = "Obra";
            this.txtObra.Click += new System.EventHandler(this.txtObra_Click);
            this.txtObra.TextChanged += new System.EventHandler(this.txtObra_TextChanged);
            this.txtObra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtObra_KeyDown);
            this.txtObra.Leave += new System.EventHandler(this.txtObra_Leave);
            // 
            // txtCargo
            // 
            this.txtCargo.BackColor = System.Drawing.Color.AliceBlue;
            this.txtCargo.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.ForeColor = System.Drawing.Color.LightGray;
            this.txtCargo.Location = new System.Drawing.Point(617, 403);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(100, 24);
            this.txtCargo.TabIndex = 47;
            this.txtCargo.Text = "Cargo";
            this.txtCargo.Click += new System.EventHandler(this.txtCargo_Click);
            this.txtCargo.TextChanged += new System.EventHandler(this.txtCargo_TextChanged);
            this.txtCargo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCargo_KeyDown);
            this.txtCargo.Leave += new System.EventHandler(this.txtCargo_Leave);
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.AliceBlue;
            this.txtApellido.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.LightGray;
            this.txtApellido.Location = new System.Drawing.Point(617, 373);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 24);
            this.txtApellido.TabIndex = 46;
            this.txtApellido.Text = "Apellido";
            this.txtApellido.Click += new System.EventHandler(this.txtApellido_Click);
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            this.txtApellido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtApellido_KeyDown);
            this.txtApellido.Leave += new System.EventHandler(this.txtApellido_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.AliceBlue;
            this.txtNombre.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.LightGray;
            this.txtNombre.Location = new System.Drawing.Point(617, 343);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 24);
            this.txtNombre.TabIndex = 45;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.Click += new System.EventHandler(this.txtNombre_Click);
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyDown);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
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
            this.btnBuscar.TabIndex = 44;
            this.btnBuscar.Text = "BUSCAR EMPLEADO";
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
            this.btnBorrar.TabIndex = 43;
            this.btnBorrar.Text = "BORRAR EMPLEADO";
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
            this.btnCargar.TabIndex = 42;
            this.btnCargar.Text = "CARGAR EMPLEADO";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // datagridEmpleados
            // 
            this.datagridEmpleados.AllowUserToAddRows = false;
            this.datagridEmpleados.AllowUserToDeleteRows = false;
            this.datagridEmpleados.AllowUserToResizeColumns = false;
            this.datagridEmpleados.AllowUserToResizeRows = false;
            this.datagridEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridEmpleados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridEmpleados.Location = new System.Drawing.Point(75, 330);
            this.datagridEmpleados.MaximumSize = new System.Drawing.Size(510, 200);
            this.datagridEmpleados.MultiSelect = false;
            this.datagridEmpleados.Name = "datagridEmpleados";
            this.datagridEmpleados.ReadOnly = true;
            this.datagridEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridEmpleados.Size = new System.Drawing.Size(510, 200);
            this.datagridEmpleados.TabIndex = 41;
            this.datagridEmpleados.TabStop = false;
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
            this.btnCerrarSesion.TabIndex = 40;
            this.btnCerrarSesion.Text = "CERRAR SESION";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
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
            this.panelDiseño.Location = new System.Drawing.Point(0, 0);
            this.panelDiseño.Name = "panelDiseño";
            this.panelDiseño.Size = new System.Drawing.Size(1339, 273);
            this.panelDiseño.TabIndex = 54;
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
            // pictureboxLogo
            // 
            this.pictureboxLogo.Image = global::INNOBRA_FE.Properties.Resources.WhatsApp_Image_2024_04_20_at_23_03_58;
            this.pictureboxLogo.Location = new System.Drawing.Point(1133, 96);
            this.pictureboxLogo.Name = "pictureboxLogo";
            this.pictureboxLogo.Size = new System.Drawing.Size(194, 177);
            this.pictureboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxLogo.TabIndex = 55;
            this.pictureboxLogo.TabStop = false;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEmpleados.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.Black;
            this.btnEmpleados.Location = new System.Drawing.Point(75, 219);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(110, 44);
            this.btnEmpleados.TabIndex = 55;
            this.btnEmpleados.Text = "EMPLEADOS";
            this.btnEmpleados.UseVisualStyleBackColor = false;
            // 
            // btnMaquinas
            // 
            this.btnMaquinas.BackColor = System.Drawing.Color.Lavender;
            this.btnMaquinas.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMaquinas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnMaquinas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMaquinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaquinas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaquinas.ForeColor = System.Drawing.Color.Black;
            this.btnMaquinas.Location = new System.Drawing.Point(203, 219);
            this.btnMaquinas.Name = "btnMaquinas";
            this.btnMaquinas.Size = new System.Drawing.Size(110, 44);
            this.btnMaquinas.TabIndex = 55;
            this.btnMaquinas.Text = "MAQUINAS";
            this.btnMaquinas.UseVisualStyleBackColor = false;
            this.btnMaquinas.Click += new System.EventHandler(this.btnMaquinas_Click);
            // 
            // Pantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 612);
            this.Controls.Add(this.panelDiseño);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtObra);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.datagridEmpleados);
            this.Controls.Add(this.btnCerrarSesion);
            this.Name = "Pantalla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla";
            this.Load += new System.EventHandler(this.Pantalla_Load);
            this.Click += new System.EventHandler(this.Pantalla_Click);
            this.Controls.SetChildIndex(this.btnCerrarSesion, 0);
            this.Controls.SetChildIndex(this.datagridEmpleados, 0);
            this.Controls.SetChildIndex(this.btnCargar, 0);
            this.Controls.SetChildIndex(this.btnBorrar, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.txtApellido, 0);
            this.Controls.SetChildIndex(this.txtCargo, 0);
            this.Controls.SetChildIndex(this.txtObra, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.panelDiseño, 0);
            this.Controls.SetChildIndex(this.PanelBarraTitulo, 0);
            this.PanelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorObra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridEmpleados)).EndInit();
            this.panelDiseño.ResumeLayout(false);
            this.panelDiseño.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorNombre;
        private System.Windows.Forms.ErrorProvider errorApellido;
        private System.Windows.Forms.ErrorProvider errorCargo;
        private System.Windows.Forms.ErrorProvider errorObra;
        private System.Windows.Forms.ErrorProvider errorId;
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.TextBox txtObra;
        public System.Windows.Forms.TextBox txtCargo;
        public System.Windows.Forms.TextBox txtApellido;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DataGridView datagridEmpleados;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel panelDiseño;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.PictureBox pictureboxLogo;
        private System.Windows.Forms.Button btnMaquinas;
        private System.Windows.Forms.Button btnEmpleados;
    }
}