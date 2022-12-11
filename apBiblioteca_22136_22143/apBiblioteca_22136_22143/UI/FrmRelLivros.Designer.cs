namespace apBiblioteca_22136_22143.UI
{
    partial class FrmRelLivros
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpBusca = new System.Windows.Forms.TabPage();
            this.tpRelatorio = new System.Windows.Forms.TabPage();
            this.txtIdLivro = new System.Windows.Forms.TextBox();
            this.lbIdLivro = new System.Windows.Forms.Label();
            this.btnExibir = new System.Windows.Forms.Button();
            this.dgvRelLivros = new System.Windows.Forms.DataGridView();
            this.idEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDevolucaoPrevista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tpBusca.SuspendLayout();
            this.tpRelatorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpBusca);
            this.tabControl1.Controls.Add(this.tpRelatorio);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tpBusca
            // 
            this.tpBusca.Controls.Add(this.btnExibir);
            this.tpBusca.Controls.Add(this.lbIdLivro);
            this.tpBusca.Controls.Add(this.txtIdLivro);
            this.tpBusca.Location = new System.Drawing.Point(4, 25);
            this.tpBusca.Name = "tpBusca";
            this.tpBusca.Padding = new System.Windows.Forms.Padding(3);
            this.tpBusca.Size = new System.Drawing.Size(768, 397);
            this.tpBusca.TabIndex = 0;
            this.tpBusca.Text = "Buscar";
            this.tpBusca.UseVisualStyleBackColor = true;
            // 
            // tpRelatorio
            // 
            this.tpRelatorio.Controls.Add(this.dgvRelLivros);
            this.tpRelatorio.Location = new System.Drawing.Point(4, 25);
            this.tpRelatorio.Name = "tpRelatorio";
            this.tpRelatorio.Padding = new System.Windows.Forms.Padding(3);
            this.tpRelatorio.Size = new System.Drawing.Size(768, 397);
            this.tpRelatorio.TabIndex = 1;
            this.tpRelatorio.Text = "Relatório";
            this.tpRelatorio.UseVisualStyleBackColor = true;
            // 
            // txtIdLivro
            // 
            this.txtIdLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtIdLivro.Location = new System.Drawing.Point(169, 78);
            this.txtIdLivro.Name = "txtIdLivro";
            this.txtIdLivro.Size = new System.Drawing.Size(260, 30);
            this.txtIdLivro.TabIndex = 0;
            // 
            // lbIdLivro
            // 
            this.lbIdLivro.AutoSize = true;
            this.lbIdLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbIdLivro.Location = new System.Drawing.Point(77, 78);
            this.lbIdLivro.Name = "lbIdLivro";
            this.lbIdLivro.Size = new System.Drawing.Size(86, 25);
            this.lbIdLivro.TabIndex = 1;
            this.lbIdLivro.Text = "Id Livro :";
            // 
            // btnExibir
            // 
            this.btnExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExibir.Location = new System.Drawing.Point(169, 141);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(92, 37);
            this.btnExibir.TabIndex = 2;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // dgvRelLivros
            // 
            this.dgvRelLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmprestimo,
            this.nomeLivro,
            this.nomeLeitor,
            this.dataEmprestimo,
            this.dataDevolucaoPrevista});
            this.dgvRelLivros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRelLivros.Location = new System.Drawing.Point(3, 3);
            this.dgvRelLivros.Name = "dgvRelLivros";
            this.dgvRelLivros.RowHeadersWidth = 51;
            this.dgvRelLivros.RowTemplate.Height = 24;
            this.dgvRelLivros.Size = new System.Drawing.Size(762, 391);
            this.dgvRelLivros.TabIndex = 0;
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
            // dataDevolucaoPrevista
            // 
            this.dataDevolucaoPrevista.HeaderText = "Devolução Prevista";
            this.dataDevolucaoPrevista.MinimumWidth = 6;
            this.dataDevolucaoPrevista.Name = "dataDevolucaoPrevista";
            this.dataDevolucaoPrevista.Width = 125;
            // 
            // FrmRelLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmRelLivros";
            this.Text = "FrmRelLivros";
            this.tabControl1.ResumeLayout(false);
            this.tpBusca.ResumeLayout(false);
            this.tpBusca.PerformLayout();
            this.tpRelatorio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelLivros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpBusca;
        private System.Windows.Forms.TabPage tpRelatorio;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Label lbIdLivro;
        private System.Windows.Forms.TextBox txtIdLivro;
        private System.Windows.Forms.DataGridView dgvRelLivros;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDevolucaoPrevista;
    }
}