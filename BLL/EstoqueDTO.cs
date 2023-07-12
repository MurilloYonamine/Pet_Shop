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
        public void CEstoque(EstoqueDTO dados)
        {
            int qtde = new int();

            try
            {
                string sql = "SELECT EsQuantidade FROM tb_estoque WHERE EsProCodigo=@codigo";
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Define o tipo de comando
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new MySqlParameter("@codigo", dados.Codigo));
                //Realiza a leitura dos dados - Reader
                //Ignora os títulos da tabela
                MySqlDataReader dr = cmd.ExecuteReader();
                //Verifica se há linhas nesta leitura de dados
                if (dr.HasRows)
                {
                    //Enquanto houver dados
                    while (dr.Read())
                    {
                        qtde = dr.GetInt32(0);
                        dados.Quantidade += qtde;
                    }//11 + 1 = 12
                }
                Conexao.fecharConexao();

            }
            catch (MySqlException erro)
            {

                dados.Mensagem = "ERRO - SalvarEstoque - InserirDados -" + erro.ErrorCode + erro.Message;
            }
            try
            {
                string sql = "UPDATE tb_estoque SET EsQuantidade=@qtde WHERE EsProCodigo=@codigo";
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new MySqlParameter("@qtde", dados.Quantidade));
                cmd.Parameters.Add(new MySqlParameter("@codigo", dados.Codigo));
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
                dados.Mensagem = "ERRO - SalvarEstoque - CEstoque -" + erro.ErrorCode + erro.Message;
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
        public void DeletarDados(EstoqueDTO dados)
        {
            //Comando Delete para o BD
            string sql = "DELETE FROM tb_fornecedor WHERE FoCodigo=@codigo";
            //Variável que receberá o resultado da Conexão e Delete
            MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
            //Declarar o tipo de comando: Text ou Procedure
            cmd.CommandType = CommandType.Text;
            //Parâmetros que serão substituídos
            cmd.Parameters.Add(new MySqlParameter("@codigo", dados.Codigo));
            //Execução do comando
            int registrosDeletados = cmd.ExecuteNonQuery();
            //Verificação da exclusão do registros
            if (registrosDeletados >= 1)
            {
                dados.Mensagem = "Registro deletado com Sucesso!";
            }
            else
            {
                dados.Mensagem = "Falha ao deletar o registro!";
            }
            Conexao.fecharConexao();

        }
        public void CancelarFornecedor(EstoqueDTO dados)
        {
            int qtde = new int();
            try
            {
                string sql = "SELECT FoQuantidade, EsQuantidade FROM tb_fornecedor INNER JOIN tb_estoque ON EsProCodigo = FoProCodigo WHERE FoCodigo=@codigo ";
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Define o tipo de comando
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new MySqlParameter("@codigo", dados.Codigo));
                //Realiza a leitura dos dados - Reader
                //Ignora os títulos da tabela
                MySqlDataReader dr = cmd.ExecuteReader();
                //Verifica se há linhas nesta leitura de dados
                if (dr.HasRows)
                {
                    //Enquanto houver dados
                    while (dr.Read())
                    {
                        dados.Quantidade = dr.GetInt32(0);
                        qtde = dr.GetInt32(1);
                        qtde -= dados.Quantidade;
                    }//11 + 1 = 12
                }
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "ERRO - DeletarEstoque - DCEstoque -" + erro.ErrorCode + erro.Message;
            }
            try
            {
                string sql = "UPDATE tb_estoque SET EsQuantidade=@qtde WHERE EsProCodigo=@codigo";
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new MySqlParameter("@qtde", qtde));
                cmd.Parameters.Add(new MySqlParameter("@codigo", dados.NomeProduto));
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
                dados.Mensagem = "ERRO - DeletarEstoque - DCEstoque -" + erro.ErrorCode + erro.Message;
            }
        }
    }
}
