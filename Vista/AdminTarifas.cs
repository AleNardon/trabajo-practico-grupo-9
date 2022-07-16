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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
        }

        private void AdminTarifas_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection cn = new SQLiteConnection(conexion))
            {

                cn.Open();

                string query = "select * from TARIFAS";


                SQLiteCommand cmd = new SQLiteCommand(query, cn);

                SQLiteDataReader tarifas = cmd.ExecuteReader();

                if (tarifas.Read())
                {
                    txtCamion.Text = tarifas["CAMION"].ToString();
                    txtAuto.Text = tarifas["AUTO"].ToString();
                    txtMoto.Text = tarifas["MOTO"].ToString();

                }
            }
        }
    }
}
