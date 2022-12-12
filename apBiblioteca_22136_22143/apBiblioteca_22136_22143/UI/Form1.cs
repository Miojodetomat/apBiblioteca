using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using DAL;

namespace apBiblioteca_22136_22143
{
    /* 
        Esse formulário apresenta todas as principais operações ou seja, as funções,
        que o usuário poderá realizar durante o uso do programa. Aqui focamos, principalmente,
        na conexão com o banco de dados. Caso a conexão feita seja incorreta ou não preenchida
        corretamente, o programa alertará o usuário. Caso esteja conectado corretamente, o
        usuário poderá fazer o uso pleno do programa.
    */

    public partial class FrmPrincipal : Form
    {
        UI.FrmLivros formLivros                = null;
        UI.FrmLeitores formLeitores            = null;
        UI.FrmEmprestimos formEmprestimo       = null;
        UI.FrmRelEmpPendentes formRelPendentes = null;
        UI.FrmRelDevolvidos formRelDevolvidos  = null;
        UI.FrmRelLivros formRelLivros          = null;
        UI.FrmRelLeitor formRelLeitor          = null;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void simToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtBanco.Text == "" || txtUsuario.Text == "" || txtSenha.Text == "")
                MessageBox.Show("Preencha os dados de conexão!");
            else
            {
                formLivros = new UI.FrmLivros();
                formLivros.banco   = txtBanco.Text;
                formLivros.usuario = txtUsuario.Text;
                formLivros.senha   = txtSenha.Text;
                formLivros.Show();
            }
        }

        private void leitoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtBanco.Text == "" || txtUsuario.Text == "" || txtSenha.Text == "")
                MessageBox.Show("Preencha os dados de conexão!");
            else
            {
                formLeitores = new UI.FrmLeitores();
                formLeitores.banco   = txtBanco.Text;
                formLeitores.usuario = txtUsuario.Text;
                formLeitores.senha   = txtSenha.Text;
                formLeitores.Show();
            }
        }

        private void emprestimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtBanco.Text == "" || txtUsuario.Text == "" || txtSenha.Text == "")
                MessageBox.Show("Preencha os dados de conexão!");
            else
            {
                formEmprestimo = new UI.FrmEmprestimos();
                formEmprestimo.banco   = txtBanco.Text;
                formEmprestimo.senha   = txtSenha.Text;
                formEmprestimo.usuario = txtUsuario.Text;
                formEmprestimo.Show();
            }
        }

        private void devoluçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtBanco.Text == "" || txtUsuario.Text == "" || txtSenha.Text == "")
                MessageBox.Show("Preencha os dados de conexão!");
            else
            {
                formEmprestimo = new UI.FrmEmprestimos(UI.FrmEmprestimos.DEVOLUCAO);
                formEmprestimo.banco   = txtBanco.Text;
                formEmprestimo.senha   = txtSenha.Text;
                formEmprestimo.usuario = txtUsuario.Text;
                formEmprestimo.Show();
            }
        }

        private void pendentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtBanco.Text == "" || txtUsuario.Text == "" || txtSenha.Text == "")
                MessageBox.Show("Preencha os dados de conexão!");
            else
            {
                formRelPendentes = new UI.FrmRelEmpPendentes();
                formRelPendentes.banco   = txtBanco.Text;
                formRelPendentes.senha   = txtSenha.Text;
                formRelPendentes.usuario = txtUsuario.Text;
                formRelPendentes.Show();
            }
        }

        private void devolvidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtBanco.Text == "" || txtUsuario.Text == "" || txtSenha.Text == "")
                MessageBox.Show("Preencha os dados de conexão!");
            else
            {
                formRelDevolvidos = new UI.FrmRelDevolvidos();
                formRelDevolvidos.banco   = txtBanco.Text;
                formRelDevolvidos.senha   = txtSenha.Text;
                formRelDevolvidos.usuario = txtUsuario.Text;
                formRelDevolvidos.Show();
            }
        }

        private void pLeitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtBanco.Text == "" || txtUsuario.Text == "" || txtSenha.Text == "")
                MessageBox.Show("Preencha os dados de conexão!");
            else
            {
                formRelLeitor = new UI.FrmRelLeitor();
                formRelLeitor.banco   = txtBanco.Text;
                formRelLeitor.senha   = txtSenha.Text;
                formRelLeitor.usuario = txtUsuario.Text;
                formRelLeitor.Show();
            }
        }

        private void pLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtBanco.Text == "" || txtUsuario.Text == "" || txtSenha.Text == "")
                MessageBox.Show("Preencha os dados de conexão!");
            else
            {
                formRelLivros = new UI.FrmRelLivros();
                formRelLivros.banco   = txtBanco.Text;
                formRelLivros.senha   = txtSenha.Text;
                formRelLivros.usuario = txtUsuario.Text;
                formRelLivros.Show();
            }
        }
    }
}
