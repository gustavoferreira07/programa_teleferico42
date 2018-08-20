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
using programa_teleferico.Repositorio;
using System.Data.SqlClient;
using programa_teleferico.Utilitatio;

namespace programa_teleferico.Tela
{
    public partial class tela_consulta_avulso : Form
    {
        public tela_consulta_avulso()
        {
            InitializeComponent();
        }
        public string cpf;
       
        Conexao conexao = new Conexao();
        string nomeFunc;
        SqlCommand comando = new SqlCommand();
       

        private void tela_consulta_avulso_Load(object sender, EventArgs e)
        {
            Listar_avulso listar_tabelas = new Listar_avulso();
            DataSet ds = new DataSet();
            ds = listar_tabelas.listarAvulso();
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "Nome ";
            dataGridView1.Columns[1].HeaderText = "CPF";
            dataGridView1.Columns[2].HeaderText = "Contato";
            dataGridView1.Columns[3].HeaderText = "Endereço";
            dataGridView1.Columns[4].HeaderText = "Banco";
            dataGridView1.Columns[5].HeaderText = "Agência";
            dataGridView1.Columns[6].HeaderText = "Conta";
            dataGridView1.Columns[7].HeaderText = "Tipo de contrato";
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cpf = (dataGridView1.Rows[e.RowIndex].Cells["cpf_func"].Value).ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nomeFunc = (dataGridView1.Rows[e.RowIndex].Cells["nome_func"].Value).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("select * from tbl_funcionario where nome_func=@nome", conexao.ConectarBD());
            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nomeFunc;
            dr = cmd.ExecuteReader();

            if (dr.HasRows == false)
            {

                MessageBox.Show("Funcionário não encontrado!", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                conexao.DesconectarBD();
            }
            else
            {
                if (MessageBox.Show("Tem certeza que deseja apagar Funcionário  " + nomeFunc + "? , ele será excluído do banco permanentemente", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    comando.Connection = conexao.DesconectarBD();
                    comando.Connection = conexao.ConectarBD();
                    comando.CommandText = "delete from tbl_funcionario where nome_func= '" + nomeFunc + "'";

                    try
                    {

                        comando.ExecuteNonQuery();
                        MessageBox.Show("Funcionário apagado com sucesso !", "Informação",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Listar_avulso listar_tabelas = new Listar_avulso();
                        DataSet ds = new DataSet();
                        ds = listar_tabelas.listarAvulso();
                        dataGridView1.DataSource = ds.Tables[0];
                        dataGridView1.Columns[0].HeaderText = "Nome ";
                        dataGridView1.Columns[1].HeaderText = "CPF";
                        dataGridView1.Columns[2].HeaderText = "Contato";
                        dataGridView1.Columns[3].HeaderText = "Endereço";
                        dataGridView1.Columns[4].HeaderText = "Banco";
                        dataGridView1.Columns[5].HeaderText = "Agência";
                        dataGridView1.Columns[6].HeaderText = "Conta";
                        dataGridView1.Columns[7].HeaderText = "Tipo de contrato";
                        dataGridView1.Refresh();

                    }

                    catch (Exception er)
                    {
                        MessageBox.Show("Falha ao alterado alimento. \n Detalhes do Erro: " + er);
                    }
                    conexao.DesconectarBD();
                    //Desconectar pela ultima vez

                }


            }
        }
    }
}
