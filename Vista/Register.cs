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
using System.Text.RegularExpressions;

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

        SQLiteErrorCode errorCode;
        string passwordEncrypted;


        private void btnRegister_Click(object sender, EventArgs e)
        {



            SQLiteConnection cn = new SQLiteConnection(conexion);


            try
            {
                passwordEncrypted = EncriptarPassBD(txtPassword.Text);

                string query = "Insert into USUARIOS (NOMBRE, APELLIDO, EMAIL, CONTRASENA, DNI, TELEFONO) values ('" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtMail.Text + "','" + passwordEncrypted + "'," + txtDNI.Text + "," + txtTel.Text + ")";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, cn);
                cn.Open();

                if (validarEmail() == true)
                {

                    da.SelectCommand.ExecuteNonQuery();

                MessageBox.Show("Usuario creado con exito. Bienvenido! " + AcceptButton);

                Usuario usuarioForm = new Usuario();
                this.Hide();

                usuarioForm.ShowDialog();

                } else
                {
                    MessageBox.Show("Escriba una direccion de Email valida" + AcceptButton);

                }



            }

            catch (Exception)
            {
                
                if (txtNombre.Text == "" || txtApellido.Text == "" || txtMail.Text == "" || txtDNI.Text == "" || txtPassword.Text == "" || txtTel.Text == "")
                {
                    MessageBox.Show("Por favor complete todos los campos" + AcceptButton);
                }
               
               
                else if (emailExist(errorCode))
                {
                    MessageBox.Show("Ya existe una cuenta con este Email o DNI" + AcceptButton);

                }



            }

                finally
                {
                    cn.Close();

            }

        }


        public bool emailExist(SQLiteErrorCode errorCode)
        {
            errorCode = SQLiteErrorCode.Abort;
            return true;

 
        }
        public bool validarEmail()
        {
            string emailFormato;
            emailFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(txtMail.Text, emailFormato))
            {
                if (Regex.Replace(txtMail.Text, emailFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        public static string EncriptarPassBD(string cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encrypted = System.Text.Encoding.Unicode.GetBytes(cadenaAencriptar);
            result = Convert.ToBase64String(encrypted);
            return result;
        }
    }
}
