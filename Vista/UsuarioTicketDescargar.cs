﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace Vista
{
    public partial class UsuarioTicketDescargar : Form
    {
        public UsuarioTicketDescargar()
        {
            InitializeComponent();
        }

        


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        //devuelve el la direccion home dependiendo el sistema operativo que tengas
        public static string getHomePath()
        {
            // Not in .NET 2.0
            // System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            if (System.Environment.OSVersion.Platform == System.PlatformID.Unix)
                return System.Environment.GetEnvironmentVariable("HOME");

            return System.Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
        }
        //devuelve la direccion absoluta de la carpeta desgargas segun el sistema que tengas
        //ej: C:\Users\alejo\Downloads
        //lo usaremos para que cualquier persona pueda descargar el pdf en su pc
        public static string getDownloadFolderPath()
        {
            if (System.Environment.OSVersion.Platform == System.PlatformID.Unix)
            {
                string pathDownload = System.IO.Path.Combine(getHomePath(), "Downloads");
                return pathDownload;
            }

            return System.Convert.ToString(
                Microsoft.Win32.Registry.GetValue(
                     @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders"
                    , "{374DE290-123F-4565-9164-39C4925E467B}"
                    , String.Empty
                )
            );
        }

        private void btnGenTicket_Click(object sender, EventArgs e)
        {

            string folder = getDownloadFolderPath() + "/factura.pdf";

            FileStream fs = new FileStream(folder, FileMode.Create);
            Document doc = new Document(PageSize.LETTER, 5, 5, 7, 7);
            PdfWriter pw = PdfWriter.GetInstance(doc, fs);

            doc.Open();

            //se define autor y titulo 
            doc.AddAuthor("Chimichanga");
            doc.AddTitle("Peaje");

            //Se define fuente
            iTextSharp.text.Font standardfont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            //Encabezado 
            doc.Add(new Paragraph("Peaje"));
            doc.Add(Chunk.NEWLINE);

            //Encabezado de columnas
            PdfPTable tblEjemplo = new PdfPTable(5);
            tblEjemplo.WidthPercentage = 100;

            //titulo de las columnas

            PdfPCell clVendedor = new PdfPCell(new Phrase("Vendedor", standardfont));
            clVendedor.BorderWidth = 0;
            clVendedor.BorderWidthBottom = 0.75f;

            PdfPCell clTipoVehiculo = new PdfPCell(new Phrase("Tipo de vehículo", standardfont));
            clTipoVehiculo.BorderWidth = 0;
            clTipoVehiculo.BorderWidthBottom = 0.75f;

            PdfPCell clPrecio = new PdfPCell(new Phrase("Monto", standardfont));
            clPrecio.BorderWidth = 0;
            clPrecio.BorderWidthBottom = 0.75f;

            PdfPCell clPatente = new PdfPCell(new Phrase("Patente", standardfont));
            clPatente.BorderWidth = 0;
            clPatente.BorderWidthBottom = 0.75f;

            PdfPCell clFecha = new PdfPCell(new Phrase("Fecha", standardfont));
            clFecha.BorderWidth = 0;
            clFecha.BorderWidthBottom = 0.75f;



            tblEjemplo.AddCell(clVendedor);
            tblEjemplo.AddCell(clTipoVehiculo);
            tblEjemplo.AddCell(clPrecio);
            tblEjemplo.AddCell(clPatente);
            tblEjemplo.AddCell(clFecha);


            //agregar datos

            clVendedor = new PdfPCell(new Phrase(Datos.vendedor, standardfont));
            clVendedor.BorderWidth = 0;


            
            clTipoVehiculo = new PdfPCell(new Phrase(Datos.selectedVehicle, standardfont));
            clTipoVehiculo.BorderWidth = 0;

            

            if(Datos.selectedVehicle == "Camion")
            {
                clPrecio = new PdfPCell(new Phrase(Datos.precioCamion, standardfont));
                clPrecio.BorderWidth = 0;

            } else if (Datos.selectedVehicle == "Auto")
            {
                clPrecio = new PdfPCell(new Phrase(Datos.precioAuto, standardfont));
                clPrecio.BorderWidth = 0;

            } else if (Datos.selectedVehicle == "Moto")
            {
                clPrecio = new PdfPCell(new Phrase(Datos.precioMoto, standardfont));
                clPrecio.BorderWidth = 0;

            }

            clPatente = new PdfPCell(new Phrase(Datos.patente, standardfont));
            clPatente.BorderWidth = 0;

            clFecha = new PdfPCell(new Phrase(Datos.fecha, standardfont));
            clFecha.BorderWidth = 0;

            tblEjemplo.AddCell(clVendedor);
            tblEjemplo.AddCell(clTipoVehiculo);
            tblEjemplo.AddCell(clPrecio);
            tblEjemplo.AddCell(clPatente);
            tblEjemplo.AddCell(clFecha);



            doc.Add(tblEjemplo);

            doc.Close();
            pw.Close();

            MessageBox.Show("Descargado correctamente");
            this.Close();


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
