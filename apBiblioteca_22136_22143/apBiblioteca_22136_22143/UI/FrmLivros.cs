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
    // A UI chama a BLL que chama a DAL que, por sua vez, acessa os dados e retorna os objetos

    public partial class FrmLivros : Form
    {
        public string banco, usuario, senha;

        private void btnNovo_Click(object sender, EventArgs e)
        {
            // "cria" (instancia) um novo livro (que ainda não foi
            // incluído no banco de dados, mas posteriormente será)
            Livro livr = new Livro(0, "", "", "");
            livr.CodigoLivro = txtCodigoLivro.Text;
            livr.TituloLivro = txtTituloLivro.Text;
            livr.AutorLivro = txtAutorLivro.Text;

            // caso os campos não estejam todos preenchidos, o programa alertará o usuário
            if (txtCodigoLivro.Text == "" || txtTituloLivro.Text == "" || txtAutorLivro.Text == "")
                MessageBox.Show("Preencha todos os campos!");

            try
            {
                // inclui um novo livro com os dados passados pelo usuário
                LivroBLL bll = new LivroBLL(banco, usuario, senha);
                bll.IncluirLivro(livr);
                MessageBox.Show("Livro incluido com sucesso!");

                List<Livro> listaLivros = bll.SelecionarLivrosPorCodigo(txtCodigoLivro.Text);

                // inclui um id (identity) para o livro que está sendo adicionado ao banco
                if (listaLivros.Count == 1)
                    txtIdLivro.Text = listaLivros[0].IdLivro.ToString();
                else
                    txtIdLivro.Text = listaLivros[listaLivros.Count - 1].IdLivro.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // permite que o usuário altere o que está nos textbox para instanciar
            // um livro com as novas informações
            Livro livro = new Livro(int.Parse(txtIdLivro.Text),
                                              txtCodigoLivro.Text,
                                              txtTituloLivro.Text,
                                              txtAutorLivro.Text);

            try
            {
                // altera o livro no banco de dados (com as informações adicionadas
                // ou modificadas pelo usuário)
                LivroBLL bll = new LivroBLL(banco, usuario, senha);
                bll.AlterarLivro(livro);
                MessageBox.Show("Livro alterado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // pega somente o id do livro (que é o necessário para fazer a exclusão)
            Livro livro = new Livro(Convert.ToInt32(txtIdLivro.Text), "", "", "");

            try
            {
                LivroBLL bll = new LivroBLL(banco, usuario, senha);
                bll.ExcluirLivro(livro);
                MessageBox.Show("Livro excluido com sucesso!");

                // após a exclusão do livro no banco de dados,
                // limpa as textboxs para que o usuário possa continuar a usar
                // o programa sem o livro que foi deletado anteriormente
                txtIdLivro.Text     = "";
                txtCodigoLivro.Text = "";
                txtTituloLivro.Text = "";
                txtAutorLivro.Text  = "";

                // limpa todas as informações na lista (já que foi excluído um livro)
                dgvListaLivros.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            // pede que o usuário insira um código, já que para procurar um livro
            // é preciso o seu código
            if (txtCodigoLivro.Text == "")
                MessageBox.Show("Preencha como o código que deseja");

            List<Livro> livros = null;

            try
            {
                LivroBLL bll = new LivroBLL(banco, usuario, senha);
                livros = bll.SelecionarLivrosPorCodigo(txtCodigoLivro.Text);

                // procura na lista retornada as respectivas informações
                // que fazem jus ao código procurado
                txtIdLivro.Text     = livros[0].IdLivro.ToString();
                txtCodigoLivro.Text = livros[0].CodigoLivro.ToString();
                txtTituloLivro.Text = livros[0].TituloLivro.ToString();
                txtAutorLivro.Text  = livros[0].AutorLivro.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message.ToString());
            }
        }


        /*
            A evento de duplo clique em uma cell permite que o usuário, ao clicar em uma célula (ou
            seja, em um campo de uma linha da tabela) seja feito o que estiver dentro do evento. Nesse
            caso, o que queremos que seja feito é que: sejam retornadas todas as informações presentes
            um uma linha da tabela nos textboxs da aba de cadastro, e para isso serão retornadas as 
            informações cujo usuário tenha efetuado o duplo clique sobre.
        */
        private void dgvListaLivros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // coloca em cada textbox as informações presentes nas respectivas células,
            // de forma que sejam colocadas as informações corretas em seus corretos textboxs
            txtIdLivro.Text     = dgvListaLivros.CurrentRow.Cells[0].Value.ToString();
            txtCodigoLivro.Text = dgvListaLivros.CurrentRow.Cells[1].Value.ToString();
            txtTituloLivro.Text = dgvListaLivros.CurrentRow.Cells[2].Value.ToString();
            txtAutorLivro.Text  = dgvListaLivros.CurrentRow.Cells[3].Value.ToString();

            // muda para a aba de cadastro (com as informações do livro
            // cujo foi feito o duplo clique sobre)
            tcLivros.SelectTab(tpCadastroLivros);
        }

        private void Exibir_Click(object sender, EventArgs e)
        {
            // caso os campos não estejam todos preenchidos, o programa alertará o usuário
            if (txtCodigoLivro.Text == "" || txtTituloLivro.Text == "" || txtAutorLivro.Text == "")
                    MessageBox.Show("Preencha todos os campos!");
            else
            {
                try
                {
                    LivroBLL bll = new LivroBLL(banco, usuario, senha);
                    dgvListaLivros.Rows.Clear();
                    DataTable tabela = bll.SelecionarLivros();

                    // o for percorre todos os elementos da tabela e vai
                    // adicionando as informações do banco de dados em seus
                    // respectivos campos
                    for (int i = 0; i < tabela.Rows.Count; i++)
                    {
                        if (i != tabela.Rows.Count - 1)
                            dgvListaLivros.Rows.Add();

                        dgvListaLivros[0, i].Value = tabela.Rows[i][0];
                        dgvListaLivros[1, i].Value = tabela.Rows[i][1];
                        dgvListaLivros[2, i].Value = tabela.Rows[i][2];
                        dgvListaLivros[3, i].Value = tabela.Rows[i][3];
                    }
                    tcLivros.SelectTab(tpListaLivros); // abre a aba da lista
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        }

        public FrmLivros()
        {
            InitializeComponent();
        }
    }
}
