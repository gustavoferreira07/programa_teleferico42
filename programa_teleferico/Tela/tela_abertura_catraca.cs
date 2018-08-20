using programa_teleferico.Controlador;
using programa_teleferico.Repositorio;
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
using programa_teleferico.Utilitatio;
using System.Data.SqlClient;

namespace programa_teleferico.Tela
{
    public partial class tela_abertura_catraca : Form
    {
        public tela_abertura_catraca()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rdbP1.Checked)
            {
                AberturaCatraca catraca = new AberturaCatraca();
                SalvarCatraca salvar = new SalvarCatraca();

                catraca.Data = msk_dataCatraca.Text;
                catraca.CodigoCatraca = txt_codigoCatraca.Text;
                catraca.NomeCatraca = cbbOperador.Text;
                catraca.InicialCatraca = int.Parse(txtInicialCatraca.Text);

                salvar.salvarCatraca(catraca);
            }
            else if (rdbP2.Checked)
            {
                AberturaCatraca catraca = new AberturaCatraca();
                SalvarCatraca salvar = new SalvarCatraca();


                catraca.CodigoCatraca = txt_codigoCatraca.Text;
                catraca.NomeCatraca = cbbOperador.Text;
                catraca.InicialCatraca = int.Parse(txtInicialCatraca.Text);

                salvar.salvarCatraca2(catraca);
            }
        }

        private void tela_abertura_catraca_Load(object sender, EventArgs e)
        {
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
            String scom = "select * from tbl_funcionario order by nome_func";
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if ((txt_codigoCatraca.Text == "") || (txtInicialCatraca.Text == "") || (msk_dataCatraca.Text == "") || (cbbOperador.Text == ""))
            {
                MessageBox.Show("Insira todos os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (rdbP1.Checked)
                {
                    AberturaCatraca catraca = new AberturaCatraca();
                    SalvarCatraca salvar = new SalvarCatraca();

                    catraca.Data = msk_dataCatraca.Text;
                    catraca.CodigoCatraca = txt_codigoCatraca.Text;
                    catraca.NomeCatraca = cbbOperador.Text;
                    catraca.InicialCatraca = int.Parse(txtInicialCatraca.Text);

                    salvar.salvarCatraca(catraca);
                }
                else if (rdbP2.Checked)
                {
                    AberturaCatraca catraca = new AberturaCatraca();
                    SalvarCatraca salvar = new SalvarCatraca();


                    catraca.CodigoCatraca = txt_codigoCatraca.Text;
                    catraca.NomeCatraca = cbbOperador.Text;
                    catraca.InicialCatraca = int.Parse(txtInicialCatraca.Text);

                    salvar.salvarCatraca2(catraca);
                }
            }
        }
    }
}