using System;
using System.Drawing;
using System.Windows.Forms;


namespace ConsultaRapida
{
    class FormatForm
    {
        public static void DesignGrid(DataGridView grid)
        {
            grid.Visible = true;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.RowHeadersVisible = false;
            grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
            //grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle.SelectionBackColor = Color.DeepPink;
            dataGridViewCellStyle.SelectionForeColor = Color.White;
            dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(109, 72, 154);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 9.75F, FontStyle.Regular);
            grid.BorderStyle = BorderStyle.None;
            grid.BackgroundColor = Color.White;

            //Se o grid possuir registros alternar cores das linhas entre branco e cinza claro
            if (grid.SelectedRows.Count > 0)
            {
                int index = grid.SelectedRows[0].Index;

                if (index >= 0)
                    grid.Rows[index].Selected = false;
            }
                        
            grid.RowsDefaultCellStyle.BackColor = Color.White;
            grid.RowsDefaultCellStyle.ForeColor = Color.Black;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            grid.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            grid.GridColor = Color.Silver;

            grid.PerformLayout();
            grid.Dock = DockStyle.Fill;
                       

        }
        public static void DesignForm(Panel PainelTitulo, PictureBox btnMinimizar, PictureBox btnMaximizar, PictureBox btnFechar, Button botaoPadrao)
        {
            //definindo ancoragem e cor do painel superior.
            PainelTitulo.Dock = DockStyle.Top;
            PainelTitulo.BackColor = Color.FromArgb(109, 72, 154);
            PainelTitulo.Height = 52;

            //definindo ancoragem, icones e tamanho dos botoes de controle.
            btnFechar.Height = 25;
            btnFechar.Width = 25;
            btnMaximizar.Height = 25;
            btnMaximizar.Width = 25;
            btnMinimizar.Height = 25;
            btnMinimizar.Width = 25;
            btnFechar.Image = Properties.Resources.cancel_208px;
            btnMaximizar.Image = Properties.Resources.maximizar;
            btnMinimizar.Image = Properties.Resources.minimizar;
            btnFechar.SizeMode = PictureBoxSizeMode.Zoom;
            btnFechar.Anchor = AnchorStyles.Top;
            btnFechar.Anchor = AnchorStyles.Right;
            btnMaximizar.Anchor = AnchorStyles.Top;
            btnMaximizar.Anchor = AnchorStyles.Right;
            btnMinimizar.Anchor = AnchorStyles.Top;
            btnMinimizar.Anchor = AnchorStyles.Right;

            //configuração de botões do formulário: Cor, tamanho e fonte de texto.
            botaoPadrao.BackColor = Color.FromArgb(114, 82, 157);
            botaoPadrao.ForeColor = Color.WhiteSmoke;
            botaoPadrao.Font = new Font("Arial", 8.25F, FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            botaoPadrao.Cursor = Cursors.Hand;
            botaoPadrao.FlatStyle = FlatStyle.Flat;
            botaoPadrao.Height = 30;
            botaoPadrao.Width = 72;
            botaoPadrao.TextAlign = ContentAlignment.MiddleLeft;

        }

        public static void DesignTab(string txtconsulta, TabControl tab, DataGridView grid)
        {

            //Adicionando a tabpage com o titulo como query que foi utilizada           
            
            TabPage minhaTab = new TabPage(txtconsulta);
            
            tab.TabPages.Add(minhaTab);
            

            //adicionando o objeto datagridview dentro da tabpage

            minhaTab.Controls.Add(grid);


            tab.SelectTab(minhaTab);
            tab.Refresh();

            //classe para formatação do datagridview
            FormatForm.DesignGrid(grid);

        }        

    }
}
