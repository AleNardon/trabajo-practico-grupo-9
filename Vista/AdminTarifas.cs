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
    public partial class AdminTarifas : Form
    {
        public AdminTarifas()
        {
            InitializeComponent();
        }
        
        string conexion = "Data Source= DataBasePeaje.db;Version=3;New=False;Compress=True;";

        

        private void AdminTarifas_Load(object sender, EventArgs e)
        {
           
        }




        private void btnActualizar_Click(object sender, EventArgs e)
        {

            using (SQLiteConnection cn = new SQLiteConnection(conexion))
            {


                cn.Open();
                string query = "UPDATE TARIFAS SET CAMION = " + txtCamion.Text + ", AUTO = " + txtAuto.Text + ", MOTO = " + txtMoto.Text + ";";


                using (SQLiteCommand cmd = new SQLiteCommand(query, cn))
                {
                    cmd.ExecuteNonQuery();
                     MessageBox.Show("Tarifas acutalizadas correctamente" + AcceptButton);
                    cn.Close();




                }


            }


        }

    




        private void btnMostrar_Click(object sender, EventArgs e)
        {

            using (SQLiteConnection cn = new SQLiteConnection(conexion))
            {


                cn.Open();
                string query = "select * from TARIFAS";

                using (SQLiteCommand cmd = new SQLiteCommand(query, cn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {


                    

                        if (reader.Read())
                        {
                            txtCamion.Text = reader["CAMION"].ToString();
                            txtAuto.Text = reader["AUTO"].ToString();
                            txtMoto.Text = reader["MOTO"].ToString();
                            reader.Close();
                            cn.Close();



                        }

                    }
                }





                cn.Close();
            }

        }
        public void onlyNumber(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
            return;

        }

        private void txtCamion_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumber(sender,e);
        }

        private void txtAuto_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumber(sender, e);

        }

        private void txtMoto_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumber(sender, e);

        }
    }
}
