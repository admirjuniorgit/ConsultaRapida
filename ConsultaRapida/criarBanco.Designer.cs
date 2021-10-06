
namespace ConsultaRapida
{
    partial class criarBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(criarBanco));
            this.MenuSuperior = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNomeBanco = new System.Windows.Forms.TextBox();
            this.btnCriarBanco = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuSuperior
            // 
            this.MenuSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(26)))), ((int)(((byte)(156)))));
            this.MenuSuperior.Controls.Add(this.pictureBox1);
            this.MenuSuperior.Controls.Add(this.label4);
            this.MenuSuperior.Controls.Add(this.btnFechar);
            this.MenuSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuSuperior.Location = new System.Drawing.Point(0, 0);
            this.MenuSuperior.Name = "MenuSuperior";
            this.MenuSuperior.Size = new System.Drawing.Size(401, 52);
            this.MenuSuperior.TabIndex = 21;
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
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(58, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Criar uma nova DATABASE";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(359, 14);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 25);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 0;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.txtNomeBanco);
            this.panel1.Location = new System.Drawing.Point(18, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 31);
            this.panel1.TabIndex = 31;
            // 
            // txtNomeBanco
            // 
            this.txtNomeBanco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(176)))));
            this.txtNomeBanco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeBanco.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeBanco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(82)))), ((int)(((byte)(157)))));
            this.txtNomeBanco.Location = new System.Drawing.Point(11, 10);
            this.txtNomeBanco.Name = "txtNomeBanco";
            this.txtNomeBanco.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNomeBanco.Size = new System.Drawing.Size(337, 13);
            this.txtNomeBanco.TabIndex = 0;
            this.txtNomeBanco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeBanco_KeyPress);
            // 
            // btnCriarBanco
            // 
            this.btnCriarBanco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCriarBanco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(26)))), ((int)(((byte)(156)))));
            this.btnCriarBanco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCriarBanco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarBanco.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.btnCriarBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarBanco.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarBanco.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCriarBanco.Location = new System.Drawing.Point(298, 152);
            this.btnCriarBanco.Name = "btnCriarBanco";
            this.btnCriarBanco.Size = new System.Drawing.Size(82, 30);
            this.btnCriarBanco.TabIndex = 1;
            this.btnCriarBanco.Text = "Criar Banco";
            this.btnCriarBanco.UseVisualStyleBackColor = false;
            this.btnCriarBanco.Click += new System.EventHandler(this.btnCriarBanco_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(82)))), ((int)(((byte)(157)))));
            this.label1.Location = new System.Drawing.Point(15, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Digite um nome para o novo Banco:";
            // 
            // criarBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(401, 206);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCriarBanco);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "criarBanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "criarBanco";
            this.Load += new System.EventHandler(this.criarBanco_Load);
            this.MenuSuperior.ResumeLayout(false);
            this.MenuSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MenuSuperior;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNomeBanco;
        private System.Windows.Forms.Button btnCriarBanco;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}