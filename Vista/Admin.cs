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



        private void Admin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AdminUsuarios AdmUsuarios = new AdminUsuarios();
            this.Hide();

            AdmUsuarios.ShowDialog();
            this.Show();
        }

        private void btnTarifas_Click(object sender, EventArgs e)
        {
            AdminTarifas AdmTarifas = new AdminTarifas();
            this.Hide();

            AdmTarifas.ShowDialog();
            this.Show();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            UsuarioTicket ticket = new UsuarioTicket();
            this.Hide();
            ticket.ShowDialog();

            this.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificarDatos_Click(object sender, EventArgs e)
        {
            UsuarioModificarDato from = new UsuarioModificarDato();

            this.Hide();
            from.ShowDialog();

            this.Show();
        }
    }
}
