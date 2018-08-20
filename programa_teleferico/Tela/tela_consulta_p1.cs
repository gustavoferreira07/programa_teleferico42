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
    public partial class tela_consulta_p1 : Form
    {

        Conexao conexao = new Conexao();
        string codigo;
        string codigo2;
        SaveFileDialog slv = new SaveFileDialog();

        public tela_consulta_p1()
        {
            InitializeComponent();
        }

        private void brnRefresh_Click(object sender, EventArgs e)
        {
        }

        public void NomeData1()
        {
            
            dataGridView1.Columns[0].HeaderText = "Codigo";
            dataGridView1.Columns[1].HeaderText = "Data";
            dataGridView1.Columns[2].HeaderText = "Operador";
            dataGridView1.Columns[3].HeaderText = "Troco";
            dataGridView1.Columns[4].HeaderText = "Inicial Ida1";
            dataGridView1.Columns[5].HeaderText = "Final ida1";
            dataGridView1.Columns[6].HeaderText = "Inicial ida2";
            dataGridView1.Columns[7].HeaderText = "Final ida2";
            dataGridView1.Columns[8].HeaderText = "Inicial ida3";
            dataGridView1.Columns[9].HeaderText = "Final ida3";
            dataGridView1.Columns[10].HeaderText = "Inicial ida/volta1";
            dataGridView1.Columns[11].HeaderText = "Final ida/Volta1";
            dataGridView1.Columns[12].HeaderText = "inciial ida/Volta2";
            dataGridView1.Columns[13].HeaderText = "Final ida/Volta2";
            dataGridView1.Columns[14].HeaderText = "Inicial ida/volta3";
            dataGridView1.Columns[15].HeaderText = "Final ida/volta3";
            dataGridView1.Columns[16].HeaderText = "Inicial PU1";
            dataGridView1.Columns[17].HeaderText = "Final PU1";
            dataGridView1.Columns[18].HeaderText = "Inicial PU2";
            dataGridView1.Columns[19].HeaderText = "Final PU2";
            dataGridView1.Columns[20].HeaderText = "inciial ida/Volta2";
            dataGridView1.Columns[21].HeaderText = "Final ida/Volta2";
            dataGridView1.Columns[22].HeaderText = "Inicial ida/volta3";
            dataGridView1.Columns[23].HeaderText = "Final ida/volta3";
            
        }

        public void NomeData2()
        {   
            dataGridView2.Columns[0].HeaderText = "Codigo";
            dataGridView2.Columns[1].HeaderText = "Data";
            dataGridView2.Columns[2].HeaderText = "Operador";
            dataGridView2.Columns[3].HeaderText = "Troco";
            dataGridView2.Columns[4].HeaderText = "Inicial Ida1";
            dataGridView2.Columns[5].HeaderText = "Final ida1";
            dataGridView2.Columns[6].HeaderText = "Inicial ida2";
            dataGridView2.Columns[7].HeaderText = "Final ida2";
            dataGridView2.Columns[8].HeaderText = "Inicial ida3";
            dataGridView2.Columns[9].HeaderText = "Final ida3";
            dataGridView2.Columns[10].HeaderText = "Inicial ida/volta1";
            dataGridView2.Columns[11].HeaderText = "Final ida/Volta1";
            dataGridView2.Columns[12].HeaderText = "inciial ida/Volta2";
            dataGridView2.Columns[13].HeaderText = "Final ida/Volta2";
            dataGridView2.Columns[14].HeaderText = "Inicial ida/volta3";
            dataGridView2.Columns[15].HeaderText = "Final ida/volta3";
            dataGridView2.Columns[16].HeaderText = "Inicial PU1";
            dataGridView2.Columns[17].HeaderText = "Final PU1";
            dataGridView2.Columns[18].HeaderText = "Inicial PU2";
            dataGridView2.Columns[19].HeaderText = "Final PU2";
            dataGridView2.Columns[20].HeaderText = "inciial ida/Volta2";
            dataGridView2.Columns[21].HeaderText = "Final ida/Volta2";
            dataGridView2.Columns[22].HeaderText = "Inicial ida/volta3";
            dataGridView2.Columns[23].HeaderText = "Final ida/volta3";
            
        }

        private void tela_consulta_p1_Load(object sender, EventArgs e)
        {
           // preencherCBDescricao();
            
        }
        private void preencherCBDescricao()
        {
            Conexao con = new Conexao();
            try
            {
                con.ConectarBD();
                con.DesconectarBD();
            }

            catch (SqlException sqle)
            {
                con.ConectarBD();
                MessageBox.Show("Falha ao efetuar a conexão. Erro: " + sqle);
            }
            String scom = "select * from tbl_funcionario order by nome_func asc";
            SqlDataAdapter da = new SqlDataAdapter(scom, con.ConectarBD());
            DataTable dtResultado = new DataTable();
            dtResultado.Clear();
            cbbOperador.DataSource = null;
            da.Fill(dtResultado);
            cbbOperador.DataSource = dtResultado;
            cbbOperador.ValueMember = "cpf_func";
            cbbOperador.DisplayMember = "nome_func";
            cbbOperador.SelectedItem = "";

            cbbOperador.Refresh(); 
            con.DesconectarBD();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
        }
        private void MetroGridView1_DoubleClick(object sender, EventArgs e)
        {
            telaCarregaGrid tela = new telaCarregaGrid();
            tela.Show();


            SqlDataReader dr;

            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand("select * from tbl_p1 where cd_fechamentop1=@codigo", con.ConectarBD());
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
                        tela.Show();
                        tela.txt_codigoFechamento.Text = dr[0].ToString();
                        tela.txt_nomeFechamento.Text = dr[2].ToString();
                        tela.txt_dataFechamento.Text = dr[1].ToString();
                        tela.txt_trocoFechamento.Text = dr[3].ToString();
                        //bilhetes iniciais
                        tela.txt_idaInicialFechamento.Text = dr[4].ToString();
                        tela.txt_idaInicial2Fechamento.Text = dr[6].ToString();
                        tela.txt_idaInicial3Fechamento.Text = dr[8].ToString();
                        tela.txt_idaVoltaInicialFechamento.Text = dr[10].ToString();
                        tela.txt_idaVoltaInicial2Fechamento.Text = dr[12].ToString();
                        tela.txt_idaVoltaInicial3Fechamento.Text = dr[14].ToString();
                        tela.txt_peixeUrbanoInicialFechamento.Text = dr[16].ToString();
                        tela.txt_peixeUrbanoInicial2Fechamento.Text = dr[18].ToString();
                        // BILHETES FINAIS
                        tela.txt_idaFinalFechamento.Text = dr[5].ToString();
                        tela.txt_idaFinal2Fechamento.Text = dr[7].ToString();
                        tela.txt_idaFinal3Fechamento.Text = dr[9].ToString();
                        tela.txt_idaVoltaFinalFechamento.Text = dr[11].ToString();
                        tela.txt_idaVoltaFinal2Fechamento.Text = dr[13].ToString();
                        tela.txt_idaVoltaFinal3Fechamento.Text = dr[15].ToString();
                        tela.txt_peixeUrbanoFinalFechamento.Text = dr[17].ToString();
                        tela.txt_peixeUrbanoFinal2Fechamento.Text = dr[19].ToString();
                        //TOTAL VENDAS
                        tela.txt_totalVendasIda.Text = dr[20].ToString();
                        tela.txt_totalVendasIdaVolta.Text = dr[22].ToString();
                        tela.txt_totalVendasPeixeUrbano.Text = dr[24].ToString();
                        //TOTAL DINHEIRO
                        tela.txt_DinheirototalIda.Text = dr[21].ToString();
                        tela.txt_DinheirototalIdaVolta.Text = dr[23].ToString();
                        tela.txt_totalFinal.Text = dr[28].ToString();
                        // cartao
                        tela.txt_debito.Text = dr[25].ToString();
                        tela.txt_credito.Text = dr[26].ToString();
                        tela.txt_totalCartao.Text = dr[27].ToString();
                        //SANGRIA E TOTAIS
                        tela.txt_trouxe.Text = dr[29].ToString();
                        tela.txt_sangria.Text = dr[30].ToString();
                        tela.txt_totalDinheiro.Text = dr[31].ToString();
                        tela.label38.Text = dr[32].ToString();
                        tela.lblTotalTrazer.Text = "Total Trazer: " + dr[33].ToString();
                        tela.lblTrouxe.Text = "Total Trouxe: " + dr[34].ToString();
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

        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        {



            telaCarregaGrid tela = new telaCarregaGrid();
            tela.Show();


            SqlDataReader dr;

            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand("select * from tbl_p1 where cd_fechamentop1=@codigo", con.ConectarBD());
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

                        tela.txt_codigoFechamento.Text = dr[0].ToString();
                        tela.txt_nomeFechamento.Text = dr[2].ToString();
                        tela.txt_dataFechamento.Text = dr[1].ToString();
                        tela.txt_trocoFechamento.Text = dr[3].ToString();
                        //bilhetes iniciais
                        tela.txt_idaInicialFechamento.Text = dr[4].ToString();
                        tela.txt_idaInicial2Fechamento.Text = dr[6].ToString();
                        tela.txt_idaInicial3Fechamento.Text = dr[8].ToString();
                        tela.txt_idaVoltaInicialFechamento.Text = dr[10].ToString();
                        tela.txt_idaVoltaInicial2Fechamento.Text = dr[12].ToString();
                        tela.txt_idaVoltaInicial3Fechamento.Text = dr[14].ToString();
                        tela.txt_peixeUrbanoInicialFechamento.Text = dr[16].ToString();
                        tela.txt_peixeUrbanoInicial2Fechamento.Text = dr[18].ToString();
                        // BILHETES FINAIS
                        tela.txt_idaFinalFechamento.Text = dr[5].ToString();
                        tela.txt_idaFinal2Fechamento.Text = dr[7].ToString();
                        tela.txt_idaFinal3Fechamento.Text = dr[9].ToString();
                        tela.txt_idaVoltaFinalFechamento.Text = dr[11].ToString();
                        tela.txt_idaVoltaFinal2Fechamento.Text = dr[13].ToString();
                        tela.txt_idaVoltaFinal3Fechamento.Text = dr[15].ToString();
                        tela.txt_peixeUrbanoFinalFechamento.Text = dr[17].ToString();
                        tela.txt_peixeUrbanoFinal2Fechamento.Text = dr[19].ToString();
                        //TOTAL VENDAS
                        tela.txt_totalVendasIda.Text = dr[20].ToString();
                        tela.txt_totalVendasIdaVolta.Text = dr[22].ToString();
                        tela.txt_totalVendasPeixeUrbano.Text = dr[24].ToString();
                        //TOTAL DINHEIRO
                        tela.txt_DinheirototalIda.Text = dr[21].ToString();
                        tela.txt_DinheirototalIdaVolta.Text = dr[23].ToString();
                        tela.txt_totalFinal.Text = dr[28].ToString();
                        // cartao
                        tela.txt_debito.Text = dr[25].ToString();
                        tela.txt_credito.Text = dr[26].ToString();
                        tela.txt_totalCartao.Text = dr[27].ToString();
                        //SANGRIA E TOTAIS
                        tela.txt_trouxe.Text = dr[29].ToString();
                        tela.txt_sangria.Text = dr[30].ToString();
                        tela.txt_totalDinheiro.Text = dr[31].ToString();
                        tela.label38.Text = dr[32].ToString();
                        tela.lblTotalTrazer.Text = dr[33].ToString();
                        tela.lblTrouxe.Text = dr[34].ToString();
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

        private void rdbP1_CheckedChanged(object sender, EventArgs e)
        {
            Listar_tabelas_plataformas listar_tabelas = new Listar_tabelas_plataformas();
            DataSet ds = new DataSet();
            ds = listar_tabelas.listarTodos();
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();
        }

        private void rdbP2_CheckedChanged(object sender, EventArgs e)
        {
            Listar_tabelas_plataformas listar_tabelas = new Listar_tabelas_plataformas();
            DataSet ds = new DataSet();
            ds = listar_tabelas.listarTodos();
            dataGridView1.DataSource = ds.Tables[1];
            dataGridView1.Refresh();
        }

        private void cbbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {

            {
                DataSet ds = new DataSet();
                ds = listarOperador();
                dataGridView1.DataSource = ds.Tables[1];
                dataGridView1.Refresh();


            }
            {
                DataSet ds = new DataSet();
                ds = listarOperador();
                dataGridView2.DataSource = ds.Tables[0];
                dataGridView2.Refresh();

            }
        }

        public DataSet listarOperador()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("select * from tbl_p1  where nm_operadorp1 = '" + cbbOperador.Text + "'; select *from tbl_p2 where nm_operadorp2 ='" + cbbOperador.Text + "'", conexao.ConectarBD());
            da.Fill(ds);
            conexao.DesconectarBD();
            return ds;


        }

        private void ckb2_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb2.Checked == true)
            {
                Listar_tabelas_plataformas listar_tabelas = new Listar_tabelas_plataformas();
                DataSet ds = new DataSet();
                ds = listar_tabelas.listarTodos();
                dataGridView2.DataSource = ds.Tables[1];
                NomeData2();


                dataGridView2.Refresh();
            }
            else
            {
                dataGridView2.DataSource = null;

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb1.Checked == true)
            {
                Listar_tabelas_plataformas listar_tabelas = new Listar_tabelas_plataformas();
                DataSet ds = new DataSet();
                ds = listar_tabelas.listarTodos();
                dataGridView1.DataSource = ds.Tables[0];
                NomeData1();




                dataGridView1.Refresh();
            }
            else
            {

                dataGridView1.DataSource = null;

            }
        }



        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo2 = (dataGridView2.Rows[e.RowIndex].Cells["cd_fechamentop2"].Value).ToString();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            codigo = (dataGridView1.Rows[e.RowIndex].Cells["cd_fechamentop1"].Value).ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //codigo = (dataGridView1.Rows[e.RowIndex].Cells["cd_fechamentop1"].Value).ToString();




            telaCarregaGrid tela = new telaCarregaGrid();
            tela.Show();


            SqlDataReader dr;

            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand("select * from tbl_p1 where cd_fechamentop1=@codigo", con.ConectarBD());
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

                        tela.txt_codigoFechamento.Text = dr[0].ToString();
                        tela.txt_nomeFechamento.Text = dr[2].ToString();
                        tela.txt_dataFechamento.Text = dr[1].ToString();
                        tela.txt_trocoFechamento.Text = dr[3].ToString();
                        //bilhetes iniciais
                        tela.txt_idaInicialFechamento.Text = dr[4].ToString();
                        tela.txt_idaInicial2Fechamento.Text = dr[6].ToString();
                        tela.txt_idaInicial3Fechamento.Text = dr[8].ToString();
                        tela.txt_idaVoltaInicialFechamento.Text = dr[10].ToString();
                        tela.txt_idaVoltaInicial2Fechamento.Text = dr[12].ToString();
                        tela.txt_idaVoltaInicial3Fechamento.Text = dr[14].ToString();
                        tela.txt_peixeUrbanoInicialFechamento.Text = dr[16].ToString();
                        tela.txt_peixeUrbanoInicial2Fechamento.Text = dr[18].ToString();
                        // BILHETES FINAIS
                        tela.txt_idaFinalFechamento.Text = dr[5].ToString();
                        tela.txt_idaFinal2Fechamento.Text = dr[7].ToString();
                        tela.txt_idaFinal3Fechamento.Text = dr[9].ToString();
                        tela.txt_idaVoltaFinalFechamento.Text = dr[11].ToString();
                        tela.txt_idaVoltaFinal2Fechamento.Text = dr[13].ToString();
                        tela.txt_idaVoltaFinal3Fechamento.Text = dr[15].ToString();
                        tela.txt_peixeUrbanoFinalFechamento.Text = dr[17].ToString();
                        tela.txt_peixeUrbanoFinal2Fechamento.Text = dr[19].ToString();
                        //TOTAL VENDAS
                        tela.txt_totalVendasIda.Text = dr[20].ToString();
                        tela.txt_totalVendasIdaVolta.Text = dr[22].ToString();
                        tela.txt_totalVendasPeixeUrbano.Text = dr[24].ToString();
                        //TOTAL DINHEIRO
                        tela.txt_DinheirototalIda.Text = dr[21].ToString();
                        tela.txt_DinheirototalIdaVolta.Text = dr[23].ToString();
                        tela.txt_totalFinal.Text = dr[28].ToString();
                        // cartao
                        tela.txt_debito.Text = dr[25].ToString();
                        tela.txt_credito.Text = dr[26].ToString();
                        tela.txt_totalCartao.Text = dr[27].ToString();
                        //SANGRIA E TOTAIS
                        tela.txt_trouxe.Text = dr[29].ToString();
                        tela.txt_sangria.Text = dr[30].ToString();
                        tela.txt_totalDinheiro.Text = dr[31].ToString();
                        tela.label38.Text = dr[32].ToString();
                        tela.lblTotalTrazer.Text = dr[33].ToString();
                        tela.lblTrouxe.Text = dr[34].ToString();
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

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo2 = (dataGridView2.Rows[e.RowIndex].Cells["cd_fechamentop2"].Value).ToString();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            telaCarregaGrid tela = new telaCarregaGrid();
            tela.Show();


            SqlDataReader dr;

            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand("select * from tbl_p2 where cd_fechamentop2=@codigo", con.ConectarBD());
            cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = codigo2;
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
                        tela.lbl_titulo.Text = "TELEFÉRICO ESTORIL PLATAFORMA 2";
                        tela.txt_codigoFechamento.Text = dr[0].ToString();
                        tela.txt_nomeFechamento.Text = dr[2].ToString();
                        tela.txt_dataFechamento.Text = dr[1].ToString();
                        tela.txt_trocoFechamento.Text = dr[3].ToString();
                        //bilhetes iniciais
                        tela.txt_idaInicialFechamento.Text = dr[4].ToString();
                        tela.txt_idaInicial2Fechamento.Text = dr[6].ToString();
                        tela.txt_idaInicial3Fechamento.Text = dr[8].ToString();
                        tela.txt_idaVoltaInicialFechamento.Text = dr[10].ToString();
                        tela.txt_idaVoltaInicial2Fechamento.Text = dr[12].ToString();
                        tela.txt_idaVoltaInicial3Fechamento.Text = dr[14].ToString();
                        tela.txt_peixeUrbanoInicialFechamento.Text = dr[16].ToString();
                        tela.txt_peixeUrbanoInicial2Fechamento.Text = dr[18].ToString();
                        // BILHETES FINAIS
                        tela.txt_idaFinalFechamento.Text = dr[5].ToString();
                        tela.txt_idaFinal2Fechamento.Text = dr[7].ToString();
                        tela.txt_idaFinal3Fechamento.Text = dr[9].ToString();
                        tela.txt_idaVoltaFinalFechamento.Text = dr[11].ToString();
                        tela.txt_idaVoltaFinal2Fechamento.Text = dr[13].ToString();
                        tela.txt_idaVoltaFinal3Fechamento.Text = dr[15].ToString();
                        tela.txt_peixeUrbanoFinalFechamento.Text = dr[17].ToString();
                        tela.txt_peixeUrbanoFinal2Fechamento.Text = dr[19].ToString();
                        //TOTAL VENDAS
                        tela.txt_totalVendasIda.Text = dr[20].ToString();
                        tela.txt_totalVendasIdaVolta.Text = dr[22].ToString();
                        tela.txt_totalVendasPeixeUrbano.Text = dr[24].ToString();
                        //TOTAL DINHEIRO
                        tela.txt_DinheirototalIda.Text = dr[21].ToString();
                        tela.txt_DinheirototalIdaVolta.Text = dr[23].ToString();
                        tela.txt_totalFinal.Text = dr[28].ToString();
                        // cartao
                        tela.txt_debito.Text = dr[25].ToString();
                        tela.txt_credito.Text = dr[26].ToString();
                        tela.txt_totalCartao.Text = dr[27].ToString();
                        //SANGRIA E TOTAIS
                        tela.txt_trouxe.Text = dr[29].ToString();
                        tela.txt_sangria.Text = dr[30].ToString();
                        tela.txt_totalDinheiro.Text = dr[31].ToString();
                        tela.label38.Text = dr[32].ToString();
                        tela.lblTotalTrazer.Text = dr[33].ToString();
                        tela.lblTrouxe.Text = dr[34].ToString();
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

        private void btn_buscar_Click(object sender, EventArgs e)
        {
           
                 SqlDataReader dr;
                 Conexao con = new Conexao();
                 SqlCommand cmd = new SqlCommand("select * from tbl_p1 where dt_fechammentop1>='" + dtp1.Text + "' and dt_fechammentop1<='" + dtp2.Text + "'", con.ConectarBD());
                 dr = cmd.ExecuteReader();
                 if (dr.HasRows == false)
                 {
                     MessageBox.Show("Não houve nenhuma venda neste dia !","tente inserir outro dia", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                     dataGridView1.Refresh();
                 }
                 else
                 {
                     {
                         DataSet ds = new DataSet();
                         ds = pesquisarPlataforma();
                         dataGridView1.DataSource = ds.Tables[0];
                      //   dataGridView1.Columns[4].HeaderText = "Total Vendas P1 R$";
                         dataGridView1.Refresh();
                    NomeData1();

                     }
                     {
                    DataSet ds = new DataSet();
                    ds = pesquisarPlataforma();
                    dataGridView2.DataSource = ds.Tables[1];
                    //   dataGridView1.Columns[4].HeaderText = "Total Vendas P1 R$";
                    dataGridView2.Refresh();
                    NomeData2();
                }
                 }
             
        }

        public DataSet pesquisarPlataforma()
        {


            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("select * from tbl_p1  where dt_fechammentop1 >='" + dtp1.Text + "' and dt_fechammentop1<='" + dtp2.Text + "'; select * from tbl_p2  where dt_fechammentop2 >='" + dtp1.Text + "' and dt_fechammentop2<='" + dtp2.Text + "'", conexao.ConectarBD());

            da.Fill(ds);
            conexao.DesconectarBD();
            return ds;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ckb1.Checked)
            {


                DataTable dt = new DataTable();
                SqlDataAdapter da;
                da = new SqlDataAdapter("select cd_fechamentop1, dt_fechammentop1, vl_trocop1, no_total_vendap1_ida, no_total_dinheirop1_ida, no_total_vendap1_volta, no_total_dinheriop1_volta, ds_verificap1 from tbl_p1 where dt_fechammentop1 >='" + dtp1.Text + "' and dt_fechammentop1<='" + dtp2.Text + "'", conexao.ConectarBD());
                da.Fill(dt);
                    try
                    {
                    DataSet ds = new DataSet();
                    da.Fill(dt);
                    ds.Tables.Add(dt);

                    slv.Filter = "Arquivo do Excel *.xls | *.xls";
                       
                       
                        slv.ShowDialog();
                        dt.WriteXml(slv.FileName, System.Data.XmlWriteMode.IgnoreSchema);
                    MessageBox.Show("Salvo com Sucesso !");
                    }

                    catch(Exception ex)
                    {
                    MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
                
            }
            else if (ckb2.Checked)
            {
                DataTable dt = new DataTable();

                try
                {


                    if (this.dataGridView2.DataSource is DataTable)
                    {

                        dt = ((DataTable)dataGridView2.DataSource);
                       
                        slv.Filter = "doc|XML files (*.xml)|*.xml";
                        dt.TableName = "Set";
                        slv.DefaultExt = ".xls";
                        slv.ShowDialog();
                        dt.WriteXml(slv.FileName, System.Data.XmlWriteMode.IgnoreSchema);

                    }
                    else
                    //-este else testa se a informacao no grid vem de um dataset

                    {
                        dt = ((DataTable)dataGridView2.DataSource);
                        
                        dt.TableName = "Set";
                        slv.Filter = "doc|XML files (*.xml)|*.xml";
                        slv.DefaultExt = ".xls";
                        slv.ShowDialog();
                        dt.WriteXml(slv.FileName, System.Data.XmlWriteMode.IgnoreSchema);

                    }
                }
                catch
                {

                }
            }
            }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ckb1.Enabled = true;
            ckb2.Enabled = true;

            cbbOperador.Enabled = false;

            dtp1.Enabled = false;
            dtp2.Enabled = false;
            btn_buscar.Enabled = false;

            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;

        
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ckb1.Enabled = false;
            ckb2.Enabled = false;

            cbbOperador.Enabled = true;

            dtp1.Enabled = false;
            dtp2.Enabled = false;
            btn_buscar.Enabled = false;

            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;

           
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ckb1.Enabled = false;
            ckb2.Enabled = false;

            cbbOperador.Enabled = false;

            dtp1.Enabled = true;
            dtp2.Enabled = true;
            btn_buscar.Enabled = true;

            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;

          
        }
    }
}

