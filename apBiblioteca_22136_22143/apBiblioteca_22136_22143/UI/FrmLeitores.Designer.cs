namespace apBiblioteca_22136_22143.UI
{
    partial class FrmLeitores
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpCadastroLeitores = new System.Windows.Forms.TabPage();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtNomeLeitor = new System.Windows.Forms.TextBox();
            this.txtTelefoneLeitor = new System.Windows.Forms.TextBox();
            this.txtEmailLeitor = new System.Windows.Forms.TextBox();
            this.txtEnderecoLeitor = new System.Windows.Forms.TextBox();
            this.txtIdLeitor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpListaLeitores = new System.Windows.Forms.TabPage();
            this.dgvListaLeitores = new System.Windows.Forms.DataGridView();
            this.idLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tpCadastroLeitores.SuspendLayout();
            this.tpListaLeitores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaLeitores)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tpCadastroLeitores);
            this.tabControl.Controls.Add(this.tpListaLeitores);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(647, 337);
            this.tabControl.TabIndex = 0;
            // 
            // tpCadastroLeitores
            // 
            this.tpCadastroLeitores.Controls.Add(this.btnProcurar);
            this.tpCadastroLeitores.Controls.Add(this.btnAlterar);
            this.tpCadastroLeitores.Controls.Add(this.btnExcluir);
            this.tpCadastroLeitores.Controls.Add(this.btnExibir);
            this.tpCadastroLeitores.Controls.Add(this.btnNovo);
            this.tpCadastroLeitores.Controls.Add(this.txtNomeLeitor);
            this.tpCadastroLeitores.Controls.Add(this.txtTelefoneLeitor);
            this.tpCadastroLeitores.Controls.Add(this.txtEmailLeitor);
            this.tpCadastroLeitores.Controls.Add(this.txtEnderecoLeitor);
            this.tpCadastroLeitores.Controls.Add(this.txtIdLeitor);
            this.tpCadastroLeitores.Controls.Add(this.label5);
            this.tpCadastroLeitores.Controls.Add(this.label4);
            this.tpCadastroLeitores.Controls.Add(this.label3);
            this.tpCadastroLeitores.Controls.Add(this.label2);
            this.tpCadastroLeitores.Controls.Add(this.label1);
            this.tpCadastroLeitores.Location = new System.Drawing.Point(4, 29);
            this.tpCadastroLeitores.Name = "tpCadastroLeitores";
            this.tpCadastroLeitores.Padding = new System.Windows.Forms.Padding(3);
            this.tpCadastroLeitores.Size = new System.Drawing.Size(639, 304);
            this.tpCadastroLeitores.TabIndex = 0;
            this.tpCadastroLeitores.Text = "Cadastro";
            this.tpCadastroLeitores.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(240, 232);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(79, 31);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(360, 232);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(80, 31);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(484, 232);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(80, 31);
            this.btnExibir.TabIndex = 12;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(112, 232);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(82, 31);
            this.btnNovo.TabIndex = 10;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtNomeLeitor
            // 
            this.txtNomeLeitor.Location = new System.Drawing.Point(155, 75);
            this.txtNomeLeitor.MaxLength = 10;
            this.txtNomeLeitor.Name = "txtNomeLeitor";
            this.txtNomeLeitor.Size = new System.Drawing.Size(222, 26);
            this.txtNomeLeitor.TabIndex = 9;
            // 
            // txtTelefoneLeitor
            // 
            this.txtTelefoneLeitor.Location = new System.Drawing.Point(155, 107);
            this.txtTelefoneLeitor.MaxLength = 20;
            this.txtTelefoneLeitor.Name = "txtTelefoneLeitor";
            this.txtTelefoneLeitor.Size = new System.Drawing.Size(222, 26);
            this.txtTelefoneLeitor.TabIndex = 8;
            // 
            // txtEmailLeitor
            // 
            this.txtEmailLeitor.Location = new System.Drawing.Point(155, 141);
            this.txtEmailLeitor.MaxLength = 50;
            this.txtEmailLeitor.Name = "txtEmailLeitor";
            this.txtEmailLeitor.Size = new System.Drawing.Size(222, 26);
            this.txtEmailLeitor.TabIndex = 7;
            // 
            // txtEnderecoLeitor
            // 
            this.txtEnderecoLeitor.Location = new System.Drawing.Point(155, 173);
            this.txtEnderecoLeitor.MaxLength = 100;
            this.txtEnderecoLeitor.Name = "txtEnderecoLeitor";
            this.txtEnderecoLeitor.Size = new System.Drawing.Size(438, 26);
            this.txtEnderecoLeitor.TabIndex = 6;
            // 
            // txtIdLeitor
            // 
            this.txtIdLeitor.Location = new System.Drawing.Point(155, 43);
            this.txtIdLeitor.Name = "txtIdLeitor";
            this.txtIdLeitor.ReadOnly = true;
            this.txtIdLeitor.Size = new System.Drawing.Size(100, 26);
            this.txtIdLeitor.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nome :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificação :";
            // 
            // tpListaLeitores
            // 
            this.tpListaLeitores.Controls.Add(this.dgvListaLeitores);
            this.tpListaLeitores.Location = new System.Drawing.Point(4, 29);
            this.tpListaLeitores.Name = "tpListaLeitores";
            this.tpListaLeitores.Padding = new System.Windows.Forms.Padding(3);
            this.tpListaLeitores.Size = new System.Drawing.Size(639, 304);
            this.tpListaLeitores.TabIndex = 1;
            this.tpListaLeitores.Text = "Lista";
            this.tpListaLeitores.UseVisualStyleBackColor = true;
            // 
            // dgvListaLeitores
            // 
            this.dgvListaLeitores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaLeitores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLeitor,
            this.nomeLeitor,
            this.telefoneLeitor,
            this.emailLeitor,
            this.enderecoLeitor});
            this.dgvListaLeitores.Location = new System.Drawing.Point(6, 6);
            this.dgvListaLeitores.Name = "dgvListaLeitores";
            this.dgvListaLeitores.Size = new System.Drawing.Size(630, 292);
            this.dgvListaLeitores.TabIndex = 0;
            // 
            // idLeitor
            // 
            this.idLeitor.HeaderText = "Identificação";
            this.idLeitor.Name = "idLeitor";
            this.idLeitor.ReadOnly = true;
            // 
            // nomeLeitor
            // 
            this.nomeLeitor.HeaderText = "Nome";
            this.nomeLeitor.MaxInputLength = 10;
            this.nomeLeitor.Name = "nomeLeitor";
            this.nomeLeitor.Width = 90;
            // 
            // telefoneLeitor
            // 
            this.telefoneLeitor.HeaderText = "Telefone";
            this.telefoneLeitor.MaxInputLength = 20;
            this.telefoneLeitor.Name = "telefoneLeitor";
            this.telefoneLeitor.Width = 110;
            // 
            // emailLeitor
            // 
            this.emailLeitor.HeaderText = "E-mail";
            this.emailLeitor.MaxInputLength = 50;
            this.emailLeitor.Name = "emailLeitor";
            this.emailLeitor.Width = 120;
            // 
            // enderecoLeitor
            // 
            this.enderecoLeitor.HeaderText = "Endereço";
            this.enderecoLeitor.MaxInputLength = 100;
            this.enderecoLeitor.Name = "enderecoLeitor";
            this.enderecoLeitor.Width = 150;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(383, 72);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(88, 32);
            this.btnProcurar.TabIndex = 15;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // FrmLeitores
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(671, 361);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Name = "FrmLeitores";
            this.Text = "FrmLeitores";
            this.tabControl.ResumeLayout(false);
            this.tpCadastroLeitores.ResumeLayout(false);
            this.tpCadastroLeitores.PerformLayout();
            this.tpListaLeitores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaLeitores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpCadastroLeitores;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtNomeLeitor;
        private System.Windows.Forms.TextBox txtTelefoneLeitor;
        private System.Windows.Forms.TextBox txtEmailLeitor;
        private System.Windows.Forms.TextBox txtEnderecoLeitor;
        private System.Windows.Forms.TextBox txtIdLeitor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpListaLeitores;
        private System.Windows.Forms.DataGridView dgvListaLeitores;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoLeitor;
        private System.Windows.Forms.Button btnProcurar;
    }
}