using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Tarefa_Teste
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                     
            try
            {
                //DriverManager.getConnection("jdbc:mysql://localhost:3306/bancopoo", "root", "");
              //  MySqlConnection con = new MySqlConnection("server=localhost:3306; database=bancoaula; password=root");
             
                MySqlConnection con = new MySqlConnection("server= localhost; port=3306; user=root; database=bancoaula; password =''");
                
                con.Open();
                MySqlCommand comando = new MySqlCommand("SELECT ra, nome FROM Alunos where ra= ?_ra" , con);

                comando.Parameters.Clear();
                comando.Parameters.Add("?_ra", MySqlDbType.Int32);
                comando.Parameters["?_ra"].Value = 200; 
                comando.CommandType = CommandType.Text;
                MySqlDataReader rsAlunos;               
                rsAlunos = comando.ExecuteReader();
                //rsAlunos.Read();
                if (rsAlunos.Read()){
                    MessageBox.Show("Correto " +     rsAlunos["nome"].ToString());

                } else {
                    MessageBox.Show("Não entrou ");
                }

            }catch (SqlException Erro) {
                MessageBox.Show("Erro" + Erro.Message);
            }
               
        }//fim metodo

        private void button1_Click(object sender, EventArgs e)
        {
             
        }
    }
}
