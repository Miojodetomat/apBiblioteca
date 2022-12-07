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
                MessageBox.Show("Leitor alterado com sucesso!");
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
                MessageBox.Show("Leitor excluido com sucesso!");

                txtIdLeitor.Text = "";
                txtNomeLeitor.Text = "";
                txtTelefoneLeitor.Text = "";
                txtEmailLeitor.Text = "";
                txtEnderecoLeitor.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            if (txtNomeLeitor.Text == "" || txtEmailLeitor.Text == "" || txtTelefoneLeitor.Text == "" || txtEnderecoLeitor.Text == "")
                MessageBox.Show("Preencha todos os campos!");
            else
            {
                try 
                {
                    LeitorBLL bll = new LeitorBLL(banco, usuario, senha);
                    dgvListaLeitores.Rows.Clear();
                    DataTable tabela = bll.SelecionarLeitores();

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
                    tcLeitores.SelectTab(tpListaLeitores);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Erro : " + ex.Message.ToString());
                }
            }

            /*
            try
            {
                LeitorBLL bll = new LeitorBLL(banco, usuario, senha);
                dgvListaLeitores.DataSource = bll.ListarLeitores();
                tcLeitores.SelectTab(tpListaLeitores);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
            */
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            if (txtNomeLeitor.Text == "")
                MessageBox.Show("Preencha como o nome que deseja");

            List<Leitor> leitores = null; 

            try
            {
                LeitorBLL bll = new LeitorBLL(banco, usuario, senha);
                leitores = bll.SelecionarLeitoresPorNome(txtNomeLeitor.Text);

                txtIdLeitor.Text = leitores[0].IdLeitor.ToString();
                txtEmailLeitor.Text = leitores[0].EmailLeitor.ToString();
                txtTelefoneLeitor.Text = leitores[0].TelefoneLeitor.ToString();
                txtEnderecoLeitor.Text = leitores[0].TelefoneLeitor.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }

            /*
            try
            {
                LeitorBLL bll = new LeitorBLL(banco, usuario, senha);
                dgvListaLeitores.DataSource = bll.ListarLeitoresPorNome(txtNomeLeitor.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
            */
        }

        private void dgvListaLeitores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdLeitor.Text = dgvListaLeitores.CurrentRow.Cells[0].Value.ToString();
            txtNomeLeitor.Text = dgvListaLeitores.CurrentRow.Cells[1].Value.ToString();
            txtTelefoneLeitor.Text = dgvListaLeitores.CurrentRow.Cells[2].Value.ToString();
            txtEmailLeitor.Text = dgvListaLeitores.CurrentRow.Cells[3].Value.ToString();
            txtEnderecoLeitor.Text = dgvListaLeitores.CurrentRow.Cells[4].Value.ToString();

            tcLeitores.SelectTab(tpCadastroLeitores);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Leitor novoLeitor = new Leitor(0, "", "", "", "");
            novoLeitor.NomeLeitor = txtNomeLeitor.Text;
            novoLeitor.EmailLeitor = txtEmailLeitor.Text;
            novoLeitor.TelefoneLeitor = txtTelefoneLeitor.Text;
            novoLeitor.EnderecoLeitor = txtEnderecoLeitor.Text;

            if (txtNomeLeitor.Text == "" || txtEmailLeitor.Text == "" || txtTelefoneLeitor.Text == "" || txtEnderecoLeitor.Text == "")
                MessageBox.Show("Preencha todos os campos!");

            try
            {
                LeitorBLL leitorBLL = new LeitorBLL(banco, usuario, senha);
                leitorBLL.IncluirLeitor(novoLeitor);
                MessageBox.Show("Leitor incluido com sucesso!");
                List<Leitor> listaLeitores = leitorBLL.SelecionarLeitoresPorNome(txtNomeLeitor.Text);

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