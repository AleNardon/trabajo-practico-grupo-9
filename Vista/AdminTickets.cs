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
    public partial class AdminTickets : Form
    {
        public AdminTickets()
        {
            InitializeComponent();
        }
        public string conexion = "Data Source= DataBasePeaje.db;Version=3;New=False;Compress=True;";


        private void AdminTickets_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        public void cargarTabla()
        {
            SQLiteConnection cn = new SQLiteConnection(conexion);

            cn.Open();
            string query = "select * from TICKETS";

            SQLiteDataAdapter da = new SQLiteDataAdapter(query, cn);

            DataTable dt = new DataTable();


            da.Fill(dt); //Llena tabla virtual
            dgvAdminTickets.DataSource = dt; // Muiestra tabla en grafico


            cn.Close();

        }

      
    }

}
