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
    public partial class UsuarioModificarDato : Form
    {
        public UsuarioModificarDato()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void UsuarioModificarDato_Load(object sender, EventArgs e)
        {


            using (SQLiteConnection cn = new SQLiteConnection(conexion))
            {


                    cn.Open();
                    string query = "select * from USUARIOS where ID = " + Datos.activeID;

                    using (SQLiteCommand cmd = new SQLiteCommand(query, cn))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {


                            if (reader.Read())
                            {
                                txtNombre.Text = reader["NOMBRE"].ToString();
                                txtApellido.Text = reader["APELLIDO"].ToString();
                                txtMail.Text = reader["EMAIL"].ToString();
                                txtDNI.Text = reader["DNI"].ToString();
                                txtTelefono.Text = reader["TELEFONO"].ToString();


                                txtContrasena.Text = reader["CONTRASENA"].ToString();

                                string passDecrypted = DesEncriptarPassBD(txtContrasena.Text);

                            txtContrasena.Text = passDecrypted;





                            reader.Close();
                                cn.Close();
                            }
                            else
                            {
                            reader.Close();

                            cn.Close();
                            }

                        }
                    }

                




            }
        }


            public void onlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        public void onlyLetter(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
     
        }

        public string conexion = "Data Source= DataBasePeaje.db;Version=3;New=False;Compress=True;";


        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            using (SQLiteConnection cn = new SQLiteConnection(conexion))
            {
            

                try
                {


                    cn.Open();
                    string query = "update USUARIOS set NOMBRE = '" + txtNombre.Text + "', APELLIDO = '" + txtApellido.Text + "', EMAIL = '" + txtMail.Text + "', DNI = " + txtDNI.Text + ", TELEFONO = " + txtTelefono.Text + ", CONTRASENA = '" +txtContrasena.Text + "' WHERE ID = " + Datos.activeID + ";";



                    using (SQLiteCommand cmd = new SQLiteCommand(query, cn))
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuario acutalizado correctamente" + AcceptButton);
                        cn.Close();


                    }

                }
                catch (Exception)
                {
                    if (emailExist(errorCode))
                    {
                        MessageBox.Show("Ya existe una cuenta con este Email o DNI" + AcceptButton);

                    }
                }

            }
        }

        SQLiteErrorCode errorCode;

        public bool emailExist(SQLiteErrorCode errorCode)
        {
            errorCode = SQLiteErrorCode.Abort;
            return true;


        }

        public static string DesEncriptarPassBD(string cadenaAdesencriptar)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(cadenaAdesencriptar);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }
    }
}
