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
    class SalvarCatraca
    {
        public const string NOME_TABELA = "tbl_aberturaCatracap1";

        Conexao conexao = new Conexao();
        SqlCommand comando = new SqlCommand();

        public void salvarCatraca(AberturaCatraca catraca)
        {
            comando.CommandText = "insert into " + NOME_TABELA + " values('" + catraca.CodigoCatraca + "','" +catraca.NomeCatraca+ "','"+catraca.Data+ "'," +catraca.InicialCatraca + ")";


            comando.Connection = conexao.ConectarBD();

            try
            {

                comando.ExecuteNonQuery();
                MessageBox.Show("Salvo com sucesso!", "Informação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception e)
            {
                MessageBox.Show("Falha ao Salvar Abertura. \n Detalhesdo Erro:" + e.Message);

            }
            //Desconectar pela ultima vez
            conexao.DesconectarBD();
        }

        public void salvarCatraca2(AberturaCatraca catraca)
        {
            comando.CommandText = "insert into tbl_aberturaCatracap2 values('" + catraca.CodigoCatraca + "','" + catraca.NomeCatraca + "','" + catraca.Data + "'," + catraca.InicialCatraca + ")";


            comando.Connection = conexao.ConectarBD();

            try
            {

                comando.ExecuteNonQuery();
                MessageBox.Show("Salvo com sucesso!", "Informação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception e)
            {
                MessageBox.Show("Falha ao Salvar Abertura. \n Detalhesdo Erro:" + e.Message);

            }
            //Desconectar pela ultima vez
            conexao.DesconectarBD();
        }
    }
}
