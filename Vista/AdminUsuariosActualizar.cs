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

                if (Datos.ID != "")
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
                            chkAdmin.Checked = reader["ADMIN"].Equals(true);

                                selectedID = reader["ID"].ToString();



                                reader.Close();
                            cn.Close();
                        } else
                            {
                                cn.Close();
                            }

                    }
                }

                }

                else if (Datos.DNI != "")
                {

                    cn.Open();
                    string query = "select * from USUARIOS where DNI = " + Datos.DNI;

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
                                chkAdmin.Checked = reader["ADMIN"].Equals(true);

                                selectedID = reader["ID"].ToString();



                                reader.Close();
                                cn.Close();
                            } else {
                                cn.Close();
                                    }

                        }
                    }

                }
            }

        }
        string selectedID;


        private void btnModificar_Click(object sender, EventArgs e)
        {

            using (SQLiteConnection cn = new SQLiteConnection(conexion))
            {
                string resultAdmin = YesNo();

                try
                {


                cn.Open();
                string query = "update USUARIOS set NOMBRE = '" + txtNombre.Text + "', APELLIDO = '" + txtApellido.Text + "', EMAIL = '" + txtEmail.Text + "', CONTRASENA = '" + txtContrasena.Text + "', DNI = " + txtDNI.Text + ", TELEFONO = " + txtTelefono.Text + ", ADMIN = '" + resultAdmin + "' WHERE ID = " + selectedID + ";";

                

                using (SQLiteCommand cmd = new SQLiteCommand(query, cn))
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario acutalizado correctamente" + AcceptButton);
                    cn.Close();
                    this.Close();

                    AdminUsuarios form = new AdminUsuarios();
                        form.ShowDialog();


                }

                } catch (Exception)
                {
                    if (emailExist(errorCode))
                    {
                        MessageBox.Show("Ya existe una cuenta con este Email o DNI" + AcceptButton);

                    }
                }

            }
        }
        SQLiteErrorCode errorCode;

        public string YesNo()
        {
            string Y = "Y";
            string N = "N";

            bool admin = chkAdmin.Checked.Equals(true);


            if (admin)
            {
                return Y;
            } else
            {
                return N;
            }
        }

        public bool emailExist(SQLiteErrorCode errorCode)
        {
            errorCode = SQLiteErrorCode.Abort;
            return true;


        }

        public void onlyLetter(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyLetter(sender, e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyLetter(sender, e);

        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumber(sender, e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumber(sender, e);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminUsuarios form = new AdminUsuarios();
            form.ShowDialog();

        }
    }
}
