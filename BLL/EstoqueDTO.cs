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
    public class EstoqueDTO
    {
        public int Codigo { get; set; }
        public int Quantidade { get; set; }
        public string Mensagem { get; set; }
        public string NomeProduto { get; set; }
    }
    public class SalvarEstoque
    {
        public void InserirDadosEstoque(EstoqueDTO dados)
        {
            try
            {
                string sql = "INSERT INTO tb_estoque (EsProCodigo, EsQuantidade) " +
                    "VALUES (@codigoProduto, @qtd)";
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new MySqlParameter("@codigoProduto", dados.Codigo));
                cmd.Parameters.Add(new MySqlParameter("@qtd", dados.Quantidade));
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

                dados.Mensagem = "ERRO - SalvarEstoque - InserirDadosEstoque -" + erro.ErrorCode + erro.Message;
            }
        }
    }
    public class ConsultarEstoque
    {
        // --------------------------------------------------------------- //
        // Listar estoque na DataGridVIew
        public DataTable ListarDadosEstoque(EstoqueDTO dados)
        {
            DataTable tabela = new DataTable();
            try
            {
                //Intrução de comando SELECT para o BD
                string sql = "SELECT es.EsCodigo, pro.ProNome, es.EsQuantidade " +
                    "FROM tb_estoque as es " +
                    "INNER JOIN tb_produto as pro " +
                    "ON EsProCodigo=ProCodigo";
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
                dados.Mensagem = "Erro - ConsultarEstoque - ListarDadosEstoque " +
                erro.Message.ToString();
            }
            //O comando SELECT sempre precisa retornar algum dado
            //Este retorno será no formato de tabela, sendo aplicado ao DataGridView
            return tabela;

        }
        public DataTable ListarDadosProdutoFiltro(EstoqueDTO dados)
        {
            DataTable tabela = new DataTable();
            try
            {
                //Intrução de comando SELECT para o BD
                string sql = "SELECT es.EsCodigo, pro.ProNome, es.EsQuantidade " +
                    "FROM tb_estoque as es" +
                    "INNER JOIN tb_produto as pro" +
                    "ON EsProCodigo=ProCodigo WHERE ProNome LIKE @nome";
                //Comando para o SELECT e a Conexão - MySqlCommand
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                cmd.Parameters.Add(new MySqlParameter("@nome", "%" + dados.NomeProduto + "%"));
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
                dados.Mensagem = "Erro - ConsultarEstoque - ListarDadosProdutoFiltro " +
                erro.Message.ToString();
            }
            //O comando SELECT sempre precisa retornar algum dado
            //Este retorno será no formato de tabela, sendo aplicado ao DataGridView
            return tabela;
        }
    }
    public class AtualizarEstoque
    {

    }
    public class DeletarEstoque
    {

    }
}
