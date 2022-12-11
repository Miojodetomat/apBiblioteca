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

namespace apBiblioteca_22136_22143.UI
{
    public partial class FrmRelLeitor : Form
    {
        public string banco, usuario, senha;
        public FrmRelLeitor()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            if (txtIdLeitor.Text == "")
                MessageBox.Show("Digite o id desejado");
            else
            {
                EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
                DataTable lista = bll.SelecionarEmprestimosPorLeitor(int.Parse(txtIdLeitor.Text));
                dgvLeitores.Rows.Clear();
                for (int i = 0; i < lista.Rows.Count; i++)
                {
                    if (i != lista.Rows.Count - 1)
                        dgvLeitores.Rows.Add();

                    dgvLeitores[0, i].Value = lista.Rows[i][0];
                    dgvLeitores[1, i].Value = lista.Rows[i][1];
                    dgvLeitores[2, i].Value = lista.Rows[i][2];
                    dgvLeitores[3, i].Value = lista.Rows[i][3];
                    dgvLeitores[4, i].Value = lista.Rows[i][4];
                }
            }
        }
    }
}
