using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using DAL;
namespace BLL
{
    public class ProdutoDTO
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public DateTime Registro { get; set; }
        public string Mensagem { get; set; }
    }
    public class SalvarProduto
    {
        public void InserirDadosProduto(ProdutoDTO dados)
        {
            try
            {
                string sql = "INSERT INTO tb_produto (ProNome, ProTipo, ProMarca, ProRegistro) " +
                                             "VALUES (@proNome, @proTipo, @proMarca, @proRegistro)";
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new MySqlParameter("@proNome", dados.Nome));
                cmd.Parameters.Add(new MySqlParameter("@proTipo", dados.Tipo));
                cmd.Parameters.Add(new MySqlParameter("@proMarca", dados.Marca));
                cmd.Parameters.Add(new MySqlParameter("@proRegistro", dados.Registro));
                int registrosInseridos = cmd.ExecuteNonQuery();
                if (registrosInseridos >= 1)
                {
                    dados.Mensagem = "Registro do produto inserido com Sucesso!";
                }
                else
                {
                    dados.Mensagem = "Falha ao inserir o produto no registro!";
                }
            }
            catch (MySqlException erro)
            {

                dados.Mensagem = "ERRO - SalvarProduto - InserirDadosProduto -" + erro.ErrorCode + erro.Message;
            }
        }
    }
    public class ConsultarProduto
    {
        public void BuscarCodigoProduto(ProdutoDTO dados)
        {
            try
            {
                string sql = "SELECT ProCodigo FROM tb_produto ORDER BY ProCodigo DESC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Define o tipo de comando
                cmd.CommandType = CommandType.Text;
                //Realiza a leitura dos dados - Reader
                //Ignora os títulos da tabela
                MySqlDataReader dr = cmd.ExecuteReader();
                //Verifica se há linhas nesta leitura de dados
                if (dr.HasRows)
                {
                    //Enquanto houver dados
                    while (dr.Read())
                    {
                        dados.Codigo = dr.GetInt32(0);
                    }//11 + 1 = 12
                }
                Conexao.fecharConexao();

            }
            catch (MySqlException erro)
            {

                dados.Mensagem = "ERRO - ConsultarProduto - BuscarCodigoProduto -" + erro.ErrorCode + erro.Message;
            }
        }
        // --------------------------------------------------------------- //
        // Listar produtos na DataGridVIew
        public DataTable ListarDadosProduto(ProdutoDTO dados)
        {
            //Declaração da variável que receberá os dados no formato de tabela.
            DataTable tabela = new DataTable();
            try
            {
                //Intrução de comando SELECT para o BD
                string sql = "SELECT * FROM tb_produto";
                //Comando para o SELECT e a Conexão - MySqlCommand
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Adaptar os dados do BD para o formato de tabela
                //com a execução da Conexão e SELECT
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                //Preenchimento da variável em formato de tabela - Fill = preencher
                adaptador.Fill(tabela);
                //Fechar a conexão
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "Erro - ConsultarProduto - ListarDadosProduto " +
                erro.Message.ToString();
            }
            //O comando SELECT sempre precisa retornar algum dado
            //Este retorno será no formato de tabela, sendo aplicado ao DataGridView
            return tabela;
        }
        public DataTable ListarDadosFiltro(ProdutoDTO dados)
        {
            DataTable tabela = new DataTable();
            try
            {
                //Intrução de comando SELECT para o BD
                string sql = "SELECT * From tb_cliente WHERE ClNome LIKE @nome";
                //Comando para o SELECT e a Conexão - MySqlCommand
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());

                cmd.Parameters.Add(new MySqlParameter("@nome", "%" + dados.Nome + "%"));
                //Adaptar os dados do BD para o formato de tabela
                //com a execução da Conexão e SELECT
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                //Preenchimento da variável em formato de tabela - Fill = preencher
                adaptador.Fill(tabela);
                //Fechar a conexão
                Conexao.fecharConexao();
            }
            catch (Exception erro)
            {
                dados.Mensagem = "Erro - ConsultarProduto - ListarDadosFiltro " +
                erro.Message.ToString();
            }
            return tabela;
        }
    }
    public class AtualizarProduto
    {
        public void AtualizarDadosProduto(ProdutoDTO dados)
        {
            try
            {
                //String com o comando de atualização
                string sql = "UPDATE tb_produto " +
                "SET ProNome=@nome, ProTipo=@tipo, ProMarca=@marca, ProRegistro=@registro " +
                "WHERE ProCodigo=@codigo";
                //Uso da abertura de Conexão e da string sql
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Tipo de comando: Text ou Stored Procedure
                cmd.CommandType = CommandType.Text;
                //Parâmetros que serão substituídos (@) por variáveis
                cmd.Parameters.Add(new MySqlParameter("@codigo", dados.Codigo));
                cmd.Parameters.Add(new MySqlParameter("@nome", dados.Nome));
                cmd.Parameters.Add(new MySqlParameter("@tipo", dados.Tipo));
                cmd.Parameters.Add(new MySqlParameter("@marca", dados.Marca));
                cmd.Parameters.Add(new MySqlParameter("@registro", dados.Registro));
                int registrosAtualizados = cmd.ExecuteNonQuery();
                //Verifica se algum registro foi atualizado
                if (registrosAtualizados >= 1)
                {
                    dados.Mensagem = "Sucesso ao atualizar o registro!";
                }
                else
                {
                    dados.Mensagem = "Falha ao atualizar o registro!";
                }
                Conexao.fecharConexao();
            }

            catch (MySqlException erro)
            {
                dados.Mensagem = "ERRO - AtualizarProduto - AtualizarDadosProduto - " +
                erro.Message.ToString();
            }
        }
    }
    public class DeletarProduto
    {

    }
}
