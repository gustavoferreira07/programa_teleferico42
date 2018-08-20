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
    public partial class tela_fechamento_catraca : Form
    {
        public tela_fechamento_catraca()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //contagem dos giros
            int totalIni = int.Parse(txtInicialCatraca.Text);
            int totalFin = int.Parse(txtFinalCatraca.Text);
            int totalGiro = totalFin - totalIni;
            txtTotalCatraca.Text = totalGiro.ToString();
        
           //logica para soma de bilhete ao numero de giros
            int ida = int.Parse(txtTotalIda.Text);
            int idaVolta = int.Parse(txtTotalIdaVolta.Text);
            int PU = int.Parse(txtTotalPU.Text);
            int cortesia = int.Parse(txtTotalCortesia.Text);
            int totalBilhetes = ida + idaVolta + PU + cortesia;
            int fechamento= totalGiro-totalBilhetes;
            if (fechamento > 0)
            {
                lblFechamento.Text = fechamento + " Giros á mais";
            }
            else if (fechamento < 0)
            {
                lblFechamento.Text = fechamento + " Giros a menos";
            }
            else
                lblFechamento.Text = "Sem erros no fechamento !";
        }

        private void tela_fechamento_catraca_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rdbP1.Checked)
            {
                SalvarFechamentoCatraca salvar = new SalvarFechamentoCatraca();
                FechamentoCatraca ct = new FechamentoCatraca();
                ct.CodigoCatraca = txt_codigoCatraca.Text;
                ct.NomeCatraca = txt_nomeCatraca.Text;
                ct.Data = txtDataCatraca.Text;
                ct.InicialCatraca = int.Parse(txtInicialCatraca.Text);
                ct.FinalCatraca = int.Parse(txtFinalCatraca.Text);
                ct.TotalCatraca = int.Parse(txtTotalCatraca.Text);
                ct.TotalIda = int.Parse(txtTotalIda.Text);
                ct.TotalVolta = int.Parse(txtTotalIdaVolta.Text);
                ct.TotalPU = int.Parse(txtTotalPU.Text);
                ct.TotalCortesia = int.Parse(txtTotalCortesia.Text);
                ct.Relatorio = lblFechamento.Text;


                salvar.salvarFechamentoCatracap1(ct);
            }
            else if (rdbP2.Checked)
            {
                SalvarFechamentoCatraca salvar = new SalvarFechamentoCatraca();
                FechamentoCatraca ct = new FechamentoCatraca();
                ct.CodigoCatraca = txt_codigoCatraca.Text;
                ct.NomeCatraca = txt_nomeCatraca.Text;
                ct.Data = txtDataCatraca.Text;
                ct.InicialCatraca = int.Parse(txtInicialCatraca.Text);
                ct.FinalCatraca = int.Parse(txtFinalCatraca.Text);
                ct.TotalCatraca = int.Parse(txtTotalCatraca.Text);
                ct.TotalIda = int.Parse(txtTotalIda.Text);
                ct.TotalVolta = int.Parse(txtTotalIdaVolta.Text);
                ct.TotalPU = int.Parse(txtTotalPU.Text);
                ct.TotalCortesia = int.Parse(txtTotalCortesia.Text);
                ct.Relatorio = lblFechamento.Text;

                salvar.salvarFechamentoCatracap2(ct);

            }
            else
                MessageBox.Show("Informe a plataforma !","Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rdbP1.Checked)
            {
                string codigo;
                SqlDataReader dr;
                codigo = txt_codigoCatraca.Text;
                Conexao con = new Conexao();
                SqlCommand cmd = new SqlCommand("select * from tbl_aberturaCatracap1 where cd_aberturaCatracap1=@codigo", con.ConectarBD());
                cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = txt_codigoCatraca.Text;
                dr = cmd.ExecuteReader();
                try
                {
                    if (dr.HasRows == false)
                    {
                        MessageBox.Show("Não houve nenhuma Abertura de caixa com este código !");
                        txtInicialCatraca.Clear();
                        txt_nomeCatraca.Clear();
                        txtDataCatraca.Clear();
                    }
                    else
                    {
                        while (dr.Read())
                        {
                            txt_nomeCatraca.Text = dr[1].ToString();
                            txtDataCatraca.Text = dr[2].ToString();
                            txtInicialCatraca.Text = dr[3].ToString();
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
                codigo = txt_codigoCatraca.Text;
                Conexao con = new Conexao();
                SqlCommand cmd = new SqlCommand("select * from tbl_aberturaCatracap2 where cd_aberturaCatracap2=@codigo", con.ConectarBD());
                cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = txt_codigoCatraca.Text;
                dr = cmd.ExecuteReader();
                try
                {
                    if (dr.HasRows == false)
                    {
                        MessageBox.Show("Não houve nenhuma Abertura de caixa com este código !");
                        txtInicialCatraca.Clear();
                        txt_nomeCatraca.Clear();
                        txtDataCatraca.Clear();
                    }
                    else
                    {
                        while (dr.Read())
                        {
                            txt_nomeCatraca.Text = dr[1].ToString();
                            txtDataCatraca.Text = dr[2].ToString();
                            txtInicialCatraca.Text = dr[3].ToString();
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
            else
                MessageBox.Show("Selecione a plataforma !","Atenção");
        }
    }
}
