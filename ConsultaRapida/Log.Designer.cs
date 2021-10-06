namespace ConsultaRapida
{
    partial class Log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MenuSuperior = new System.Windows.Forms.Panel();
            this.lbBanco = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.dgvEstrutura = new System.Windows.Forms.DataGridView();
            this.COLUMN_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHARACTER_MAXIMUM_LENGTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IS_NULLABLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MenuSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstrutura)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuSuperior
            // 
            this.MenuSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(72)))), ((int)(((byte)(154)))));
            this.MenuSuperior.Controls.Add(this.btnMinimizar);
            this.MenuSuperior.Controls.Add(this.btnMaximizar);
            this.MenuSuperior.Controls.Add(this.btnFechar);
            this.MenuSuperior.Controls.Add(this.lbBanco);
            this.MenuSuperior.Location = new System.Drawing.Point(451, 12);
            this.MenuSuperior.Name = "MenuSuperior";
            this.MenuSuperior.Size = new System.Drawing.Size(349, 52);
            this.MenuSuperior.TabIndex = 20;
            // 
            // lbBanco
            // 
            this.lbBanco.AutoSize = true;
            this.lbBanco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBanco.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbBanco.Location = new System.Drawing.Point(128, 18);
            this.lbBanco.Name = "lbBanco";
            this.lbBanco.Size = new System.Drawing.Size(0, 18);
            this.lbBanco.TabIndex = 8;
            this.lbBanco.Visible = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(236, 18);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(272, 18);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Image = global::ConsultaRapida.Properties.Resources.cancel_208px;
            this.btnFechar.Location = new System.Drawing.Point(308, 18);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 25);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 0;
            this.btnFechar.TabStop = false;
            // 
            // dgvEstrutura
            // 
            this.dgvEstrutura.AllowUserToAddRows = false;
            this.dgvEstrutura.AllowUserToDeleteRows = false;
            this.dgvEstrutura.AllowUserToResizeRows = false;
            this.dgvEstrutura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstrutura.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvEstrutura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(72)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstrutura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEstrutura.ColumnHeadersVisible = false;
            this.dgvEstrutura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COLUMN_NAME,
            this.DATA_TYPE,
            this.CHARACTER_MAXIMUM_LENGTH,
            this.IS_NULLABLE});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstrutura.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEstrutura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEstrutura.EnableHeadersVisualStyles = false;
            this.dgvEstrutura.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvEstrutura.Location = new System.Drawing.Point(3, 3);
            this.dgvEstrutura.Name = "dgvEstrutura";
            this.dgvEstrutura.ReadOnly = true;
            this.dgvEstrutura.RowHeadersVisible = false;
            this.dgvEstrutura.Size = new System.Drawing.Size(1272, 603);
            this.dgvEstrutura.TabIndex = 29;
            // 
            // COLUMN_NAME
            // 
            this.COLUMN_NAME.DataPropertyName = "COLUMN_NAME";
            this.COLUMN_NAME.HeaderText = "Nome";
            this.COLUMN_NAME.Name = "COLUMN_NAME";
            this.COLUMN_NAME.ReadOnly = true;
            // 
            // DATA_TYPE
            // 
            this.DATA_TYPE.DataPropertyName = "DATA_TYPE";
            this.DATA_TYPE.HeaderText = "Tipo de Dados";
            this.DATA_TYPE.Name = "DATA_TYPE";
            this.DATA_TYPE.ReadOnly = true;
            // 
            // CHARACTER_MAXIMUM_LENGTH
            // 
            this.CHARACTER_MAXIMUM_LENGTH.DataPropertyName = "CHARACTER_MAXIMUM_LENGTH";
            this.CHARACTER_MAXIMUM_LENGTH.HeaderText = "Máximo de caracteres";
            this.CHARACTER_MAXIMUM_LENGTH.Name = "CHARACTER_MAXIMUM_LENGTH";
            this.CHARACTER_MAXIMUM_LENGTH.ReadOnly = true;
            // 
            // IS_NULLABLE
            // 
            this.IS_NULLABLE.DataPropertyName = "IS_NULLABLE";
            this.IS_NULLABLE.HeaderText = "Permite Nulo?";
            this.IS_NULLABLE.Name = "IS_NULLABLE";
            this.IS_NULLABLE.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1286, 637);
            this.tabControl1.TabIndex = 31;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvEstrutura);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1278, 609);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consultas realizadas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1278, 609);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tabelas Alteradas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1310, 719);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.MenuSuperior);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Log";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log";
            this.Load += new System.EventHandler(this.Log_Load);
            this.MenuSuperior.ResumeLayout(false);
            this.MenuSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstrutura)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuSuperior;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Label lbBanco;
        private System.Windows.Forms.DataGridView dgvEstrutura;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLUMN_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHARACTER_MAXIMUM_LENGTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn IS_NULLABLE;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}