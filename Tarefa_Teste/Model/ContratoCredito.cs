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
    class ContratoCredito
    {
        public bool tem = false;
        MySqlDataReader dr;
        MySqlCommand cmd = new MySqlCommand();
        Conexao con = new Conexao();


        public String G_Contrato(int id, int idCli, float vlrCont, float Taxa, String PerioTaxa, DateTime DatCont, DateTime DatVenc)
        {
            cmd.CommandText = "insert into td_cre_contratocredito values (@id,@idCli, @vlrCont, @Taxa, @PerioTaxa, @DatCont, @DatVenc)";
            cmd.Parameters.AddWithValue("@id",id);
            cmd.Parameters.AddWithValue("@idCli", idCli);
            cmd.Parameters.AddWithValue("@vlrCont", vlrCont);
            cmd.Parameters.AddWithValue("@Taxa",Taxa);
            cmd.Parameters.AddWithValue("@PerioTaxa",PerioTaxa);
            cmd.Parameters.AddWithValue(" @DatCont",DatCont);
            cmd.Parameters.AddWithValue("@DatVenc",DatVenc);
            tem = false;
            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.Desconectar();
                MessageBox.Show("Cadastrado com Sucessor ");
                tem = true;
            }
            catch (SqlException)
            {

               
            }


            return "a";
        }

    }
}
