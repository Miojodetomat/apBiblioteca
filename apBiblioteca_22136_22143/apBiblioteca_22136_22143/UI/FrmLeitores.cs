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
    // A UI chama a BLL que chama a DAL que, por sua vez, acessa os dados e retorna os objetos

    public partial class FrmLeitores : Form
    {
        public string banco, usuario, senha;

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // permite que o usuário altere o que está nos textbox para instanciar
            // um leitor com as novas informações
            Leitor leitor = new Leitor(int.Parse(txtIdLeitor.Text), 
                                                 txtNomeLeitor.Text, 
                                                 txtTelefoneLeitor.Text,
                                                 txtEmailLeitor.Text, 
                                                 txtEnderecoLeitor.Text);
            try
            {
                // altera o leitor no banco de dados (com as informações adicionadas
                // ou modificadas pelo usuário)
                LeitorBLL bll = new LeitorBLL(banco, usuario, senha);
                bll.AlterarLeitor(leitor);
                MessageBox.Show("Leitor alterado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // pega somente o id do leitor (que é o necessário para fazer a exclusão)
            Leitor leitor = new Leitor(int.Parse(txtIdLeitor.Text), "", "", "", "");

            try
            {
                LeitorBLL bll = new LeitorBLL(banco, usuario, senha);
                bll.ExcluirLeitor(leitor);
                MessageBox.Show("Leitor excluido com sucesso!");

                // após a exclusão do leitor no banco de dados,
                // limpa as textboxs para que o usuário possa continuar a usar
                // o programa sem o leitor que foi deletado anteriormente
                txtIdLeitor.Text       = "";
                txtNomeLeitor.Text     = "";
                txtTelefoneLeitor.Text = "";
                txtEmailLeitor.Text    = "";
                txtEnderecoLeitor.Text = "";

                // limpa todas as informações na lista (já que foi excluído um leitor)
                dgvListaLeitores.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            // caso os campos não estejam todos preenchidos, o programa alertará o usuário
            if (txtNomeLeitor.Text == "" || txtEmailLeitor.Text == "" || txtTelefoneLeitor.Text == "" || txtEnderecoLeitor.Text == "")
                MessageBox.Show("Preencha todos os campos!");
            else
            {
                try 
                {
                    LeitorBLL bll = new LeitorBLL(banco, usuario, senha);
                    dgvListaLeitores.Rows.Clear();
                    DataTable tabela = bll.SelecionarLeitores();

                    // o for percorre todos os elementos da tabela e vai
                    // adicionando as informações do banco de dados em seus
                    // respectivos campos
                    for (int i = 0; i < tabela.Rows.Count; i++)
                    {
                        if (i != tabela.Rows.Count - 1)
                            dgvListaLeitores.Rows.Add();

                        dgvListaLeitores[0, i].Value = tabela.Rows[i][0];
                        dgvListaLeitores[1, i].Value = tabela.Rows[i][1];
                        dgvListaLeitores[2, i].Value = tabela.Rows[i][2];
                        dgvListaLeitores[3, i].Value = tabela.Rows[i][3];
                        dgvListaLeitores[4, i].Value = tabela.Rows[i][4];
                    }
                    tcLeitores.SelectTab(tpListaLeitores); // abre a aba da lista
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            // pede que o usuário insira um nome, já que para procurar um leitor
            // é preciso o seu nome
            if (txtNomeLeitor.Text == "")
                MessageBox.Show("Preencha como o nome que deseja");

            List<Leitor> leitores = null; 

            try
            {
                LeitorBLL bll = new LeitorBLL(banco, usuario, senha);
                leitores = bll.SelecionarLeitoresPorNome(txtNomeLeitor.Text);

                // procura na lista retornada as respectivas informações
                // que fazem jus ao nome procurado
                txtIdLeitor.Text       = leitores[0].IdLeitor.ToString();
                txtEmailLeitor.Text    = leitores[0].EmailLeitor.ToString();
                txtTelefoneLeitor.Text = leitores[0].TelefoneLeitor.ToString();
                txtEnderecoLeitor.Text = leitores[0].TelefoneLeitor.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }


        /*
            A evento de duplo clique em uma cell permite que o usuário, ao clicar em uma célula (ou
            seja, em um campo de uma linha da tabela) seja feito o que estiver dentro do evento. Nesse
            caso, o que queremos que seja feito é que: sejam retornadas todas as informações presentes
            um uma linha da tabela nos textboxs da aba de cadastro, e para isso serão retornadas as 
            informações cujo usuário tenha efetuado o duplo clique sobre.
        */
        private void dgvListaLeitores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // coloca em cada textbox as informações presentes nas respectivas células,
            // de forma que sejam colocadas as informações corretas em seus corretos textboxs
            txtIdLeitor.Text       = dgvListaLeitores.CurrentRow.Cells[0].Value.ToString();
            txtNomeLeitor.Text     = dgvListaLeitores.CurrentRow.Cells[1].Value.ToString();
            txtTelefoneLeitor.Text = dgvListaLeitores.CurrentRow.Cells[2].Value.ToString();
            txtEmailLeitor.Text    = dgvListaLeitores.CurrentRow.Cells[3].Value.ToString();
            txtEnderecoLeitor.Text = dgvListaLeitores.CurrentRow.Cells[4].Value.ToString();

            // muda para a aba de cadastro (com as informações do leitor
            // cujo foi feito o duplo clique sobre)
            tcLeitores.SelectTab(tpCadastroLeitores);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            // "cria" (instancia) um novo leitor (que ainda não foi
            // incluído no banco de dados, mas posteriormente será)
            Leitor novoLeitor = new Leitor(0, "", "", "", "");
            novoLeitor.NomeLeitor = txtNomeLeitor.Text;
            novoLeitor.EmailLeitor = txtEmailLeitor.Text;
            novoLeitor.TelefoneLeitor = txtTelefoneLeitor.Text;
            novoLeitor.EnderecoLeitor = txtEnderecoLeitor.Text;

            // caso os campos não estejam todos preenchidos, o programa alertará o usuário
            if (txtNomeLeitor.Text == "" || txtEmailLeitor.Text == "" || txtTelefoneLeitor.Text == "" || txtEnderecoLeitor.Text == "")
                MessageBox.Show("Preencha todos os campos!");

            try
            {
                // inclui um novo leitor com os dados passados pelo usuário
                LeitorBLL leitorBLL = new LeitorBLL(banco, usuario, senha);
                leitorBLL.IncluirLeitor(novoLeitor);
                MessageBox.Show("Leitor incluido com sucesso!");

                List<Leitor> listaLeitores = leitorBLL.SelecionarLeitoresPorNome(txtNomeLeitor.Text);

                // inclui um id (identity) para o leitor que está sendo adicionado ao banco
                if (listaLeitores.Count == 1)
                    txtIdLeitor.Text = listaLeitores[0].IdLeitor.ToString();
                else
                    txtIdLeitor.Text = listaLeitores[listaLeitores.Count - 1].IdLeitor.ToString();
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