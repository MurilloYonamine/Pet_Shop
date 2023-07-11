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
    public class FornecedorDTO
    {
        public int Codigo { get; set; }
        public int CodigoProduto { get; set; }
        public string Produto { get; set; }
        public string Fornecedor { get; set; }
        public DateTime Validade { get; set; }
        public int Quantidade { get; set; }
        public string Preco { get; set; }
        public DateTime Registro { get; set; }
        public decimal Total { get; set; }
        public string Mensagem { get; set; }
    }
    public class SalvarFornecedor
    {
        public void InserirDadosFornecedor(FornecedorDTO dados)
        {
            try
            {

                string sql = "INSERT INTO tb_fornecedor " +
                    "(FoNome, FoValidade, FoQuantidade, FoPreco, FoProCodigo FoRegistro, FoTotal) " +
                    "VALUES (@nome, @validade, @quantidade, @preco, @proCodigo, @registro, @total)";
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new MySqlParameter("@nome", dados.Fornecedor));
                cmd.Parameters.Add(new MySqlParameter("@validade", dados.Validade));
                cmd.Parameters.Add(new MySqlParameter("@quantidade", dados.Quantidade));
                cmd.Parameters.Add(new MySqlParameter("@preco", dados.Preco));
                cmd.Parameters.Add(new MySqlParameter("@proCodigo", dados.CodigoProduto));
                cmd.Parameters.Add(new MySqlParameter("@registro", dados.Registro));
                cmd.Parameters.Add(new MySqlParameter("@total", dados.Total));

                int registrosInseridos = cmd.ExecuteNonQuery();
                if (registrosInseridos >= 1)
                {
                    dados.Mensagem = "Registro da compra inserido com Sucesso!";
                }
                else
                {
                    dados.Mensagem = "Falha ao inserir a compra no registro!";
                }
            }
            catch (MySqlException erro)
            {

                dados.Mensagem = "ERRO - SalvarFornecedor - InserirDadosFornecedor -" + erro.ErrorCode + erro.Message;
            }
        }
        public void InserirDadosSomar(FornecedorDTO dados)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_PmInserirSomar", Conexao.obterConexao());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new MySqlParameter("@pFoValidade", dados.Validade));
                cmd.Parameters.Add(new MySqlParameter("@pFoQuantidade ", dados.Quantidade));
                cmd.Parameters.Add(new MySqlParameter("@pFoPreco", dados.Preco));
                cmd.Parameters.Add(new MySqlParameter("@pFoProCodigo", dados.CodigoProduto));
                cmd.Parameters.Add(new MySqlParameter("@pFoRegistro", dados.Registro));
                cmd.Parameters.Add(new MySqlParameter("@pFoNome", dados.Fornecedor));
                cmd.Parameters.Add(new MySqlParameter("@pFoTotal", dados.Total));

                int registrosAtualizados = cmd.ExecuteNonQuery();
                if (registrosAtualizados >= 1)
                {
                    dados.Mensagem = "Registro atualizado com Sucesso!";
                }
                else
                {
                    dados.Mensagem = "Falha ao atualizar registro!";
                }
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "ERRO - SalvarFornecedor - InserirDadosSomar: " +
                erro.Message.ToString();
            }
        }
    }
    public class ConsultarFornecedor
    {
        // --------------------------------------------------------------- //
        // Listar Compras pelo Fornecedor na DataGridVIew
        public DataTable ListarDadosCompra(FornecedorDTO dados)
        {
            //Declaração da variável que receberá os dados no formato de tabela.
            DataTable tabela = new DataTable();
            try
            {
                //Intrução de comando SELECT para o BD
                string sql = "SELECT * FROM tb_fornecedor";
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
                dados.Mensagem = "Erro - ConsultarFornecedor - ListarDadosCompra " +
                erro.Message.ToString();
            }
            //O comando SELECT sempre precisa retornar algum dado
            //Este retorno será no formato de tabela, sendo aplicado ao DataGridView
            return tabela;

        }
    }
    public class AtualizarFornecedor
    {
        public void AtualizarDadosFornecedor(FornecedorDTO dados)
        {
            try
            {
                //String com o comando de atualização
                string sql = "UPDATE tb_fornecedor SET " +
                "FoNome=@fornecedor, FoValidade=@validade, FoQuantidade=@qtde," +
                "FoPreco=@preco, FoProCodigo=@registro, FoProCodigo=@produto, FoTotal=@total" +
                " WHERE FoCodigo=@codigo";
                //Uso da abertura de Conexão e da string sql
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Tipo de comando: Text ou Stored Procedure
                cmd.CommandType = CommandType.Text;
                //Parâmetros que serão substituídos (@) por variáveis
                cmd.Parameters.Add(new MySqlParameter("@codigo", dados.Codigo));
                cmd.Parameters.Add(new MySqlParameter("@fornecedor", dados.Fornecedor));
                cmd.Parameters.Add(new MySqlParameter("@validade", dados.Validade));
                cmd.Parameters.Add(new MySqlParameter("@qtde", dados.Quantidade));
                cmd.Parameters.Add(new MySqlParameter("@preco", dados.Preco));
                cmd.Parameters.Add(new MySqlParameter("@registro", dados.Registro));
                cmd.Parameters.Add(new MySqlParameter("@produto", dados.Registro));
                cmd.Parameters.Add(new MySqlParameter("@total", dados.Total));
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
                dados.Mensagem = "ERRO - AtualizarFornecedor - AtualizarDadosFornecedor - " +
                erro.Message.ToString();
            }

        }
    }
    public class DeletarFornecedor
    {
        public void DeletarDadosFornecedor(FornecedorDTO dados)
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
    }
}
