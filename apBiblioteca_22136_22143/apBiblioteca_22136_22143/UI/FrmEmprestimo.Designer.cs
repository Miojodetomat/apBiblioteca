﻿namespace apBiblioteca_22136_22143.UI
{
    partial class FrmEmprestimos
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
            this.tcEmprestimos = new System.Windows.Forms.TabControl();
            this.tpEmprestimo = new System.Windows.Forms.TabPage();
            this.dtDevPrev = new System.Windows.Forms.DateTimePicker();
            this.dtEmp = new System.Windows.Forms.DateTimePicker();
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
            this.tpDevolucao = new System.Windows.Forms.TabPage();
            this.btnProcurarDev = new System.Windows.Forms.Button();
            this.dtEmpDev = new System.Windows.Forms.DateTimePicker();
            this.dtDevReal = new System.Windows.Forms.DateTimePicker();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtIdLeitorDev = new System.Windows.Forms.TextBox();
            this.txtIdLivroDev = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdEmprestimoDev = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tpListaEmprestimos = new System.Windows.Forms.TabPage();
            this.dgvListaEmprestimos = new System.Windows.Forms.DataGridView();
            this.idEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDevolucaoPrevista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDevolucaoReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcEmprestimos.SuspendLayout();
            this.tpEmprestimo.SuspendLayout();
            this.tpDevolucao.SuspendLayout();
            this.tpListaEmprestimos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmprestimos)).BeginInit();
            this.SuspendLayout();
            // 
            // tcEmprestimos
            // 
            this.tcEmprestimos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcEmprestimos.Controls.Add(this.tpEmprestimo);
            this.tcEmprestimos.Controls.Add(this.tpDevolucao);
            this.tcEmprestimos.Controls.Add(this.tpListaEmprestimos);
            this.tcEmprestimos.Location = new System.Drawing.Point(12, 12);
            this.tcEmprestimos.Name = "tcEmprestimos";
            this.tcEmprestimos.SelectedIndex = 0;
            this.tcEmprestimos.Size = new System.Drawing.Size(806, 362);
            this.tcEmprestimos.TabIndex = 1;
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
            this.tpEmprestimo.Location = new System.Drawing.Point(4, 34);
            this.tpEmprestimo.Name = "tpEmprestimo";
            this.tpEmprestimo.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmprestimo.Size = new System.Drawing.Size(798, 324);
            this.tpEmprestimo.TabIndex = 0;
            this.tpEmprestimo.Text = "Emprestimo";
            this.tpEmprestimo.UseVisualStyleBackColor = true;
            // 
            // dtDevPrev
            // 
            this.dtDevPrev.Location = new System.Drawing.Point(281, 211);
            this.dtDevPrev.Name = "dtDevPrev";
            this.dtDevPrev.Size = new System.Drawing.Size(347, 30);
            this.dtDevPrev.TabIndex = 17;
            // 
            // dtEmp
            // 
            this.dtEmp.Location = new System.Drawing.Point(281, 166);
            this.dtEmp.Name = "dtEmp";
            this.dtEmp.Size = new System.Drawing.Size(347, 30);
            this.dtEmp.TabIndex = 16;
            // 
            // btnProcurar
            // 
            this.btnProcurar.BackColor = System.Drawing.Color.Silver;
            this.btnProcurar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProcurar.Location = new System.Drawing.Point(555, 24);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(77, 35);
            this.btnProcurar.TabIndex = 15;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = false;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Silver;
            this.btnAlterar.Location = new System.Drawing.Point(281, 268);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(77, 35);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Silver;
            this.btnExcluir.Location = new System.Drawing.Point(418, 268);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(77, 35);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.BackColor = System.Drawing.Color.Silver;
            this.btnExibir.Location = new System.Drawing.Point(555, 268);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(77, 35);
            this.btnExibir.TabIndex = 12;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = false;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Silver;
            this.btnNovo.Location = new System.Drawing.Point(144, 268);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(77, 35);
            this.btnNovo.TabIndex = 10;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtIdLeitor
            // 
            this.txtIdLeitor.Location = new System.Drawing.Point(281, 76);
            this.txtIdLeitor.MaxLength = 10;
            this.txtIdLeitor.Name = "txtIdLeitor";
            this.txtIdLeitor.Size = new System.Drawing.Size(222, 30);
            this.txtIdLeitor.TabIndex = 9;
            // 
            // txtIdLivro
            // 
            this.txtIdLivro.Location = new System.Drawing.Point(281, 121);
            this.txtIdLivro.MaxLength = 20;
            this.txtIdLivro.Name = "txtIdLivro";
            this.txtIdLivro.Size = new System.Drawing.Size(222, 30);
            this.txtIdLivro.TabIndex = 8;
            // 
            // txtIdEmprestimo
            // 
            this.txtIdEmprestimo.Location = new System.Drawing.Point(281, 31);
            this.txtIdEmprestimo.Name = "txtIdEmprestimo";
            this.txtIdEmprestimo.Size = new System.Drawing.Size(117, 30);
            this.txtIdEmprestimo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Id Leitor :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Id Livro :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data do empréstimo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de devolução prevista :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificação :";
            // 
            // tpDevolucao
            // 
            this.tpDevolucao.Controls.Add(this.btnProcurarDev);
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
            this.tpDevolucao.Location = new System.Drawing.Point(4, 25);
            this.tpDevolucao.Name = "tpDevolucao";
            this.tpDevolucao.Padding = new System.Windows.Forms.Padding(3);
            this.tpDevolucao.Size = new System.Drawing.Size(798, 333);
            this.tpDevolucao.TabIndex = 2;
            this.tpDevolucao.Text = "Devolução";
            this.tpDevolucao.UseVisualStyleBackColor = true;
            // 
            // btnProcurarDev
            // 
            this.btnProcurarDev.BackColor = System.Drawing.Color.Silver;
            this.btnProcurarDev.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProcurarDev.Location = new System.Drawing.Point(538, 34);
            this.btnProcurarDev.Name = "btnProcurarDev";
            this.btnProcurarDev.Size = new System.Drawing.Size(77, 35);
            this.btnProcurarDev.TabIndex = 20;
            this.btnProcurarDev.Text = "Procurar";
            this.btnProcurarDev.UseVisualStyleBackColor = false;
            this.btnProcurarDev.Click += new System.EventHandler(this.btnProcurarDev_Click);
            // 
            // dtEmpDev
            // 
            this.dtEmpDev.Location = new System.Drawing.Point(310, 165);
            this.dtEmpDev.Name = "dtEmpDev";
            this.dtEmpDev.Size = new System.Drawing.Size(344, 30);
            this.dtEmpDev.TabIndex = 19;
            // 
            // dtDevReal
            // 
            this.dtDevReal.Location = new System.Drawing.Point(310, 208);
            this.dtDevReal.Name = "dtDevReal";
            this.dtDevReal.Size = new System.Drawing.Size(344, 30);
            this.dtDevReal.TabIndex = 18;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Silver;
            this.btnAtualizar.Location = new System.Drawing.Point(341, 263);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(80, 37);
            this.btnAtualizar.TabIndex = 16;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtIdLeitorDev
            // 
            this.txtIdLeitorDev.Location = new System.Drawing.Point(310, 79);
            this.txtIdLeitorDev.MaxLength = 10;
            this.txtIdLeitorDev.Name = "txtIdLeitorDev";
            this.txtIdLeitorDev.ReadOnly = true;
            this.txtIdLeitorDev.Size = new System.Drawing.Size(196, 30);
            this.txtIdLeitorDev.TabIndex = 15;
            // 
            // txtIdLivroDev
            // 
            this.txtIdLivroDev.Location = new System.Drawing.Point(310, 122);
            this.txtIdLivroDev.MaxLength = 20;
            this.txtIdLivroDev.Name = "txtIdLivroDev";
            this.txtIdLivroDev.ReadOnly = true;
            this.txtIdLivroDev.Size = new System.Drawing.Size(196, 30);
            this.txtIdLivroDev.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(229, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Id Leitor :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(236, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Id Livro :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Data do empréstimo :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(124, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Data da devolução real :";
            // 
            // txtIdEmprestimoDev
            // 
            this.txtIdEmprestimoDev.Location = new System.Drawing.Point(310, 36);
            this.txtIdEmprestimoDev.Name = "txtIdEmprestimoDev";
            this.txtIdEmprestimoDev.Size = new System.Drawing.Size(111, 30);
            this.txtIdEmprestimoDev.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Identificação :";
            // 
            // tpListaEmprestimos
            // 
            this.tpListaEmprestimos.Controls.Add(this.dgvListaEmprestimos);
            this.tpListaEmprestimos.Location = new System.Drawing.Point(4, 25);
            this.tpListaEmprestimos.Name = "tpListaEmprestimos";
            this.tpListaEmprestimos.Padding = new System.Windows.Forms.Padding(3);
            this.tpListaEmprestimos.Size = new System.Drawing.Size(798, 333);
            this.tpListaEmprestimos.TabIndex = 1;
            this.tpListaEmprestimos.Text = "Lista";
            this.tpListaEmprestimos.UseVisualStyleBackColor = true;
            // 
            // dgvListaEmprestimos
            // 
            this.dgvListaEmprestimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaEmprestimos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmprestimo,
            this.idLeitor,
            this.idLivro,
            this.dataEmprestimo,
            this.dataDevolucaoPrevista,
            this.dataDevolucaoReal});
            this.dgvListaEmprestimos.Location = new System.Drawing.Point(-4, 0);
            this.dgvListaEmprestimos.Name = "dgvListaEmprestimos";
            this.dgvListaEmprestimos.RowHeadersWidth = 51;
            this.dgvListaEmprestimos.Size = new System.Drawing.Size(802, 329);
            this.dgvListaEmprestimos.TabIndex = 0;
            this.dgvListaEmprestimos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaEmprestimos_CellDoubleClick);
            // 
            // idEmprestimo
            // 
            this.idEmprestimo.HeaderText = "Identificação";
            this.idEmprestimo.MinimumWidth = 6;
            this.idEmprestimo.Name = "idEmprestimo";
            this.idEmprestimo.ReadOnly = true;
            this.idEmprestimo.Width = 125;
            // 
            // idLeitor
            // 
            this.idLeitor.HeaderText = "Id Leitor";
            this.idLeitor.MinimumWidth = 6;
            this.idLeitor.Name = "idLeitor";
            this.idLeitor.Width = 125;
            // 
            // idLivro
            // 
            this.idLivro.HeaderText = "Id Livro";
            this.idLivro.MinimumWidth = 6;
            this.idLivro.Name = "idLivro";
            this.idLivro.Width = 125;
            // 
            // dataEmprestimo
            // 
            this.dataEmprestimo.HeaderText = "Data do Empréstimo";
            this.dataEmprestimo.MaxInputLength = 50;
            this.dataEmprestimo.MinimumWidth = 6;
            this.dataEmprestimo.Name = "dataEmprestimo";
            this.dataEmprestimo.Width = 120;
            // 
            // dataDevolucaoPrevista
            // 
            this.dataDevolucaoPrevista.HeaderText = "Devolução Prevista";
            this.dataDevolucaoPrevista.MaxInputLength = 50;
            this.dataDevolucaoPrevista.MinimumWidth = 6;
            this.dataDevolucaoPrevista.Name = "dataDevolucaoPrevista";
            this.dataDevolucaoPrevista.Width = 170;
            // 
            // dataDevolucaoReal
            // 
            this.dataDevolucaoReal.HeaderText = "Devolução Real";
            this.dataDevolucaoReal.MinimumWidth = 6;
            this.dataDevolucaoReal.Name = "dataDevolucaoReal";
            this.dataDevolucaoReal.Width = 150;
            // 
            // FrmEmprestimos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(830, 386);
            this.Controls.Add(this.tcEmprestimos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Name = "FrmEmprestimos";
            this.Text = "Manutenção de empréstimos e devoluções da biblioteca";
            this.tcEmprestimos.ResumeLayout(false);
            this.tpEmprestimo.ResumeLayout(false);
            this.tpEmprestimo.PerformLayout();
            this.tpDevolucao.ResumeLayout(false);
            this.tpDevolucao.PerformLayout();
            this.tpListaEmprestimos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmprestimos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcEmprestimos;
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
        private System.Windows.Forms.TabPage tpListaEmprestimos;
        private System.Windows.Forms.DataGridView dgvListaEmprestimos;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDevolucaoPrevista;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDevolucaoReal;
        private System.Windows.Forms.Button btnProcurarDev;
    }
}