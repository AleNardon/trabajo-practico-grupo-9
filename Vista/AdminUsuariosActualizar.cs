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



            txtNombre.Text = Datos.Nombre;
            txtApellido.Text = Datos.Apellido;
            txtEmail.Text = Datos.Email;
            txtContrasena.Text = Datos.Contrasena;
            txtDNI.Text = Datos.DNI;
            txtTelefono.Text = Datos.Telefono;



        }
    }
}
