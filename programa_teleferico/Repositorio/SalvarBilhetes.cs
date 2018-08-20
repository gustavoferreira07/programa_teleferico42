using programa_teleferico.Controlador;
using programa_teleferico.Tela;
using programa_teleferico.Utilitatio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa_teleferico.Repositorio
{
    class SalvarBilhetes
    {
        public const string NOME_TABELA = "tbl_atualiza";

        Conexao conexao = new Conexao();
        SqlCommand comando = new SqlCommand();
       

       public void salvarBilhetes(Bilhetes bilhetes)
        {
            comando.CommandText = "insert into " + NOME_TABELA + " values('" + bilhetes.Tipo_bilhetes + "'," + bilhetes.Qtde_bilhetes + ")";


            comando.Connection = conexao.ConectarBD();

            try
            {

                comando.ExecuteNonQuery();
                MessageBox.Show("Salvo com sucesso!", "Informação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception e)
            {
                MessageBox.Show("Falha ao cadastrar bilhetes. \n Detalhesdo Erro:" + e.Message);

            }
            //Desconectar pela ultima vez
            conexao.DesconectarBD();
        }
       
        
        }

    }

