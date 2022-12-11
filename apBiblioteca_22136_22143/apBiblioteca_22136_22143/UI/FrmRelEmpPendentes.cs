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
    public partial class FrmRelEmpPendentes : Form
    {
        public string banco, usuario, senha;
        public FrmRelEmpPendentes()
        {
            InitializeComponent();
        }

        private void FrmRelEmpPendentes_Load(object sender, EventArgs e)
        {
            try
            {
                EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
                DataTable lista = bll.SelecionarEmprestimosPendentes();
                dgvRelEmpPendentes.Rows.Clear();

                for (int i = 0; i < lista.Rows.Count; i++)
                {
                    if (i != lista.Rows.Count - 1)
                        dgvRelEmpPendentes.Rows.Add();

                    dgvRelEmpPendentes[0, i].Value = lista.Rows[i][0];
                    dgvRelEmpPendentes[1, i].Value = lista.Rows[i][1];
                    dgvRelEmpPendentes[2, i].Value = lista.Rows[i][2];
                    dgvRelEmpPendentes[3, i].Value = lista.Rows[i][3];
                    dgvRelEmpPendentes[4, i].Value = lista.Rows[i][4];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }
    }
}
