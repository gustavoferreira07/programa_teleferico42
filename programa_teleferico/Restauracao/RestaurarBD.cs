using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa_teleferico.Restauracao
{
    class RestaurarBD
    {

        //METODO QUE AUTOMATIZA TUDO E RESTAURA O BANCO

        public void RestaurarDBPadraoCasoNaoExista()
        {
            try
            {
                var bancoExiste = VerificaSeBancoJaExiste();


                if (!bancoExiste)
                {
                    RestaurarDBPadrao();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }







        //MÉTODO QUE VEFICA SE EXISTE O BANCO DESEJADO NA MAQUINA
        private bool VerificaSeBancoJaExiste()
        {
            bool retorno = false;

            try
            {
                using (var conn = new System.Data.SqlClient.SqlConnection(@"Server=.\SQLEXPRESS;Database=master;Trusted_Connection=True;"))
                {
                    conn.Open();
                    using (var comm = conn.CreateCommand())
                    {
                        comm.CommandText = "SELECT 1 FROM SYS.DATABASES WHERE NAME LIKE 'db_teleferico'";
                        var valor = comm.ExecuteScalar();

                        if (valor != null && valor != DBNull.Value && Convert.ToInt32(valor).Equals(1))
                        {

                            retorno = true;

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return retorno;
        }


        //METODO QUE DESCOBRE O DIRETORIO PADRAO DE BACKUP DO SQL
        private void DescobrirDiretoriosPadrao(out string diretorioDados, out string diretorioLog, out string diretorioBackup)
        {
            using (var connection = new System.Data.SqlClient.SqlConnection(@"Server=.\SQLEXPRESS;Database=master;Trusted_Connection=True;"))
            {
                var serverConnection = new Microsoft.SqlServer.Management.Common.ServerConnection(connection);
                var server = new Microsoft.SqlServer.Management.Smo.Server(serverConnection);
                diretorioDados = !string.IsNullOrWhiteSpace(server.Settings.DefaultFile) ? server.Settings.DefaultFile : (!string.IsNullOrWhiteSpace(server.DefaultFile) ? server.DefaultFile : server.MasterDBPath);
                diretorioLog = !string.IsNullOrWhiteSpace(server.Settings.DefaultLog) ? server.Settings.DefaultLog : (!string.IsNullOrWhiteSpace(server.DefaultLog) ? server.DefaultLog : server.MasterDBLogPath);
                diretorioBackup = !string.IsNullOrWhiteSpace(server.Settings.BackupDirectory) ? server.Settings.BackupDirectory : server.BackupDirectory;
            }
        }





        //METODO QUE CRIA O BANCO DE DADOS AUTOMATICAMENTE CASO ELE NAO EXISTA!
        private void RestaurarDBPadrao()
        {
            try
            {
                string diretorioDados, diretorioLog, diretorioBackup;
                DescobrirDiretoriosPadrao(out diretorioDados, out diretorioLog, out diretorioBackup);

                using (var conn = new System.Data.SqlClient.SqlConnection(@"Server=.\SQLEXPRESS;Database=master;Trusted_Connection=True;"))
                {
                    conn.Open();
                    using (var comm = conn.CreateCommand())
                    {
                        var caminhoCompletoBackup = System.IO.Path.Combine(diretorioBackup, "DBteleferico.bak");
                        var caminhoCompletoDados = System.IO.Path.Combine(diretorioDados, "db_teleferico.mdf");
                        var caminhoCompletoLog = System.IO.Path.Combine(diretorioLog, "db_teleferico.ldf");
                        System.IO.File.Copy("DBteleferico.bak", caminhoCompletoBackup, true);
                        comm.CommandText =
                            @"RESTORE DATABASE db_teleferico " +
                            @"FROM DISK = N'" + caminhoCompletoBackup + "' " +
                            @"WITH FILE = 1, " +
                            @"MOVE N'db_teleferico' TO N'" + caminhoCompletoDados + "', " +
                            @"MOVE N'db_teleferico_LOG' TO N'" + caminhoCompletoLog + "', " +
                            @"NOUNLOAD, REPLACE, STATS = 10";
                        comm.ExecuteNonQuery();
                        MessageBox.Show("Restaurado com sucesso!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
