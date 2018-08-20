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
    class Listar_avulso
    {
        Conexao conexao = new Conexao();
        public DataSet listarAvulso()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("select * from tbl_funcionario order by nome_func asc", conexao.ConectarBD());
            da.Fill(ds);
            conexao.DesconectarBD();
            return ds;
        }
    }
}
