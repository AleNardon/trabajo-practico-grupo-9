using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Vista
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        string conexion = "Data Source= DataBasePeaje.db;Version=3;New=False;Compress=True;";




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
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LogIn logInForm = new LogIn();
            this.Hide();

            logInForm.ShowDialog();


        }

        /* TRY CATCH DE REGISTRO */

        private void btnRegister_Click(object sender, EventArgs e)
        {

            SQLiteConnection cn = new SQLiteConnection(conexion);
            
                try
                {
                    string query = "Insert into USUARIOS (NOMBRE, APELLIDO, EMAIL, CONTRASENA, DNI, TELEFONO) values ('" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtMail.Text + "','" + txtPassword.Text + "'," + txtDNI.Text + "," + txtTel.Text + ")";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(query, cn);
                    cn.Open();

                    da.SelectCommand.ExecuteNonQuery();

                    MessageBox.Show("Usuario creado con exito");

                }

                catch (Exception)
                {

                    if (txtNombre.Text == "" || txtApellido.Text == "" || txtMail.Text == "" || txtDNI.Text == "" || txtPassword.Text == "" || txtTel.Text == "")
                    {
                        MessageBox.Show("Por favor complete todos los campos" + AcceptButton);
                    } 
                     else if (!txtMail.Text.Contains("@")) 
                {
                        
                    MessageBox.Show("Escriba una direccion de Email valida" + AcceptButton);

                }
                else if (userExist() == true)
                    {
                        MessageBox.Show("Ya existe una cuenta con este Email" + AcceptButton);
                        
                    }

                }

                finally
                {
                    cn.Close();

                }

        }


        public bool userExist()
        {
            bool resultado = false;

            SQLiteConnection cn = new SQLiteConnection(conexion);
            cn.Open();
            string query = "select EMAIL from USUARIOS where EMAIL = '" + txtMail.Text + "'";
            SQLiteCommand cmd = new SQLiteCommand(query, cn);

            SQLiteDataReader reader = cmd.ExecuteReader();


            if (reader.HasRows)
            {
                resultado = true;
                return resultado;

            }
            else
            {
                return resultado;

            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
