using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarefa_Teste.Modal;
using Tarefa_Teste.View;
using System.Windows.Forms;

namespace Tarefa_Teste.Controller

{
    class Controle
    {
        public bool tem;
        Model.Usuario objUsu = new Model.Usuario();
        
        public void verificalogin(String login, String senha) 
        {
            tem = objUsu.verificalogin(login, senha);
            if (tem == true)
            {
                //Form1 c = new Form1();
                frmMenu objCad = new frmMenu();
                objCad.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Login ou Senha Inválido");
            }
         }


        public String GravaContrato(int id, int idCli, float vlrCont, float Taxa, String PerioTaxa, DateTime DatCont, DateTime DatVenc)
        {


            return "a";
        }

        public int ConsCliCpf(String Cpf)
        {


            return 1;
        }



    }
}
