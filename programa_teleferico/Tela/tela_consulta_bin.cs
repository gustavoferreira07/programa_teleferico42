using programa_teleferico.Utilitatio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace programa_teleferico.Tela
{
    public partial class tela_consulta_bin : MetroForm
    {
        public tela_consulta_bin()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
        }

        private void tela_consulta_bin_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string data;
            SqlDataReader dr;
            data = dtCartao.Text;
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand("select * from tbl_p2 where dt_fechammentop2=@data", con.ConectarBD());
            cmd.Parameters.Add("@data", SqlDbType.VarChar).Value = dtCartao.Text;
            dr = cmd.ExecuteReader();
            if (dr.HasRows == false)
            {
                MessageBox.Show("Não houve nenhuma venda neste dia !");
            }
            else
                if (rdtDebito.Checked)
                {
                    while (dr.Read())
                    {
                        txtValorTotal.Text = dr[21].ToString();
                    }
                    con.DesconectarBD();
                    con.ConectarBD();
                    con.DesconectarBD();
                }
                else if (rdbCredito.Checked)
                {
                    while (dr.Read())
                        txtValorTotal.Text = dr[22].ToString();
                    con.DesconectarBD();
                    con.ConectarBD();
                    con.DesconectarBD();
                }
                else if (rdbTodos.Checked)
                {
                    while (dr.Read())
                        txtValorTotal.Text = dr[23].ToString();
                    con.DesconectarBD();
                    con.ConectarBD();
                    con.DesconectarBD();

                }
                else
                    MessageBox.Show("Preencha todos os campos necessários !");
             
        }                     
        }
    }

