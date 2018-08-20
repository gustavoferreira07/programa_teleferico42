using programa_teleferico.Controlador;
using programa_teleferico.Utilitatio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa_teleferico.Repositorio
{
    class SalvarAvulso
    {
        Conexao conexao = new Conexao();
        SqlCommand comando = new SqlCommand();

        public void salvarAvulso(Avulso avulso)
        {
            comando.CommandText = "insert into tbl_funcionario values('" + avulso.Nome + "','" + avulso.Cpf + "','" + avulso.Celular+ "','"+avulso.Endereço+"','" + avulso.Banco+ "','" + avulso.Agencia + "','" +avulso.Conta + "','"+avulso.Tipo+"')";


            comando.Connection = conexao.ConectarBD();

            try
            {

                comando.ExecuteNonQuery();
                MessageBox.Show("Salvo com sucesso!", "Informação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception e)
            {
                MessageBox.Show("Falha ao Cadastrar Avulso. \n Detalhesdo Erro:" + e.Message);

            }
            //Desconectar pela ultima vez
            conexao.DesconectarBD();
        }
    }
}
