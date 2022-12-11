namespace apBiblioteca_22136_22143.UI
{
    partial class FrmLivros
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
            this.tcLivros = new System.Windows.Forms.TabControl();
            this.tpCadastroLivros = new System.Windows.Forms.TabPage();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.Exibir = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtTituloLivro = new System.Windows.Forms.TextBox();
            this.txtAutorLivro = new System.Windows.Forms.TextBox();
            this.txtIdLivro = new System.Windows.Forms.TextBox();
            this.txtCodigoLivro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.tpListaLivros = new System.Windows.Forms.TabPage();
            this.dgvListaLivros = new System.Windows.Forms.DataGridView();
            this.idLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcLivros.SuspendLayout();
            this.tpCadastroLivros.SuspendLayout();
            this.tpListaLivros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // tcLivros
            // 
            this.tcLivros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcLivros.Controls.Add(this.tpCadastroLivros);
            this.tcLivros.Controls.Add(this.tpListaLivros);
            this.tcLivros.Location = new System.Drawing.Point(12, 12);
            this.tcLivros.Name = "tcLivros";
            this.tcLivros.SelectedIndex = 0;
            this.tcLivros.Size = new System.Drawing.Size(662, 322);
            this.tcLivros.TabIndex = 0;
            // 
            // tpCadastroLivros
            // 
            this.tpCadastroLivros.Controls.Add(this.btnNovo);
            this.tpCadastroLivros.Controls.Add(this.btnAlterar);
            this.tpCadastroLivros.Controls.Add(this.btnExcluir);
            this.tpCadastroLivros.Controls.Add(this.Exibir);
            this.tpCadastroLivros.Controls.Add(this.btnProcurar);
            this.tpCadastroLivros.Controls.Add(this.txtTituloLivro);
            this.tpCadastroLivros.Controls.Add(this.txtAutorLivro);
            this.tpCadastroLivros.Controls.Add(this.txtIdLivro);
            this.tpCadastroLivros.Controls.Add(this.txtCodigoLivro);
            this.tpCadastroLivros.Controls.Add(this.label4);
            this.tpCadastroLivros.Controls.Add(this.label3);
            this.tpCadastroLivros.Controls.Add(this.label2);
            this.tpCadastroLivros.Controls.Add(this.lbId);
            this.tpCadastroLivros.Location = new System.Drawing.Point(4, 34);
            this.tpCadastroLivros.Name = "tpCadastroLivros";
            this.tpCadastroLivros.Padding = new System.Windows.Forms.Padding(3);
            this.tpCadastroLivros.Size = new System.Drawing.Size(654, 284);
            this.tpCadastroLivros.TabIndex = 0;
            this.tpCadastroLivros.Text = "Cadastro";
            this.tpCadastroLivros.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Silver;
            this.btnNovo.Location = new System.Drawing.Point(106, 220);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(77, 35);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Silver;
            this.btnAlterar.Location = new System.Drawing.Point(228, 220);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(77, 35);
            this.btnAlterar.TabIndex = 11;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Silver;
            this.btnExcluir.Location = new System.Drawing.Point(350, 220);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(77, 35);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // Exibir
            // 
            this.Exibir.BackColor = System.Drawing.Color.Silver;
            this.Exibir.Location = new System.Drawing.Point(472, 220);
            this.Exibir.Name = "Exibir";
            this.Exibir.Size = new System.Drawing.Size(77, 35);
            this.Exibir.TabIndex = 9;
            this.Exibir.Text = "Exibir";
            this.Exibir.UseVisualStyleBackColor = false;
            this.Exibir.Click += new System.EventHandler(this.Exibir_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.BackColor = System.Drawing.Color.Silver;
            this.btnProcurar.Location = new System.Drawing.Point(472, 39);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(77, 35);
            this.btnProcurar.TabIndex = 8;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = false;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // txtTituloLivro
            // 
            this.txtTituloLivro.Location = new System.Drawing.Point(170, 121);
            this.txtTituloLivro.MaxLength = 50;
            this.txtTituloLivro.Name = "txtTituloLivro";
            this.txtTituloLivro.Size = new System.Drawing.Size(443, 30);
            this.txtTituloLivro.TabIndex = 7;
            // 
            // txtAutorLivro
            // 
            this.txtAutorLivro.Location = new System.Drawing.Point(170, 160);
            this.txtAutorLivro.MaxLength = 50;
            this.txtAutorLivro.Name = "txtAutorLivro";
            this.txtAutorLivro.Size = new System.Drawing.Size(443, 30);
            this.txtAutorLivro.TabIndex = 6;
            // 
            // txtIdLivro
            // 
            this.txtIdLivro.Location = new System.Drawing.Point(170, 43);
            this.txtIdLivro.Name = "txtIdLivro";
            this.txtIdLivro.ReadOnly = true;
            this.txtIdLivro.Size = new System.Drawing.Size(135, 30);
            this.txtIdLivro.TabIndex = 5;
            // 
            // txtCodigoLivro
            // 
            this.txtCodigoLivro.Location = new System.Drawing.Point(170, 82);
            this.txtCodigoLivro.MaxLength = 10;
            this.txtCodigoLivro.Name = "txtCodigoLivro";
            this.txtCodigoLivro.Size = new System.Drawing.Size(150, 30);
            this.txtCodigoLivro.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Autor(es) do livro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Título do Livro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código do livro:";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(48, 46);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(127, 25);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "Identificação:";
            // 
            // tpListaLivros
            // 
            this.tpListaLivros.BackColor = System.Drawing.Color.DarkGray;
            this.tpListaLivros.Controls.Add(this.dgvListaLivros);
            this.tpListaLivros.Location = new System.Drawing.Point(4, 34);
            this.tpListaLivros.Name = "tpListaLivros";
            this.tpListaLivros.Padding = new System.Windows.Forms.Padding(3);
            this.tpListaLivros.Size = new System.Drawing.Size(654, 284);
            this.tpListaLivros.TabIndex = 1;
            this.tpListaLivros.Text = "Lista";
            // 
            // dgvListaLivros
            // 
            this.dgvListaLivros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLivro,
            this.codigoLivro,
            this.tituloLivro,
            this.autorLivro});
            this.dgvListaLivros.Location = new System.Drawing.Point(-4, 6);
            this.dgvListaLivros.Name = "dgvListaLivros";
            this.dgvListaLivros.RowHeadersWidth = 51;
            this.dgvListaLivros.Size = new System.Drawing.Size(658, 282);
            this.dgvListaLivros.TabIndex = 0;
            this.dgvListaLivros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaLivros_CellDoubleClick);
            // 
            // idLivro
            // 
            this.idLivro.HeaderText = "Identificação";
            this.idLivro.MinimumWidth = 6;
            this.idLivro.Name = "idLivro";
            this.idLivro.ReadOnly = true;
            this.idLivro.Width = 125;
            // 
            // codigoLivro
            // 
            this.codigoLivro.HeaderText = "Código";
            this.codigoLivro.MaxInputLength = 10;
            this.codigoLivro.MinimumWidth = 6;
            this.codigoLivro.Name = "codigoLivro";
            this.codigoLivro.Width = 125;
            // 
            // tituloLivro
            // 
            this.tituloLivro.HeaderText = "Título";
            this.tituloLivro.MaxInputLength = 50;
            this.tituloLivro.MinimumWidth = 6;
            this.tituloLivro.Name = "tituloLivro";
            this.tituloLivro.Width = 200;
            // 
            // autorLivro
            // 
            this.autorLivro.HeaderText = "Autor(es)";
            this.autorLivro.MaxInputLength = 50;
            this.autorLivro.MinimumWidth = 6;
            this.autorLivro.Name = "autorLivro";
            this.autorLivro.Width = 200;
            // 
            // FrmLivros
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(686, 346);
            this.Controls.Add(this.tcLivros);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Name = "FrmLivros";
            this.Text = "Manutenção de livros de biblioteca";
            this.tcLivros.ResumeLayout(false);
            this.tpCadastroLivros.ResumeLayout(false);
            this.tpCadastroLivros.PerformLayout();
            this.tpListaLivros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaLivros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcLivros;
        private System.Windows.Forms.TabPage tpCadastroLivros;
        private System.Windows.Forms.TabPage tpListaLivros;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtTituloLivro;
        private System.Windows.Forms.TextBox txtAutorLivro;
        private System.Windows.Forms.TextBox txtIdLivro;
        private System.Windows.Forms.TextBox txtCodigoLivro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button Exibir;
        private System.Windows.Forms.DataGridView dgvListaLivros;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorLivro;
    }
}