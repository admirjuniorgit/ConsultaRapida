namespace ConsultaRapida
{
    partial class EliminarBanco
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarBanco));
            this.dgvRegistro = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MenuSuperior = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnClipBoard = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.btnTransfer = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).BeginInit();
            this.MenuSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClipBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTransfer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegistro
            // 
            this.dgvRegistro.AllowUserToAddRows = false;
            this.dgvRegistro.AllowUserToDeleteRows = false;
            this.dgvRegistro.AllowUserToResizeColumns = false;
            this.dgvRegistro.AllowUserToResizeRows = false;
            this.dgvRegistro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegistro.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistro.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRegistro.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRegistro.GridColor = System.Drawing.Color.Linen;
            this.dgvRegistro.Location = new System.Drawing.Point(22, 164);
            this.dgvRegistro.MultiSelect = false;
            this.dgvRegistro.Name = "dgvRegistro";
            this.dgvRegistro.ReadOnly = true;
            this.dgvRegistro.RowHeadersVisible = false;
            this.dgvRegistro.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRegistro.RowTemplate.Height = 24;
            this.dgvRegistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistro.Size = new System.Drawing.Size(479, 435);
            this.dgvRegistro.TabIndex = 0;
            this.dgvRegistro.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRegistro_CellFormatting);
            this.dgvRegistro.Click += new System.EventHandler(this.dgvRegistro_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ForeColor = System.Drawing.Color.Red;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(556, 164);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(479, 435);
            this.listBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(176)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(22, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(479, 19);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(82)))), ((int)(((byte)(157)))));
            this.label1.Location = new System.Drawing.Point(19, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pesquisar o nome do banco (*O campo pesquisa parte do nome)";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(82)))), ((int)(((byte)(157)))));
            this.label2.Location = new System.Drawing.Point(19, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Banco de dados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(82)))), ((int)(((byte)(157)))));
            this.label3.Location = new System.Drawing.Point(553, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Banco de dados para exclusão";
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
            this.MenuSuperior.Size = new System.Drawing.Size(1061, 52);
            this.MenuSuperior.TabIndex = 20;
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
            this.label4.Location = new System.Drawing.Point(58, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Executar o drop no banco de dados";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(1021, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 25);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 0;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 0;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // btnClipBoard
            // 
            this.btnClipBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClipBoard.Image = ((System.Drawing.Image)(resources.GetObject("btnClipBoard.Image")));
            this.btnClipBoard.Location = new System.Drawing.Point(969, 128);
            this.btnClipBoard.Name = "btnClipBoard";
            this.btnClipBoard.Size = new System.Drawing.Size(30, 30);
            this.btnClipBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClipBoard.TabIndex = 21;
            this.btnClipBoard.TabStop = false;
            this.btnClipBoard.Click += new System.EventHandler(this.btnClipBoard_Click);
            this.btnClipBoard.MouseEnter += new System.EventHandler(this.btnClipBoard_MouseEnter);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(507, 209);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(43, 39);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 8;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransfer.Image = ((System.Drawing.Image)(resources.GetObject("btnTransfer.Image")));
            this.btnTransfer.Location = new System.Drawing.Point(507, 164);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(43, 39);
            this.btnTransfer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnTransfer.TabIndex = 9;
            this.btnTransfer.TabStop = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            this.btnTransfer.MouseEnter += new System.EventHandler(this.btnTransfer_MouseEnter);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(1005, 128);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(30, 30);
            this.btnClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClear.TabIndex = 10;
            this.btnClear.TabStop = false;
            this.btnClear.Click += new System.EventHandler(this.pictureBox1_Click);
            this.btnClear.MouseEnter += new System.EventHandler(this.btnClear_MouseEnter);
            // 
            // EliminarBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1061, 632);
            this.Controls.Add(this.btnClipBoard);
            this.Controls.Add(this.MenuSuperior);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dgvRegistro);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EliminarBanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EliminarBanco";
            this.Load += new System.EventHandler(this.EliminarBanco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).EndInit();
            this.MenuSuperior.ResumeLayout(false);
            this.MenuSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClipBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTransfer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegistro;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.PictureBox btnTransfer;
        private System.Windows.Forms.PictureBox btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel MenuSuperior;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.PictureBox btnClipBoard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}