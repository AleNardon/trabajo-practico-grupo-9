﻿using System;
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

        public string conexion = "Data Source= DataBasePeaje.db;Version=3;New=False;Compress=True;";


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
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


                                txtContrasena.Text = reader["CONTRASENA"].ToString(); // Contrasena encriptada

                                string passDecrypted = DesEncriptarPassBD(txtContrasena.Text); //  Desencripta

                            txtContrasena.Text = passDecrypted; // Muestra COntrasena desencriptada





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



        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            string passwordEncrypted = EncriptarPassBD(txtContrasena.Text); // Encripta nueva contrasena

            using (SQLiteConnection cn = new SQLiteConnection(conexion))
            {
            

                try
                {


                    cn.Open();
                    string query = "update USUARIOS set NOMBRE = '" + txtNombre.Text + "', APELLIDO = '" + txtApellido.Text + "', EMAIL = '" + txtMail.Text + "', DNI = " + txtDNI.Text + ", TELEFONO = " + txtTelefono.Text + ", CONTRASENA = '" + passwordEncrypted + "' WHERE ID = " + Datos.activeID + ";";



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
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
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
