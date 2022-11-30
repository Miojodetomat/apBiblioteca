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

namespace apBiblioteca_22136_22143
{
    public partial class FrmEmprestimo : Form
    {
        public string banco, usuario, senha;
        public FrmEmprestimo()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Emprestimo emprestimo = new Emprestimo(0, int.Parse(txtIdLivro.Text), int.Parse(txtIdLeitor.Text),
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
            Emprestimo emprestimo = new Emprestimo(int.Parse(txtIdEmprestimo.Text), 0, 0, dtEmp.Value, dtDevPrev.Value, dtDevPrev.Value);
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
                dgvEmprestimos.DataSource = bll.SelecionarEmprestimos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Emprestimo emp = new Emprestimo(int.Parse(txtIdEmprestimoDev.Text), int.Parse(txtIdLivroDev.Text),
                                                int.Parse(txtIdLeitorDev.Text), dtEmp.Value, dtDevPrev.Value, dtDevReal.Value);
            try
            {
                EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
                bll.AlterarEmprestimo(emp);
            }
            catch(Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            try
            {
                EmprestimoBLL bll = new EmprestimoBLL(banco,usuario, senha);
                dgvEmprestimos.DataSource = bll.SelecionarEmprestimosPorLeitor(int.Parse(txtIdLeitor.Text));
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
