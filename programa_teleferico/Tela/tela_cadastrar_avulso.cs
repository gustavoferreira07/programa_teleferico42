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
using programa_teleferico.Controlador;
using programa_teleferico.Repositorio;

namespace programa_teleferico.Tela
{
    public partial class tela_cadastrar_avulso : Form
    {
        public tela_cadastrar_avulso()
        {
            InitializeComponent();
        }

        private void tela_cadastrar_avulso_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbbBanco.Text);
        }

        private void cbbBanco_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            if/* ((txtNome.Text == "") ||*/((mskCpf.Text == "") || (mskCel.Text == "") || (ttEndereco.Text == "") || (cbbBanco.Text == "") || (txtAgencia.Text == "") || (txtConta.Text == ""))
            {
                MessageBox.Show("Preencha todos os campos !", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Avulso avulso = new Avulso();
                SalvarAvulso salvar = new SalvarAvulso();

                avulso.Nome = txtNome.Text;
                avulso.Cpf = mskCpf.Text;
                avulso.Celular = mskCel.Text;
                avulso.Endereço = ttEndereco.Text;
                avulso.Banco = cbbBanco.Text;
                avulso.Agencia = txtAgencia.Text;
                avulso.Conta = txtConta.Text;
                avulso.Tipo = cbbContrato.Text;

                salvar.salvarAvulso(avulso);
            }
        }

        private void cbbBanco_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
