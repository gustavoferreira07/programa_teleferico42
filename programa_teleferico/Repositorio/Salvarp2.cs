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
    class Salvarp2
    {
        public const string NOME_TABELA = "tbl_p2";
        Conexao conexao = new Conexao();
        SqlCommand comando = new SqlCommand();
     

        public void salvarFechamentop2(Classep2 P2)
        {
            comando.CommandText = "insert into " + NOME_TABELA + " values('" + P2.Codigop2 + "','" + P2.Datap2 + "','" + P2.Nome_operadorp2 + "'," + P2.Trocop2 + "," + P2.BilheteIdaIni1p2 +
                "," + P2.BilheteIdaFin1p2 + "," + P2.BilheteIdaIni2p2 + "," + P2.BilheteIdaFin2p2 + ","+P2.BilheteIdaIni3p2+","+P2.BilheteIdaFin3p2+","+ P2.BilheteVoltaIni1p2 + "," + P2.BilheteVoltaFin1p2 + "," + P2.BilheteVoltaIni2p2 + ","+
                P2.BilheteVoltaIni3p2+","+P2.BilheteVoltaFin3p2+","+P2.BilheteVoltaFin2p2 + "," + P2.BilhetePUIni1p2 + "," + P2.BilhetePUfin1p2 + "," + P2.BilhetePUIni2p2 + "," +
                P2.BilhetePUfin2p2 + "," + P2.TotalVendaIdap2 + "," + P2.TotalDinheiroIdap2 + "," + P2.TotalVendaVoltap2 + "," +
                P2.TotalDinheiroVoltap2 + "," + P2.TotalVendaPUp2 + "," + P2.TotalDebitop2 + "," + P2.TotalCreditop2 + "," +
                P2.TotalCartaop2 + "," + P2.TotalDinheiroVendasp2 + "," + P2.Trouxep2 + "," + P2.Sangriap2 + "," + P2.TotalCaixap2 +",'"+P2.Verificap2+ "','"+P2.TotalTrazerp2+"','"+P2.TotalTrouxep2+"')";


            comando.Connection = conexao.ConectarBD();

            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Fechamento salvo com sucesso!", "Informação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                     

            }
            catch (Exception e)
            {
                MessageBox.Show("Falha ao Salvar Fechamento. \n Detalhesdo Erro:" + e);
            }
            //Desconectar pela ultima vez
            conexao.DesconectarBD();
        }
    }
}
