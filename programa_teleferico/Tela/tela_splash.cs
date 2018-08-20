using programa_teleferico.Restauracao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace programa_teleferico.Tela
{
    public partial class tela_splash : Form
    {

        RestaurarBD banco = new RestaurarBD();

        public tela_splash()
        {
            InitializeComponent();
            try
            {
                banco.RestaurarDBPadraoCasoNaoExista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        double por;
        private void tmr_por_Tick(object sender, EventArgs e)
        {
            if (por < 100)
            {
                por = por + 2;
                lblPor.Text = por.ToString() + " %";

            }
            else
            {
                tmr_por.Enabled = false;

            }
        }

        private void tmr_telef_Tick(object sender, EventArgs e)
        {

            if (pgbTeleferico.Value < 100)
            {

                pgbTeleferico.Value = pgbTeleferico.Value + 2;

            }
            else
            {
                tmr_telef.Enabled = false;
                this.Visible = false;

                tela_login chama = new tela_login();
                chama.Show();
            }
        }

        private void tela_splash_Load(object sender, EventArgs e)
        {

        }
    }
}
