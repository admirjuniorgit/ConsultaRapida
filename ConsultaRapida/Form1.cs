using EnvDTE;
using System;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

namespace ConsultaRapida
{
    public partial class Form1 : Form
    {
        string VersãoSoftware = "";


        bool isDrag = false;
        int lastY = 0;

        string USER,SENHA,IP,PORTA;

        string pathLOG = @"c:\CR_LOG.mac";

        public Form1()
        {


            InitializeComponent();
            txtPesquisaBanco.Focus();

            //Classe responsável por formatar o design do formulário
            FormatForm.DesignForm(MenuSuperior, btnMinimizar, btnMaximizar, btnFechar, btnConsulta);
        }
       //Recebendo os parâmetros de conexão do banco da tela de login
        public Form1(string user, string senha, string ip, string porta)
        {
            InitializeComponent();
            USER = user;
            SENHA = senha;
            PORTA = porta;
            IP = ip;

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void Releasecapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void _setarVersao()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);

            //colocando os dados da versão do assembly em uma variavel
            VersãoSoftware = fileVersionInfo.ProductVersion;
        }
        protected override void OnResizeBegin(EventArgs e)
        {
            SuspendLayout();
            base.OnResizeBegin(e);
        }
        protected override void OnResizeEnd(EventArgs e)
        {
            ResumeLayout();
            base.OnResizeEnd(e);
        }

        private void Maximizar()
        {
            if (WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }

        }

        public void _criaTabs()
        {
            string consulta = txtConsulta.Text;

            DataGridView grid = new DataGridView();

            //clase responsável por criar as tabpages e o grid dentro da tab
            FormatForm.DesignTab(consulta, tabControl1, grid);

            //função que faz uma query no banco e exibi no grid criado
            _ConsultarDGVtab(grid);

        }
        public void _criaTabsTop1000()
        {
            string consulta = txtConsulta.Text;

            DataGridView grid = new DataGridView();

            //clase responsável por criar as tabpages e o grid dentro da tab
            FormatForm.DesignTab(consulta, tabControl1, grid);

            //função que faz uma query no banco e exibi no grid criado
            _CarregarTOP1000(grid);

        }
        public void _criaTabsTop500()
        {
            string consulta = txtConsulta.Text;

            DataGridView grid = new DataGridView();

            //clase responsável por criar as tabpages e o grid dentro da tab
            FormatForm.DesignTab(consulta, tabControl1, grid);

            //função que faz uma query no banco e exibi no grid criado
            _CarregarTOP500(grid);

        }
        public void _criaTabsTop100()
        {
            string consulta = txtConsulta.Text;

            DataGridView grid = new DataGridView();

            //clase responsável por criar as tabpages e o grid dentro da tab
            FormatForm.DesignTab(consulta, tabControl1, grid);

            //função que faz uma query no banco e exibi no grid criado

            _CarregarTOP100(grid);
        }

