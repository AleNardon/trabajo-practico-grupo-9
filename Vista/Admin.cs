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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        public string conexion = "Data Source= DataBasePeaje.db;Version=3;New=False;Compress=True;";


        private void Admin_Load(object sender, EventArgs e)
        {
            SQLiteConnection cn = new SQLiteConnection(conexion);

            string query = "select * from USUARIOS";
            SQLiteDataAdapter da = new SQLiteDataAdapter(query, cn);

            da.SelectCommand.CommandType = CommandType.Text;

            cn.Open();
            da.Fill(dt);

            dgvUsuarios.DataSource = dt;

        }
    }
}
