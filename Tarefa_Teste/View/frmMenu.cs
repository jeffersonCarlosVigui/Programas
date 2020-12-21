using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarefa_Teste.View
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void encerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void contratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadContrato frmCad = new frmCadContrato();
            frmCad.ShowDialog();
        }

        private void amortizaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAmortizacao frmAm = new frmAmortizacao();
            frmAm.ShowDialog();
        }
    }
}
