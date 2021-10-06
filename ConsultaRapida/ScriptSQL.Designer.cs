namespace ConsultaRapida
{
    partial class ScriptSQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptSQL));
            this.MenuSuperior = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.lbBanco = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtScript = new System.Windows.Forms.TextBox();
            this.btnExecutarScript = new System.Windows.Forms.Button();
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscaScript = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscaScript)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuSuperior
            // 
            this.MenuSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(26)))), ((int)(((byte)(156)))));
            this.MenuSuperior.Controls.Add(this.pictureBox1);
            this.MenuSuperior.Controls.Add(this.btnMinimizar);
            this.MenuSuperior.Controls.Add(this.btnMaximizar);
            this.MenuSuperior.Controls.Add(this.btnFechar);
            this.MenuSuperior.Controls.Add(this.lbBanco);
            this.MenuSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuSuperior.Location = new System.Drawing.Point(0, 0);
            this.MenuSuperior.Name = "MenuSuperior";
            this.MenuSuperior.Size = new System.Drawing.Size(1045, 52);
            this.MenuSuperior.TabIndex = 20;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(932, 13);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(968, 13);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Image = global::ConsultaRapida.Properties.Resources.cancel_208px;
            this.btnFechar.Location = new System.Drawing.Point(1004, 13);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 25);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 0;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lbBanco
            // 
            this.lbBanco.AutoSize = true;
            this.lbBanco.BackColor = System.Drawing.Color.Transparent;
            this.lbBanco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBanco.ForeColor = System.Drawing.Color.White;
            this.lbBanco.Location = new System.Drawing.Point(58, 20);
            this.lbBanco.Name = "lbBanco";
            this.lbBanco.Size = new System.Drawing.Size(287, 18);
            this.lbBanco.TabIndex = 8;
            this.lbBanco.Text = "Execução de scripts no banco de dados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(82)))), ((int)(((byte)(157)))));
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Selecione o arquivo. (*.SQL, *TXT )";
            // 
            // txtScript
            // 
            this.txtScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(176)))));
            this.txtScript.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtScript.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtScript.ForeColor = System.Drawing.Color.Black;
            this.txtScript.Location = new System.Drawing.Point(15, 110);
            this.txtScript.Name = "txtScript";
            this.txtScript.Size = new System.Drawing.Size(479, 19);
            this.txtScript.TabIndex = 28;
            // 
            // btnExecutarScript
            // 
            this.btnExecutarScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecutarScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(26)))), ((int)(((byte)(156)))));
            this.btnExecutarScript.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExecutarScript.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExecutarScript.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.btnExecutarScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecutarScript.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutarScript.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExecutarScript.Location = new System.Drawing.Point(537, 99);
            this.btnExecutarScript.Name = "btnExecutarScript";
            this.btnExecutarScript.Size = new System.Drawing.Size(72, 30);
            this.btnExecutarScript.TabIndex = 32;
            this.btnExecutarScript.Text = "Executar";
            this.btnExecutarScript.UseVisualStyleBackColor = false;
            this.btnExecutarScript.Click += new System.EventHandler(this.btnExecutarScript_Click);
            // 
            // txtConteudo
            // 
            this.txtConteudo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConteudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(176)))));
            this.txtConteudo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConteudo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConteudo.ForeColor = System.Drawing.Color.Black;
            this.txtConteudo.Location = new System.Drawing.Point(15, 172);
            this.txtConteudo.Multiline = true;
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConteudo.Size = new System.Drawing.Size(1018, 395);
            this.txtConteudo.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(82)))), ((int)(((byte)(157)))));
            this.label2.Location = new System.Drawing.Point(12, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "Conteúdo do arquivo:";
            // 
            // btnBuscaScript
            // 
            this.btnBuscaScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscaScript.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscaScript.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaScript.Image")));
            this.btnBuscaScript.Location = new System.Drawing.Point(501, 99);
            this.btnBuscaScript.Name = "btnBuscaScript";
            this.btnBuscaScript.Size = new System.Drawing.Size(30, 30);
            this.btnBuscaScript.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscaScript.TabIndex = 31;
            this.btnBuscaScript.TabStop = false;
            this.btnBuscaScript.Click += new System.EventHandler(this.btnBuscaScript_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // ScriptSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1045, 593);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.btnBuscaScript);
            this.Controls.Add(this.btnExecutarScript);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtScript);
            this.Controls.Add(this.MenuSuperior);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScriptSQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScriptSQL";
            this.Load += new System.EventHandler(this.ScriptSQL_Load);
            this.MenuSuperior.ResumeLayout(false);
            this.MenuSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscaScript)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MenuSuperior;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Label lbBanco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtScript;
        private System.Windows.Forms.PictureBox btnBuscaScript;
        private System.Windows.Forms.Button btnExecutarScript;
        private System.Windows.Forms.TextBox txtConteudo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}