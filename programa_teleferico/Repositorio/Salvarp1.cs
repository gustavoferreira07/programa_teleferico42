using programa_teleferico.Controlador;
using programa_teleferico.Tela;
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
    class Salvarp1
    {
        public const string NOME_TABELA = "tbl_p1";
        Conexao conexao = new Conexao();
        SqlCommand comando = new SqlCommand();
      

        public void salvarFechamento(Classep1 P1)
        {
            comando.CommandText = "insert into " + NOME_TABELA + " values('" + P1.Codigo + "','" + P1.Data + "','" + P1.Nome_operador  +"','" + P1.Troco + "','" + P1.BilheteIdaIni1 +
                "','" + P1.BilheteIdaFin1 + "','" + P1.BilheteIdaIni2 + "','" + P1.BilheteIdaFin2 + "',"+P1.BilheteIdaIni3+","+P1.BilheteIdaFin3+","+ P1.BilheteVoltaIni1 + "," + P1.BilheteVoltaFin1 + "," + P1.BilheteVoltaIni2 + ","+
                P1.BilheteVoltaFin2 + ","+P1.BilheteVoltaIni3+","+P1.BilheteVoltaFin3+","+ P1.BilhetePUIni1 + "," + P1.BilhetePUfin1 + "," + P1.BilhetePUIni2 + "," +
                P1.BilhetePUfin2 + "," + P1.TotalVendaIda + "," + P1.TotalDinheiroIda + "," + P1.TotalVendaVolta + "," +
                P1.TotalDinheiroVolta + "," + P1.TotalVendaPU + "," + P1.TotalDebito + "," + P1.TotalCredito + "," +
                P1.TotalCartao + "," + P1.TotalDinheiroVendas + "," + P1.Trouxe + "," + P1.Sangria + "," + P1.TotalCaixa+",'"+P1.Verificap1+"','"+P1.TotalTrazer+"','"+P1.TotalTrouxe+"')";


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
