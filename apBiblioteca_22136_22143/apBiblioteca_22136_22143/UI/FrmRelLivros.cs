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
    public partial class FrmRelLivros : Form
    {
        public string banco, usuario, senha;
        public FrmRelLivros()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            // solicita ao usuário que digite o id (identity) gerado
            // na inclusão do livro para que possa gerar o relatório
            // daquele livro
            if (txtIdLivro.Text == "")
                MessageBox.Show("Digite o id desejado");
            else
            {
                EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
                LeitorBLL leitorBLL = new LeitorBLL(banco, usuario, senha);
                DataTable lista = bll.SelecionarEmprestimosPorLivro(int.Parse(txtIdLivro.Text));
                dgvRelLivros.Rows.Clear();

                for(int i = 0; i < lista.Rows.Count; i++)
                {
                    if (i != lista.Rows.Count - 1)
                        dgvRelLivros.Rows.Add();

                    Leitor leitor = leitorBLL.ListarLeitorPorId((int)lista.Rows[i][2]);
                    if (leitor == null)
                        break;

                    dgvRelLivros[0, i].Value = lista.Rows[i][0];
                    dgvRelLivros[1, i].Value = lista.Rows[i][1];
                    dgvRelLivros[2, i].Value = leitor.NomeLeitor;
                    dgvRelLivros[3, i].Value = lista.Rows[i][3];
                    dgvRelLivros[4, i].Value = lista.Rows[i][4];
                }
                tcRelatorioLivros.SelectTab(tpRelatorio); // abre a tabela com o relatório
            }
        }
    }
}
