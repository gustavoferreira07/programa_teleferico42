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

namespace programa_teleferico.Tela
{
    public partial class tela_AlterarSenha : Form
    {

        String usuL;
        public tela_AlterarSenha(String usu)
        {
            InitializeComponent();
            this.usuL = usu;
        }
        public tela_AlterarSenha()
        {
            InitializeComponent();
        }

        SqlCommand comando = new SqlCommand();
        Conexao conexao = new Conexao();



        private void btnAlterar_Click(object sender, EventArgs e)
        {
           
            }
    
            

        private void tela_AlterarSenha_Load(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            comando.CommandType = CommandType.Text;

            SqlDataReader dr2;
            SqlCommand cmdo = new SqlCommand("select * from tbl_login where nm_usuario=@usu ", conexao.ConectarBD());
            cmdo.Parameters.Add("@usu", SqlDbType.VarChar).Value = txtUsu.Text;
            dr2 = cmdo.ExecuteReader();
            try
            {
                if (dr2.HasRows == true)
                {
                    conexao.DesconectarBD();
                    SqlCommand cmdSelect = new SqlCommand("select * from tbl_login where nm_usuario=@usu1", conexao.ConectarBD());
                    cmdSelect.Parameters.Add("@usu1", SqlDbType.VarChar).Value = txtUsu.Text;
                    DataSet ds = new DataSet();
                    SqlDataAdapter sqlda = new SqlDataAdapter(cmdSelect);
                    sqlda.Fill(ds, "tbl_login");
                    //"select '" + txtSenhaAtual.Text + "' from tbl_login where nm_usuario=@usu"
                    string senhaconf = ds.Tables["tbl_login"].Rows[0]["ds_senha"].ToString();
                    if (txtSenhaAtual.Text != senhaconf)
                    {
                        MessageBox.Show("A senha antigo não esta correta");
                        txtSenhaAtual.Clear();
                        conexao.DesconectarBD();
                    }

                    else
                    {


                        conexao.DesconectarBD();


                        comando.CommandText = "update tbl_login set nm_usuario=@usu,ds_senha=@senha ";
                        comando.Parameters.Add("@usu", SqlDbType.VarChar).Value = txtUsu.Text;
                        comando.Parameters.Add("@senha", SqlDbType.VarChar).Value = txtNovaSenha.Text;
                        // try
                        // {
                        comando.Connection = conexao.ConectarBD();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Alterado salvo com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conexao.DesconectarBD();
                        this.Close();

                        // }
                        /* catch (Exception ex)
                         {
                             MessageBox.Show("Falha ao inserir. \n Detalhesdo Erro:" + ex);

                         }*/

                    }
                }






                else
                {
                    MessageBox.Show("usuario nao encontrado");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
