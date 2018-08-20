using programa_teleferico.Utilitatio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace programa_teleferico.Tela
{
    class Listar_tabelas_plataformas
    {       
        Conexao conexao = new Conexao();
        public DataSet listarTodos()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("select * from tbl_p1;select * from tbl_p2", conexao.ConectarBD());
            da.Fill(ds);
            conexao.DesconectarBD();
            return ds;
        }    
     
        }
    
    }

