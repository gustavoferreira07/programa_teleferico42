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
    public partial class tela_abertura : Form
    {
        public tela_abertura()
        {
            InitializeComponent();
            
        }

       
        int hour;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tela_abertura_Load(object sender, EventArgs e)
        {

         /*   if (hour < 10)
            {
                // lblHora.Text = Convert.ToString(DateTime.Now.Hour) + ":0" + Convert.ToString(DateTime.Now.Minute);
                msk_data.Text = Convert.ToString(DateTime.Now);//+"   " + Convert.ToString(DateTime.Now.Hour) + ":0" + Convert.ToString(DateTime.Now.Minute); ;
                preencherCBDescricao();
         }
          else*/
               // lblHora.Text = Convert.ToString(DateTime.Now.Hour) + ":" + Convert.ToString(DateTime.Now.Minute);
            
            preencherCBDescricao();
          
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
            String scom = "select * from tbl_funcionario";
            SqlDataAdapter da = new SqlDataAdapter(scom, con.ConectarBD());
            DataTable dtResultado = new DataTable();
            dtResultado.Clear();//o ponto mais importante (limpa a table antes de preenche-la)
            cbbOperador.DataSource = null;
            da.Fill(dtResultado);
            cbbOperador.DataSource = dtResultado;
            cbbOperador.ValueMember = "cpf_func";
            cbbOperador.DisplayMember = "nome_func";
            cbbOperador.SelectedItem = "";
            cbbOperador.Refresh(); //faz uma nova busca no BD para preencher os valores da cb de departamentos.
            con.DesconectarBD();
        }
        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void ptb_log1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {

            if ((txt_codigo.Text == "") || (cbbOperador.Text == "") || (msk_data.Text == "") || (txt_troco.Text == "") || (txt_idaInicial.Text == "") || (txt_idaVoltaFinal.Text == "") || (txt_idaInicial2.Text == "")
                    || (txt_idaFinal2.Text == "") || (txt_idaInicial3.Text == "") || (txt_idaFinal3.Text == "") || (txt_idaVoltaInicial.Text == "") || (txt_idaVoltaFinal.Text == "") || (txt_idaInicial2.Text == "")
                    || (txt_idaVoltaFinal2.Text == "") || (txt_idaInicial3.Text == "") || (txt_idaVoltaFinal3.Text == "") || (txt_peixeUrbanoInicial.Text == "") || (txt_peixeUrbanoFinal.Text == "")
                    || (txt_peixeUrbanoInicial2.Text == "") || (txt_peixeUrbanoFinal2.Text == ""))
            {
                MessageBox.Show("Preencha os campos em branco", "Atenção");
            }

            else
            {


                SalvarAbertura salvar = new SalvarAbertura();

                if (rdbP1.Checked)
                {
                    SalvarAbertura salve = new SalvarAbertura();
                    AberturaCaixa p1 = new AberturaCaixa();

                    p1.Nome_operadorAbertura = cbbOperador.Text;
                    p1.DataAbertura = msk_data.Text;
                    p1.CodigoAbertura = txt_codigo.Text;
                    p1.TrocoAbertura = int.Parse(txt_troco.Text);
                    p1.BilheteIdaIni1Abertura = int.Parse(txt_idaInicial.Text);
                    p1.BilheteIdaFin1Abertura = int.Parse(txt_idaFinal.Text);
                    p1.BilheteIdaIni2Abertura = int.Parse(txt_idaInicial2.Text);
                    p1.BilheteIdaFin2Abertura = int.Parse(txt_idaFinal2.Text);
                    p1.BilheteIdaIni3Abertura = int.Parse(txt_idaInicial3.Text);
                    p1.BilheteIdaFin3Abertura = int.Parse(txt_idaFinal3.Text);
                    p1.BilheteVoltaIni1Abertura = int.Parse(txt_idaVoltaInicial.Text);
                    p1.BilheteVoltaFin1Abertura = int.Parse(txt_idaVoltaFinal.Text);
                    p1.BilheteVoltaIni2Abertura = int.Parse(txt_idaVoltaInicial2.Text);
                    p1.BilheteVoltaFin2Abertura = int.Parse(txt_idaVoltaFinal2.Text);
                    p1.BilheteVoltaIni3Abertura = int.Parse(txt_idaVoltaInicial3.Text);
                    p1.BilheteVoltaFin3Abertura = int.Parse(txt_idaVoltaFinal3.Text);
                    p1.BilhetePUIni1Abertura = int.Parse(txt_peixeUrbanoInicial.Text);
                    p1.BilhetePUfin1Abertura = int.Parse(txt_peixeUrbanoFinal.Text);
                    p1.BilhetePUIni2Abertura = int.Parse(txt_peixeUrbanoInicial2.Text);
                    p1.BilhetePUfin2Abertura = int.Parse(txt_peixeUrbanoFinal2.Text);

                    salve.salvarAbertura1(p1);
                }
                else if (rdbP2.Checked)
                {
                    SalvarAbertura salve2 = new SalvarAbertura();
                    AberturaCaixa p2 = new AberturaCaixa();
                    p2.Nome_operadorAbertura = cbbOperador.Text;
                    p2.DataAbertura = msk_data.Text;
                    p2.CodigoAbertura = txt_codigo.Text;
                    p2.TrocoAbertura = int.Parse(txt_troco.Text);
                    p2.BilheteIdaIni1Abertura = int.Parse(txt_idaInicial.Text);
                    p2.BilheteIdaFin1Abertura = int.Parse(txt_idaFinal.Text);
                    p2.BilheteIdaIni2Abertura = int.Parse(txt_idaInicial2.Text);
                    p2.BilheteIdaFin2Abertura = int.Parse(txt_idaFinal2.Text);
                    p2.BilheteIdaIni3Abertura = int.Parse(txt_idaInicial3.Text);
                    p2.BilheteIdaFin3Abertura = int.Parse(txt_idaFinal3.Text);
                    p2.BilheteVoltaIni1Abertura = int.Parse(txt_idaVoltaInicial.Text);
                    p2.BilheteVoltaFin1Abertura = int.Parse(txt_idaVoltaFinal.Text);
                    p2.BilheteVoltaIni2Abertura = int.Parse(txt_idaVoltaInicial2.Text);
                    p2.BilheteVoltaFin2Abertura = int.Parse(txt_idaVoltaFinal2.Text);
                    p2.BilheteVoltaIni3Abertura = int.Parse(txt_idaVoltaInicial3.Text);
                    p2.BilheteVoltaFin3Abertura = int.Parse(txt_idaVoltaFinal3.Text);
                    p2.BilhetePUIni1Abertura = int.Parse(txt_peixeUrbanoInicial.Text);
                    p2.BilhetePUfin1Abertura = int.Parse(txt_peixeUrbanoFinal.Text);
                    p2.BilhetePUIni2Abertura = int.Parse(txt_peixeUrbanoInicial2.Text);
                    p2.BilhetePUfin2Abertura = int.Parse(txt_peixeUrbanoFinal2.Text);

                    salve2.salvarAbertura2(p2);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            hour = Convert.ToInt16(DateTime.Now.Minute);
            msk_data.Text = Convert.ToString(DateTime.Now);

        }
    }
}
