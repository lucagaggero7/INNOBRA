using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using INNOBRA_FE;
using Microsoft.Win32;


namespace INNOBRA_FE
{
    public partial class Login : FrmBase
    {
        //variables que cuentan los clicks de los textbox 
        int nombredeusuarioclick = 0;
        int contraseñaclick = 0;

        public Login()
        {
            InitializeComponent();
        }


        public void Login_Load(object sender, EventArgs e)
        {
           
        }



        // Iniciar sesion llamando al metodo que verifica si el usuario y la contraseña existen 
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            this.ActiveControl = PanelBarraTitulo;

            //verificamos que el nombre de usuario y la contraseña existan en un usuario mediante un if
            // para permitir el login y dar paso al siguiente formulario
            if (txtNombredeusuario.Text == "admin" && txtContraseña.Text == "admin")
            {
                Pantalla frm1 = new Pantalla();
                this.AddOwnedForm(frm1);
                frm1.Show();
                this.Hide();

                if (chkRecordar.Checked == false)
                {
                    txtNombredeusuario.Text = "Nombre de usuario";
                    txtNombredeusuario.ForeColor = System.Drawing.Color.DarkGray;

                    txtContraseña.Text = "Contraseña";
                    txtContraseña.ForeColor = System.Drawing.Color.DarkGray;
                    txtContraseña.PasswordChar = '\0';

                }

            }
            //en caso de que el usuario y la contraseña no existan o no coincidan
            //se muestra un mensaje de error
            else
            {
                MessageBox.Show("Error de Usuario y/o contraseña");
            }

        }


        //Vaciar textbox de nombre de usuario (solo la primera vez que se hace click)
        // usando la variable contador de clicks
        private void txtNombredeusuario_Click(object sender, EventArgs e)
        {
            nombredeusuarioclick++;

            if (nombredeusuarioclick >= 1 && txtNombredeusuario.Text == "Nombre de usuario")
            {
                txtNombredeusuario.Text = "";
            }
            else
            {
                return;
            }
        }


        //Vaciar textbox de contraseña (solo la primera vez que se hace click)
        // usando la variable contador de clicks
        private void txtContraseña_Click(object sender, EventArgs e)
        {
            contraseñaclick++;

            if (contraseñaclick >= 1 && txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.PasswordChar = '*';
            }
            else
            {
                return;
            }
        }

        //Ocultar caracteres contraseña
        private void txtContraseña_DoubleClick(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = '*';
        }


        //Ocultar caracteres contraseña
        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            contraseñaclick++;
            txtContraseña.PasswordChar = '*';
            txtContraseña.ForeColor = Color.Black;
        }


        private void txtNombredeusuario_TextChanged(object sender, EventArgs e)
        {
            txtNombredeusuario.ForeColor = Color.Black;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}