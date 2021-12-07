using ConsultaRapida.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Windows.Forms;


namespace ConsultaRapida
{
    public partial class Login : Form
    {
        //    bool isDrag = false;
        //    int lastY = 0;

        [DllImport("wininet.dll")]

        
        private extern static Boolean InternetGetConnectedState(out int Description, int ReservedValue);


        // Um método que verifica se esta conectado

        public static Boolean IsConnected()

        {

            int Description;

            return InternetGetConnectedState(out Description, 0);

        }
        public Login()
        {
            InitializeComponent();

            
            txtSenha.Focus();
            timer1.Start();
        }
       
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void Releasecapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void verificarVersao()
        {
            //Verificando as informações do assembly do projeto
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);

            //colocando os dados da versão do assembly em uma variavel
            string v1 = fileVersionInfo.ProductVersion;

            //acessando um servidor ftp e comparando o assembly do projeto com o arquivo de versão
            WebClient request = new WebClient();
            string url = "ftp://consultarapida.ddns.net/version.txt";


            request.Credentials = new NetworkCredential("consultarapida@ddns.net", "Q1m9f8f8");

            try
            {
                byte[] newFileData = request.DownloadData(url);

                string v2 = System.Text.Encoding.UTF8.GetString(newFileData);

                //versao do projeto
                Version version1 = new Version(v1);
                //versao no ftp
                Version version2 = new Version(v2);

                //comparando as versões
                var result = version1.CompareTo(version2);
                if (result > 0)
                {
                    alerta.popup("Consulta Rápida, versão: "+v1.ToString()," Software de Uso interno na Autocom3 com permissão do desenvolvedor.");
                }
                else if (result < 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Existe uma versão mais nova do software. Gostaria de fazer o download agora?", "Aviso de atualização", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        
                        System.Diagnostics.Process.Start("http://consultarapida.ddns.net/ddns.net/consultarapida/ConsultaRapida.exe");
                        Application.Exit();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }

                return;
                
            }
            catch (WebException)
            {
                MessageBox.Show("Você precisa estar conectado ao internet para verificar a versão do software.");
            }
            
        }
        
        private void _Entrar()
        {
            string user = txtUsuario.Text;
            string senha = txtSenha.Text;
            string ip = txtIPBanco.Text;
            string porta = txtPorta.Text;

            if (lbServicos.Text.Contains("Em Execução"))
            {                 
                WebClient request = new WebClient();

                string licenca = "ftp://consultarapida.ddns.net/licenca.txt";


                request.Credentials = new NetworkCredential("consultarapida@ddns.net", "Q1m9f8f8");

                try
                {

                    byte[] newFileData = request.DownloadData(licenca);

                    string serial = System.Text.Encoding.UTF8.GetString(newFileData);

                    if (serial == "ativo")
                    {
                        Form1 frm1 = new Form1(user, senha, ip, porta);
                        frm1.Show();
                        timer1.Stop();
                        Hide();
                    }
                    else
                    {
                        alerta.popup("Olá!", "Sua licença expirou, entre em contato com o desenvolvedor. Whatsapp: 24 999318827");
                    }
                }
                catch (WebException ex)
                {

                    MessageBox.Show(ex.Message);
                }
               
                
            }

            if (lbServicos.Text.Contains("Parado"))
            {
                alerta.popup("Atenção!","O serviço do SQL está desligado, verifique antes de continuar.");
                alerta.popup("Serviço do windows","Inicie o serviço do SQL antes de prosseguir.");
                DialogResult dialogResult = MessageBox.Show("Gostaria de ativar o serviço agora?", "Serviço do SQLEXPRESS", MessageBoxButtons.YesNo);

                

                if (dialogResult == DialogResult.Yes)
                {

                    ServiceController sc = new ServiceController("MSSQL$SQLEXPRESS");
                    sc.Start();
                    sc.WaitForStatus(ServiceControllerStatus.Running);
                    alerta.popup("Aviso!","O serviço do SQL está em funcionamento.");
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }

            }
            
        }
        
        private void btnEntrar_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtSenha.Text != "" && txtUsuario.Text != "")
                {
                    _Entrar();
                }
                else
                {
                    alerta.popup("Atenção!" + Environment.NewLine, "Os campos usuário e senha precisam estar preenchidos!");
                }

            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtSenha.Text != "" && txtUsuario.Text != "")
                {
                    _Entrar();
                }
                else
                {
                    alerta.popup("Atenção!" + Environment.NewLine, "Os campos usuário e senha precisam estar preenchidos!");
                }

            }
        }
        private void verificarServicos()
        {
            string serviceName = "MSSQL$SQLEXPRESS";

            ServiceController sc = new ServiceController(serviceName);

            lbServicos.Text = sc.Status.ToString();

            if (lbServicos.Text.Contains("Running"))
            {
                lbServicos.Text = "Em Execução!";
                lbServicos.ForeColor = Color.Green;
            }
            if (lbServicos.Text.Contains("Stopped"))
            {
                lbServicos.Text = "Parado!";
                lbServicos.ForeColor = Color.Red;
            }

        }
        private void Login_Load(object sender, EventArgs e)
        {
            
            if (IsConnected()) //se estiver conectado a internet verifica versão
            {
                //Verificando versão do software
                verificarVersao();
            }
            else
            {
                alerta.popup("Aviso!","Para verificar atualizações do software você precisa estar conectado a internet!");
            }
            
            verificarServicos();
            txtSenha.Focus();
            txtSenha.Select();
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtSenha.Text != "" && txtUsuario.Text != "")
                {
                    _Entrar();
                }
                else
                {
                    alerta.popup("Atenção!" + Environment.NewLine, "Os campos usuário e senha precisam estar preenchidos!");
                }


            }
        }

        private void btnVisualizarSenha_MouseDown(object sender, MouseEventArgs e)
        {
            Image eyeOpen = Resources.eye_96px;
            

            btnVisualizarSenha.Image = Resources.eye_96px;
            txtSenha.PasswordChar = '\0';
        }

        private void btnVisualizarSenha_MouseUp(object sender, MouseEventArgs e)
        {
            Image eyeClose = Resources.olhobloq_32;
            btnVisualizarSenha.Image = Resources.olhobloq_32;

            txtSenha.PasswordChar = Convert.ToChar("*");
        }

        private void chkBorda_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtIPBanco_Click(object sender, EventArgs e)
        {
            if (txtIPBanco.Text != "")
            {
                txtIPBanco.SelectAll();
            }
        }

        private void txtPorta_Click(object sender, EventArgs e)
        {
            if (txtPorta.Text != "")
            {
                txtPorta.SelectAll();
            }
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                txtUsuario.SelectAll();
            }
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text != "")
            {

                txtSenha.SelectAll();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            verificarServicos();
        }

        private void MenuSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            Releasecapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnVisualizarSenha_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void btnVisualizarSenha_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {

            if (txtSenha.Text != "" && txtUsuario.Text != "" && txtPorta.Text != "")
            {
                _Entrar();

            }
            else
            {
                alerta.popup("Atenção!" + Environment.NewLine, "Os campos usuário, senha e porta precisam estar preenchidos!");
            }
        }

        private void btnEntrar_MouseEnter(object sender, EventArgs e)
        {
            btnEntrar.Image = Properties.Resources.btnentrar2;
        }

        private void btnEntrar_MouseLeave(object sender, EventArgs e)
        {
            btnEntrar.Image = Properties.Resources.btnEntrar1;
        }
    }
}
