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
    class SalvarAbertura
    {

        Conexao conexao = new Conexao();
        SqlCommand comando = new SqlCommand();

        public void salvarAbertura1(AberturaCaixa p1)
        {
            comando.CommandText = "insert into tbl_aberturap1 values('" + p1.CodigoAbertura + "','" + p1.Nome_operadorAbertura + "','" + p1.DataAbertura + "'," + p1.TrocoAbertura + "," + p1.BilheteIdaIni1Abertura + "," + p1.BilheteIdaFin1Abertura +
                "," + p1.BilheteIdaIni2Abertura + "," + p1.BilheteIdaFin2Abertura + "," + p1.BilheteIdaIni3Abertura + "," + p1.BilheteIdaFin3Abertura + ","
                + p1.BilheteVoltaIni1Abertura + "," + p1.BilheteVoltaFin1Abertura + "," + p1.BilheteVoltaIni2Abertura + "," + p1.BilheteVoltaFin2Abertura + "," + p1.BilheteVoltaIni3Abertura + "," + p1.BilheteVoltaFin3Abertura + "," + p1.BilhetePUIni1Abertura + "," + p1.BilhetePUfin1Abertura + "," + p1.BilhetePUIni2Abertura + "," + p1.BilhetePUfin2Abertura + ")";


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

        public void salvarAbertura2(AberturaCaixa p2)
        {
            comando.CommandText = "insert into tbl_aberturap2 values('" + p2.CodigoAbertura + "','" + p2.Nome_operadorAbertura + "','" + p2.DataAbertura + "'," + p2.TrocoAbertura + "," + p2.BilheteIdaIni1Abertura + "," + p2.BilheteIdaFin1Abertura +
                "," + p2.BilheteIdaIni2Abertura + "," + p2.BilheteIdaFin2Abertura + "," + p2.BilheteIdaIni3Abertura + "," + p2.BilheteIdaFin3Abertura + ","
                + p2.BilheteVoltaIni1Abertura + "," + p2.BilheteVoltaFin1Abertura + "," + p2.BilheteVoltaIni2Abertura + "," + p2.BilheteVoltaFin2Abertura + "," + p2.BilheteVoltaIni3Abertura + "," + p2.BilheteVoltaFin3Abertura + "," + p2.BilhetePUIni1Abertura + "," + p2.BilhetePUfin1Abertura + "," + p2.BilhetePUIni2Abertura + "," + p2.BilhetePUfin2Abertura + ")";


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