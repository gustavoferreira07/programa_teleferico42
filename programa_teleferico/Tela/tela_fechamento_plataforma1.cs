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
    public partial class tela_fechamento_plataforma1 : Form
    {
        Conexao conexao = new Conexao();
        Salvarp1 salvarp1 = new Salvarp1();
        int hour;

        public tela_fechamento_plataforma1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void gpb_abertura_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
           
            try
            {
               

                //calculo do total de vendas IDA
                int idaInicial = int.Parse(txt_idaInicialFechamento.Text);
                int idaFinal = int.Parse(txt_idaFinalFechamento.Text);
                int idaInicial2 = int.Parse(txt_idaInicial2Fechamento.Text);
                int idaFinal2 = int.Parse(txt_idaFinal2Fechamento.Text);
                int idaInicial3 = int.Parse(txt_idaInicial3Fechamento.Text);
                int idaFinal3 = int.Parse(txt_idaFinal3Fechamento.Text);
                double testeMod;
                double testeMod2;
                double testeMod3;
                int vendaIda = (idaFinal - idaInicial) + (idaFinal2 - idaInicial2) + (idaFinal3 - idaInicial3);
                testeMod = idaFinal % 100;
                if (testeMod==0)
                {
                    vendaIda = vendaIda+ 1;
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
                if (txt_idaFinal2Fechamento.Text == "0")
                {
                    vendaIda = vendaIda - 1;
                }
                if (txt_idaFinal3Fechamento.Text == "0")
                {
                    vendaIda = vendaIda - 1;
                }

                txt_vendasIda.Text = vendaIda.ToString();
                txt_totalVendasIda.Text = vendaIda.ToString();

                //calculo do total de vendas IDA/VOLTA
                int voltaInicial = int.Parse(txt_idaVoltaInicialFechamento.Text);
                int voltaFinal = int.Parse(txt_idaVoltaFinalFechamento.Text);
                int voltaInicial2 = int.Parse(txt_idaVoltaInicial2Fechamento.Text);
                int voltaFinal2 = int.Parse(txt_idaVoltaFinal2Fechamento.Text);
                int voltaInicial3 = int.Parse(txt_idaVoltaInicial3Fechamento.Text);
                int voltaFinal3 = int.Parse(txt_idaVoltaFinal3Fechamento.Text);
                double testeModVolta;
                double testeMod2Volta;
                double testeMod3Volta;
               
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
                if (txt_idaVoltaFinal2Fechamento.Text == "0")
                {
                    vendasVolta = vendasVolta - 1;
                }
                if (txt_idaVoltaFinal3Fechamento.Text == "0")
                {
                    vendasVolta = vendasVolta - 1;
                }

                txt_vendasIdaVolta.Text = vendasVolta.ToString();
                txt_totalVendasIdaVolta.Text = vendasVolta.ToString();

                //calculo do total de vendas peixes urbanos
                int idaPUInicial = int.Parse(txt_peixeUrbanoInicialFechamento.Text);
                int idaPUFinal = int.Parse(txt_peixeUrbanoFinalFechamento.Text);
                int idaPUInicial2 = int.Parse(txt_peixeUrbanoInicial2Fechamento.Text);
                int idaPUFinal2 = int.Parse(txt_peixeUrbanoFinal2Fechamento.Text);

                int vendasPU = (idaPUFinal - idaPUInicial) + (idaPUFinal2 - idaPUInicial2);

                txt_vendasPeixeUrbano.Text = vendasPU.ToString();
                txt_totalVendasPeixeUrbano.Text = vendasPU.ToString();

                //total de dinheiro vendas IDA
                int dinheiroIda = (vendaIda * 10);
                txt_DinheirototalIda.Text = dinheiroIda.ToString();

                //total de dinheiro vendas IDA/VOLTA
                int dinheiroVolta = (vendasVolta * 16);
                txt_DinheirototalIdaVolta.Text = dinheiroVolta.ToString();

                //soma do total do dinheiro
                int total = dinheiroIda + dinheiroVolta;
                txt_totalFinal.Text = total.ToString();

                //soma de vendas com cartão
                int debito = int.Parse(txt_debito.Text);
                int credito = int.Parse(txt_credito.Text);
                int vendaCartao = debito + credito;
                txt_totalCartao.Text = vendaCartao.ToString();

                //logica de conferência de fechamento
                int totalTrazer2 = int.Parse(txt_totalFinal.Text) + int.Parse(txt_trocoFechamento.Text);
                int totalTrazer = totalTrazer2 - int.Parse(txt_sangria.Text);
                int totalTrouxe = int.Parse(txt_trouxe.Text) + int.Parse(txt_totalCartao.Text);
                int fechamento = totalTrouxe - totalTrazer;

                //logica totalTrzerFinal
                int troco = int.Parse(txt_trocoFechamento.Text);
                int totalTrazerfinal = total + troco;
                lblTotalTrazer.Text = "Total a ser trago: " + totalTrazerfinal;

                //logica TotalTrouxe2
                int sangria = int.Parse(txt_sangria.Text);
                int trouxe = int.Parse(txt_trouxe.Text);
                int totaltrouxe2 = vendaCartao + sangria + trouxe;
                lblTrouxe.Text = "total Trouxe: R$" + totaltrouxe2;



                //total de vendas mais troco, = totalDinheiro
                txt_totalDinheiro.Text = totalTrazer2.ToString(); ;

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
                MessageBox.Show("Insira corretamente os campos em branco ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void tela_fechamento_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((txt_idaFinalFechamento.Text == "") || (txt_idaFinal2Fechamento.Text == "") || (txt_idaVoltaFinalFechamento.Text == "")
                || (txt_idaVoltaFinal2Fechamento.Text == "") || (txt_peixeUrbanoFinalFechamento.Text == "") || (txt_peixeUrbanoFinal2Fechamento.Text == "")
                || (txt_debito.Text == "") || (txt_credito.Text == "") || (txt_totalCartao.Text == "") || (txt_trouxe.Text == "")
                || (txt_sangria.Text == ""))
            {
                MessageBox.Show("Insira os campos em branco !", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Classep1 p1 = new Classep1();


                p1.Codigo = txt_codigoFechamento.Text;
                p1.Data = txt_dataFechamento.Text;
                p1.Nome_operador = txt_nomeFechamento.Text;
                p1.Troco = int.Parse(txt_trocoFechamento.Text);
                p1.BilheteIdaIni1 = int.Parse(txt_idaInicialFechamento.Text);
                p1.BilheteIdaFin1 = int.Parse(txt_idaFinalFechamento.Text);
                p1.BilheteIdaIni2 = int.Parse(txt_idaInicial2Fechamento.Text);
                p1.BilheteIdaFin2 = int.Parse(txt_idaFinal2Fechamento.Text);
                p1.BilheteIdaIni3 = int.Parse(txt_idaInicial3Fechamento.Text);
                p1.BilheteIdaFin3 = int.Parse(txt_idaFinal3Fechamento.Text);
                p1.BilheteVoltaIni1 = int.Parse(txt_idaVoltaInicialFechamento.Text);
                p1.BilheteVoltaFin1 = int.Parse(txt_idaVoltaFinalFechamento.Text);
                p1.BilheteVoltaIni2 = int.Parse(txt_idaVoltaInicial2Fechamento.Text);
                p1.BilheteVoltaFin2 = int.Parse(txt_idaVoltaFinal2Fechamento.Text);
                p1.BilheteVoltaIni3 = int.Parse(txt_idaVoltaInicial3Fechamento.Text);
                p1.BilheteVoltaFin3 = int.Parse(txt_idaVoltaFinal3Fechamento.Text);
                p1.BilhetePUIni1 = int.Parse(txt_peixeUrbanoInicialFechamento.Text);
                p1.BilhetePUfin1 = int.Parse(txt_peixeUrbanoFinalFechamento.Text);
                p1.BilhetePUIni2 = int.Parse(txt_peixeUrbanoInicial2Fechamento.Text);
                p1.BilhetePUfin2 = int.Parse(txt_peixeUrbanoFinal2Fechamento.Text);
                p1.TotalVendaIda = int.Parse(txt_totalVendasIda.Text);
                p1.TotalDinheiroIda = int.Parse(txt_DinheirototalIda.Text);
                p1.TotalVendaVolta = int.Parse(txt_totalVendasIdaVolta.Text);
                p1.TotalDinheiroVolta = int.Parse(txt_DinheirototalIdaVolta.Text);
                p1.TotalVendaPU = int.Parse(txt_vendasPeixeUrbano.Text);
                p1.TotalDebito = int.Parse(txt_debito.Text);
                p1.TotalCredito = int.Parse(txt_credito.Text);
                p1.TotalCartao = int.Parse(txt_totalCartao.Text);
                p1.TotalDinheiroVendas = int.Parse(txt_totalFinal.Text);
                p1.Trouxe = int.Parse(txt_trouxe.Text);
                p1.Sangria = int.Parse(txt_sangria.Text);
                p1.TotalCaixa = int.Parse(txt_totalDinheiro.Text);
                p1.Verificap1 = lblFechamento.Text;
                p1.TotalTrouxe = lblTrouxe.Text;
                p1.TotalTrazer = lblTotalTrazer.Text;
                salvarp1.salvarFechamento(p1);
                try
                {
                    this.Close();
                }
                catch
                {

                }

            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {

            Conexao con = new Conexao();
           
            string codigos;

            codigos = txt_codigoFechamento.Text;
            SqlDataReader dr2;
            SqlCommand cmdo = new SqlCommand("select * from tbl_p1 where cd_fechamentop1=@codigos ", con.ConectarBD());
            cmdo.Parameters.Add("@codigos", SqlDbType.VarChar).Value = txt_codigoFechamento.Text;
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
                    codigo = txt_codigoFechamento.Text;
           
                    SqlCommand cmd = new SqlCommand("select * from tbl_aberturap1 where cd_aberturap1=@codigo ", con.ConectarBD());
                    cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = txt_codigoFechamento.Text;
                    dr = cmd.ExecuteReader();
                    try
                    {

                        if (dr.HasRows == false)
                        {
                            MessageBox.Show("Não houve nenhuma Abertura de caixa com este código !", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);              
                        }

                        else
                        {

                            {
                                while (dr.Read())
                                {
                                    txt_nomeFechamento.Text = dr[1].ToString();
                                //    txt_dataFechamento.Text = dr[2].ToString();
                                    txt_trocoFechamento.Text = dr[3].ToString();
                                    txt_idaInicialFechamento.Text = dr[4].ToString();
                                    txt_idaInicial2Fechamento.Text = dr[6].ToString();
                                    txt_idaInicial3Fechamento.Text = dr[8].ToString();

                                    txt_idaVoltaInicialFechamento.Text = dr[10].ToString();
                                    txt_idaVoltaInicial2Fechamento.Text = dr[12].ToString();
                                    txt_idaVoltaInicial3Fechamento.Text = dr[14].ToString();
                                    txt_peixeUrbanoInicialFechamento.Text = dr[16].ToString();
                                    txt_peixeUrbanoInicial2Fechamento.Text = dr[18].ToString();
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
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Text = "";
                }
                if (c is MaskedTextBox)
                {
                    (c as MaskedTextBox).Text = "";
                }
                if (c is RadioButton)
                {
                    (c as RadioButton).Checked = false;
                }

            }
        }

        private void gpb_bilhetes_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            hour = Convert.ToInt16(DateTime.Now.Minute);
            txt_dataFechamento.Text = Convert.ToString(DateTime.Now);
        }
               
   }
   
}

