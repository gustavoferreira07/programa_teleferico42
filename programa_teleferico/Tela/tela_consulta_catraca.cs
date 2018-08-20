using programa_teleferico.Repositorio;
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

namespace programa_teleferico.Tela
{
    public partial class tela_consulta_catraca : Form
    {
        Conexao conexao = new Conexao();
        string codigo;

        public DataSet buscarCodigoCatraca()
        {

            SqlCommand cmd = new SqlCommand();
            tela_consulta_p1 tela = new tela_consulta_p1();
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("select * from tbl_fechamentoCatracap1 where cd_fechamnetoCatracap1='" + txtCodigo.Text + "';" + " select * from tbl_fechamentoCatracap2 where cd_fechamnetoCatracap2='" + txtCodigo.Text + "';", conexao.ConectarBD());
            da.Fill(ds);
            conexao.DesconectarBD();
            return ds;
        }
        public tela_consulta_catraca()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbP1.Checked)
            {
                Listar_tabelas_catraca listar_tabelas = new Listar_tabelas_catraca();
                DataSet ds = new DataSet();
                ds = buscarCodigoCatraca();
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Refresh();
            }

            else if (rdbP2.Checked)
            {
                Listar_tabelas_catraca listar_tabelas = new Listar_tabelas_catraca();
                DataSet ds = new DataSet();
                ds = buscarCodigoCatraca();
                dataGridView1.DataSource = ds.Tables[1];
                dataGridView1.Refresh();
            
            }
            else
                MessageBox.Show("Selecione a plataforma !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void brnRefresh_Click(object sender, EventArgs e)
        {
            if (rdbP1.Checked)
            {
                Listar_tabelas_catraca listar_tabelas = new Listar_tabelas_catraca();
                DataSet ds = new DataSet();
                ds = listar_tabelas.listarTodos();
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Refresh();
            }
            else if (rdbP2.Checked)
            {
                Listar_tabelas_catraca listar_tabelas = new Listar_tabelas_catraca();
                DataSet ds = new DataSet();
                ds = listar_tabelas.listarTodos();
                dataGridView1.DataSource = ds.Tables[1];
                dataGridView1.Refresh();
            }
            else
                MessageBox.Show("Selecione a plataforma !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
       
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {   
            telaCarregaGridCatraca tela = new telaCarregaGridCatraca();
            tela.Show();
            if (rdbP1.Checked)
            {
                string codigo;
                SqlDataReader dr;
                codigo = txtCodigo.Text;
                Conexao con = new Conexao();
                SqlCommand cmd = new SqlCommand("select * from tbl_fechamentoCatracap1 where cd_fechamnetoCatracap1=@codigo", con.ConectarBD());
                cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = txtCodigo.Text;
                dr = cmd.ExecuteReader();
                try
                {
                    if (dr.HasRows == false)
                    {
                        MessageBox.Show("Não houve nenhuma Abertura de caixa com este código !");
                    }
                    else
                    {
                        while (dr.Read())
                        {

                            tela.txt_codigoCatraca.Text = dr[0].ToString();
                            tela.txt_nomeCatraca.Text = dr[1].ToString();
                            tela.txtDataCatraca.Text = dr[2].ToString();
                            tela.txtInicialCatraca.Text = dr[3].ToString();
                            tela.txtFinalCatraca.Text = dr[4].ToString();
                            tela.txtTotalCatraca.Text = dr[5].ToString();
                            tela.txtTotalIda.Text = dr[6].ToString();
                            tela.txtTotalIdaVolta.Text = dr[7].ToString();
                            tela.txtTotalPU.Text = dr[8].ToString();
                            tela.txtTotalCortesia.Text = dr[9].ToString();
                            tela.lblFechamento.Text = dr[10].ToString();
                        }

                        con.DesconectarBD();
                        con.ConectarBD();
                        con.DesconectarBD();
                    }
                }

                catch
                {
                    
                }
            
            }
            else if (rdbP2.Checked)
            {
                string codigo;
                SqlDataReader dr;
                codigo = txtCodigo.Text;
                Conexao con = new Conexao();
                SqlCommand cmd = new SqlCommand("select * from tbl_fechamentoCatracap2 where cd_fechamnetoCatracap2=@codigo", con.ConectarBD());
                cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = txtCodigo.Text;
                dr = cmd.ExecuteReader();
                try
                {
                    if (dr.HasRows == false)
                    {
                        MessageBox.Show("Não houve nenhuma Abertura de caixa com este código !");
                    }
                    else
                    {
                        while (dr.Read())
                        {

                            tela.txt_codigoCatraca.Text = dr[0].ToString();
                            tela.txt_nomeCatraca.Text = dr[1].ToString();
                            tela.txtDataCatraca.Text = dr[2].ToString();
                            tela.txtInicialCatraca.Text = dr[3].ToString();
                            tela.txtFinalCatraca.Text = dr[4].ToString();
                            tela.txtTotalCatraca.Text = dr[5].ToString();
                            tela.txtTotalIda.Text = dr[6].ToString();
                            tela.txtTotalIdaVolta.Text = dr[7].ToString();
                            tela.txtTotalPU.Text = dr[8].ToString();
                            tela.txtTotalCortesia.Text = dr[9].ToString();
                            tela.lblFechamento.Text = dr[10].ToString();
                        }

                        con.DesconectarBD();
                        con.ConectarBD();
                        con.DesconectarBD();
                    }
                }

                catch
                {
                   
                }
            }
        }

        private void btnPesquisar_BackgroundImageLayoutChanged(object sender, EventArgs e)
        {

        }

        private void rdbP1_CheckedChanged(object sender, EventArgs e)
        {
            Listar_tabelas_catraca listar_tabelas = new Listar_tabelas_catraca();
            DataSet ds = new DataSet();
            ds = listar_tabelas.listarTodos();
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();
        }

        private void rdbP2_CheckedChanged(object sender, EventArgs e)
        {
            Listar_tabelas_catraca listar_tabelas = new Listar_tabelas_catraca();
            DataSet ds = new DataSet();
            ds = listar_tabelas.listarTodos();
            dataGridView1.DataSource = ds.Tables[1];
            dataGridView1.Refresh();
        }

        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = (dataGridView1.Rows[e.RowIndex].Cells[0].Value).ToString();
         
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (rdbP1.Checked)
            {
                

                telaCarregaGridCatraca tela = new telaCarregaGridCatraca();
                tela.Show();
               
                SqlDataReader dr;
                Conexao con = new Conexao();
                SqlCommand cmd = new SqlCommand("select * from tbl_fechamentoCatracap1 where cd_fechamnetoCatracap1=@codigo", con.ConectarBD());
                cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = codigo;
                dr = cmd.ExecuteReader();
                try
                {
                    if (dr.HasRows == false)
                    {
                        MessageBox.Show("Não houve nenhuma Abertura de caixa com este código !");
                    }
                    else
                    {
                        while (dr.Read())
                        {
                            tela.lblFechamento.Text = "FECHAMENTO CATRACA P1";
                            tela.txt_codigoCatraca.Text = dr[0].ToString();
                            tela.txt_nomeCatraca.Text = dr[1].ToString();
                            tela.txtDataCatraca.Text = dr[2].ToString();
                            tela.txtInicialCatraca.Text = dr[3].ToString();
                            tela.txtFinalCatraca.Text = dr[4].ToString();
                            tela.txtTotalCatraca.Text = dr[5].ToString();
                            tela.txtTotalIda.Text = dr[6].ToString();
                            tela.txtTotalIdaVolta.Text = dr[7].ToString();
                            tela.txtTotalPU.Text = dr[8].ToString();
                            tela.txtTotalCortesia.Text = dr[9].ToString();
                            tela.lblFechamento.Text = dr[10].ToString();

                        }

                        con.DesconectarBD();
                        con.ConectarBD();
                        con.DesconectarBD();
                    }
                }

                catch
                {

                }
            }
            else if (rdbP2.Checked)
            {
                telaCarregaGridCatraca tela = new telaCarregaGridCatraca();
                tela.Show();
                
                SqlDataReader dr;
                Conexao con = new Conexao();
                SqlCommand cmd = new SqlCommand("select * from tbl_fechamentoCatracap2 where cd_fechamnetoCatracap2=@codigo", con.ConectarBD());
                cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = codigo;
                dr = cmd.ExecuteReader();
                try
                {
                    if (dr.HasRows == false)
                    {
                        MessageBox.Show("Não houve nenhuma Abertura de caixa com este código !");
                    }
                    else
                    {
                        while (dr.Read())
                        {
                            tela.lblFechamento.Text = "FECHAMENTO CATRACA P2";
                            tela.txt_codigoCatraca.Text = dr[0].ToString();
                            tela.txt_nomeCatraca.Text = dr[1].ToString();
                            tela.txtDataCatraca.Text = dr[2].ToString();
                            tela.txtInicialCatraca.Text = dr[3].ToString();
                            tela.txtFinalCatraca.Text = dr[4].ToString();
                            tela.txtTotalCatraca.Text = dr[5].ToString();
                            tela.txtTotalIda.Text = dr[6].ToString();
                            tela.txtTotalIdaVolta.Text = dr[7].ToString();
                            tela.txtTotalPU.Text = dr[8].ToString();
                            tela.txtTotalCortesia.Text = dr[9].ToString();
                            tela.lblFechamento.Text = dr[10].ToString();

                        }

                        con.DesconectarBD();
                        con.ConectarBD();
                        con.DesconectarBD();
                    }
                }

                catch
                {

                }
            }
        }
    }
}
