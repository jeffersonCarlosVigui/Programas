using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Tarefa_Teste.Modal
{
        
        public class Conexao
        {
            MySqlConnection con = new MySqlConnection("server= localhost; port=3306; user=root; database=bd_tarefa_teste; password =''");
        //    public Conexao(){
        //        MySqlConnection con = new MySqlConnection("server= localhost; port=3306; user=root; database=bd_tarefa_teste; password =''");
       // }
            public MySqlConnection Conectar() {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                con.Open();
                }
                return con;
            }

            public void Desconectar(){
               if (con.State == System.Data.ConnectionState.Open)
                {
                con.Close();
                }
            }    

        }
}
