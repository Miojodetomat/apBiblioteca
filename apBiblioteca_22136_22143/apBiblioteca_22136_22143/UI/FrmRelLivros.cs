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
            if (txtIdLivro.Text == "")
                MessageBox.Show("Digite o id desejado");
            else
            {
                EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
                DataTable lista = bll.SelecionarEmprestimosPorLivro(int.Parse(txtIdLivro.Text));
                dgvRelLivros.Rows.Clear();
                for(int i = 0; i < lista.Rows.Count; i++)
                {
                    if (i != lista.Rows.Count - 1)
                        dgvRelLivros.Rows.Add();

                    dgvRelLivros[0, i].Value = lista.Rows[i][0];
                    dgvRelLivros[1, i].Value = lista.Rows[i][1];
                    dgvRelLivros[2, i].Value = lista.Rows[i][2];
                    dgvRelLivros[3, i].Value = lista.Rows[i][3];
                    dgvRelLivros[4, i].Value = lista.Rows[i][4];
                }
                
            }
        }
    }
}
