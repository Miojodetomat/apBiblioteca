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
    public partial class FrmRelDevolvidos : Form
    {
        public string banco, usuario, senha;

        private void FrmRelDevolvidos_Load(object sender, EventArgs e)
        {
            try
            {
                EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
                DataTable lista = bll.SelecionarEmprestimosDevolvidos();
                dgvDevolvidos.Rows.Clear();

                for (int i = 0; i < lista.Rows.Count; i++)
                {
                    if (i != lista.Rows.Count - 1)
                        dgvDevolvidos.Rows.Add();

                    dgvDevolvidos[0, i].Value = lista.Rows[i][0];
                    dgvDevolvidos[1, i].Value = lista.Rows[i][1];
                    dgvDevolvidos[2, i].Value = lista.Rows[i][2];
                    dgvDevolvidos[3, i].Value = lista.Rows[i][3];
                    dgvDevolvidos[4, i].Value = lista.Rows[i][4];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        public FrmRelDevolvidos()
        {
            InitializeComponent();
        }
    }
}
