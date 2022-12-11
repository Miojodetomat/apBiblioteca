namespace apBiblioteca_22136_22143.UI
{
    partial class FrmRelEmpPendentes
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
            this.dgvRelEmpPendentes = new System.Windows.Forms.DataGridView();
            this.idEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDevolucaoPrevista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelEmpPendentes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRelEmpPendentes
            // 
            this.dgvRelEmpPendentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRelEmpPendentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelEmpPendentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmprestimo,
            this.idLeitor,
            this.idLivro,
            this.dataEmprestimo,
            this.dataDevolucaoPrevista});
            this.dgvRelEmpPendentes.Location = new System.Drawing.Point(12, 24);
            this.dgvRelEmpPendentes.Name = "dgvRelEmpPendentes";
            this.dgvRelEmpPendentes.RowHeadersWidth = 51;
            this.dgvRelEmpPendentes.RowTemplate.Height = 24;
            this.dgvRelEmpPendentes.Size = new System.Drawing.Size(776, 414);
            this.dgvRelEmpPendentes.TabIndex = 0;
            // 
            // idEmprestimo
            // 
            this.idEmprestimo.HeaderText = "Identificação";
            this.idEmprestimo.MinimumWidth = 6;
            this.idEmprestimo.Name = "idEmprestimo";
            this.idEmprestimo.Width = 125;
            // 
            // idLeitor
            // 
            this.idLeitor.HeaderText = "Leitor";
            this.idLeitor.MinimumWidth = 6;
            this.idLeitor.Name = "idLeitor";
            this.idLeitor.Width = 125;
            // 
            // idLivro
            // 
            this.idLivro.HeaderText = "Livro";
            this.idLivro.MinimumWidth = 6;
            this.idLivro.Name = "idLivro";
            this.idLivro.Width = 125;
            // 
            // dataEmprestimo
            // 
            this.dataEmprestimo.HeaderText = "Retirada";
            this.dataEmprestimo.MinimumWidth = 6;
            this.dataEmprestimo.Name = "dataEmprestimo";
            this.dataEmprestimo.Width = 125;
            // 
            // dataDevolucaoPrevista
            // 
            this.dataDevolucaoPrevista.HeaderText = "Devolução prevista";
            this.dataDevolucaoPrevista.MinimumWidth = 6;
            this.dataDevolucaoPrevista.Name = "dataDevolucaoPrevista";
            this.dataDevolucaoPrevista.Width = 125;
            // 
            // FrmRelEmpPendentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvRelEmpPendentes);
            this.Name = "FrmRelEmpPendentes";
            this.Text = "FrmRelEmpPendentes";
            this.Load += new System.EventHandler(this.FrmRelEmpPendentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelEmpPendentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRelEmpPendentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDevolucaoPrevista;
    }
}