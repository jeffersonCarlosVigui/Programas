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
    class Cliente
    {
        public bool tem = false;
        MySqlDataReader dr;
        MySqlCommand cmd = new MySqlCommand();
        Conexao con = new Conexao();

        public object Cpf(String strCpf)
        {
            cmd.CommandText = "Select * From td_cli_cliente Where CpfCnpj = @strCpf";
            cmd.Parameters.AddWithValue("@strCpf", strCpf);
      
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr["id"];
                   // return (int)dr["id"];
                }
                con.Desconectar();
                dr.Close();
            }
            catch (SqlException erro)
            {

                MessageBox.Show(erro.Message);

            }
            return 0;
        }


    }//Classe
}//NameSpace
