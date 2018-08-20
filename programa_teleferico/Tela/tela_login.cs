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
    public partial class tela_login : Form
    {
        public tela_login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand("select * from tbl_login where" +
           " nm_usuario=@usu and ds_senha=@senha ", con.ConectarBD());
            cmd.Parameters.Add("@usu", SqlDbType.VarChar).Value = txtUsu.Text;
            cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = txtSenha.Text;
           
            dr = cmd.ExecuteReader();



            if (dr.HasRows)
            {
               MetroMessageBox.Show(this,"Login efetuado com sucesso !","Bem vindo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tela_menu frm = new tela_menu();
                frm.Show();
                this.Hide();


            }

            else
                MetroMessageBox.Show(this,"Senha ou Usuario Incorretos!", "Incorreto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtSenha.Clear();
        }

        private void tela_login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tela_AlterarSenha tela = new tela_AlterarSenha(txtUsu.Text);
            tela.Show();
        }
    }
}
