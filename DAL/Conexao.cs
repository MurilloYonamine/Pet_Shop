using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Acesso à string de conexão.
using DAL.Properties;
// Acessp aos comandos para o Mysql.
using MySql.Data.MySqlClient;

namespace DAL
{
    public class Conexao
    {
        //Recebe as mensagens de erro do MySqlException
        public static string mensagem = string.Empty;
        //Armazena a string de conexão em uma variável.
        //O atributo static mantém a variável durante toda a execução do programa.
        private static string strConn = Settings.Default.strConexao;
        //Variável que receberá a conexão com o BD.
        private static MySqlConnection conn = null;
        //Método para obter a conexão.
        public static MySqlConnection obterConexao()
        {
            //Instanciar a classe de conexão
            conn = new MySqlConnection(strConn);
            //Tratamento de exceções com Try{} catch{}.
            try
            {
                //Abre a conexão utilizando o método Open().
                conn.Open();
            }
            catch (MySqlException erro)
            {
                //Define a variável como nulo se ocorrer erro.
                conn = null;
                //Apresenta a mensagem de exceção.
                mensagem = erro.ToString();
            }
            //Retorna o resultado da conexão.
            return conn;
        }
        //Método para fechar a conexão.
        public static MySqlConnection fecharConexao()
        {
            //Instanciar a classe de conexão
            conn = new MySqlConnection(strConn);
            //Tratamento de exceções com Try{} catch{}.
            try
            {
                //Fecha a conexão utilizando o método Close().
                conn.Close();
            }
            catch (MySqlException erro)
            {
                //Define a variável como nulo se ocorrer erro.
                conn = null;
                //Apresenta a mensagem de exceção.
                mensagem = erro.ToString();
            }
            //Retorna o resultado da conexão.
            return conn;
        }
    }
}
