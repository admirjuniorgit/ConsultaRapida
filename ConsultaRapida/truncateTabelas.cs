using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConsultaRapida
{
    public partial class truncateTabelas : Form
    {
        public truncateTabelas()
        {
            InitializeComponent();
            txtNomeBanco.Focus();
        }
        string USER;
        string SENHA;
        string IP;
        public truncateTabelas(string ip, string user, string senha)
        {
            InitializeComponent();
            USER = user;
            SENHA = senha;
            IP = ip;
        }
        private void carregarTabelas()
        {
            try
            {
                string banco = txtNomeBanco.Text;

                string strconexao = "Data Source=" + IP + ",1433; Initial Catalog = " + banco + "; User Id=" + USER + "; pwd = " + SENHA + "; "; ;
                SqlConnection con = new SqlConnection(strconexao);

                string sql = "select * from information_schema.tables";
                SqlCommand comm = new SqlCommand(sql, con);
                con.Open();
                comm.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(comm);
                DataTable tabelas = new DataTable();
                da.Fill(tabelas);
                listBox1.DataSource = tabelas;

                listBox1.DisplayMember = "TABLE_NAME";
                listBox1.ValueMember = "TABLE_NAME";
                con.Close();

            }
            catch
            {

                MessageBox.Show("Banco não encontrado, verifique se o nome do campo está escrito corretamente.");
            }


        }
        private void btn_Todos_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeBanco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                carregarTabelas();
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("DROP TABLE " + listBox1.Text.ToString() + " ");

        }

        private void truncateTabelas_Load(object sender, EventArgs e)
        {

        }
        
        private void apagarMultiplasTabelas()
        {
            
            foreach (var item in listBox2.Items)
            {
                string lista = item.ToString();

                try
                {
                    string banco = txtNomeBanco.Text;
                    string strconexao = "Data Source=" + IP + ",1433; Initial Catalog = " + banco + "; User Id=" + USER + "; pwd = " + SENHA + "; "; ;
                    using (SqlConnection con = new SqlConnection(strconexao))
                    {

                        StringBuilder sql = new StringBuilder();


                        sql.AppendFormat(@"" + lista);

                        con.Open();

                        using (SqlCommand comm = new SqlCommand(sql.ToString(), con))
                        {
                            comm.ExecuteNonQuery();


                        }
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
           

        }
        private void btn_Truncate_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja eliminar todas tabelas da lista?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {

                try
                {
                    apagarMultiplasTabelas();
                    MessageBox.Show("Todas as tabelas listadas foram eliminadas!");
                    listBox2.Items.Clear();
                    carregarTabelas();
                    
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não é possível maximizar a tela!");
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não é possível minimizar a tela no momento!");
        }

        private void btnClipBoard_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count > 0)
            {
                Clipboard.SetText(string.Join(Environment.NewLine, listBox2.Items.OfType<string>()));
                MessageBox.Show("Copia da lista efetuada com sucesso!");
            }
            else
            {
                MessageBox.Show("O Listbox precisa ter dados para copiar");
            }

        }

        private void btnClipBoard_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnClipBoard, "Clique aqui para copiar os itens listados para área de transferência");
        }

        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnClear, "Clique aqui para limpar a listagem de drop");
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnDelete, "Clique aqui para executar o drop de todas as tabelas selecionadas");
        }
    }
}
