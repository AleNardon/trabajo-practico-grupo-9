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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        string conexion = "Data Source= DataBasePeaje.db;Version=3;New=False;Compress=True;";


        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register RegisterForm = new Register();
            this.Hide();


            RegisterForm.ShowDialog();

           

        }
        string password;
        


        private void btnlogIn_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtEmail.Text) || !string.IsNullOrEmpty(txtPassword.Text))
            {
                using (SQLiteConnection cn = new SQLiteConnection(conexion))
                {


                    cn.Open();

                    string query = "select CONTRASENA from USUARIOS where EMAIL = '" + txtEmail.Text + "'";



                    using (SQLiteCommand cmd = new SQLiteCommand(query, cn))
                    {

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {


                            

                        if (reader.Read())
                        {
                            password = reader["CONTRASENA"].ToString();

                            string query2 = "select EMAIL, CONTRASENA from USUARIOS where EMAIL = @vEMAIL and CONTRASENA = @vCONTRASENA";

                            using (SQLiteCommand cmd2 = new SQLiteCommand(query2, cn))
                            {

                                string passwordCompare = EncriptarPassBD(txtPassword.Text);

                                cmd2.Parameters.AddWithValue("@vEMAIL", txtEmail.Text);
                                cmd2.Parameters.AddWithValue("@vCONTRASENA", passwordCompare);




                                if (password == passwordCompare)
                                {
                                    using (SQLiteDataReader reader2 = cmd2.ExecuteReader())
                                    {

                                        if (reader2.Read())
                                        {

                                            string queryAdmin = "select EMAIL, ADMIN from USUARIOS where EMAIL = @vEMAIL and ADMIN = @vADMIN ";

                                            SQLiteCommand cmd3 = new SQLiteCommand(queryAdmin, cn);
                                            cmd3.Parameters.AddWithValue("@vEMAIL", txtEmail.Text);
                                            cmd3.Parameters.AddWithValue("@vADMIN", "Y");

                                                using (SQLiteDataReader reader3 = cmd3.ExecuteReader())
                                                {
                                                    if (reader3.Read())
                                                    {
                                                        reader.Close();
                                                        reader2.Close();
                                                        reader3.Close();
                                                        cn.Close();

                                                        string activeID = perfilActivo(txtEmail.Text);

                                                        Datos.activeID = activeID;


                                                        Admin adminForm = new Admin();
                                                        this.Hide();

                                                        adminForm.ShowDialog();


                                                    }
                                                    else
                                                    {
                                                        reader.Close();
                                                        reader2.Close();
                                                        reader3.Close();
                                                        cn.Close();

                                                        string activeID = perfilActivo(txtEmail.Text);

                                                        Datos.activeID = activeID;

                                                        Usuario usuarioForm = new Usuario();
                                                        this.Hide();



                                                        usuarioForm.ShowDialog();


                                                    }

                                                }


                                                    

                                           

                                        }
                                        else
                                        {
                                            reader.Close();
                                            reader2.Close();
                                            cn.Close();

                                        }

                                    }

                                }

                                else
                                {
                                    reader.Close();
                                    cn.Close();

                                    MessageBox.Show("Contraseña o mail incorrectos");
                                }





                            }
                        }
                        else
                        {
                            reader.Close();
                            cn.Close();

                            MessageBox.Show("Contraseña o mail incorrectos");
                        }

                    }

                    }


                }


            } else
            {
                MessageBox.Show("Complete algun campo");
            }

           
        }


        public static string EncriptarPassBD(string cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encrypted = System.Text.Encoding.Unicode.GetBytes(cadenaAencriptar);
            result = Convert.ToBase64String(encrypted);
            return result;
        }

        public string perfilActivo(string mailActivo)
        {
            using (SQLiteConnection cn = new SQLiteConnection(conexion))
            {
                cn.Open();
                string query = "select ID from USUARIOS where EMAIL = '" + mailActivo + "'";

                using (SQLiteCommand cmd = new SQLiteCommand(query, cn))
                {

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {

                        if (reader.Read())
                        {
                            string ID = reader["ID"].ToString();
                            reader.Close();
                            cn.Close();
                            return ID;
                        }
                        else
                        {
                            reader.Close();
                            cn.Close();


                            return string.Empty;
                        }
                    }
                        

                }

            }
        }

    }
}
