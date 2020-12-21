using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarefa_Teste.Model;
using Tarefa_Teste.Controller;

namespace Tarefa_Teste.View
{
    public partial class frmCadContrato : Form
    {
        public bool tem = false;
        public frmCadContrato()
        {
            InitializeComponent();
        }

        
        private void txtCpfCnpj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Erro   ");
            }

        }

        private void txtCpfCnpj_TextChanged(object sender, EventArgs e)
        {

        }

        private void Taxa_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            bool tem = false;
            int IdCli;
            Controle objCont = new Controle();
            Cliente objCli   = new Cliente();

            IdCli = objCli.Cpf(txtCpfCnpj.Text);
            if (IdCli == 0)
            {
                MessageBox.Show("Cpf Não Valido !!! "); 
            }


            //tem = objCont.GravaContrato(c);

            
        }
    }
}
