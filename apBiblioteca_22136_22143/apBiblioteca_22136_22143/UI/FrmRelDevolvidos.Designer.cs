namespace apBiblioteca_22136_22143.UI
{
    partial class FrmRelDevolvidos
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
            this.dgvDevolvidos = new System.Windows.Forms.DataGridView();
            this.idEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDevolucaoReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolvidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDevolvidos
            // 
            this.dgvDevolvidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDevolvidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevolvidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmprestimo,
            this.nomeLivro,
            this.nomeLeitor,
            this.dataEmprestimo,
            this.dataDevolucaoReal});
            this.dgvDevolvidos.Location = new System.Drawing.Point(12, 12);
            this.dgvDevolvidos.Name = "dgvDevolvidos";
            this.dgvDevolvidos.RowHeadersWidth = 51;
            this.dgvDevolvidos.RowTemplate.Height = 24;
            this.dgvDevolvidos.Size = new System.Drawing.Size(776, 426);
            this.dgvDevolvidos.TabIndex = 0;
            // 
            // idEmprestimo
            // 
            this.idEmprestimo.HeaderText = "Identificação";
            this.idEmprestimo.MinimumWidth = 6;
            this.idEmprestimo.Name = "idEmprestimo";
            this.idEmprestimo.Width = 125;
            // 
            // nomeLivro
            // 
            this.nomeLivro.HeaderText = "Livro";
            this.nomeLivro.MinimumWidth = 6;
            this.nomeLivro.Name = "nomeLivro";
            this.nomeLivro.Width = 125;
            // 
            // nomeLeitor
            // 
            this.nomeLeitor.HeaderText = "Leitor";
            this.nomeLeitor.MinimumWidth = 6;
            this.nomeLeitor.Name = "nomeLeitor";
            this.nomeLeitor.Width = 125;
            // 
            // dataEmprestimo
            // 
            this.dataEmprestimo.HeaderText = "Retirada";
            this.dataEmprestimo.MinimumWidth = 6;
            this.dataEmprestimo.Name = "dataEmprestimo";
            this.dataEmprestimo.Width = 125;
            // 
            // dataDevolucaoReal
            // 
            this.dataDevolucaoReal.HeaderText = "Devolução";
            this.dataDevolucaoReal.MinimumWidth = 6;
            this.dataDevolucaoReal.Name = "dataDevolucaoReal";
            this.dataDevolucaoReal.Width = 125;
            // 
            // FrmRelDevolvidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDevolvidos);
            this.Name = "FrmRelDevolvidos";
            this.Text = "FrmRelDevolvidos";
            this.Load += new System.EventHandler(this.FrmRelDevolvidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolvidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDevolvidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDevolucaoReal;
    }
}