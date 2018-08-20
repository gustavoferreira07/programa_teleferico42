using iTextSharp.text;
using iTextSharp.text.pdf;
using programa_teleferico.Print;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa_teleferico.Tela
{
    public partial class telaCarregaGrid : Form
    {
        public telaCarregaGrid()
        {
            InitializeComponent();
        }
        int socaNessa = 1500;
        int vagabunda = 630;
        Bitmap captura = null;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                button2.Visible = false;
                button1.Visible = false;
                button3.Visible = false;
                CapturarForm();
                button2.Visible = true;
                button1.Visible = true;
                button3.Visible = true;
                captura.Save("foto.jpg");
                GerarPDF("documentTel.pdf");
                System.Diagnostics.Process.Start("documentTel.pdf");
            }
            catch 
            {
            }


        
        }

        public void GerarPDF(string CaminhoArquivoPDF)
        {

            Document documento = new Document(PageSize.A4);
            PdfWriter.GetInstance(documento, new FileStream(CaminhoArquivoPDF, FileMode.Create));

            try
            {


              
                iTextSharp.text.Image imagem1 = iTextSharp.text.Image.GetInstance("foto.jpg");
                imagem1.ScaleToFit(socaNessa, vagabunda);



                documento.Open();
               
                documento.Add(imagem1);
                documento.Close();
               
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }


        }

        public void CapturarForm()
        {

         //   var formBorderStyleAnterior = this.FormBorderStyle;

            try
            {
                //this.FormBorderStyle = FormBorderStyle.None;

                WindowHelper.Rect rect;
                WindowHelper.DwmGetWindowAttribute(this.Handle, (int)WindowHelper.Dwmwindowattribute.DwmwaExtendedFrameBounds,
                    out rect, System.Runtime.InteropServices.Marshal.SizeOf(typeof(WindowHelper.Rect)));
                var rectangle = rect.ToRectangle();

                captura = new Bitmap(rectangle.Width, rectangle.Height);
                var graphics = Graphics.FromImage(captura);
                graphics.CopyFromScreen(rectangle.Left, rectangle.Top, -10, 0, rectangle.Size);
                
            }
            finally
            {
                //this.FormBorderStyle = formBorderStyleAnterior;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(captura, 0, 0);
        }

        private void telaCarregaGrid_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void gpb_abertura_Enter(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }
    }
 
    
}
