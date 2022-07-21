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
    public partial class UsuarioModificarDato : Form
    {
        public UsuarioModificarDato()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void UsuarioModificarDato_Load(object sender, EventArgs e)
        {
            txtDNI.MaxLength = 8; 
         
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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Complete el nombre");
            }
            else if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Complete el apellido");
            }
            else if (string.IsNullOrEmpty(txtMail.Text))
            {
                MessageBox.Show("Complete el mail");
            }
            else if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Complete el Teléfoino");
            }
            else if (string.IsNullOrEmpty(txtDNI.Text))
            {
                MessageBox.Show("Complete el DNI");
            } 
            else
            {
                MessageBox.Show("Usuario modificado"); 
            }
        }
    }
}
