using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa_teleferico.Utilitatio
{
    class Conexao
    {


        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=db_teleferico;Integrated Security=True");

        public SqlConnection ConectarBD()
        {

            try
            {
                con.Open();

            }
            catch (Exception e)
            {
                MessageBox.Show("Falha ao conectar.\nDetalhes do erro: " + e);
            }
            return con;
        }

        public SqlConnection DesconectarBD()
        {
            try
            {
                con.Close();
                //MessageBox.Show("Desconectado com sucesso!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Falha ao desconectar.\nDetalhes do erro: " + e);
            }
            return con;
        }


        public void ChecarSetiveAberFecha()
        {
            try {
                if (con != null && con.State != System.Data.ConnectionState.Closed)
                {
                    DesconectarBD();
                }
            }
            catch
            {

            }
        }
    }
}
