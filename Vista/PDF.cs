using System;
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
    public partial class PDF : Form
    {
        public PDF()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        List<Class1> lista = new List<Class1>();

        private void llenar()
        {
            Class1 temp = new Class1();
            temp.Camion = "Camión";
            temp.auto = "Auto";
            temp.moto = "Moto";
            temp.PrecioCamion = 100;
            temp.PrecioAuto = 50;
            temp.PrecioMoto = 25; 
        }

        private void btnGenTicket_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\LogJuan\PDFTicket.pfd", FileMode.Create);
            Document doc = new Document(PageSize.LETTER, 5, 5, 7, 7);
            PdfWriter pw = PdfWriter.GetInstance(doc, fs);

            doc.Open();

            //se define autor y titulo 
            doc.AddAuthor("Juan");
            doc.AddTitle("Peaje"); 

            //Se define fuente
            iTextSharp.text.Font standardfont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            //Encabezado 
            doc.Add(new Paragraph("Peaje"));
            doc.Add(Chunk.NEWLINE);

            //Encabezado de columnas
            PdfPTable tblEjemplo = new PdfPTable(2);
            tblEjemplo.WidthPercentage = 100; 

            //titulo de las columnas
            PdfPCell clTipoVehiculo =  new PdfPCell(new Phrase ("Tipo de vehículo", standardfont));
            clTipoVehiculo.BorderWidth = 0;
            clTipoVehiculo.BorderWidthBottom = 0.75f;

            PdfPCell clPrecio = new PdfPCell(new Phrase("Precio", standardfont));
            clPrecio.BorderWidth = 0;
            clPrecio.BorderWidthBottom = 0.75f;

            tblEjemplo.AddCell(clTipoVehiculo);
            tblEjemplo.AddCell(clPrecio); 

            //agregar datos

            


        }
    }
}
