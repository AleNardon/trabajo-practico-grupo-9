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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        string conexion = "Data Source= DataBasePeaje.db;Version=3;New=False;Compress=True;";
        string precioCamion;
        string precioAuto;
        string precioMoto;

        private void Usuario_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now; 
            txtFecha.Text = fecha.ToString("dd/MM/yyyy");
            cmbUsuario.SelectedIndex = 0;

            txtPatente.MaxLength = 7;

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
                            precioCamion = reader["CAMION"].ToString();
                           precioAuto = reader["AUTO"].ToString();
                            precioMoto = reader["MOTO"].ToString();
                            reader.Close();
                            cn.Close();



                        }

                    }
                }





                cn.Close();
            }



        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUsuario.SelectedIndex == 1)
            {
                txtTarifas.Text = precioCamion;  
            }
            if (cmbUsuario.SelectedIndex == 2)
            {
                txtTarifas.Text = precioAuto;
            }
            if (cmbUsuario.SelectedIndex == 3)
            {
                txtTarifas.Text = precioMoto; 
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            
            
               
            
           
            
                if (string.IsNullOrEmpty(txtPatente.Text))
                {
                    MessageBox.Show("Complete el campo de la patente");
                }
                
                else if (txtPatente.Text.Length < 6)
                    {
                        MessageBox.Show("La patente no puede tener menos de 6 dígitos");
                    }

            else if (cmbUsuario.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione un tipo de vehículo");
            }

            else
            {
                MessageBox.Show("Se imprimió tu ticket");
            }
                
                
            }
            
        }
    }

