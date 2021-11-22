
namespace ConsultaRapida
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.MenuSuperior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtIPBanco = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbServicos = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnEntrar = new System.Windows.Forms.PictureBox();
            this.btnVisualizarSenha = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.MenuSuperior.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEntrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVisualizarSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuSuperior
            // 
            this.MenuSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(26)))), ((int)(((byte)(156)))));
            this.MenuSuperior.Controls.Add(this.pictureBox1);
            this.MenuSuperior.Controls.Add(this.label1);
            this.MenuSuperior.Controls.Add(this.pictureBox3);
            this.MenuSuperior.Controls.Add(this.pictureBox5);
            this.MenuSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuSuperior.Location = new System.Drawing.Point(0, 0);
            this.MenuSuperior.Name = "MenuSuperior";
            this.MenuSuperior.Size = new System.Drawing.Size(397, 52);
            this.MenuSuperior.TabIndex = 20;
            this.MenuSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuSuperior_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(53, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Credenciais do banco";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.Location = new System.Drawing.Point(3, 9);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUsuario.Size = new System.Drawing.Size(341, 14);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Text = "sa";
            this.txtUsuario.Click += new System.EventHandler(this.txtUsuario_Click);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.White;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.Black;
            this.txtSenha.Location = new System.Drawing.Point(3, 9);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSenha.Size = new System.Drawing.Size(342, 14);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.Click += new System.EventHandler(this.txtSenha_Click);
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(82)))), ((int)(((byte)(157)))));
            this.label2.Location = new System.Drawing.Point(21, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Usuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(82)))), ((int)(((byte)(157)))));
            this.label3.Location = new System.Drawing.Point(21, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Senha:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtSenha);
            this.panel1.Location = new System.Drawing.Point(24, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 31);
            this.panel1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtUsuario);
            this.panel2.Location = new System.Drawing.Point(24, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 31);
            this.panel2.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(82)))), ((int)(((byte)(157)))));
            this.label4.Location = new System.Drawing.Point(21, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "IP do Banco de dados";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtIPBanco);
            this.panel3.Location = new System.Drawing.Point(24, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 31);
            this.panel3.TabIndex = 26;
            // 
            // txtIPBanco
            // 
            this.txtIPBanco.BackColor = System.Drawing.Color.White;
            this.txtIPBanco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIPBanco.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPBanco.ForeColor = System.Drawing.Color.Black;
            this.txtIPBanco.Location = new System.Drawing.Point(3, 9);
            this.txtIPBanco.Name = "txtIPBanco";
            this.txtIPBanco.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtIPBanco.Size = new System.Drawing.Size(239, 14);
            this.txtIPBanco.TabIndex = 1;
            this.txtIPBanco.Text = "127.0.0.1";
            this.txtIPBanco.Click += new System.EventHandler(this.txtIPBanco_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.txtPorta);
            this.panel4.Location = new System.Drawing.Point(285, 105);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(87, 31);
            this.panel4.TabIndex = 27;
            // 
            // txtPorta
            // 
            this.txtPorta.BackColor = System.Drawing.Color.White;
            this.txtPorta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPorta.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorta.ForeColor = System.Drawing.Color.Black;
            this.txtPorta.Location = new System.Drawing.Point(3, 9);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPorta.Size = new System.Drawing.Size(81, 14);
            this.txtPorta.TabIndex = 2;
            this.txtPorta.Text = "1433";
            this.txtPorta.Click += new System.EventHandler(this.txtPorta_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(82)))), ((int)(((byte)(157)))));
            this.label5.Location = new System.Drawing.Point(285, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Porta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(72)))), ((int)(((byte)(154)))));
            this.label6.Location = new System.Drawing.Point(21, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Status do serviço:";
            // 
            // lbServicos
            // 
            this.lbServicos.AutoSize = true;
            this.lbServicos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServicos.ForeColor = System.Drawing.Color.Black;
            this.lbServicos.Location = new System.Drawing.Point(122, 283);
            this.lbServicos.Name = "lbServicos";
            this.lbServicos.Size = new System.Drawing.Size(64, 15);
            this.lbServicos.TabIndex = 29;
            this.lbServicos.Text = "Desligado";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.Image = global::ConsultaRapida.Properties.Resources.btnEntrar1;
            this.btnEntrar.Location = new System.Drawing.Point(263, 268);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(109, 30);
            this.btnEntrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEntrar.TabIndex = 45;
            this.btnEntrar.TabStop = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click_1);
            this.btnEntrar.MouseEnter += new System.EventHandler(this.btnEntrar_MouseEnter);
            this.btnEntrar.MouseLeave += new System.EventHandler(this.btnEntrar_MouseLeave);
            // 
            // btnVisualizarSenha
            // 
            this.btnVisualizarSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVisualizarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisualizarSenha.Image = global::ConsultaRapida.Properties.Resources.olhobloq_32;
            this.btnVisualizarSenha.Location = new System.Drawing.Point(352, 193);
            this.btnVisualizarSenha.Name = "btnVisualizarSenha";
            this.btnVisualizarSenha.Size = new System.Drawing.Size(20, 20);
            this.btnVisualizarSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVisualizarSenha.TabIndex = 8;
            this.btnVisualizarSenha.TabStop = false;
            this.btnVisualizarSenha.Click += new System.EventHandler(this.btnVisualizarSenha_Click);
            this.btnVisualizarSenha.DoubleClick += new System.EventHandler(this.btnVisualizarSenha_DoubleClick);
            this.btnVisualizarSenha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnVisualizarSenha_MouseDown);
            this.btnVisualizarSenha.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnVisualizarSenha_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(322, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(358, 13);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(397, 333);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lbServicos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnVisualizarSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MenuSuperior);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            this.MenuSuperior.ResumeLayout(false);
            this.MenuSuperior.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEntrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVisualizarSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MenuSuperior;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtIPBanco;
        private System.Windows.Forms.PictureBox btnVisualizarSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbServicos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox btnEntrar;
    }
}