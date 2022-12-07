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
    public partial class FrmPrincipal : Form
    {
        UI.FrmLivros formLivros = null;
        UI.FrmLeitores formLeitores = null;
        UI.FrmEmprestimos formEmprestimo = null;

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
                formLivros.banco = txtBanco.Text;
                formLivros.usuario = txtUsuario.Text;
                formLivros.senha = txtSenha.Text;
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
                formLeitores.banco = txtBanco.Text;
                formLeitores.usuario = txtUsuario.Text;
                formLeitores.senha = txtSenha.Text;
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
                formEmprestimo.banco = txtBanco.Text;
                formEmprestimo.senha = txtSenha.Text;
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
                formEmprestimo.banco = txtBanco.Text;
                formEmprestimo.senha = txtSenha.Text;
                formEmprestimo.usuario = txtUsuario.Text;
                formEmprestimo.Show();
            }
        }
    }
}
