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
    public partial class Pantalla2 : FrmBase
    {
        //Creamos una nueva instancia de la clase alumno
        //
        Maquina maquina = new Maquina();

        //Creamos una nueva instancia de la clase alumnos
        //
        Maquinas maquinas = new Maquinas();

        bool existe;
        int index;
        int marcaclick = 0;
        int modeloclick = 0;
        int descripcionclick = 0;
        int obraclick = 0;
        int idclick = 0;


        public Pantalla2()
        {
            InitializeComponent();
            datagridMaquinas.DataSource = maquinas.ListaDT;
            datagridMaquinas.ClearSelection();

            foreach (DataGridViewColumn column in datagridMaquinas.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            panelDiseño.SendToBack();
            PanelBarraTitulo.SendToBack();

            labelFecha.Text = "Fecha de Hoy: " + DateTime.Now.ToString("dd 'de' MMMM 'de' yyyy");
            labelUsuario.Text = "Usuario: " + "admin";
        }

        private void Pantalla2_Load(object sender, EventArgs e)
        {
            int AltoGridIniM = datagridMaquinas.Height;
            int AltoGridM = 15;
            int AltoForm = this.Height;

            AltoGridM = AltoGridM + datagridMaquinas.ColumnHeadersHeight;

            for (int i = 0; i <= datagridMaquinas.Rows.Count - 1; i++)
            {
                AltoGridM = AltoGridM + datagridMaquinas.Rows[i].Height;
            }

            datagridMaquinas.Height = AltoGridM;
            datagridMaquinas.ClearSelection();

            ////////////////////////////////////

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Owner.Hide();
            Owner.Owner.Show();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text != "" && txtMarca.Text != "Marca")
            {
                //borro el error 
                errorMarca.SetError(txtMarca, "");
            }
            else
            {
                errorMarca.SetError(txtMarca, "Debe ingresar una Marca");
                txtMarca.Focus();
                return;
            }

            if (txtModelo.Text != "" && txtModelo.Text != "Modelo")
            {
                //borro el error 
                errorModelo.SetError(txtModelo, "");
            }
            else
            {
                errorModelo.SetError(txtModelo, "Debe ingresar un modelo");
                txtModelo.Focus();
                return;
            }

            if (txtDescripcion.Text != "" && txtDescripcion.Text != "Descripcion")
            {
                //borro el error 
                errorDescripcion.SetError(txtDescripcion, "");
            }
            else
            {
                errorDescripcion.SetError(txtDescripcion, "Debe ingresar una descripcion");
                txtDescripcion.Focus();
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


            maquina.Agregar(
                                txtMarca.Text,
                             txtModelo.Text,
                             txtDescripcion.Text,
                             txtObra.Text);


            maquinas.InsertMaquina(maquina);

            MessageBox.Show("Mauquina Cargada");

            datagridMaquinas.DataSource = maquinas.ListaDT;
            int AltoGridIniM = datagridMaquinas.Height;
            int AltoGridM = 15;
            int AltoForm = this.Height;

            AltoGridM = AltoGridM + datagridMaquinas.ColumnHeadersHeight;

            for (int i = 0; i <= datagridMaquinas.Rows.Count - 1; i++)
            {
                AltoGridM = AltoGridM + datagridMaquinas.Rows[i].Height;
            }

            datagridMaquinas.Height = AltoGridM;
            datagridMaquinas.ClearSelection();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            existe = maquinas.ExisteMaquina(txtId.Text);
            index = maquinas.BuscarMaquina(txtId.Text);


            if (existe == false)
            {
                MessageBox.Show("El ID no existe");
                datagridMaquinas.ClearSelection();
                return;
            }
            else
            {

                datagridMaquinas.Rows[index].Selected = true;
            }


        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            existe = maquinas.BorrarMaquina(txtId.Text);

            if (existe == false)
            {
                MessageBox.Show("El ID no existe");
                return;
            }
            else
            {
                MessageBox.Show("Registro borrado de la lista");

            }

            int AltoGridIniM = datagridMaquinas.Height;
            int AltoGridM = 15;
            int AltoForm = this.Height;

            AltoGridM = AltoGridM + datagridMaquinas.ColumnHeadersHeight;

            for (int i = 0; i <= datagridMaquinas.Rows.Count - 1; i++)
            {
                AltoGridM = AltoGridM + datagridMaquinas.Rows[i].Height;
            }

            datagridMaquinas.Height = AltoGridM;
            datagridMaquinas.ClearSelection();
        }

        private void Pantalla2_Click(object sender, EventArgs e)
        {
            datagridMaquinas.ClearSelection();

            //Ejecutamos los evenetos leave para ahorrar lineas if
            txtMarca_Leave(sender, e);
            txtModelo_Leave(sender, e);
            txtDescripcion_Leave(sender, e);
            txtObra_Leave(sender, e);
            txtId_Leave(sender, e);

            //

            //Sacamos el foco de los textbox para no generar bugs del cursor
            btnMaquinas.Focus();
            //
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {

            Owner.Show();
            this.Hide();
        }


        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            marcaclick++;
            txtMarca.ForeColor = Color.Black;

        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
            modeloclick++;
            txtModelo.ForeColor = Color.Black;
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            descripcionclick++;
            txtDescripcion.ForeColor = Color.Black;
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

        private void txtMarca_Click(object sender, EventArgs e)
        {
            marcaclick++;

            if (marcaclick >= 1 && txtMarca.Text == "Marca")
            {
                txtMarca.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtModelo_Click(object sender, EventArgs e)
        {
            modeloclick++;
            if (modeloclick >= 1 && txtModelo.Text == "Modelo")
            {
                txtModelo.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtDescripcion_Click(object sender, EventArgs e)
        {
            descripcionclick++;
            if (descripcionclick >= 1 && txtDescripcion.Text == "Descripcion")
            {
                txtDescripcion.Text = "";
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

  

        private void txtMarca_KeyDown(object sender, KeyEventArgs e)
        {
            marcaclick++;

            if (marcaclick >= 1 && txtMarca.Text == "Marca")
            {
                txtMarca.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtModelo_KeyDown(object sender, KeyEventArgs e)
        {
            modeloclick++;

            if (modeloclick >= 1 && txtModelo.Text == "Modelo")
            {
                txtModelo.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            descripcionclick++;

            if (descripcionclick >= 1 && txtDescripcion.Text == "Descripcion")
            {
                txtDescripcion.Text = "";
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

        private void txtMarca_Leave(object sender, EventArgs e)
        {
            if (txtMarca.Text == "")
            {
                txtMarca.Text = "Marca";
                txtMarca.ForeColor = Color.LightGray;
            }
        }

        private void txtModelo_Leave(object sender, EventArgs e)
        {
            if (txtModelo.Text == "")
            {
                txtModelo.Text = "Modelo";
                txtModelo.ForeColor = Color.LightGray;
            }
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                txtDescripcion.Text = "Descripcion";
                txtDescripcion.ForeColor = Color.LightGray;
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
    }
}
