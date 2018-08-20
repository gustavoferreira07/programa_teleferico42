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
    public partial class tela_exportar_excel : Form
    {
        public tela_exportar_excel()
        {
            InitializeComponent();
        }
        SaveFileDialog slv = new SaveFileDialog();
        Conexao conexao = new Conexao();

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {

                SqlDataReader dr;
                SqlCommand cmd = new SqlCommand("select cd_fechamentop1 as[Codigo Fechamento], dt_fechammentop1 as[Data fechamento], no_total_vendap1_ida as[Total vendas IDA], no_total_dinheirop1_ida as[Total arrrecadado IDA], no_total_vendap1_volta as[Total vendas Ida/Volta], no_total_dinheriop1_volta as[Total arrecadado ida/volta], ds_verificap1 as[Detalhe caixa] from tbl_p1 where dt_fechammentop1 >='" + dtp1.Text + "' and dt_fechammentop1<='" + dtp2.Text + "'", conexao.ConectarBD());

                dr = cmd.ExecuteReader();
                if (dr.HasRows == false)
                {
                    MessageBox.Show("Não houve nenhuma venda neste dia !", "tente inserir outro dia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    conexao.DesconectarBD();
                }
                else
                {
                    conexao.DesconectarBD();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da;
                    da = new SqlDataAdapter("select cd_fechamentop1 as[Codigo Fechamento], dt_fechammentop1 as[Data fechamento], no_total_vendap1_ida as[Total vendas IDA], no_total_dinheirop1_ida as[Total arrrecadado IDA], no_total_vendap1_volta as[Total vendas Ida/Volta], no_total_dinheriop1_volta as[Total arrecadado ida/volta], ds_verificap1 as[Detalhe caixa] from tbl_p1 where dt_fechammentop1 >='" + dtp1.Text + "' and dt_fechammentop1<='" + dtp2.Text + "'", conexao.ConectarBD());
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
                        this.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
            else if (radioButton2.Checked)
            {


                SqlDataReader dr;
                SqlCommand cmd = new SqlCommand("select cd_fechamentop1 as[Codigo Fechamento], dt_fechammentop1 as[Data fechamento], no_total_vendap1_ida as[Total vendas IDA], no_total_dinheirop1_ida as[Total arrrecadado IDA], no_total_vendap1_volta as[Total vendas Ida/Volta], no_total_dinheriop1_volta as[Total arrecadado ida/volta], ds_verificap1 as[Detalhe caixa] from tbl_p1 where dt_fechammentop1 >='" + dtp1.Text + "' and dt_fechammentop1<='" + dtp2.Text + "'", conexao.ConectarBD());

                dr = cmd.ExecuteReader();
                if (dr.HasRows == false)
                {
                    MessageBox.Show("Não houve nenhuma venda neste dia !", "tente inserir outro dia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    conexao.DesconectarBD();
                }
                else
                {
                    conexao.DesconectarBD();
                    DataTable dt = new DataTable();
                        SqlDataAdapter da;
                        da = new SqlDataAdapter("select cd_fechamentop2 as[Codigo Fechamento], dt_fechammentop2 as[Data fechamento], no_total_vendap2_ida as[Total vendas IDA], no_total_dinheirop2_ida as[Total arrrecadado IDA], no_total_vendap2_volta as[Total vendas Ida/Volta], no_total_dinheriop2_volta as[Total arrecadado ida/volta], ds_verificap2 as[Detalhe caixa] from tbl_p2 where dt_fechammentop2 >='" + dtp1.Text + "' and dt_fechammentop2<='" + dtp2.Text + "'", conexao.ConectarBD());
                        da.Fill(dt);
                        try
                        {
                            DataSet ds = new DataSet();
                            da.Fill(dt);
                            ds.Tables.Add(dt);

                            slv.Filter = "Arquivo do Excel *.xls | *.xls";


                            slv.ShowDialog();
                            dt.WriteXml(slv.FileName, System.Data.XmlWriteMode.IgnoreSchema);

                        MessageBox.Show("Salvo com Sucesso !", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conexao.DesconectarBD();
                    }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            
            else
                MessageBox.Show("Selecione a plataforma !", "Dados incorretos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
            

        private void button2_Click(object sender, EventArgs e)
        {
           


              
           
        }
        public DataSet pesquisarExcel()
        {


            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("select cd_fechamentop1, dt_fechammentop1, vl_trocop1, no_total_vendap1_ida, no_total_dinheirop1_ida, no_total_vendap1_volta, no_total_dinheriop1_volta, ds_verificap1 from tbl_p1 where dt_fechammentop1 >='" + dtp1.Text + "' and dt_fechammentop1<='" + dtp2.Text + "'; select cd_fechamentop2, dt_fechammentop2, vl_trocop2, no_total_vendap2_ida, no_total_dinheirop2_ida, no_total_vendap2_volta, no_total_dinheriop2_volta, ds_verificap2 from tbl_p2 where dt_fechammentop2 >= '" + dtp1.Text + "' and dt_fechammentop2 <= '" + dtp2.Text + "'", conexao.ConectarBD());

            da.Fill(ds);
            conexao.DesconectarBD();
            return ds;

        }
    }
}
