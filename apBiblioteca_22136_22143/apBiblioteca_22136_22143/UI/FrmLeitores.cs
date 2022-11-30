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

namespace apBiblioteca_22136_22143.UI
{
    public partial class FrmLeitores : Form
    {
        public string banco, usuario, senha;

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Leitor leitor = new Leitor(int.Parse(txtIdLeitor.Text), 
                                        txtNomeLeitor.Text, 
                                        txtTelefoneLeitor.Text,
                                        txtEmailLeitor.Text, 
                                        txtEnderecoLeitor.Text);
            try
            {
                LeitorBLL bll = new LeitorBLL(banco, usuario, senha);
                bll.AlterarLeitor(leitor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Leitor leitor = new Leitor(int.Parse(txtIdLeitor.Text), "", "", "", "");
            try
            {
                LeitorBLL bll = new LeitorBLL(banco, usuario, senha);
                bll.ExcluirLeitor(leitor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                LeitorBLL bll = new LeitorBLL(banco, usuario, senha);
                dgvListaLeitores.DataSource = bll.ListarLeitores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            try
            {
                LeitorBLL bll = new LeitorBLL(banco, usuario, senha);
                dgvListaLeitores.DataSource = bll.ListarLeitoresPorNome(txtNomeLeitor.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Leitor novoLeitor = new Leitor(0, "", "", "", "");
            novoLeitor.NomeLeitor = txtNomeLeitor.Text;
            novoLeitor.EmailLeitor = txtEmailLeitor.Text;
            novoLeitor.TelefoneLeitor = txtTelefoneLeitor.Text;
            novoLeitor.EnderecoLeitor = txtEnderecoLeitor.Text;
            try
            {
                LeitorBLL leitorBLL = new LeitorBLL(banco, usuario, senha);
                leitorBLL.IncluirLeitor(novoLeitor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        public FrmLeitores()
        {
            InitializeComponent();
        }

    }
}
