using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Data.SqlClient;
using programa_teleferico.Utilitatio;

namespace programa_teleferico.Tela
{
    public partial class tela_consulta_bilhetes : MetroForm
    {
        public tela_consulta_bilhetes()
        {
            InitializeComponent();
        }

        private void tela_consulta_bilhetes_Load(object sender, EventArgs e)
        {

        }

        private void cbbTipoBilhete_SelectedIndexChanged(object sender, EventArgs e)
        {

          
            SqlDataReader dr;
           
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand("select * from tbl_bilhete where tipo_bilhete=@tipo", con.ConectarBD());
            cmd.Parameters.Add("@tipo", SqlDbType.VarChar).Value = cbbTipoBilhete.Text;
            dr = cmd.ExecuteReader();
            if (dr.HasRows == false)
            {
                MessageBox.Show("Não há bilhetes cadastrados !");
            }
            else
               
                    while (dr.Read())
                    {
                       txtQtde.Text = dr[1].ToString();
                    }
                    con.DesconectarBD();
                    con.ConectarBD();
                    con.DesconectarBD();
              }
        }
    }
