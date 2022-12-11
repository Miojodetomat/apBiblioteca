namespace apBiblioteca_22136_22143
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.msOpcoes = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leitoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emprestimosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devoluçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatótiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nÃOToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.simToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pEmpréstimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolvidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pLeitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msOpcoes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msOpcoes
            // 
            this.msOpcoes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msOpcoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.operaçõesToolStripMenuItem,
            this.relatótiosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.msOpcoes.Location = new System.Drawing.Point(0, 0);
            this.msOpcoes.Name = "msOpcoes";
            this.msOpcoes.Size = new System.Drawing.Size(379, 30);
            this.msOpcoes.TabIndex = 0;
            this.msOpcoes.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livrosToolStripMenuItem,
            this.leitoresToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem1});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(82, 26);
            this.cadastroToolStripMenuItem.Text = "&Cadastro";
            // 
            // livrosToolStripMenuItem
            // 
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.livrosToolStripMenuItem.Text = "&Livros";
            this.livrosToolStripMenuItem.Click += new System.EventHandler(this.livrosToolStripMenuItem_Click);
            // 
            // leitoresToolStripMenuItem
            // 
            this.leitoresToolStripMenuItem.Name = "leitoresToolStripMenuItem";
            this.leitoresToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.leitoresToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.leitoresToolStripMenuItem.Text = "L&eitores";
            this.leitoresToolStripMenuItem.Click += new System.EventHandler(this.leitoresToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(193, 6);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nãoToolStripMenuItem,
            this.simToolStripMenuItem});
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(196, 26);
            this.sairToolStripMenuItem1.Text = "Sai&r";
            // 
            // nãoToolStripMenuItem
            // 
            this.nãoToolStripMenuItem.Name = "nãoToolStripMenuItem";
            this.nãoToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.nãoToolStripMenuItem.Text = "Não";
            // 
            // simToolStripMenuItem
            // 
            this.simToolStripMenuItem.Name = "simToolStripMenuItem";
            this.simToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.simToolStripMenuItem.Text = "Sim";
            this.simToolStripMenuItem.Click += new System.EventHandler(this.simToolStripMenuItem1_Click);
            // 
            // operaçõesToolStripMenuItem
            // 
            this.operaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emprestimosToolStripMenuItem,
            this.devoluçõesToolStripMenuItem});
            this.operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            this.operaçõesToolStripMenuItem.Size = new System.Drawing.Size(94, 26);
            this.operaçõesToolStripMenuItem.Text = "&Operações";
            // 
            // emprestimosToolStripMenuItem
            // 
            this.emprestimosToolStripMenuItem.Name = "emprestimosToolStripMenuItem";
            this.emprestimosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.emprestimosToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.emprestimosToolStripMenuItem.Text = "E&mpréstimos";
            this.emprestimosToolStripMenuItem.Click += new System.EventHandler(this.emprestimosToolStripMenuItem_Click);
            // 
            // devoluçõesToolStripMenuItem
            // 
            this.devoluçõesToolStripMenuItem.Name = "devoluçõesToolStripMenuItem";
            this.devoluçõesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.devoluçõesToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.devoluçõesToolStripMenuItem.Text = "De&voluções";
            this.devoluçõesToolStripMenuItem.Click += new System.EventHandler(this.devoluçõesToolStripMenuItem_Click);
            // 
            // relatótiosToolStripMenuItem
            // 
            this.relatótiosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pEmpréstimoToolStripMenuItem,
            this.pLeitorToolStripMenuItem,
            this.pLivroToolStripMenuItem});
            this.relatótiosToolStripMenuItem.Name = "relatótiosToolStripMenuItem";
            this.relatótiosToolStripMenuItem.Size = new System.Drawing.Size(90, 26);
            this.relatótiosToolStripMenuItem.Text = "&Relatótios";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nÃOToolStripMenuItem1,
            this.simToolStripMenuItem1});
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 26);
            this.sairToolStripMenuItem.Text = "&Sair";
            // 
            // nÃOToolStripMenuItem1
            // 
            this.nÃOToolStripMenuItem1.Name = "nÃOToolStripMenuItem1";
            this.nÃOToolStripMenuItem1.Size = new System.Drawing.Size(120, 26);
            this.nÃOToolStripMenuItem1.Text = "Não";
            // 
            // simToolStripMenuItem1
            // 
            this.simToolStripMenuItem1.Name = "simToolStripMenuItem1";
            this.simToolStripMenuItem1.Size = new System.Drawing.Size(120, 26);
            this.simToolStripMenuItem1.Text = "Sim";
            this.simToolStripMenuItem1.Click += new System.EventHandler(this.simToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Banco de dados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Senha:";
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(155, 37);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(164, 30);
            this.txtBanco.TabIndex = 4;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(155, 69);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(164, 30);
            this.txtUsuario.TabIndex = 5;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(155, 101);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(164, 30);
            this.txtSenha.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBanco);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 151);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conexão";
            // 
            // pEmpréstimoToolStripMenuItem
            // 
            this.pEmpréstimoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pendentesToolStripMenuItem,
            this.devolvidosToolStripMenuItem});
            this.pEmpréstimoToolStripMenuItem.Name = "pEmpréstimoToolStripMenuItem";
            this.pEmpréstimoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pEmpréstimoToolStripMenuItem.Text = "p/ Empréstimo";
            // 
            // pendentesToolStripMenuItem
            // 
            this.pendentesToolStripMenuItem.Name = "pendentesToolStripMenuItem";
            this.pendentesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pendentesToolStripMenuItem.Text = "Pendentes";
            this.pendentesToolStripMenuItem.Click += new System.EventHandler(this.pendentesToolStripMenuItem_Click);
            // 
            // devolvidosToolStripMenuItem
            // 
            this.devolvidosToolStripMenuItem.Name = "devolvidosToolStripMenuItem";
            this.devolvidosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.devolvidosToolStripMenuItem.Text = "Devolvidos";
            this.devolvidosToolStripMenuItem.Click += new System.EventHandler(this.devolvidosToolStripMenuItem_Click);
            // 
            // pLeitorToolStripMenuItem
            // 
            this.pLeitorToolStripMenuItem.Name = "pLeitorToolStripMenuItem";
            this.pLeitorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pLeitorToolStripMenuItem.Text = "p/ Leitor";
            this.pLeitorToolStripMenuItem.Click += new System.EventHandler(this.pLeitorToolStripMenuItem_Click);
            // 
            // pLivroToolStripMenuItem
            // 
            this.pLivroToolStripMenuItem.Name = "pLivroToolStripMenuItem";
            this.pLivroToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pLivroToolStripMenuItem.Text = "p/ Livro";
            this.pLivroToolStripMenuItem.Click += new System.EventHandler(this.pLivroToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(379, 200);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.msOpcoes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MainMenuStrip = this.msOpcoes;
            this.Name = "FrmPrincipal";
            this.Text = "Login";
            this.msOpcoes.ResumeLayout(false);
            this.msOpcoes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msOpcoes;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leitoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatótiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nÃOToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem simToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem emprestimosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devoluçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pEmpréstimoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolvidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pLeitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pLivroToolStripMenuItem;
    }
}

