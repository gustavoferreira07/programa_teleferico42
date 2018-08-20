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
    public partial class telaCarregaGridCatraca : Form
    {
        public telaCarregaGridCatraca()
        {
            InitializeComponent();
        }
        int socaNessa = 770;
        int vagabunda = 540;
        Bitmap captura = null;

        private void button1_Click(object sender, EventArgs e)
        {

            button1.Visible = false;
            CapturarForm();
            button1.Visible = true;
            captura.Save("file.png");
            GerarPDF("document.pdf");
            System.Diagnostics.Process.Start("document.pdf");

        }

        public void GerarPDF(string CaminhoArquivoPDF)
        {

            Document documento = new Document(PageSize.A4);
            PdfWriter.GetInstance(documento, new FileStream(CaminhoArquivoPDF, FileMode.Create));

            try
            {

                captura.Save("file.png");
                iTextSharp.text.Image imagem1 = iTextSharp.text.Image.GetInstance("file.png");
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

            var formBorderStyleAnterior = this.FormBorderStyle;

            try
            {
                this.FormBorderStyle = FormBorderStyle.None;

                WindowHelper.Rect rect;
                WindowHelper.DwmGetWindowAttribute(this.Handle, (int)WindowHelper.Dwmwindowattribute.DwmwaExtendedFrameBounds,
                    out rect, System.Runtime.InteropServices.Marshal.SizeOf(typeof(WindowHelper.Rect)));
                var rectangle = rect.ToRectangle();

                captura = new Bitmap(rectangle.Width, rectangle.Height);
                var graphics = Graphics.FromImage(captura);
                graphics.CopyFromScreen(rectangle.Left, rectangle.Top, 0, 0, rectangle.Size);

            }
            finally
            {
                this.FormBorderStyle = formBorderStyleAnterior;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(captura, 20, 20);
        }
    }
}

