using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ConsultaRapida
{
    public partial class ScriptSQL : Form
    {
        string user = "";
        string senha = "";
        string ip = "";
        string porta = "";
        string banco = "";
            
        public ScriptSQL()
        {
            InitializeComponent();
        }
        

        public ScriptSQL(string USER, string SENHA, string IP, string PORTA,string BANCO)
        {
            InitializeComponent();
             user = USER;
             senha = SENHA;
             ip = IP;
             porta = PORTA;
            banco = BANCO;
            Text = banco;
        }
        private void selecionarArquivo()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Scripts SQL| *.sql;*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtScript.Text = ofd.FileName;
               txtConteudo.Text= File.ReadAllText(@""+txtScript.Text);
                txtConteudo.ForeColor = Color.Black;
            }
        }
        private void btnBuscaScript_Click(object sender, EventArgs e)
        {
            selecionarArquivo();            
        }

        private void btnExecutarScript_Click(object sender, EventArgs e)
        {
            txtConteudo.ForeColor = Color.Black;
            if (txtScript.Text != "")
            {
                if (lbBanco.Text != "")
                {
                    try
                    {
                        ExecutarScriptSQL();
                        MessageBox.Show("Script executado com sucesso!");

                        txtConteudo.ForeColor = Color.Blue;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        txtConteudo.ForeColor = Color.Red;
                    }
                                        
                }
                else
                {
                    MessageBox.Show("Para executar o script SQL você precisa selecionar o banco, clique duas vezes no banco desejado.");
                }

            }
            else
            {
                MessageBox.Show("Selecione o arquivo SQL antes de executar!");
            }
        }

        private void ScriptSQL_Load(object sender, EventArgs e)
        {

        }
        private void ExecutarScriptSQL()
        {

            string strconexao = "Data Source=" + ip + ","+porta+";" + "Initial Catalog=" + banco + ";" + "User Id=" + user + " ; pwd=" + senha + ";"; ;
            try
            {
                string script = File.ReadAllText(txtScript.Text);

                // dividir script no comando "GO"
                System.Collections.Generic.IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$",
                                         RegexOptions.Multiline | RegexOptions.IgnoreCase);
                using (SqlConnection connection = new SqlConnection(strconexao))
                {
                    connection.Open();
                    foreach (string commandString in commandStrings)
                    {
                        if (commandString.Trim() != "")
                        {
                            using (var command = new SqlCommand(commandString, connection))
                            {
                                try
                                {
                                    command.ExecuteNonQuery();

                                }
                                catch (SqlException ex)
                                {
                                    string spError = commandString.Length > 100 ? commandString.Substring(0, 100) + " ...\n..." : commandString;
                                    MessageBox.Show(string.Format("Verifique o script SqlServer.\nFile: {0} \nLine: {1} \nError: {2} \nSQL Command: \n{3}", txtScript.Text, ex.LineNumber, ex.Message, spError), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                }
                            }
                        }
                    }
                    connection.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não é possível maximizar a tela no momento!");
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não é possível minimizar a tela no momento!");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
