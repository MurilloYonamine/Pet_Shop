using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Para uso dos métodos MySQL
using MySql.Data.MySqlClient;
// Para uso dos métodos do projeto DAL
using DAL;

namespace BLL
{
    public class TesteConexao
    {
        // Receberá o retorno do método obterConexao.
        public MySqlConnection conectar = null;
        // Receberá o retorno das exceções (erros).
        public string mensagem = string.Empty;

        // Método para verificar a conexão.

        public void Verificar()
        {
            conectar = Conexao.obterConexao();
            mensagem = Conexao.mensagem;
        }
    }
}
