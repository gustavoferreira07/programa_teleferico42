using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using programa_teleferico.Controlador;
using programa_teleferico.Repositorio;
using System.Data.SqlClient;
using programa_teleferico.Utilitatio;

namespace programa_teleferico.Tela
{
    public partial class tela_cadastrar_bilhete : Form
    {
        public tela_cadastrar_bilhete()
        {
            InitializeComponent();
        }

        private void tela_cadastrar_bilhete_Load(object sender, EventArgs e)
        {

        }
        


        private void metroButton1_Click(object sender, EventArgs e)
        {
            Bilhetes bilhetes = new Bilhetes();
            SalvarBilhetes salvar = new SalvarBilhetes();

           bilhetes.Tipo_bilhetes = cbbTipoBilhete.Text;
           bilhetes.Qtde_bilhetes = int.Parse(txt_qtde.Text); 

            salvar.salvarBilhetes(bilhetes);
        }

        private void cbbTipoBilhete_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = cbbTipoBilhete.Text;
        }
    }
}
