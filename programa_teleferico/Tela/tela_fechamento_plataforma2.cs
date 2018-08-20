using programa_teleferico.Controlador;
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
    public partial class tela_fechamento_plataforma2 : Form
    {

        Salvarp2 salvarp2 = new Salvarp2();
        int hour;

        public tela_fechamento_plataforma2()
        {
            InitializeComponent();
        }

        private void btn_Calcularp2_Click(object sender, EventArgs e)
        {
            
            try
            {
                //calculo do total de vendas IDA
                int idaInicial = int.Parse(txt_idaInicialFechamentop2.Text);
                int idaFinal = int.Parse(txt_idaFinalFechamentop2.Text);
                int idaInicial2 = int.Parse(txt_idaInicial2Fechamentop2.Text);
                int idaFinal2 = int.Parse(txt_idaFinal2Fechamentop2.Text);
                int idaInicial3 = int.Parse(txt_idaInicial3Fechamentop2.Text);
                int idaFinal3 = int.Parse(txt_idaFinal3Fechamentop2.Text);
                int testeMod;
                int testeMod2;
                int testeMod3;
                int vendaIda = (idaFinal - idaInicial) + (idaFinal2 - idaInicial2) + (idaFinal3 - idaFinal3);
                testeMod = idaFinal % 100;
                if (testeMod == 0)
                {
                    vendaIda = vendaIda + 1;
                }
                testeMod2 = idaFinal2 % 100;
                if (testeMod2 == 0)
                {
                    vendaIda = vendaIda + 1;
                }
                testeMod3 = idaFinal3 % 100;
                if (testeMod3 == 0)
                {
                    vendaIda = vendaIda + 1;
                }
                if (txt_idaFinal2Fechamentop2.Text == "0")
                {
                    vendaIda = vendaIda - 1;
                }
                if (txt_idaFinal3Fechamentop2.Text == "0")
                {
                    vendaIda = vendaIda - 1;
                }
                txt_vendasIdap2.Text = vendaIda.ToString();
                txt_totalVendasIdap2.Text = vendaIda.ToString();

                //calculo do total de vendas IDA/VOLTA
                int voltaInicial = int.Parse(txt_idaVoltaInicialFechamentop2.Text);
                int voltaFinal = int.Parse(txt_idaVoltaFinalFechamentop2.Text);
                int voltaInicial2 = int.Parse(txt_idaVoltaInicial2Fechamentop2.Text);
                int voltaFinal2 = int.Parse(txt_idaVoltaFinal2Fechamentop2.Text);
                int voltaInicial3 = int.Parse(txt_idaVoltaInicial3Fechamentop2.Text);
                int voltaFinal3 = int.Parse(txt_idaVoltaFinal3Fechamentop2.Text);
                int testeModVolta;
                int testeMod2Volta;
                int testeMod3Volta;
                int vendasVolta = (voltaFinal - voltaInicial) + (voltaFinal2 - voltaInicial2) + (voltaFinal3 - voltaInicial3);

                testeModVolta = voltaFinal % 100;

                if (testeModVolta == 0)
                {
                    vendasVolta = vendasVolta + 1;
                }

                testeMod2Volta = voltaFinal2 % 100;
                if (testeMod2Volta == 0)
                {
                    vendasVolta = vendasVolta + 1;
                }

                testeMod3Volta = voltaFinal3 % 100;
                if (testeMod3 == 0)
                {
                    vendasVolta = vendasVolta + 1;
                }
                if (txt_idaVoltaFinal2Fechamentop2.Text == "0")
                {
                    vendasVolta = vendasVolta - 1;
                }
                if (txt_idaVoltaFinal3Fechamentop2.Text == "0")
                {
                    vendasVolta = vendasVolta - 1;
                }


                txt_vendasIdaVoltap2.Text = vendasVolta.ToString();
                txt_totalVendasIdaVoltap2.Text = vendasVolta.ToString();

                //calculo do total de vendas peixes urbanos
                int idaPUInicial = int.Parse(txt_peixeUrbanoInicialFechamentop2.Text);
                int idaPUFinal = int.Parse(txt_peixeUrbanoFinalFechamentop2.Text);
                int idaPUInicial2 = int.Parse(txt_peixeUrbanoInicial2Fechamentop2.Text);
                int idaPUFinal2 = int.Parse(txt_peixeUrbanoFinal2Fechamentop2.Text);

                int vendasPU = (idaPUFinal - idaPUInicial) + (idaPUFinal2 - idaPUInicial2);

                txt_vendasPeixeUrbanop2.Text = vendasPU.ToString();
                txt_totalVendasPeixeUrbanop2.Text = vendasPU.ToString();

                //total de dinheiro vendas IDA
                int dinheiroIda = (vendaIda * 10);
                txt_DinheirototalIdap2.Text = dinheiroIda.ToString();

                //total de dinheiro vendas IDA/VOLTA
                int dinheiroVolta = (vendasVolta * 16);
                txt_DinheirototalIdaVoltap2.Text = dinheiroVolta.ToString();

                //soma do total do dinheiro
                int total = dinheiroIda + dinheiroVolta;
                txt_totalFinalp2.Text = total.ToString();

                //soma de vendas com cartão
                int debito = int.Parse(txt_debitop2.Text);
                int credito = int.Parse(txt_creditop2.Text);
                int vendaCartao = debito + credito;
                txt_totalCartaop2.Text = vendaCartao.ToString();

                //logica de conferência de fechamento
                int totalTrazer2 = int.Parse(txt_totalFinalp2.Text) + int.Parse(txt_trocoFechamentop2.Text);
                int totalTrazer = totalTrazer2 - int.Parse(txt_sangriap2.Text);
                int totalTrouxe = int.Parse(txt_trouxep2.Text) + int.Parse(txt_totalCartaop2.Text);
                int fechamento = totalTrouxe - totalTrazer;
                //logica totalTrzerFinal
                int troco = int.Parse(txt_trocoFechamentop2.Text);
                int totalTrazerfinal = total + troco;
                lblTotalTrazer.Text = "Total a ser trago: " + totalTrazerfinal;

                //logica TotalTrouxe2
                int sangria = int.Parse(txt_sangriap2.Text);
                int trouxe = int.Parse(txt_trouxep2.Text);
                int totaltrouxe2 = vendaCartao + sangria + trouxe;
                lblTrouxe.Text = "total Trouxe: R$" + totaltrouxe2;

                //total de vendas mais troco, = totalDinheiro
                txt_totalDinheirop2.Text = totalTrazer2.ToString(); ;

                if (fechamento < 0)
                {
                    lblFechamento.Text = "FALTAM R$" + fechamento;
                }
                else if (fechamento > 0)
                {
                    lblFechamento.Text = "SOBRARAM R$" + fechamento;
                }
                else
                    lblFechamento.Text = "SEM ERROS NO FECHAMENTO !";
            }
            catch 
            {
               MessageBox.Show("Insira corretamente os campos em branco ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            }
            
        private void button2_Click(object sender, EventArgs e)
        {

            Classep2 p2 = new Classep2();

            p2.Codigop2 = txt_codigoFechamentop2.Text;
            p2.Datap2 = msk_dataFechamentop2.Text;
            p2.Nome_operadorp2 = txt_nomeFechamentop2.Text;
            p2.Trocop2 = int.Parse(txt_trocoFechamentop2.Text);
            p2.BilheteIdaIni1p2 = int.Parse(txt_idaInicialFechamentop2.Text);
            p2.BilheteIdaFin1p2 = int.Parse(txt_idaFinalFechamentop2.Text);
            p2.BilheteIdaIni2p2 = int.Parse(txt_idaInicial2Fechamentop2.Text);
            p2.BilheteIdaFin2p2 = int.Parse(txt_idaFinal2Fechamentop2.Text);
            p2.BilheteIdaIni3p2 = int.Parse(txt_idaInicial3Fechamentop2.Text);
            p2.BilheteIdaFin3p2 = int.Parse(txt_idaFinal3Fechamentop2.Text);
            p2.BilheteVoltaIni1p2 = int.Parse(txt_idaVoltaInicialFechamentop2.Text);
            p2.BilheteVoltaFin1p2 = int.Parse(txt_idaVoltaFinalFechamentop2.Text);
            p2.BilheteVoltaIni2p2 = int.Parse(txt_idaVoltaInicial2Fechamentop2.Text);
            p2.BilheteVoltaFin2p2 = int.Parse(txt_idaVoltaFinal2Fechamentop2.Text);
            p2.BilheteVoltaIni3p2 = int.Parse(txt_idaVoltaInicial3Fechamentop2.Text);
            p2.BilheteVoltaFin3p2 = int.Parse(txt_idaVoltaFinal3Fechamentop2.Text);
            p2.BilhetePUIni1p2 = int.Parse(txt_peixeUrbanoInicialFechamentop2.Text);
            p2.BilhetePUfin1p2 = int.Parse(txt_peixeUrbanoFinalFechamentop2.Text);
            p2.BilhetePUIni2p2 = int.Parse(txt_peixeUrbanoInicial2Fechamentop2.Text);
            p2.BilhetePUfin2p2 = int.Parse(txt_peixeUrbanoFinal2Fechamentop2.Text);
            p2.TotalVendaIdap2 = int.Parse(txt_totalVendasIdap2.Text);
            p2.TotalDinheiroIdap2 = int.Parse(txt_DinheirototalIdap2.Text);
            p2.TotalVendaVoltap2 = int.Parse(txt_totalVendasIdaVoltap2.Text);
            p2.TotalDinheiroVoltap2 = int.Parse(txt_DinheirototalIdaVoltap2.Text);
            p2.TotalVendaPUp2 = int.Parse(txt_vendasPeixeUrbanop2.Text);
            p2.TotalDebitop2 = int.Parse(txt_debitop2.Text);
            p2.TotalCreditop2 = int.Parse(txt_creditop2.Text);
            p2.TotalCartaop2 = int.Parse(txt_totalCartaop2.Text);
            p2.TotalDinheiroVendasp2 = int.Parse(txt_totalFinalp2.Text);
            p2.Trouxep2 = int.Parse(txt_trouxep2.Text);
            p2.Sangriap2 = int.Parse(txt_sangriap2.Text);
            p2.TotalCaixap2 = int.Parse(txt_totalDinheirop2.Text);
            p2.Verificap2 = lblFechamento.Text;
            p2.TotalTrouxep2 = lblTrouxe.Text;
            p2.TotalTrazerp2 = lblTotalTrazer.Text;

            salvarp2.salvarFechamentop2(p2);
            try
            {
                this.Close();
            }
            catch
            {

            }
        }
        Conexao conexao = new Conexao();
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            
            string codigos;
            Conexao con = new Conexao();
            codigos = txt_codigoFechamentop2.Text;
            SqlDataReader dr2;
            SqlCommand cmdo = new SqlCommand("select * from tbl_p2 where cd_fechamentop2=@codigos ", con.ConectarBD());
            cmdo.Parameters.Add("@codigos", SqlDbType.VarChar).Value = txt_codigoFechamentop2.Text;
            dr2 = cmdo.ExecuteReader();
            try
            {
                if (dr2.HasRows == true)
                {
                    MessageBox.Show("Já foi feito esse fechamento !", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    con.DesconectarBD();
                }

                else
                {
                    con.DesconectarBD();
                    string codigo;
                    SqlDataReader dr;
                    codigo = txt_codigoFechamentop2.Text;
           
                    SqlCommand cmd = new SqlCommand("select * from tbl_aberturap2 where cd_aberturap2=@codigo ", con.ConectarBD());
                    cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = txt_codigoFechamentop2.Text;
                    dr = cmd.ExecuteReader();
                 try
                   {

                        if (dr.HasRows == false)
                        {
                            MessageBox.Show("Não houve nenhuma Abertura de caixa com este código !", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            con.DesconectarBD();
                        }
                        else
                        {
                            {


                                while (dr.Read())
                                {
                                    txt_nomeFechamentop2.Text = dr[1].ToString();
                                    msk_dataFechamentop2.Text = dr[2].ToString();
                                    txt_trocoFechamentop2.Text = dr[3].ToString();
                                    txt_idaInicialFechamentop2.Text = dr[4].ToString();
                                    txt_idaInicial2Fechamentop2.Text = dr[6].ToString();
                                    txt_idaInicial3Fechamentop2.Text = dr[8].ToString();

                                    txt_idaVoltaInicialFechamentop2.Text = dr[10].ToString();
                                    txt_idaVoltaInicial2Fechamentop2.Text = dr[12].ToString();
                                    txt_idaVoltaInicial3Fechamentop2.Text = dr[14].ToString();
                                    txt_peixeUrbanoInicialFechamentop2.Text = dr[16].ToString();
                                    txt_peixeUrbanoInicial2Fechamentop2.Text = dr[18].ToString();
                                }

                                con.DesconectarBD();
                                con.ConectarBD();
                                con.DesconectarBD();
                            }
                        }
                    }

                    catch
                    {

                    }
                }
            }
    
            catch
            {
                MessageBox.Show("este fechamento ja foi feito !", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            hour = Convert.ToInt16(DateTime.Now.Minute);
            msk_dataFechamentop2.Text = Convert.ToString(DateTime.Now);
        }

        private void tela_fechamento_plataforma2_Load(object sender, EventArgs e)
        {

        }
    }
}