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
    public partial class AdminUsuariosActualizar : Form
    {
        public AdminUsuariosActualizar()
        {
            InitializeComponent();
        }

        public string conexion = "Data Source= DataBasePeaje.db;Version=3;New=False;Compress=True;";




        private void AdminUsuariosActualizar_Load(object sender, EventArgs e)
        {


            using (SQLiteConnection cn = new SQLiteConnection(conexion))
            {


                cn.Open();
                string query = "select * from USUARIOS where ID = " + Datos.ID;

                using (SQLiteCommand cmd = new SQLiteCommand(query, cn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {




                        if (reader.Read())
                        {
                            txtNombre.Text = reader["NOMBRE"].ToString();
                            txtApellido.Text = reader["APELLIDO"].ToString();
                            txtEmail.Text = reader["EMAIL"].ToString();
                            txtContrasena.Text = reader["CONTRASENA"].ToString();
                            txtDNI.Text = reader["DNI"].ToString();
                            txtTelefono.Text = reader["TELEFONO"].ToString();





                            reader.Close();
                            cn.Close();



                        }

                    }
                }





                cn.Close();
            }




        }
    }
}