        private void _ConsultarDGVtab(DataGridView dgv)
        {

            try
            {

                dgv.DataSource = null;
                dgv.Rows.Clear();
                string strconexao = "Data Source=" + IP + "," + PORTA + ";" + "Initial Catalog=" + lbbancoselecionando.Text + ";" + "User Id=" + USER + " ; pwd=" + SENHA + ";"; ;
                using (SqlConnection con = new SqlConnection(strconexao))
                {

                    StringBuilder sql = new StringBuilder();


                    sql.AppendFormat(txtConsulta.Text);

                    con.Open();

                    using (SqlCommand comm = new SqlCommand(sql.ToString(), con))
                    {

                        DataTable tbBanco = new DataTable();

                        comm.CommandType = CommandType.Text;

                        SqlDataAdapter da = new SqlDataAdapter(comm);
                        DataTable tabelas = new DataTable();
                        da.Fill(tabelas);
                        dgv.DataSource = tabelas;
                        if (tabelas.Columns.Contains("timestamp"))
                        {
                            tabelas.Columns.Remove("Timestamp");
                        }
                        lbRowCount.Text = " -    Quantidade de registros : " + dgv.RowCount.ToString();
                    }
                    con.Close();

                    dgv.ClearSelection();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void _CarregarTOP1000(DataGridView dgv)
        {
            try
            {

                dgv.DataSource = null;
                dgv.Rows.Clear();
                string strconexao = "Data Source=" + IP + "," + PORTA + ";" + "Initial Catalog=" + lbbancoselecionando.Text + ";" + "User Id=" + USER + " ; pwd=" + SENHA + ";"; ;
                using (SqlConnection con = new SqlConnection(strconexao))
                {

                    StringBuilder sql = new StringBuilder();


                    sql.AppendFormat(@"select top 1000 * from " + listBox2.Text.ToString());

                    con.Open();

                    using (SqlCommand comm = new SqlCommand(sql.ToString(), con))
                    {

                        DataTable tbBanco = new DataTable();

                        comm.CommandType = CommandType.Text;

                        SqlDataAdapter da = new SqlDataAdapter(comm);
                        DataTable tabelas = new DataTable();
                        da.Fill(tabelas);
                        dgv.DataSource = tabelas;
                        if (tabelas.Columns.Contains("timestamp"))
                        {
                            tabelas.Columns.Remove("Timestamp");
                        }
                        lbRowCount.Text = " -    Quantidade de registros : " + dgv.RowCount.ToString();
                    }
                    con.Close();

                    dgv.ClearSelection();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void _CarregarTOP500(DataGridView dgv)
        {
            try
            {

                dgv.DataSource = null;
                dgv.Rows.Clear();
                string strconexao = "Data Source=" + IP + "," + PORTA + ";" + "Initial Catalog=" + lbbancoselecionando.Text + ";" + "User Id=" + USER + " ; pwd=" + SENHA + ";"; ;
                using (SqlConnection con = new SqlConnection(strconexao))
                {

                    StringBuilder sql = new StringBuilder();


                    sql.AppendFormat(@"select top 500 * from " + listBox2.Text.ToString());

                    con.Open();

                    using (SqlCommand comm = new SqlCommand(sql.ToString(), con))
                    {

                        DataTable tbBanco = new DataTable();

                        comm.CommandType = CommandType.Text;

                        SqlDataAdapter da = new SqlDataAdapter(comm);
                        DataTable tabelas = new DataTable();
                        da.Fill(tabelas);
                        dgv.DataSource = tabelas;
                        if (tabelas.Columns.Contains("timestamp"))
                        {
                            tabelas.Columns.Remove("Timestamp");
                        }
                        lbRowCount.Text = " -    Quantidade de registros : " + dgv.RowCount.ToString();
                    }
                    con.Close();
                    dgv.ClearSelection();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void _CarregarTOP100(DataGridView dgv)
        {
            try
            {

                dgv.DataSource = null;
                dgv.Rows.Clear();
                string strconexao = "Data Source=" + IP + "," + PORTA + ";" + "Initial Catalog=" + lbbancoselecionando.Text + ";" + "User Id=" + USER + " ; pwd=" + SENHA + ";"; ;
                using (SqlConnection con = new SqlConnection(strconexao))
                {

                    StringBuilder sql = new StringBuilder();


                    sql.AppendFormat(@"select top 100 * from " + listBox2.Text.ToString());

                    con.Open();

                    using (SqlCommand comm = new SqlCommand(sql.ToString(), con))
                    {

                        DataTable tbBanco = new DataTable();

                        comm.CommandType = CommandType.Text;

                        SqlDataAdapter da = new SqlDataAdapter(comm);
                        DataTable tabelas = new DataTable();
                        da.Fill(tabelas);
                        dgv.DataSource = tabelas;
                        if (tabelas.Columns.Contains("timestamp"))
                        {
                            tabelas.Columns.Remove("Timestamp");
                        }
                        lbRowCount.Text = " -    Quantidade de registros : " + dgv.RowCount.ToString();
                    }
                    con.Close();
                    dgv.ClearSelection();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void carregarBancos()
        {
            try
            {
                string strconexao = "Data Source=" + IP + "," + PORTA + "; User Id=" + USER + " ; pwd=" + SENHA + ";"; ;
                using (SqlConnection con = new SqlConnection(strconexao))
                {

                    StringBuilder sql = new StringBuilder();


                    sql.AppendFormat(@"select name from sys.databases where name like '%" + txtPesquisaBanco.Text + "%'");

                    con.Open();

                    using (SqlCommand comm = new SqlCommand(sql.ToString(), con))
                    {

                        DataTable tbBanco = new DataTable();

                        comm.CommandType = CommandType.Text;

                        SqlDataAdapter da = new SqlDataAdapter(comm);
                        DataTable tabelas = new DataTable();
                        da.Fill(tabelas);
                        listBox1.DataSource = tabelas;
                        listBox1.DisplayMember = "name";
                        listBox1.ValueMember = "name";

                    }
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                Application.Exit();
                Application.Restart();
                return;
            }

        }
        private void carregarTabelas()
        {
            try
            {
                string banco = lbbancoselecionando.Text;

                string strconexao = "Data Source=" + IP + "," + PORTA + "; Initial Catalog = " + banco + "; User Id=" + USER + " ; pwd=" + SENHA + ";"; ;
                SqlConnection con = new SqlConnection(strconexao);

                string sql = "select * from information_schema.tables order by table_name";
                SqlCommand comm = new SqlCommand(sql, con);
                con.Open();
                comm.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(comm);
                DataTable tabelas = new DataTable();
                da.Fill(tabelas);
                listBox2.DataSource = tabelas;

                listBox2.DisplayMember = "TABLE_NAME";
                listBox2.ValueMember = "TABLE_NAME";
                con.Close();
                con.Dispose();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tituloForm()
        {
            if (IP.Contains("127.0.0.1"))
            {
                string hostName = System.Net.Dns.GetHostName();

                Text = "Consulta Rapida: " +VersãoSoftware+ "  - IP: " + dadosPC.GetLocalIPAddress() + "  - USUÁRIO: " + hostName;
            }
            else
            {
                string hostName = System.Net.Dns.GetHostName();
                Text = "Consulta Rapida: " + VersãoSoftware + "  - IP: " + IP + "  - USUÁRIO: " + hostName;
            }
        }
       private void _abrirLOG()
        {
            if (!File.Exists(pathLOG))
            {
                File.Create(pathLOG);

                _ocultarLog();

            }
            else
            {
                _ocultarLog();
                _lerLOG();
            }
        }
        private void _ocultarLog()
        {
            FileInfo fi = new FileInfo(pathLOG);
            fi.Attributes |= FileAttributes.Hidden;


        }
        private void _lerLOG()
        {
            //Log de acessos ao banco e comandos com data e hora
            string txtfile = File.ReadAllText(pathLOG);
            txtLog.Text = txtfile;

            txtQuerysRecentes.AppendText(txtConsulta.Text.ToUpper() + Environment.NewLine);

        }
       private void _escreverLOG()
        {
            //escrevendo log acessos e comandos com data e hora
            StreamWriter str = File.AppendText(pathLOG);

            string comando = txtConsulta.Text;
            str.WriteLine("Comando : "+txtConsulta.Text.ToUpper() +" [ "+DateTime.Now.ToString("dd-MM-yyyy") + " - " + DateTime.Now.ToString("hh:mm:ss") +"]"+ Environment.NewLine);
            str.Close();

            _abrirLOG();

        }
        private void _escreverlogLogin()
        {
            StreamWriter str = File.AppendText(pathLOG);
            str.WriteLine(Environment.NewLine);
            str.WriteLine("Registro de nova entrada no banco : [ " +DateTime.Now.ToLongDateString()+" - "+DateTime.Now.ToString("hh:mm:ss") +" ]"+ Environment.NewLine);
            str.WriteLine("Ip do Banco : "+IP+Environment.NewLine);
            str.WriteLine("Porta do Banco : " + PORTA + Environment.NewLine);
            str.WriteLine("Usuário : " + USER + Environment.NewLine);
            str.WriteLine( Environment.NewLine);
            str.Close();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //propriedade que seta qual cor irá ficar transparente no formulario
            //this.TransparencyKey = Color.WhiteSmoke;

            _setarVersao();
            _escreverlogLogin();
            _abrirLOG();
            tituloForm();
            carregarBancos();
            txtPesquisaBanco.Focus();
            txtPesquisaBanco.Select();

        }
        private void executarConsulta()
        {
            if (txtConsulta.Text.Contains("delete"))
            {
                if (DialogResult.Yes == MessageBox.Show("Você está prestes a utilizar um comando para DELETAR dados, gostaria de continuar?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    TabPage page = tabControl1.SelectedTab;
                    DataGridView grid = (DataGridView)page.Controls[0];
                    _ConsultarDGVtab(grid);

                    txtConsulta.ForeColor = Color.Blue;
                    page.Text = txtConsulta.Text;

                }
                else
                {
                    return;
                }


            }
            else if (txtConsulta.Text.Contains("update"))
            {
                if (DialogResult.Yes == MessageBox.Show("Você está prestes a utilizar um comando para MODIFICAR dados, gostaria de continuar?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    TabPage page = tabControl1.SelectedTab;
                    DataGridView grid = (DataGridView)page.Controls[0];
                    _ConsultarDGVtab(grid);

                    txtConsulta.ForeColor = Color.Blue;
                    page.Text = txtConsulta.Text;

                }
                else
                {
                    return;
                }
            }
            else if (txtConsulta.Text.Contains("insert"))
            {
                if (DialogResult.Yes == MessageBox.Show("Você está prestes a utilizar um comando para INSERIR dados, gostaria de continuar?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    TabPage page = tabControl1.SelectedTab;
                    DataGridView grid = (DataGridView)page.Controls[0];
                    _ConsultarDGVtab(grid);

                    txtConsulta.ForeColor = Color.Blue;
                    page.Text = txtConsulta.Text;

                }
                else
                {
                    return;
                }
            }
            else if (txtConsulta.Text.Contains("drop"))
            {
                if (DialogResult.Yes == MessageBox.Show("Você está prestes a utilizar um comando para ELIMINAR bancos ou tabelas, gostaria de continuar?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    TabPage page = tabControl1.SelectedTab;
                    DataGridView grid = (DataGridView)page.Controls[0];
                    _ConsultarDGVtab(grid);

                    txtConsulta.ForeColor = Color.Blue;
                    page.Text = txtConsulta.Text;

                }
                else
                {
                    return;
                }
            }
            else
            {

                TabPage page = tabControl1.SelectedTab;
                DataGridView grid = (DataGridView)page.Controls[0];
                _ConsultarDGVtab(grid);

                txtConsulta.ForeColor = Color.Blue;
                page.Text = txtConsulta.Text;

            }

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count<= 0)
            {

                txtConsulta.ForeColor = Color.Black;
                _criaTabs();
                string tabcount = tabControl1.TabCount.ToString();
                btnLimparTab.Text = "Limpar{" + tabcount + "}";

                _carregarEstrutura();
                _ocultarHeaderGridEstrutura();
                lbRowCount.Visible = true;
                _escreverLOG();
            }
            else
            {
                executarConsulta();
                _escreverLOG();
            }

        }
        private void TabControl_Click(object sender, EventArgs e)
        {
            TabPage page = tabControl1.SelectedTab;
            txtConsulta.Text = page.Text;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            lbbancoselecionando.Text = listBox1.Text.ToString();
            lbBanco.Text = "Banco de dados selecionado: " + listBox1.Text.ToString();
            carregarTabelas();

            lbbancoselecionando.Visible = true;
            lbBanco.Visible = true;
        }

        //Carrega o layout da tabela selecionada
        private void _carregarEstrutura()
        {
            try
            {
                dgvEstrutura.DataSource = null;
                dgvEstrutura.Rows.Clear();
                string strconexao = "Data Source=" + IP + "," + PORTA + ";Initial Catalog=" + lbbancoselecionando.Text + ";" + "User Id=" + USER + " ; pwd=" + SENHA + ";"; ;
                using (SqlConnection con = new SqlConnection(strconexao))
                {

                    StringBuilder sql = new StringBuilder();


                    sql.AppendFormat(@"SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH,  IS_NULLABLE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + listBox2.Text.ToString() + "'");

                    con.Open();

                    using (SqlCommand comm = new SqlCommand(sql.ToString(), con))
                    {

                        DataTable tbBanco = new DataTable();

                        comm.CommandType = CommandType.Text;

                        SqlDataAdapter da = new SqlDataAdapter(comm);
                        DataTable tabelas = new DataTable();
                        da.Fill(tabelas);
                        dgvEstrutura.DataSource = tabelas;
                        lbQueryLayout.Visible = true;
                        lbQueryLayout.Text = "SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH,  IS_NULLABLE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + listBox2.Text.ToString().ToUpper() + "'";
                    }
                    dgvEstrutura.ClearSelection();
                    con.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void _ocultarHeaderGridEstrutura()
        {
            if (dgvEstrutura.RowCount > 0)
            {
                dgvEstrutura.ColumnHeadersVisible = true;

            }
            else
            {
                dgvEstrutura.ColumnHeadersVisible = false;
            }
        }
        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            txtConsulta.Text = "select * from " + listBox2.Text.ToString();

            txtConsulta.ForeColor = Color.Black;
            _criaTabs();
            string tabcount = tabControl1.TabCount.ToString();
            btnLimparTab.Text = "Limpar{" + tabcount + "}";

            _carregarEstrutura();
            _ocultarHeaderGridEstrutura();
            lbRowCount.Visible = true;
            _escreverLOG();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TabPage page = tabControl1.SelectedTab;
            DataGridView grid = (DataGridView)page.Controls[0];
            exportarDados.Excel(grid);


        }

        private void chkTOP_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void btnMaximizar_Click(object sender, EventArgs e)
        {

            Maximizar();

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {


                System.Windows.Forms.Application.Exit();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Fundo.Visible = true;
            btnLimparTab.Visible = false;

            Fundo.Dock = DockStyle.Fill;
            lbQueryLayout.Visible = false;
            EliminarBanco eliminar = new EliminarBanco(IP, USER, SENHA);
            eliminar.ShowDialog();

            btnLimparTab.Visible = true;


            Fundo.Visible = false;
            carregarBancos();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Fundo.Visible = true;
            btnLimparTab.Visible = false;

            Fundo.Dock = DockStyle.Fill;
            lbQueryLayout.Visible = false;
            truncateTabelas truncate = new truncateTabelas(IP, USER, SENHA);
            truncate.ShowDialog();

            btnLimparTab.Visible = true;

            Fundo.Visible = false;
            carregarBancos();
        }

        private void MenuSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            Releasecapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void MenuSuperior_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void txtPesquisaBanco_TextChanged(object sender, EventArgs e)
        {
            carregarBancos();
        }

        private void btnXLSEstrutura_Click(object sender, EventArgs e)
        {

            exportarDados.Excel(dgvEstrutura);
        }

        private void txtConsulta_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Y >= (txtConsulta.ClientRectangle.Bottom - 5) &&
        e.Y <= (txtConsulta.ClientRectangle.Bottom + 5))
            {
                isDrag = true;
                lastY = e.Y;
            }
        }

        private void txtConsulta_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrag)
            {
                txtConsulta.Height += (e.Y - lastY);
                lastY = e.Y;
            }
        }

        private void txtConsulta_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrag)
            {
                isDrag = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDataHora.Text = DateTime.Now.ToLongDateString() + " - " + DateTime.Now.ToLongTimeString();
        }


        private void btnCriarBanco_Click(object sender, EventArgs e)
        {
            Fundo.Visible = true;

            btnLimparTab.Visible = false;
            lbQueryLayout.Visible = false;

            Fundo.Dock = DockStyle.Fill;
            criarBanco criaDB = new criarBanco(IP, USER, SENHA);
            criaDB.ShowDialog();
            this.Refresh();
            Fundo.Visible = false;


            btnLimparTab.Visible = true;

            lbQueryLayout.Visible = true;
            carregarBancos();


        }


        private void chkBorda_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.W)
            {
                if (tabControl1.TabPages.Count > 0)
                {
                    TabPage page = tabControl1.SelectedTab;
                    tabControl1.TabPages.Remove(page);

                    string tabcount = tabControl1.TabCount.ToString();
                    btnLimparTab.Text = "Limpar{" + tabcount + "}";
                }
                else
                {
                    return;
                }

            }
        }

        private void btnLimparTab_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();
            txtConsulta.Clear();
            btnLimparTab.Text = "Limpar";
        }

        private void listBox3_Click(object sender, EventArgs e)
        {
            txtConsulta.Clear();

        }


        private void linkLimpar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            TabPage page = tabControl1.SelectedTab;
            txtConsulta.Text = page.Text;
        }

        private void listBox2_MouseUp(object sender, MouseEventArgs e)
        {
            if (listBox2.SelectedIndex > 0)
            {
                int location = listBox2.IndexFromPoint(e.Location);
                if (e.Button == MouseButtons.Right)
                {
                    listBox2.SelectedIndex = location;
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }



        }

        private void tOP1000ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            txtConsulta.Text = @"select top 1000 * from " + listBox2.Text.ToString();

            txtConsulta.ForeColor = Color.Black;
            _criaTabsTop1000();

            _carregarEstrutura();
            _ocultarHeaderGridEstrutura();
            lbRowCount.Visible = true;
        }

        private void tOP500ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtConsulta.Text =  @"select top 500 * from " + listBox2.Text.ToString();

            txtConsulta.ForeColor = Color.Black;
            _criaTabsTop500();

            _carregarEstrutura();
            _ocultarHeaderGridEstrutura();
            lbRowCount.Visible = true;
        }

        private void tOP100ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtConsulta.Text = @"select top 100 * from " + listBox2.Text.ToString();

            txtConsulta.ForeColor = Color.Black;
            _criaTabsTop100();

            _carregarEstrutura();
            _ocultarHeaderGridEstrutura();
            lbRowCount.Visible = true;
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void btnScript_MouseEnter(object sender, EventArgs e)
        {
            lbBanco.Visible = true;
            lbBanco.Text = "Executar script(*.sql, *.txt) no banco selecionado.";
        }

        private void btnScript_MouseLeave(object sender, EventArgs e)
        {

            lbBanco.Text = "Banco de dados selecionado: " + listBox1.Text.ToString();
            lbBanco.Visible = true;
        }

        private void btnCriarBanco_MouseEnter(object sender, EventArgs e)
        {
            lbBanco.Visible = true;
            lbBanco.Text = "Criar um novo banco de dados avulso.";


        }

        private void btnCriarBanco_MouseLeave(object sender, EventArgs e)
        {

            lbBanco.Text = "Banco de dados selecionado: " + listBox1.Text.ToString();
            lbBanco.Visible = true;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            lbBanco.Visible = true;
            lbBanco.Text = "Drop em uma tabela específica de um banco de dados.";


        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {

            lbBanco.Text = "Banco de dados selecionado: " + listBox1.Text.ToString();
            lbBanco.Visible = true;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            lbBanco.Visible = true;
            lbBanco.Text = "Drop em um ou mais banco de dados";

        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {

            lbBanco.Text = "Banco de dados selecionado: " + listBox1.Text.ToString();
            lbBanco.Visible = true;
        }

        private void btnConsulta_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                if (tabControl1.TabPages.Count <= 0)
                {

                    txtConsulta.ForeColor = Color.Black;
                    _criaTabs();
                    string tabcount = tabControl1.TabCount.ToString();
                    btnLimparTab.Text = "Limpar{" + tabcount + "}";

                    _carregarEstrutura();
                    _ocultarHeaderGridEstrutura();
                    lbRowCount.Visible = true;
                    _escreverLOG();
                }
                else
                {
                    executarConsulta();
                    _escreverLOG();
                }
            }
        }

        private void txtConsulta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                if (tabControl1.TabPages.Count <= 0)
                {

                    txtConsulta.ForeColor = Color.Black;
                    _criaTabs();
                    string tabcount = tabControl1.TabCount.ToString();
                    btnLimparTab.Text = "Limpar{" + tabcount + "}";

                    _carregarEstrutura();
                    _ocultarHeaderGridEstrutura();
                    lbRowCount.Visible = true;
                    _escreverLOG();

                }
                else
                {
                    executarConsulta();
                    _escreverLOG();
                }
            }
        }

        private void btnScript_Click_1(object sender, EventArgs e)
        {
            Fundo.Visible = true;

            btnLimparTab.Visible = false;
            lbQueryLayout.Visible = false;

            Fundo.Dock = DockStyle.Fill;
            ScriptSQL script = new ScriptSQL(USER, SENHA, IP, PORTA, lbbancoselecionando.Text);
            script.ShowDialog();

            this.Refresh();
            Fundo.Visible = false;


            btnLimparTab.Visible = true;

            lbQueryLayout.Visible = true;
            carregarBancos();


        }

        private void btnManutencao_Click(object sender, EventArgs e)
        {

        }

        private void exportarsqlToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnColor_Click(object sender, EventArgs e)
        {


        }

        private void btnControlBar_Click(object sender, EventArgs e)
        {
            if (FormBorderStyle == FormBorderStyle.None)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;

            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;

            }
        }

        private void btnTopMost_Click(object sender, EventArgs e)
        {
            if (TopMost==false)
            {
                TopMost = true;

            }
            else
            {
                TopMost = false;
            }
        }

        private void txtLog_VisibleChanged(object sender, EventArgs e)
        {
                if (txtLog.Visible)
                {
                    txtLog.SelectionStart = txtLog.TextLength;
                    txtLog.ScrollToCaret();
                }

        }

        private void btnExecutarAtach_Click(object sender, EventArgs e)
        {
            manutencao.AtacharDB(IP,PORTA,USER, SENHA,txtNomeBanco.Text,txtMDF.Text,txtLDF.Text);
        }

        private void btnPathMDF_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "mdf files (*.mdf)|*.mdf|All files (*.*)|*.*";
            ofd.Title = "Por favor selecione o arquivo físico do banco de dados";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtMDF.Text = ofd.FileName;
                txtNomeBanco.Text = ofd.SafeFileName;
            }
        }

        private void btnPathLDF_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ldf files (*.ldf)|*.ldf|All files (*.*)|*.*";
            ofd.Title = "Por favor selecione o arquivo físico do banco de dados";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtLDF.Text = ofd.FileName;
                txtNomeBanco.Text = ofd.SafeFileName;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtPastaBK.Text = fbd.SelectedPath + @"\" + txtNomebancoBK.Text + ".bkp";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtPastaRest.Text = fbd.SelectedPath + @"\" + txtNomebancoBK.Text + ".bkp";
            }
            
        }

        private void btnExecutarBK_Click(object sender, EventArgs e)
        {
            manutencao.BackupDB(IP,PORTA,USER,SENHA,txtNomebancoBK.Text, txtPastaBK.Text);
        }

        private void btnRestaurarBK_Click(object sender, EventArgs e)
        {
            manutencao.RestaurarBD(IP,PORTA,USER,SENHA,txtNomebancoBK.Text,txtPastaRest.Text);
        }

        private void tabControl2_TabIndexChanged(object sender, EventArgs e)
        {
            if (tabControl2.SelectedIndex == 1)
            {
                
            }
        }

        private void btnScript_Click(object sender, EventArgs e)
        {


        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == tabControl1.SelectedIndex)
            {
                e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text,
                    new System.Drawing.Font(tabControl1.Font, FontStyle.Regular),
                    Brushes.OrangeRed,
                    new PointF(e.Bounds.X + 3, e.Bounds.Y + 3));
            }
            else
            {
                e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text,
                    tabControl1.Font,
                    Brushes.Black,
                    new PointF(e.Bounds.X + 3, e.Bounds.Y + 3));
            }

        }

        private void btnLupa_Click(object sender, EventArgs e)
        {
            carregarBancos();
        }
    }
}
