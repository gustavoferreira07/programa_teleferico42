using programa_teleferico.Utilitatio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_teleferico.Repositorio
{
    class Listar_tabelas_catraca
    {
        Conexao conexao = new Conexao();
        public DataSet listarTodos()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("select * from tbl_fechamentoCatracap1;select * from tbl_fechamentoCatracap2", conexao.ConectarBD());
            da.Fill(ds);
            conexao.DesconectarBD();
            return ds;
        }
    }
}
