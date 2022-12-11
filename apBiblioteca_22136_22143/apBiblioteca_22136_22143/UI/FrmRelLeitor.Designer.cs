namespace apBiblioteca_22136_22143.UI
{
    partial class FrmRelLeitor
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
            this.dgvLeitores = new System.Windows.Forms.DataGridView();
            this.idEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devolucaoPrevista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tpDgvLeitores = new System.Windows.Forms.TabPage();
            this.btnExibir = new System.Windows.Forms.Button();
            this.lbIdLeitor = new System.Windows.Forms.Label();
            this.txtIdLeitor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitores)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tpDgvLeitores.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLeitores
            // 
            this.dgvLeitores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeitores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmprestimo,
            this.nomeLeitor,
            this.nomeLivro,
            this.dataEmprestimo,
            this.devolucaoPrevista});
            this.dgvLeitores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLeitores.Location = new System.Drawing.Point(3, 3);
            this.dgvLeitores.Name = "dgvLeitores";
            this.dgvLeitores.RowHeadersWidth = 51;
            this.dgvLeitores.RowTemplate.Height = 24;
            this.dgvLeitores.Size = new System.Drawing.Size(762, 391);
            this.dgvLeitores.TabIndex = 0;
            // 
            // idEmprestimo
            // 
            this.idEmprestimo.HeaderText = "Identificação";
            this.idEmprestimo.MinimumWidth = 6;
            this.idEmprestimo.Name = "idEmprestimo";
            this.idEmprestimo.Width = 125;
            // 
            // nomeLeitor
            // 
            this.nomeLeitor.HeaderText = "Leitor";
            this.nomeLeitor.MinimumWidth = 6;
            this.nomeLeitor.Name = "nomeLeitor";
            this.nomeLeitor.Width = 125;
            // 
            // nomeLivro
            // 
            this.nomeLivro.HeaderText = "Livro";
            this.nomeLivro.MinimumWidth = 6;
            this.nomeLivro.Name = "nomeLivro";
            this.nomeLivro.Width = 125;
            // 
            // dataEmprestimo
            // 
            this.dataEmprestimo.HeaderText = "Retirada";
            this.dataEmprestimo.MinimumWidth = 6;
            this.dataEmprestimo.Name = "dataEmprestimo";
            this.dataEmprestimo.Width = 125;
            // 
            // devolucaoPrevista
            // 
            this.devolucaoPrevista.HeaderText = "Devolução Prevista";
            this.devolucaoPrevista.MinimumWidth = 6;
            this.devolucaoPrevista.Name = "devolucaoPrevista";
            this.devolucaoPrevista.Width = 125;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tpDgvLeitores);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnExibir);
            this.tabPage1.Controls.Add(this.lbIdLeitor);
            this.tabPage1.Controls.Add(this.txtIdLeitor);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Leitor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tpDgvLeitores
            // 
            this.tpDgvLeitores.Controls.Add(this.dgvLeitores);
            this.tpDgvLeitores.Location = new System.Drawing.Point(4, 25);
            this.tpDgvLeitores.Name = "tpDgvLeitores";
            this.tpDgvLeitores.Padding = new System.Windows.Forms.Padding(3);
            this.tpDgvLeitores.Size = new System.Drawing.Size(768, 397);
            this.tpDgvLeitores.TabIndex = 1;
            this.tpDgvLeitores.Text = "Relatório";
            this.tpDgvLeitores.UseVisualStyleBackColor = true;
            // 
            // btnExibir
            // 
            this.btnExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExibir.Location = new System.Drawing.Point(152, 129);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(92, 37);
            this.btnExibir.TabIndex = 5;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // lbIdLeitor
            // 
            this.lbIdLeitor.AutoSize = true;
            this.lbIdLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbIdLeitor.Location = new System.Drawing.Point(60, 66);
            this.lbIdLeitor.Name = "lbIdLeitor";
            this.lbIdLeitor.Size = new System.Drawing.Size(92, 25);
            this.lbIdLeitor.TabIndex = 4;
            this.lbIdLeitor.Text = "Id Leitor :";
            // 
            // txtIdLeitor
            // 
            this.txtIdLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtIdLeitor.Location = new System.Drawing.Point(152, 66);
            this.txtIdLeitor.Name = "txtIdLeitor";
            this.txtIdLeitor.Size = new System.Drawing.Size(260, 30);
            this.txtIdLeitor.TabIndex = 3;
            // 
            // FrmRelLeitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmRelLeitor";
            this.Text = "FrmRelLeitor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitores)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tpDgvLeitores.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLeitores;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn devolucaoPrevista;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tpDgvLeitores;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Label lbIdLeitor;
        private System.Windows.Forms.TextBox txtIdLeitor;
    }
}