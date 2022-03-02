using System;
using System.Data.SqlClient;

namespace Conexao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Montando uma conexão com o banco pelo SQL Connection
            SqlConnection conexao = new SqlConnection(@"data source=LAPTOP-DNO3086A\SQLEXPRESS;   Integrated Security=SSPI ;    Initial Catalog=ExemploBD ");
            //Local do banco; Segurança para acesso (SSPI); Nome do banco 

            conexao.Open(); //Abrindo a Conexão



            string strQueryUpdate = "UPDATE usuarios SET nome = 'Fabio' WHERE usuarioId = 1";
            SqlCommand cmdComandoUpdate = new SqlCommand(strQueryUpdate, conexao);
            cmdComandoUpdate.ExecuteNonQuery();
            ////Incluindo variaveis e dados para fazer update



            string strQuerySelect = "Select * From usuarios";
            //Essa Estring executa a Query do sql

            SqlCommand cmdComandoSelect = new SqlCommand(strQuerySelect, conexao);
            //Executa o Comando SQL

            SqlDataReader dados = cmdComandoSelect.ExecuteReader();
            //Carrega a execução do comando /Executa


            


            while (dados.Read()) //Enquanto Existe dados
            {
                Console.WriteLine("Id:{0}, Nome:{1}, Cargo:{2}, Data:{3}" , dados["usuarioId"], dados["nome"], dados["cargo"], dados["date"]);



            }
            
        }
    }
}
