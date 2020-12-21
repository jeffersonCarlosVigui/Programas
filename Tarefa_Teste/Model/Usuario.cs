using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

using Tarefa_Teste.Modal;
using System.Windows.Forms;

namespace Tarefa_Teste.Model
{
    class Usuario
    {
        public bool tem = false;
        MySqlDataReader dr;
        MySqlCommand cmd = new MySqlCommand();
        Conexao con = new Conexao();
        
        public bool verificalogin(String login, String senha)
        {
            cmd.CommandText = "Select * From Usuario Where Login=@login and Senha=@senha";
            cmd.Parameters.AddWithValue("@login",login);
            cmd.Parameters.AddWithValue("@senha",senha);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                con.Desconectar();
                dr.Close();
            }
            catch (SqlException erro)
            {
                
                MessageBox.Show(erro.Message);

            }
            return tem;
        }
    }
}
