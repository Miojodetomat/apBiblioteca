using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace apBiblioteca_22136_22143.UI
{
    public partial class FrmLivros : Form
    {
        public string banco, usuario, senha;

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro(0, "", "", "");
            livro.CodigoLivro = txtCodigoLivro.Text;
            livro.TituloLivro = txtTituloLivro.Text;
            livro.AutorLivro = txtAutorLivro.Text;
            try
            {
                LivroBLL bll = new LivroBLL(banco, usuario, senha);
                bll.IncluirLivro(livro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro(int.Parse(txtIdLivro.Text),
                                              txtCodigoLivro.Text,
                                              txtTituloLivro.Text,
                                              txtAutorLivro.Text);
            try
            {
                LivroBLL bll = new LivroBLL(banco, usuario, senha);
                bll.AlterarLivro(livro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro(Convert.ToInt32(txtIdLivro.Text), "", "", "");
            try
            {
                LivroBLL bll = new LivroBLL(banco, usuario, senha);
                bll.ExcluirLivro(livro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }

        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoLivro.Text;
            Livro livro = null;
            try
            {
                LivroBLL bll = new LivroBLL(banco, usuario, senha);
                livro = bll.ListarLivroPorCodigo(codigo);

                txtIdLivro.Text = livro.IdLivro.ToString();
                txtCodigoLivro.Text = livro.CodigoLivro;
                txtTituloLivro.Text = livro.TituloLivro;
                txtAutorLivro.Text = livro.AutorLivro;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message.ToString());
            }
        }

        private void Exibir_Click(object sender, EventArgs e)
        {
            try
            {
                LivroBLL bll = new BLL.LivroBLL(banco, usuario, senha);
                dgvLivros.DataSource = bll.SelecionarLivros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        public FrmLivros()
        {
            InitializeComponent();
        }
    }
}
