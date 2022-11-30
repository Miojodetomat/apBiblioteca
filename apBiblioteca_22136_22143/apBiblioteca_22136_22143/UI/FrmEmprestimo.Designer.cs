namespace apBiblioteca_22136_22143
{
    partial class FrmEmprestimo
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
            this.tpEmprestimo = new System.Windows.Forms.TabPage();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtIdLeitor = new System.Windows.Forms.TextBox();
            this.txtIdLivro = new System.Windows.Forms.TextBox();
            this.txtIdEmprestimo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpListaLeitores = new System.Windows.Forms.TabPage();
            this.dgvEmprestimos = new System.Windows.Forms.DataGridView();
            this.idLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpDevolucao = new System.Windows.Forms.TabPage();
            this.txtIdEmprestimoDev = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdLeitorDev = new System.Windows.Forms.TextBox();
            this.txtIdLivroDev = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.dtEmp = new System.Windows.Forms.DateTimePicker();
            this.dtDevPrev = new System.Windows.Forms.DateTimePicker();
            this.dtDevReal = new System.Windows.Forms.DateTimePicker();
            this.dtEmpDev = new System.Windows.Forms.DateTimePicker();
            this.tabControl.SuspendLayout();
            this.tpEmprestimo.SuspendLayout();
            this.tpListaLeitores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimos)).BeginInit();
            this.tpDevolucao.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tpEmprestimo);
            this.tabControl.Controls.Add(this.tpDevolucao);
            this.tabControl.Controls.Add(this.tpListaLeitores);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(743, 362);
            this.tabControl.TabIndex = 1;
            // 
            // tpEmprestimo
            // 
            this.tpEmprestimo.Controls.Add(this.dtDevPrev);
            this.tpEmprestimo.Controls.Add(this.dtEmp);
            this.tpEmprestimo.Controls.Add(this.btnProcurar);
            this.tpEmprestimo.Controls.Add(this.btnAlterar);
            this.tpEmprestimo.Controls.Add(this.btnExcluir);
            this.tpEmprestimo.Controls.Add(this.btnExibir);
            this.tpEmprestimo.Controls.Add(this.btnNovo);
            this.tpEmprestimo.Controls.Add(this.txtIdLeitor);
            this.tpEmprestimo.Controls.Add(this.txtIdLivro);
            this.tpEmprestimo.Controls.Add(this.txtIdEmprestimo);
            this.tpEmprestimo.Controls.Add(this.label5);
            this.tpEmprestimo.Controls.Add(this.label4);
            this.tpEmprestimo.Controls.Add(this.label3);
            this.tpEmprestimo.Controls.Add(this.label2);
            this.tpEmprestimo.Controls.Add(this.label1);
            this.tpEmprestimo.Location = new System.Drawing.Point(4, 29);
            this.tpEmprestimo.Name = "tpEmprestimo";
            this.tpEmprestimo.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmprestimo.Size = new System.Drawing.Size(735, 329);
            this.tpEmprestimo.TabIndex = 0;
            this.tpEmprestimo.Text = "Emprestimo";
            this.tpEmprestimo.UseVisualStyleBackColor = true;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(495, 73);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(88, 32);
            this.btnProcurar.TabIndex = 15;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(263, 276);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(79, 31);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(424, 276);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(80, 31);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(593, 276);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(80, 31);
            this.btnExibir.TabIndex = 12;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(96, 276);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(82, 31);
            this.btnNovo.TabIndex = 10;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtIdLeitor
            // 
            this.txtIdLeitor.Location = new System.Drawing.Point(247, 76);
            this.txtIdLeitor.MaxLength = 10;
            this.txtIdLeitor.Name = "txtIdLeitor";
            this.txtIdLeitor.Size = new System.Drawing.Size(222, 26);
            this.txtIdLeitor.TabIndex = 9;
            // 
            // txtIdLivro
            // 
            this.txtIdLivro.Location = new System.Drawing.Point(247, 121);
            this.txtIdLivro.MaxLength = 20;
            this.txtIdLivro.Name = "txtIdLivro";
            this.txtIdLivro.Size = new System.Drawing.Size(222, 26);
            this.txtIdLivro.TabIndex = 8;
            // 
            // txtIdEmprestimo
            // 
            this.txtIdEmprestimo.Location = new System.Drawing.Point(247, 31);
            this.txtIdEmprestimo.Name = "txtIdEmprestimo";
            this.txtIdEmprestimo.ReadOnly = true;
            this.txtIdEmprestimo.Size = new System.Drawing.Size(100, 26);
            this.txtIdEmprestimo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Id Leitor :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Id Livro :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data do empréstimo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de devolução prevista :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificação :";
            // 
            // tpListaLeitores
            // 
            this.tpListaLeitores.Controls.Add(this.dgvEmprestimos);
            this.tpListaLeitores.Location = new System.Drawing.Point(4, 29);
            this.tpListaLeitores.Name = "tpListaLeitores";
            this.tpListaLeitores.Padding = new System.Windows.Forms.Padding(3);
            this.tpListaLeitores.Size = new System.Drawing.Size(735, 329);
            this.tpListaLeitores.TabIndex = 1;
            this.tpListaLeitores.Text = "Lista";
            this.tpListaLeitores.UseVisualStyleBackColor = true;
            // 
            // dgvEmprestimos
            // 
            this.dgvEmprestimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmprestimos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLeitor,
            this.nomeLeitor,
            this.telefoneLeitor,
            this.emailLeitor,
            this.enderecoLeitor});
            this.dgvEmprestimos.Location = new System.Drawing.Point(6, 6);
            this.dgvEmprestimos.Name = "dgvEmprestimos";
            this.dgvEmprestimos.Size = new System.Drawing.Size(630, 292);
            this.dgvEmprestimos.TabIndex = 0;
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
            // tpDevolucao
            // 
            this.tpDevolucao.Controls.Add(this.dtEmpDev);
            this.tpDevolucao.Controls.Add(this.dtDevReal);
            this.tpDevolucao.Controls.Add(this.btnAtualizar);
            this.tpDevolucao.Controls.Add(this.txtIdLeitorDev);
            this.tpDevolucao.Controls.Add(this.txtIdLivroDev);
            this.tpDevolucao.Controls.Add(this.label9);
            this.tpDevolucao.Controls.Add(this.label10);
            this.tpDevolucao.Controls.Add(this.label8);
            this.tpDevolucao.Controls.Add(this.label7);
            this.tpDevolucao.Controls.Add(this.txtIdEmprestimoDev);
            this.tpDevolucao.Controls.Add(this.label6);
            this.tpDevolucao.Location = new System.Drawing.Point(4, 29);
            this.tpDevolucao.Name = "tpDevolucao";
            this.tpDevolucao.Padding = new System.Windows.Forms.Padding(3);
            this.tpDevolucao.Size = new System.Drawing.Size(735, 329);
            this.tpDevolucao.TabIndex = 2;
            this.tpDevolucao.Text = "Devolução";
            this.tpDevolucao.UseVisualStyleBackColor = true;
            // 
            // txtIdEmprestimoDev
            // 
            this.txtIdEmprestimoDev.Location = new System.Drawing.Point(222, 37);
            this.txtIdEmprestimoDev.Name = "txtIdEmprestimoDev";
            this.txtIdEmprestimoDev.ReadOnly = true;
            this.txtIdEmprestimoDev.Size = new System.Drawing.Size(100, 26);
            this.txtIdEmprestimoDev.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Identificação :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Data da devolução real :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Data do empréstimo :";
            // 
            // txtIdLeitorDev
            // 
            this.txtIdLeitorDev.Location = new System.Drawing.Point(223, 78);
            this.txtIdLeitorDev.MaxLength = 10;
            this.txtIdLeitorDev.Name = "txtIdLeitorDev";
            this.txtIdLeitorDev.ReadOnly = true;
            this.txtIdLeitorDev.Size = new System.Drawing.Size(222, 26);
            this.txtIdLeitorDev.TabIndex = 15;
            // 
            // txtIdLivroDev
            // 
            this.txtIdLivroDev.Location = new System.Drawing.Point(223, 123);
            this.txtIdLivroDev.MaxLength = 20;
            this.txtIdLivroDev.Name = "txtIdLivroDev";
            this.txtIdLivroDev.ReadOnly = true;
            this.txtIdLivroDev.Size = new System.Drawing.Size(222, 26);
            this.txtIdLivroDev.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(141, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Id Leitor :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(148, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Id Livro :";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(245, 261);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(96, 31);
            this.btnAtualizar.TabIndex = 16;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // dtEmp
            // 
            this.dtEmp.Location = new System.Drawing.Point(247, 166);
            this.dtEmp.Name = "dtEmp";
            this.dtEmp.Size = new System.Drawing.Size(321, 26);
            this.dtEmp.TabIndex = 16;
            // 
            // dtDevPrev
            // 
            this.dtDevPrev.Location = new System.Drawing.Point(247, 214);
            this.dtDevPrev.Name = "dtDevPrev";
            this.dtDevPrev.Size = new System.Drawing.Size(321, 26);
            this.dtDevPrev.TabIndex = 17;
            // 
            // dtDevReal
            // 
            this.dtDevReal.Location = new System.Drawing.Point(222, 210);
            this.dtDevReal.Name = "dtDevReal";
            this.dtDevReal.Size = new System.Drawing.Size(321, 26);
            this.dtDevReal.TabIndex = 18;
            // 
            // dtEmpDev
            // 
            this.dtEmpDev.Location = new System.Drawing.Point(222, 167);
            this.dtEmpDev.Name = "dtEmpDev";
            this.dtEmpDev.Size = new System.Drawing.Size(321, 26);
            this.dtEmpDev.TabIndex = 19;
            // 
            // FrmEmprestimo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(767, 386);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Name = "FrmEmprestimo";
            this.Text = "FrmEmprestimo";
            this.tabControl.ResumeLayout(false);
            this.tpEmprestimo.ResumeLayout(false);
            this.tpEmprestimo.PerformLayout();
            this.tpListaLeitores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimos)).EndInit();
            this.tpDevolucao.ResumeLayout(false);
            this.tpDevolucao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpEmprestimo;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtIdLeitor;
        private System.Windows.Forms.TextBox txtIdLivro;
        private System.Windows.Forms.TextBox txtIdEmprestimo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpListaLeitores;
        private System.Windows.Forms.DataGridView dgvEmprestimos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoLeitor;
        private System.Windows.Forms.TabPage tpDevolucao;
        private System.Windows.Forms.TextBox txtIdLeitorDev;
        private System.Windows.Forms.TextBox txtIdLivroDev;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdEmprestimoDev;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.DateTimePicker dtDevPrev;
        private System.Windows.Forms.DateTimePicker dtEmp;
        private System.Windows.Forms.DateTimePicker dtEmpDev;
        private System.Windows.Forms.DateTimePicker dtDevReal;
    }
}