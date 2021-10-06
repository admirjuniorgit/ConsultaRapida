using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConsultaRapida
{
    public partial class criarBanco : Form
    {
        public criarBanco()
        {
            InitializeComponent();
        }
        string IP;
        string USER;
        string SENHA;

        public criarBanco(string ip, string user, string senha)
        {
            InitializeComponent();
            IP = ip;
            USER = user;
            SENHA = senha;
        }

        private void criarBanco_Load(object sender, EventArgs e)
        {
            txtNomeBanco.Focus();
            txtNomeBanco.Select();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();

        }
        private void CriarBanco()
        {
            try
            {
                string strconexao = "Data Source=" + IP + ",1433; User Id=" + USER + " ; pwd=" + SENHA;
                using (SqlConnection conn = new SqlConnection(strconexao))
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    string sql = "CREATE DATABASE " + "\"" + txtNomeBanco.Text + "\"";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Banco " + txtNomeBanco.Text + " criado com sucesso!");
                        txtNomeBanco.Text = "";

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }
        private void btnCriarBanco_Click(object sender, EventArgs e)
        {
            CriarBanco();
        }

        private void txtNomeBanco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                CriarBanco();
            }
        }
    }
}
