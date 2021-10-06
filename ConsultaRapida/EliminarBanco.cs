using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConsultaRapida
{
    public partial class EliminarBanco : Form
    {

        public EliminarBanco()
        {
            InitializeComponent();

            this.Refresh();

        }
        string USER;
        string SENHA;
        string IP;
        public EliminarBanco(string ip, string user, string senha)
        {
            InitializeComponent();

            USER = user;
            SENHA = senha;
            IP = ip;
        }
        
        private void btn_Dropar_Click(object sender, EventArgs e)
        {

        }
        private void carregarBancos()
        {
            try
            {
                string strconexao = "Data Source=" + IP + ",1433; User Id=" + USER + "; pwd = " + SENHA + "; "; ;
                using (SqlConnection con = new SqlConnection(strconexao))
                {
                    StringBuilder sql = new StringBuilder();

                    sql.AppendFormat(@"select name from sys.databases where name like '%" + textBox1.Text + "%'");

                    con.Open();

                    using (SqlCommand comm = new SqlCommand(sql.ToString(), con))
                    {

                        DataTable tbBanco = new DataTable();

                        comm.CommandType = CommandType.Text;

                        SqlDataAdapter da = new SqlDataAdapter(comm);
                        DataTable tabelas = new DataTable();
                        da.Fill(tabelas);
                        dgvRegistro.DataSource = tabelas;
                        con.Close();
                    }
                }
            }

            catch (Exception)
            {

                throw;
            }
        }
        private void apagarMultiplosBancos()
        {
           
            foreach (var item in listBox1.Items)
            {
                string lista = item.ToString();

                try
                {
                    string strconexao = "Data Source=" + IP + ",1433; User Id=" + USER + "; pwd = " + SENHA + "; "; ;
                    using (SqlConnection con = new SqlConnection(strconexao))
                    {

                        StringBuilder sql = new StringBuilder();


                        sql.AppendFormat(@"" + lista);

                        con.Open();

                        using (SqlCommand comm = new SqlCommand(sql.ToString(), con))
                        {
                            comm.ExecuteNonQuery();

                            carregarBancos();

                        }
                        con.Close();
                        
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Para um banco que esteja em uso, recomendo fechar o aplicativo e abrir novamente, antes de executar essa função");
                    if (DialogResult.Yes == MessageBox.Show("Deseja reiniciar o aplicativo agora?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {
                        Application.Exit();
                        Application.Restart();
                    }

                }
            }

        }
        private void copiartodos()
        {
            var listaParaListView = new List<string>();

            foreach (DataGridViewRow linha in this.dgvRegistro.Rows)
            {
                if (this.dgvRegistro.Rows.IndexOf(linha) == this.dgvRegistro.Rows.Count - 0)
                    break;

                var valor = linha.Cells[0].Value.ToString();
                listaParaListView.Add(valor);
            }

            foreach (var valor in listaParaListView)
                this.listBox1.Items.Add("DROP DATABASE " + "\"" + valor + "\"");
        }
        private void btn_Todos_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            carregarBancos();
            listBox1.Items.Clear();
        }

        private void dgvRegistro_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("DROP DATABASE " + "\"" + dgvRegistro.CurrentRow.Cells["name"].Value.ToString() + "\"");


            dgvRegistro.CurrentCell.Style.BackColor = Color.Yellow;

        }

        private void EliminarBanco_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void dgvRegistro_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvRegistro.SelectedRows.Count > 0)
            {
                int index = dgvRegistro.SelectedRows[0].Index;

                if (index >= 0)
                    dgvRegistro.Rows[index].Selected = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja eliminar todos os bancos da lista?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                timer1.Enabled = true;
                timer1.Start();

                apagarMultiplosBancos();
                MessageBox.Show("Todas as databases listadas foram eliminadas!");
                listBox1.Items.Clear();
                timer1.Stop();
                timer1.Enabled = false;

            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            copiartodos();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnClipBoard_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                Clipboard.SetText(string.Join(Environment.NewLine, listBox1.Items.OfType<string>()));
                MessageBox.Show("Copia da lista efetuada com sucesso!");
            }
            else
            {
                MessageBox.Show("O Listbox precisa ter dados para copiar");
            }

        }

        private void btnTransfer_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnTransfer, "Clique aqui para copiar todos os bancos de uma vez");
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnDelete, "Clique aqui para executar o drop de todos os bancos selecionados");
        }

        private void btnClipBoard_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnClipBoard, "Clique aqui para copiar os itens listados para área de transferência");
        }

        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnClear, "Clique aqui para limpar a listagem de drop");
        }
    }
}
