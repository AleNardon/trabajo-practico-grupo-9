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
                            Datos.precioCamion = precioCamion;

                            precioAuto = reader["AUTO"].ToString();
                            Datos.precioAuto = precioAuto;

                            precioMoto = reader["MOTO"].ToString();
                            Datos.precioMoto = precioMoto;

                            reader.Close();
                            cn.Close();



                        } 

                    }
                }

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
                            Datos.vendedor = reader["NOMBRE"].ToString();

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

                Datos.selectedVehicle = "Camion";

            }
            if (cmbUsuario.SelectedIndex == 2)
            {
                txtTarifas.Text = precioAuto;
                tarifaSeleccionada = precioAuto;

                Datos.selectedVehicle = "Auto";



            }
            if (cmbUsuario.SelectedIndex == 3)
            {
                txtTarifas.Text = precioMoto; 
                tarifaSeleccionada = precioMoto;

                Datos.selectedVehicle = "Moto";


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

            


            SQLiteConnection cn = new SQLiteConnection(conexion);


          

            
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
                } else
            {
                fecha.ToString();

                string query = "insert into TICKETS (VENDEDOR,  VEHICULO, TARIFA, PATENTE, FECHA) values ('" + Vendedor + "','" + Datos.selectedVehicle + "','" + tarifaSeleccionada + "' ,'" + txtPatente.Text + "', '" + fecha + "')";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, cn);
                cn.Open();

                da.SelectCommand.ExecuteNonQuery();

                Datos.patente = txtPatente.Text;
                Datos.fecha = txtFecha.Text;

                UsuarioTicketDescargar download = new UsuarioTicketDescargar();
                download.Show();



            cn.Close();

            }





        }

    }
    }

