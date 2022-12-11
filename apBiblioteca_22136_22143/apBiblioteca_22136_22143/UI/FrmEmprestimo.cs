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
    public partial class FrmEmprestimos : Form
    {
        public string banco, usuario, senha;
        public const String DEVOLUCAO = "devolucao";
        public const String EMPRESTIMO = "emprestimo";

        public FrmEmprestimos(String operacao)
        {
            InitializeComponent();
            if(operacao == DEVOLUCAO)
                tcEmprestimos.SelectTab(tpDevolucao);
        }

        public FrmEmprestimos()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Emprestimo emprestimo = new Emprestimo(int.Parse(txtIdEmprestimo.Text), int.Parse(txtIdLivro.Text), int.Parse(txtIdLeitor.Text),
                                                   dtEmp.Value, dtDevPrev.Value, dtDevPrev.Value);
            try
            {
                EmprestimoBLL bll = new EmprestimoBLL(banco,usuario, senha);
                bll.AlterarEmprestimo(emprestimo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Emprestimo emprestimo = new Emprestimo(int.Parse(txtIdEmprestimo.Text), 0, 0, 
                                                   dtEmp.Value, dtDevPrev.Value, dtDevPrev.Value);

            try
            {
                EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
                bll.ExcluirEmprestimo(emprestimo);
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
                DataTable listaEmprestimo = bll.SelecionarEmprestimos();
                dgvEmprestimos.Rows.Clear();
                
                for(int i = 0; i < listaEmprestimo.Rows.Count; i++)
                {
                    if (i != listaEmprestimo.Rows.Count - 1)
                        dgvEmprestimos.Rows.Add();

                    dgvEmprestimos[0, i].Value = listaEmprestimo.Rows[i][0];
                    dgvEmprestimos[1, i].Value = listaEmprestimo.Rows[i][1];
                    dgvEmprestimos[2, i].Value = listaEmprestimo.Rows[i][2];
                    dgvEmprestimos[3, i].Value = listaEmprestimo.Rows[i][3];
                    dgvEmprestimos[4, i].Value = listaEmprestimo.Rows[i][4];
                    dgvEmprestimos[5, i].Value = listaEmprestimo.Rows[i][5];
                }

                tcEmprestimos.SelectTab(tpListaEmprestimos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Emprestimo emprestimo = new Emprestimo(int.Parse(txtIdEmprestimoDev.Text), int.Parse(txtIdLivroDev.Text),
                                                   int.Parse(txtIdLeitorDev.Text), dtEmp.Value, dtDevPrev.Value, dtDevReal.Value);
            try
            {
                EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
                bll.AlterarEmprestimo(emprestimo);
            }
            catch(Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
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

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            try
            {
                EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
                Emprestimo emp = bll.ListarEmprestimoPorId(int.Parse(txtIdEmprestimo.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Emprestimo emprestimo = new Emprestimo(0, int.Parse(txtIdLivro.Text), int.Parse(txtIdLeitor.Text),
                                                   dtEmp.Value, dtDevPrev.Value, dtDevReal.Value);

            try
            {
                EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
                bll.IncluirEmprestimo(emprestimo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }
    }
}
