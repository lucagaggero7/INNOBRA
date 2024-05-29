using INNOBRA_BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace INNOBRA_FE
{
    public partial class Pantalla : FrmBase
    {
        //Creamos una nueva instancia de la clase alumno
        //
        Empleado empleado = new Empleado();

        //Creamos una nueva instancia de la clase alumnos
        //
        Empleados empleados = new Empleados();

        bool existe;
        int index;
        int nombreclick = 0;
        int apellidoclick = 0;
        int cargoclick = 0;
        int obraclick = 0;
        int idclick = 0;


        public Pantalla()
        {
            InitializeComponent();
            datagridEmpleados.DataSource = empleados.ListaDT;
            datagridEmpleados.ClearSelection();

            foreach (DataGridViewColumn column in datagridEmpleados.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            panelDiseño.SendToBack();
            PanelBarraTitulo.SendToBack();

            labelFecha.Text = "Fecha de Hoy: " +  DateTime.Now.ToString("dd 'de' MMMM 'de' yyyy");
            labelUsuario.Text = "Usuario: " + "admin";
        }

        private void Pantalla_Load(object sender, EventArgs e)
        {
            int AltoGridIniE = datagridEmpleados.Height;
            int AltoGridE = 15;
            int AltoForm = this.Height;

            AltoGridE = AltoGridE + datagridEmpleados.ColumnHeadersHeight;

            for (int i = 0; i <= datagridEmpleados.Rows.Count - 1; i++)
            {
                AltoGridE = AltoGridE + datagridEmpleados.Rows[i].Height;
            }

            datagridEmpleados.Height = AltoGridE;
            datagridEmpleados.ClearSelection();

            ////////////////////////////////////

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtNombre.Text != "Nombre")
            {
                //borro el error 
                errorNombre.SetError(txtNombre, "");
            }
            else
            {
                errorNombre.SetError(txtNombre, "Debe ingresar un nombre");
                txtNombre.Focus();
                return;
            }

            if (txtApellido.Text != "" && txtApellido.Text != "Apellido")
            {
                //borro el error 
                errorApellido.SetError(txtApellido, "");
            }
            else
            {
                errorApellido.SetError(txtApellido, "Debe ingresar un apellido");
                txtApellido.Focus();
                return;
            }

            if (txtCargo.Text != "" && txtCargo.Text != "Cargo")
            {
                //borro el error 
                errorCargo.SetError(txtCargo, "");
            }
            else
            {
                errorCargo.SetError(txtCargo, "Debe ingresar un cargo");
                txtCargo.Focus();
                return;
            }

            if (txtObra.Text != "" && txtObra.Text != "Obra")
            {
                //borro el error 
                errorObra.SetError(txtObra, "");
            }
            else
            {
                errorObra.SetError(txtObra, "Debe ingresar una obra");
                txtObra.Focus();
                return;

            }


            empleado.Agregar(
                                txtNombre.Text,
                             txtApellido.Text,
                             txtCargo.Text,
                             txtObra.Text);


            empleados.InsertEmpleado(empleado);

            MessageBox.Show("Empleado Cargado");

            datagridEmpleados.DataSource = empleados.ListaDT;
            int AltoGridIni = datagridEmpleados.Height;
            int AltoGrid = 15;
            int AltoForm = this.Height;

            AltoGrid = AltoGrid + datagridEmpleados.ColumnHeadersHeight;

            for (int i = 0; i <= datagridEmpleados.Rows.Count - 1; i++)
            {
                AltoGrid = AltoGrid + datagridEmpleados.Rows[i].Height;
            }

            datagridEmpleados.Height = AltoGrid;
            datagridEmpleados.ClearSelection();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            existe = empleados.ExisteEmpleado(txtId.Text);
            index = empleados.BuscarEmpleado(txtId.Text);
            

            if (existe == false)
            {
                MessageBox.Show("El ID no existe");
                datagridEmpleados.ClearSelection();
                return;
            }
            else
            {
                int seleccion;
                seleccion = Convert.ToInt32(txtId.Text);


                datagridEmpleados.Rows[index].Selected = true;
            }


        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            existe = empleados.BorrarEmpleado(txtId.Text);

            if (existe == false)
            {
                MessageBox.Show("El ID no existe");
                return;
            }
            else
            {
                MessageBox.Show("Registro borrado de la lista");

            }

            int AltoGridIni = datagridEmpleados.Height;
            int AltoGrid = 15;
            int AltoForm = this.Height;

            AltoGrid = AltoGrid + datagridEmpleados.ColumnHeadersHeight;

            for (int i = 0; i <= datagridEmpleados.Rows.Count - 1; i++)
            {
                AltoGrid = AltoGrid + datagridEmpleados.Rows[i].Height;
            }

            datagridEmpleados.Height = AltoGrid;
            datagridEmpleados.ClearSelection();
        }

        private void Pantalla_Click(object sender, EventArgs e)
        {
            datagridEmpleados.ClearSelection();

            //Ejecutamos los evenetos leave para ahorrar lineas if
            txtNombre_Leave(sender, e);
            txtApellido_Leave (sender, e);
            txtCargo_Leave(sender, e);
            txtObra_Leave(sender, e);
            txtId_Leave(sender, e);

            //

            //Sacamos el foco de los textbox para no generar bugs del cursor
            btnEmpleados.Focus();
            //
        }

        private void btnMaquinas_Click(object sender, EventArgs e)
        {
            Pantalla2 frm3 = new Pantalla2();
            this.AddOwnedForm(frm3);
            if (this.WindowState == FormWindowState.Maximized)
            {
                frm3.WindowState = FormWindowState.Maximized;
                frm3.Show();
            }
            else
            {
                frm3.WindowState = FormWindowState.Normal;
                frm3.Show();
            }
            this.Hide();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            nombreclick++;
            txtNombre.ForeColor = Color.Black;

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            apellidoclick++;
            txtApellido.ForeColor = Color.Black;
        }

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {
            cargoclick++;
            txtCargo.ForeColor = Color.Black;
        }

        private void txtObra_TextChanged(object sender, EventArgs e)
        {
            obraclick++;
            txtObra.ForeColor = Color.Black;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            idclick++;
            txtId.ForeColor = Color.Black;
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            nombreclick++;

            if (nombreclick >= 1 && txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtApellido_Click(object sender, EventArgs e)
        {
            apellidoclick++;
            if (apellidoclick >= 1 && txtApellido.Text == "Apellido")
            {
                txtApellido.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtCargo_Click(object sender, EventArgs e)
        {
            cargoclick++;
            if (cargoclick >= 1 && txtCargo.Text == "Cargo")
            {
                txtCargo.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtObra_Click(object sender, EventArgs e)
        {
            obraclick++;
            if (obraclick >= 1 && txtObra.Text == "Obra")
            {
                txtObra.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtId_Click(object sender, EventArgs e)
        {
            idclick++;
            if (idclick >= 1 && txtId.Text == "Id")
            {
                txtId.Text = "";
            }
            else
            {
                return;
            }
        }

      
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.LightGray;
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Apellido";
                txtApellido.ForeColor = Color.LightGray;
            }
        }

        private void txtCargo_Leave(object sender, EventArgs e)
        {
            if (txtCargo.Text == "")
            {
                txtCargo.Text = "Cargo";
                txtCargo.ForeColor = Color.LightGray;
            }
        }

        private void txtObra_Leave(object sender, EventArgs e)
        {
            if (txtObra.Text == "")
            {
                txtObra.Text = "Obra";
                txtObra.ForeColor = Color.LightGray;
            }
        }

        private void txtId_Leave(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                txtId.Text = "Id";
                txtId.ForeColor = Color.LightGray;
            }
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            nombreclick++;

            if (nombreclick >= 1 && txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtApellido_KeyDown(object sender, KeyEventArgs e)
        {
            apellidoclick++;

            if (apellidoclick >= 1 && txtApellido.Text == "Apellido")
            {
                txtApellido.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtCargo_KeyDown(object sender, KeyEventArgs e)
        {
            cargoclick++;

            if (cargoclick >= 1 && txtCargo.Text == "Cargo")
            {
                txtCargo.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtObra_KeyDown(object sender, KeyEventArgs e)
        {
            obraclick++;

            if (obraclick >= 1 && txtObra.Text == "Obra")
            {
                txtObra.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            idclick++;

            if (idclick >= 1 && txtId.Text == "Id")
            {
                txtId.Text = "";
            }
            else
            {
                return;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
