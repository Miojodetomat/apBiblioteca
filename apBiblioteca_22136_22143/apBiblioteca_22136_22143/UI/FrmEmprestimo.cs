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

    public partial class FrmEmprestimos : Form
    {
        public string banco, usuario, senha;

        // váriáveis que indicam em que aba o usuário está
        public const String DEVOLUCAO  = "devolucao";
        public const String EMPRESTIMO = "emprestimo";

        public FrmEmprestimos(String operacao)
        {
            InitializeComponent();

            // se o usuário, no programa principal, selecionar a operação de devolução,
            // será aberta a aba de devolução no formulário de empréstimos
            if(operacao == DEVOLUCAO)
                tcEmprestimos.SelectTab(tpDevolucao);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // permite que o usuário altere o que está nos campos para instanciar
            // um empréstimo com as novas informações
            Emprestimo emprestimo = new Emprestimo(int.Parse(txtIdEmprestimo.Text), int.Parse(txtIdLivro.Text), 
                                                   int.Parse(txtIdLeitor.Text), dtEmp.Value, dtDevPrev.Value, dtDevPrev.Value);
            try
            {
                // altera o empréstimo no banco de dados (com as informações adicionadas
                // ou modificadas pelo usuário)
                EmprestimoBLL bll = new EmprestimoBLL(banco,usuario, senha);
                bll.AlterarEmprestimo(emprestimo);
                MessageBox.Show("Empréstimo alterado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // pega somente o id do empréstimo (que é o necessário para fazer a exclusão)
            Emprestimo emprestimo = new Emprestimo(int.Parse(txtIdEmprestimo.Text), 0, 0, 
                                                   new DateTime(), new DateTime(), new DateTime());

            try
            {
                EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
                bll.ExcluirEmprestimo(emprestimo);
                MessageBox.Show("Empréstimo excluido com sucesso!");

                // após a exclusão do empréstimo no banco de dados,
                // limpa os campos para que o usuário possa continuar a usar
                // o programa sem o empréstimo que foi deletado anteriormente
                txtIdEmprestimo.Text = "";
                txtIdLeitor.Text     = "";
                txtIdLivro.Text      = "";
                dtEmp.Text           = "";
                dtDevPrev.Text       = "";
                dtDevReal.Text       = "";

                // limpa todas as informações na lista (já que foi excluído um leitor)
                dgvListaEmprestimos.Rows.Clear();
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
                EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
                dgvListaEmprestimos.Rows.Clear();
                DataTable listaEmprestimo = bll.SelecionarEmprestimos();

                // o for percorre todos os elementos da tabela e vai
                // adicionando as informações do banco de dados em seus
                // respectivos campos
                for (int i = 0; i < listaEmprestimo.Rows.Count; i++)
                {
                    if (i != listaEmprestimo.Rows.Count - 1)
                        dgvListaEmprestimos.Rows.Add();

                    dgvListaEmprestimos[0, i].Value = listaEmprestimo.Rows[i][0];
                    dgvListaEmprestimos[1, i].Value = listaEmprestimo.Rows[i][1];
                    dgvListaEmprestimos[2, i].Value = listaEmprestimo.Rows[i][2];
                    dgvListaEmprestimos[3, i].Value = listaEmprestimo.Rows[i][3];
                    dgvListaEmprestimos[4, i].Value = listaEmprestimo.Rows[i][4];
                    dgvListaEmprestimos[5, i].Value = listaEmprestimo.Rows[i][5];
                }
                tcEmprestimos.SelectTab(tpListaEmprestimos); // abre a aba da lista
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            // pede que o usuário insira um id, já que para procurar um
            // empréstimo é preciso o seu id
            if (txtIdEmprestimo.Text == "")
                MessageBox.Show("Preencha como o id que deseja");

            List<Emprestimo> emprestimos = null;

            try
            {
                EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
                emprestimos = bll.SelecionarEmprestimosPorId(int.Parse(txtIdEmprestimo.Text));

                // procura na lista retornada as respectivas informações
                // que fazem jus ao id procurado
                txtIdEmprestimo.Text = emprestimos[0].IdEmprestimo.ToString();
                txtIdLeitor.Text     = emprestimos[0].IdLeitor.ToString();
                txtIdLivro.Text      = emprestimos[0].IdLivro.ToString();
                dtEmp.Text           = emprestimos[0].DataEmprestimo.ToString();
                dtDevPrev.Text       = emprestimos[0].DataDevolucaoPrevista.ToString();
                dtDevReal.Text       = emprestimos[0].DataDevolucaoReal.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            // "cria" (instancia) um novo empréstimo (que ainda não foi
            // incluído no banco de dados, mas posteriormente será)
            Emprestimo emprestimo = new Emprestimo(0, int.Parse(txtIdLivro.Text), int.Parse(txtIdLeitor.Text),
                                                   dtEmp.Value, dtDevPrev.Value, dtDevReal.Value);

            // caso os campos não estejam todos preenchidos, o programa alertará o usuário
            if (txtIdLivro.Text == "" || txtIdLeitor.Text == "" || dtEmp.Value.Equals("") || dtDevPrev.Value.Equals(""))
                MessageBox.Show("Preencha todos os campos!");

            try
            {
                // inclui um novo empréstimo com os dados passados pelo usuário
                EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
                bll.IncluirEmprestimo(emprestimo);
                MessageBox.Show("Emprestimo incluido com sucesso!");

                List<Emprestimo> listaEmprestimo = bll.SelecionarEmprestimosPorId(int.Parse(txtIdEmprestimo.Text));

                // inclui um id (identity) para o empréstimo que está sendo adicionado ao banco
                if (listaEmprestimo.Count == 1)
                    txtIdLeitor.Text = listaEmprestimo[0].IdLeitor.ToString();
                else
                    txtIdLeitor.Text = listaEmprestimo[listaEmprestimo.Count - 1].IdLeitor.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            // permite que o usuário altere o que está nos campos para instanciar
            // um empréstimo e devolução com as novas informações
            Emprestimo emprestimo = new Emprestimo(int.Parse(txtIdEmprestimoDev.Text), int.Parse(txtIdLivroDev.Text),
                                                   int.Parse(txtIdLeitorDev.Text), dtEmp.Value, dtDevPrev.Value, dtDevReal.Value);
            try
            {
                EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
                bll.AlterarEmprestimo(emprestimo);
                MessageBox.Show("Devolução atualizada com sucesso!");
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
        private void dgvListaEmprestimos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // coloca em cada campo as informações presentes nas respectivas células,
            // de forma que sejam colocadas as informações corretas em seus corretos campos
            txtIdEmprestimo.Text = dgvListaEmprestimos.CurrentRow.Cells[0].Value.ToString();
            txtIdLeitor.Text     = dgvListaEmprestimos.CurrentRow.Cells[1].Value.ToString();
            txtIdLivro.Text      = dgvListaEmprestimos.CurrentRow.Cells[2].Value.ToString();
            dtEmp.Text           = dgvListaEmprestimos.CurrentRow.Cells[3].Value.ToString();
            dtDevPrev.Text       = dgvListaEmprestimos.CurrentRow.Cells[4].Value.ToString();
            dtDevReal.Text       = dgvListaEmprestimos.CurrentRow.Cells[5].Value.ToString();

            // muda para a aba de cadastro (com as informações de
            // empréstimo cujo foi feito o duplo clique sobre)
            tcEmprestimos.SelectTab(tpEmprestimo);
        }

        private void btnProcurarDev_Click(object sender, EventArgs e)
        {
            try
            {
                EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
                Emprestimo emp = bll.ListarEmprestimoPorId(int.Parse(txtIdEmprestimoDev.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        public FrmEmprestimos()
        {
            InitializeComponent();
        }
    }
}
