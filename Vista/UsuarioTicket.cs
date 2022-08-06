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
    public partial class UsuarioTicket : Form
    {
        public UsuarioTicket()
        {
            InitializeComponent();
        }

        string conexion = "Data Source= DataBasePeaje.db;Version=3;New=False;Compress=True;";
        string precioCamion;
        string precioAuto;
        string precioMoto;

        DateTime fecha;



        private void Usuario_Load(object sender, EventArgs e)
        {
            fecha = DateTime.Now; 
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

            using (SQLiteConnection cn = new SQLiteConnection(conexion))
            {
                cn.Open();
                string query = "select NOMBRE from USUARIOS where ID = " + Datos.activeID;

                using (SQLiteCommand cmd = new SQLiteCommand(query, cn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Vendedor = reader["NOMBRE"].ToString();
                            reader.Close();
                            cn.Close();

                        } else
                        {
                            reader.Close();
                            cn.Close();
                        }

                    }
                }
            }



        }

        string Vendedor;

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUsuario.SelectedIndex == 1)
            {
                txtTarifas.Text = precioCamion;
                tarifaSeleccionada = precioCamion;

            }
            if (cmbUsuario.SelectedIndex == 2)
            {
                txtTarifas.Text = precioAuto;
                tarifaSeleccionada = precioAuto;

            }
            if (cmbUsuario.SelectedIndex == 3)
            {
                txtTarifas.Text = precioMoto; 
                tarifaSeleccionada = precioMoto;
            }
        }

        string tarifaSeleccionada;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            fecha.ToString();

            SQLiteConnection cn = new SQLiteConnection(conexion);
            try
            {
                string query = "insert into TICKETS (VENDEDOR,  VEHICULO, TARIFA, PATENTE, FECHA) values ('" + Vendedor + "','" + cmbUsuario.SelectedIndex + "','" + tarifaSeleccionada + "' ,'" + txtPatente.Text + "', '" + fecha + "')";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, cn);
                cn.Open();

                da.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Ticket creado con exito");



            }

            catch
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

                

            } finally
            {
                cn.Close();
            }

            
               
            
           
            
                
                
                
            }
            
        }
    }

