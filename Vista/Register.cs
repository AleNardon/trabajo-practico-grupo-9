using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Vista
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        public string conexion = "Data Source=MAURI-PC;Initial Catalog = POO; Integrated Security = True";


        /* FUNCION PARA SOLO LETRAS Y NUMEROS */

        public void onlyNumber(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
            return;

        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumber(sender, e);
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumber(sender, e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyLetter(sender,e);
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyLetter(sender, e);


        }


        public void onlyLetter(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LogIn logInForm = new LogIn();
            this.Hide();

            logInForm.ShowDialog();


            Welcome welcomeForm = new Welcome();
            welcomeForm.ShowDialog();


        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
        }
    }
}
