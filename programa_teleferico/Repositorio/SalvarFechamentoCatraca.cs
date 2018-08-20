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
     class SalvarFechamentoCatraca
    {
        public const string NOME_TABELA = "tbl_fechamentoCatracap1";

        Conexao conexao = new Conexao();
        SqlCommand comando = new SqlCommand();

        public void salvarFechamentoCatracap1(FechamentoCatraca p1)
        {
            comando.CommandText = "insert into " + NOME_TABELA + " values('" + p1.CodigoCatraca + "','" + p1.NomeCatraca + "','" + p1.Data + "'," + p1.InicialCatraca + "," + p1.FinalCatraca + "," + p1.TotalCatraca +
                "," + p1.TotalIda + "," + p1.TotalVolta + "," + p1.TotalPU + "," + p1.TotalCortesia + ",'" + p1.Relatorio + "')";


            comando.Connection = conexao.ConectarBD();

            try
            {

                comando.ExecuteNonQuery();
                MessageBox.Show("Salvo com sucesso!", "Informação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception e)
            {
                MessageBox.Show("Falha ao Salvar Fechamento. \n Detalhesdo Erro:" + e.Message);

            }
            //Desconectar pela ultima vez
            conexao.DesconectarBD();
        }

        public void salvarFechamentoCatracap2(FechamentoCatraca p2)
        {
            comando.CommandText = "insert into tbl_fechamentoCatracap2 values('" + p2.CodigoCatraca + "','" + p2.NomeCatraca + "','" + p2.Data + "'," + p2.InicialCatraca + "," + p2.FinalCatraca + "," + p2.TotalCatraca +
                "," + p2.TotalIda + "," + p2.TotalVolta + "," + p2.TotalPU + "," + p2.TotalCortesia + ",'" + p2.Relatorio + "')";


            comando.Connection = conexao.ConectarBD();

            try
            {

                comando.ExecuteNonQuery();
                MessageBox.Show("Salvo com sucesso!", "Informação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception e)
            {
                MessageBox.Show("Falha ao Salvar Fechamento. \n Detalhesdo Erro:" + e.Message);

            }
            //Desconectar pela ultima vez
            conexao.DesconectarBD();
        }
    }
}
