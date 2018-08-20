using programa_teleferico.Tela;
using programa_teleferico.Utilitatio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace programa_teleferico
{
    public partial class tela_menu : Form
    {
        public tela_menu()
        {
            InitializeComponent();
        }
        Conexao conexao = new Conexao();
        private SqlCommand cmd = new SqlCommand();
        private SqlDataReader reader;
        string sql = "";

        private void novaAberturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tela_abertura frm = new tela_abertura();
            frm.Show();
         
        }

        private void novoFechamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void fechamentosAnterioresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tela_consulta_p1 frm = new tela_consulta_p1();
            frm.Show();
        }

        private void catracaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tela_abertura_catraca frm = new tela_abertura_catraca();
            frm.Show();
        }

        private void catracaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tela_fechamento_catraca frm = new tela_fechamento_catraca();
            frm.Show();
        }

        private void plataforma1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tela_consulta_p1 frm = new tela_consulta_p1();
            frm.Show();
        }

        private void binToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tela_consulta_bin frm = new tela_consulta_bin();
            frm.Show();
        }

        private void pagSeguroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tela_consulta_pagseguro frm = new tela_consulta_pagseguro();
            frm.Show();
        }

        private void totalDiárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tela_consulta_total_diario frm = new tela_consulta_total_diario();
            frm.Show();
        }

        private void tela_menu_Load(object sender, EventArgs e)
        {

        }

        private void plataforma1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            tela_fechamento_plataforma1 frm = new tela_fechamento_plataforma1();
            frm.Show();
        }

        private void plataforma2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tela_fechamento_plataforma2 frm = new tela_fechamento_plataforma2();
            frm.Show();
        }

        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Backup Files(*.bak)|*.bak";
                opf.FilterIndex = 0;

                if (opf.ShowDialog() == DialogResult.OK)

                {

                    sql = "Alter Database db_teleferico Set SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                    sql += "use master restore database db_teleferico FROM Disk = '" + opf.FileName + "' WITH REPLACE;";
                    cmd = new SqlCommand(sql, conexao.ConectarBD());
                    cmd.ExecuteNonQuery();
                    conexao.DesconectarBD();
                    MessageBox.Show("Restaurado com sucesso");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {


                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "DataBase Backup File(*.bak)|*.bak";
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    sql = "USE master BACKUP DATABASE db_teleferico TO DISK ='" + sfd.FileName + "'";
                    cmd = new SqlCommand(sql, conexao.ConectarBD());
                    cmd.ExecuteNonQuery();
                    conexao.DesconectarBD();
                    MessageBox.Show("Backup feito com sucesso");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Tente salvar o arquivo em outro local \n : " + ex.Message);
            }

            conexao.ChecarSetiveAberFecha();

        }


          

        private void catracasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tela_consulta_catraca tela = new tela_consulta_catraca();
            tela.Show();
        }

        private void vendaSemanalToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void avulsoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tela_cadastrar_avulso tela = new tela_cadastrar_avulso();
            tela.Show();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tela_cadastrar_bilhete tela = new tela_cadastrar_bilhete();
            tela.Show();
        }

        private void bilhetesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tela_consulta_bilhetes tela = new tela_consulta_bilhetes();
            tela.Show();
        }

        private void avulsosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tela_consulta_avulso tela = new tela_consulta_avulso();
            tela.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tela_cadastrar_avulso tela = new tela_cadastrar_avulso();
            tela.Show();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tela_consulta_avulso tela = new tela_consulta_avulso();
            tela.Show();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tela_consulta_bilhetes tela = new tela_consulta_bilhetes();
            tela.Show();
        }

        private void tela_menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100000350923523");
        }

        private void exportarExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tela_exportar_excel tela = new tela_exportar_excel();
            tela.Show();
        }

        private void listaDeAvulsosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
