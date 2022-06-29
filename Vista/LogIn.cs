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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        string conexion = "Data Source=LAPTOP-MAURI;Initial Catalog = POO; Integrated Security = True";


        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register RegisterForm = new Register();
            this.Hide();


            RegisterForm.ShowDialog();

           

        }

        private void btnlogIn_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                cn.Open();

                string query = "select EMAIL, CONTRASENA from USUARIOS where EMAIL = @vEMAIL and CONTRASENA = @vCONTRASENA";
                SqlCommand cmd = new SqlCommand(query, cn);

                cmd.Parameters.AddWithValue("@vEMAIL", txtEmail.Text);
                cmd.Parameters.AddWithValue("@vCONTRASENA", txtPassword.Text);



                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Ingreso correcto");
                }
                else
                {
                    MessageBox.Show("No se encontro usuario");

                }






            }
        }
    }
}
