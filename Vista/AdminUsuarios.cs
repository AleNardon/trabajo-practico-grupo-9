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
    public partial class AdminUsuarios : Form
    {
        public AdminUsuarios()
        {
            InitializeComponent();
        }

        public string conexion = "Data Source= DataBasePeaje.db;Version=3;New=False;Compress=True;";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

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

                    string query = "select DNI from USUARIOS where DNI = " + txtDNI.Text;



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

                    string query = "select ID from USUARIOS where ID = " + txtID.Text;



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


            da.Fill(dt);

            dgvUsuarios.DataSource = dt;


            cn.Close();

        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvUsuarios.SelectedCells[0].Value.ToString();
            txtDNI.Text = dgvUsuarios.SelectedCells[5].Value.ToString();



        }

        

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            AdminUsuariosActualizar actualizar = new AdminUsuariosActualizar();

            Datos.Nombre = dgvUsuarios.SelectedCells[1].Value.ToString();
            Datos.Apellido = dgvUsuarios.SelectedCells[2].Value.ToString();
            Datos.Email = dgvUsuarios.SelectedCells[3].Value.ToString();
            Datos.Contrasena = dgvUsuarios.SelectedCells[4].Value.ToString();
            Datos.DNI = dgvUsuarios.SelectedCells[5].Value.ToString();
            Datos.Telefono = dgvUsuarios.SelectedCells[6].Value.ToString();





            actualizar.Show();
        }
    }

}

