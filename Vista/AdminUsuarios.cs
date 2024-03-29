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
    public partial class AdminUsuarios : Form
    {
        public AdminUsuarios()
        {
            InitializeComponent();
        }

        public string conexion = "Data Source= DataBasePeaje.db;Version=3;New=False;Compress=True;";
        

        private void AdminUsuarios_Load(object sender, EventArgs e)
        {
            cargarTabla();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            using (SQLiteConnection cn = new SQLiteConnection(conexion))
            {

                string dni = txtDNI.Text;
                string id = txtID.Text;

                if (dni != "")
                {



                    cn.Open();

                    string query = "select DNI from USUARIOS where DNI = " + txtDNI.Text; // Selecciona DNI desde tabla con DNI escrito



                    using (SQLiteCommand cmd = new SQLiteCommand(query, cn))
                    {




                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                string query2 = "delete from USUARIOS where DNI = " + txtDNI.Text;

                                using (SQLiteCommand cmd2 = new SQLiteCommand(query2, cn))
                                {

                                    reader.Close();
                                    cmd2.ExecuteNonQuery();
                                    MessageBox.Show("Usuario eliminado correctamente");


                                    cargarTabla();

                                    reader.Close();

                                    cn.Close();



                                }

                            }
                            else
                            {
                                MessageBox.Show("No existe un usuario con ese DNI o ID");

                                reader.Close();
                                cn.Close();


                            }
                        }



                    }

                }
                else if (id != "")
                {


                    cn.Open();

                    string query = "select ID from USUARIOS where ID = " + txtID.Text; // Selecciona ID desde base de datos con ID escrito



                    using (SQLiteCommand cmd = new SQLiteCommand(query, cn))
                    {




                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                string query2 = "delete from USUARIOS where ID = " + txtID.Text;

                                using (SQLiteCommand cmd2 = new SQLiteCommand(query2, cn))
                                {

                                    reader.Close();
                                    cmd2.ExecuteNonQuery();
                                    MessageBox.Show("Usuario eliminado correctamente");

                                    cargarTabla();


                                    reader.Close();

                                    cn.Close();



                                }

                            }
                            else
                            {
                                MessageBox.Show("No existe un usuario con ese DNI o ID");

                                reader.Close();
                                cn.Close();

                            }
                        }



                    }

                }
                else
                {
                    if (string.IsNullOrEmpty(txtDNI.Text) && string.IsNullOrEmpty(txtID.Text))
                    {
                        MessageBox.Show("Complete algun campo");
                    }

                }




            }




        }


        public void cargarTabla()
        {
            SQLiteConnection cn = new SQLiteConnection(conexion);

            cn.Open();
            string query = "select * from USUARIOS";

            SQLiteDataAdapter da = new SQLiteDataAdapter(query, cn);

            DataTable dt = new DataTable();


            da.Fill(dt); //Llena tabla virtual
            dgvUsuarios.DataSource = dt; // Muiestra tabla en grafico


            cn.Close();

        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e) //Escribe en DNI y ID los seleccionados
        {
            txtID.Text = dgvUsuarios.SelectedCells[0].Value.ToString(); // Selecciona ID en la celda 0
            txtDNI.Text = dgvUsuarios.SelectedCells[5].Value.ToString(); // Selecciona DNI en la celda 5



        }



        private void btnActualizar_Click(object sender, EventArgs e)
        {
            AdminUsuariosActualizar actualizar = new AdminUsuariosActualizar();

            
            Datos.ID = txtID.Text;
            Datos.DNI = txtDNI.Text;



            using (SQLiteConnection cn = new SQLiteConnection(conexion))
            {



                if (!string.IsNullOrEmpty(txtDNI.Text) || !string.IsNullOrEmpty(txtID.Text))
                {

                    if (txtID.Text != "")
                    {


                    cn.Open();

                    string query = "select ID from USUARIOS where ID = " + txtID.Text;



                    using (SQLiteCommand cmd = new SQLiteCommand(query, cn))
                    {

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                actualizar.Show();
                                  

                                    reader.Close();

                                    cn.Close();   

                            }
                            else
                            {
                                MessageBox.Show("No existe un usuario con ese DNI o ID");

                                reader.Close();
                                cn.Close();

                            }
                        }

                    }

                    }

                    else if (txtDNI.Text != "")
                    {

                        cn.Open();

                    string query2 = "select DNI from USUARIOS where DNI = " + txtDNI.Text;


                    using (SQLiteCommand cmd = new SQLiteCommand(query2, cn))
                    {

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            {

                                    actualizar.Show();

                                   
                                    reader.Close();

                                cn.Close();

                            }
                            else
                            {
                                MessageBox.Show("No existe un usuario con ese DNI o ID");

                                reader.Close();
                                cn.Close();

                            }
                        }

                    }
                    }





                }

                else
                {
                    MessageBox.Show("Complete algun campo");
                }




            }
        }

        private void btnRefresca_Click(object sender, EventArgs e)
        {
            cargarTabla();
        }

        public void onlyNumber(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
            return;

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumber(sender, e);
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumber(sender, e);
        }
    }

}

