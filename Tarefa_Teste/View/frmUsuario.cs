using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarefa_Teste.Modal;
using Tarefa_Teste.Controller;

namespace Tarefa_Teste.View
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //bool tem = false;
            Controle objCont = new Controle();
            objCont.verificalogin(txtUsuario.Text, txtSenha.Text);
               
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            lblMensagem.Text = "";


        }
    }
}
