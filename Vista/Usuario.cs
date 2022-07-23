using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            UsuarioTicket ticket = new UsuarioTicket();

            this.Hide();
            ticket.ShowDialog();

            this.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            UsuarioModificarDato modificar = new UsuarioModificarDato();

            this.Hide(); 
            modificar.ShowDialog();

            this.Show();
        }
    }
}
