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
    public partial class tela_consulta_total_diario : Form
    {
        tela_fechamento_plataforma1 tela1 = new tela_fechamento_plataforma1();
        tela_fechamento_plataforma2 tela2 = new tela_fechamento_plataforma2();
        Calcular calcular = new Calcular();
        
        public int total1;
        public int total2;
        public int total3;
        public int total4;

        
        
        Conexao conexao = new Conexao();


        public tela_consulta_total_diario()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (rdbP1.Checked)
            {
                SqlDataReader dr;
                Conexao con = new Conexao();
                SqlCommand cmd = new SqlCommand("select * from tbl_p1 where dt_fechammentop1>='" + dtp1.Text + "' and dt_fechammentop1<='" + dtp2.Text + "'", con.ConectarBD());
                dr = cmd.ExecuteReader();
                if (dr.HasRows == false)
                {
                    MessageBox.Show("Não houve nenhuma venda neste dia !");
                }
                else
                {
                    {
                        DataSet ds = new DataSet();
                        ds = pesquisarFechamento();
                        dataGridView1.DataSource = ds.Tables[0];
                        dataGridView1.Columns[4].HeaderText = "Total Vendas P1 R$";
                        dataGridView1.Refresh();

                    }
                    {
                        DataSet ds = new DataSet();
                        ds = pesquisarCartao();
                        dataGridView4.DataSource = ds.Tables[0];
                        dataGridView4.Refresh();
                    }
                }
            }

            else if (rdbP2.Checked)
            {
                SqlDataReader dr;
                Conexao con = new Conexao();
                SqlCommand cmd = new SqlCommand("select * from tbl_p2 where dt_fechammentop2>='" + dtp1.Text + "' and dt_fechammentop2<='" + dtp2.Text + "'", con.ConectarBD());
                dr = cmd.ExecuteReader();
                if (dr.HasRows == false)
                {
                    MessageBox.Show("Não houve nenhuma venda neste dia !");
                }
                else
                {
                    {
                        DataSet ds = new DataSet();
                        ds = pesquisarFechamento2();
                        dataGridView2.DataSource = ds.Tables[0];
                        dataGridView2.Columns[4].HeaderText = "Total Vendas P2 R$";
                        dataGridView2.Refresh();
                    }

                    {
                        DataSet ds = new DataSet();
                        ds = pesquisarCartao2();
                        dataGridView3.DataSource = ds.Tables[0];
                        dataGridView3.Refresh();
                    }
                }

            }
            else if (rdbTodas.Checked)
            {
                {
                    DataSet ds = new DataSet();
                    ds = pesquisarFechamento();
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.Columns[3].HeaderText = "Total Vendas P1 R$";
                    dataGridView1.Refresh();
                }
                {
                    DataSet ds = new DataSet();
                    ds = pesquisarCartao();
                    dataGridView4.DataSource = ds.Tables[0];
                    dataGridView1.Columns[3].HeaderText = "Total Final P1";
                    dataGridView4.Refresh();
                }
                {
                    DataSet ds = new DataSet();
                    ds = pesquisarFechamento2();
                    dataGridView2.DataSource = ds.Tables[0];
                    dataGridView2.Columns[3].HeaderText = "Total Vendas P2 R$";
                    dataGridView2.Refresh();
                }

                {
                    DataSet ds = new DataSet();
                    ds = pesquisarCartao2();
                    dataGridView3.DataSource = ds.Tables[0];
                    dataGridView1.Columns[3].HeaderText = "Total Final P2";
                    dataGridView3.Refresh();
                }
            }
            else
                MessageBox.Show("Selecione a plataforma");
        }
    
        public DataSet pesquisarFechamento()
        {


            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("select dt_fechammentop1,no_total_dinheirop1_ida  ,no_total_dinheriop1_volta ,no_total_dinheirop1_vendas from tbl_p1  where dt_fechammentop1 >='" + dtp1.Text + "' and dt_fechammentop1<='" + dtp2.Text + "'", conexao.ConectarBD());

            da.Fill(ds);
            conexao.DesconectarBD();
            return ds;

        }

       

        public DataSet pesquisarFechamento2()
        {


            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("select dt_fechammentop2,no_total_dinheirop2_ida ,no_total_dinheriop2_volta ,no_total_dinheirop2_vendas  from tbl_p2  where dt_fechammentop2 >='" + dtp1.Text + "' and dt_fechammentop2<='" + dtp2.Text + "'", conexao.ConectarBD());

            da.Fill(ds);
            conexao.DesconectarBD();
            return ds;

        }

        public DataSet pesquisarCartao()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("select dt_fechammentop1,no_total_debitop1 , no_total_creditop1 , no_total_cartaop1  from tbl_p1 where dt_fechammentop1 >='" + dtp1.Text + "' and dt_fechammentop1<='" + dtp2.Text + "'", conexao.ConectarBD());
            da.Fill(ds);
            conexao.DesconectarBD();
            return ds;
                   
        }

        public DataSet pesquisarCartao2()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("select dt_fechammentop2,no_total_debitop2 , no_total_creditop2 , no_total_cartaop2  from tbl_p2 where dt_fechammentop2 >='" + dtp1.Text + "' and dt_fechammentop2<='" + dtp2.Text + "'", conexao.ConectarBD());
            da.Fill(ds);
            conexao.DesconectarBD();
            return ds;
          
        }

        public DataSet pesquisarDinheiro()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("select no_total_debitop1 , no_total_creditop1 , no_total_cartaop1 from tbl_p1 where dt_fechammentop1 >='" + dtp1.Text + "' and dt_fechammentop2<='" + dtp2.Text + "'", conexao.ConectarBD());
            da.Fill(ds);
            conexao.DesconectarBD();
            return ds;
        }
        public DataSet pesquisarDinheiro2()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("select no_total_debitop2 , no_total_creditop2 , no_total_cartaop2 from tbl_p2 where dt_fechammentop2 >='" + dtp1.Text + "' and dt_fechammentop2<='" + dtp2.Text + "'", conexao.ConectarBD());
            da.Fill(ds);
            conexao.DesconectarBD();
            return ds;
        }


        private void tela_consulta_total_diario_Load(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
           

            Calcular1();
            Calcular2();                  
           // calcular.calcularTotal3(dtp1.Text);
            //calcular.calcularTotal4(dtp1.Text);           
             Calcular3();
             Calcular4();
            int totalDinheiroP1 = total1 - total3;
            int totalDinheiroP2 = total2 - total4;
            label6.Text = "RS" + string.Format("{0:N}", totalDinheiroP1);
            label7.Text = "RS" + string.Format("{0:N}", totalDinheiroP2);
            lbltotal.Text = "R$ " + string.Format("{0:N}", total1 + total2);
            lblTotalCartao.Text = "R$" + string.Format("{0:N}", total3 + total4);
            // calcular.total1 = 0;
            // calcular.total2 = 0;
            total1 = 0;
            total2 = 0;
            total3 = 0;
            total4 = 0;

        }

        public void Calcular1() 
            {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total1 = total1 + Convert.ToInt32(row.Cells["no_total_dinheirop1_vendas"].Value);
            }
        }

        public void Calcular2()
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                total2 = total2 + Convert.ToInt32(row.Cells["no_total_dinheirop2_vendas"].Value);
            }
        }
       public void Calcular3()
        {
            foreach (DataGridViewRow row in dataGridView4.Rows)
            {
                total3 = total3 + Convert.ToInt32(row.Cells["no_total_cartaop1"].Value);
            }
        }
        public void Calcular4()
        {
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                total4 = total4 + Convert.ToInt32(row.Cells["no_total_cartaop2"].Value);
            }
        }
    
    }
}
