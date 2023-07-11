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
    public class PetMarketDTO
    {
        //Produto
        public int CodigoProduto { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public DateTime RegistroProduto { get; set; }

        //Estoque
        public int CodigoEstoque { get; set; }
        public int QuantidadeEstoque { get; set; }
        public Boolean Situacao { get; set; }

        //Fornecedor
        public int CodigoFornecedor { get; set; }
        public string Fornecedor { get; set; }
        public DateTime ValidadeFornecedor { get; set; }
        public int QuantidadeFornecedor { get; set; }
        public string PrecoFornecedor { get; set; }
        public DateTime RegistroFornecedor { get; set; }
        public decimal TotalFornecedor { get; set; }

        //Venda
        public int CodigoVenda { get; set; }
        public DateTime ValidadeVenda { get; set; }
        public string PrecoVenda { get; set; }
        public int QuantidadeVenda { get; set; }
        public int TotalVenda { get; set; }



        public string Mensagem { set; get; }
    }
    public class SalvarPetMarket
    {
        public void InserirDadosProduto(PetMarketDTO dados)
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
                cmd.Parameters.Add(new MySqlParameter("@proRegistro", dados.RegistroProduto));
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

                dados.Mensagem = "ERRO - SalvarPetMarket - InserirDadosProduto -" + erro.ErrorCode + erro.Message;
            }
        }
        public void InserirDadosEstoque(PetMarketDTO dados)
        {
            try
            {
                string sql = "INSERT INTO tb_estoque (EsProCodigo, EsQuantidade) " +
                    "VALUES (@codigoProduto, @qtd)";
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new MySqlParameter("@codigoProduto", dados.CodigoProduto));
                cmd.Parameters.Add(new MySqlParameter("@qtd", dados.QuantidadeEstoque));
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

                dados.Mensagem = "ERRO - SalvarPetMarket - InserirDadosEstoque -" + erro.ErrorCode + erro.Message;
            }
        }
        public void InserirDadosFornecedor(PetMarketDTO dados)
        {
            try
            {

                string sql = "INSERT INTO tb_fornecedor " +
                    "(FoNome, FoValidade, FoQuantidade, FoPreco, FoProCodigo FoRegistro, FoTotal) " +
                    "VALUES (@nome, @validade, @quantidade, @preco, @proCodigo, @registro, @total)";
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new MySqlParameter("@nome", dados.Fornecedor));
                cmd.Parameters.Add(new MySqlParameter("@validade", dados.ValidadeFornecedor));
                cmd.Parameters.Add(new MySqlParameter("@quantidade", dados.QuantidadeFornecedor));
                cmd.Parameters.Add(new MySqlParameter("@preco", dados.PrecoFornecedor));
                cmd.Parameters.Add(new MySqlParameter("@proCodigo", dados.CodigoProduto));
                cmd.Parameters.Add(new MySqlParameter("@registro", dados.RegistroFornecedor));
                cmd.Parameters.Add(new MySqlParameter("@total", dados.TotalFornecedor));

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

                dados.Mensagem = "ERRO - SalvarPetMarket - InserirDadosFornecedor -" + erro.ErrorCode + erro.Message;
            }
        }
        public void InserirDadosSomar(PetMarketDTO dados)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_PmInserirSomar", Conexao.obterConexao());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new MySqlParameter("@pFoValidade", dados.ValidadeFornecedor));
                cmd.Parameters.Add(new MySqlParameter("@pFoQuantidade ", dados.QuantidadeEstoque));
                cmd.Parameters.Add(new MySqlParameter("@pFoPreco", dados.PrecoFornecedor));
                cmd.Parameters.Add(new MySqlParameter("@pFoProCodigo", dados.CodigoProduto));
                cmd.Parameters.Add(new MySqlParameter("@pFoRegistro", dados.RegistroFornecedor));
                cmd.Parameters.Add(new MySqlParameter("@pFoNome", dados.Fornecedor));
                cmd.Parameters.Add(new MySqlParameter("@pFoTotal", dados.TotalFornecedor));

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
                dados.Mensagem = "ERRO - SalvarPetMarket - InserirDadosSomar: " +
                erro.Message.ToString();
            }
        }
        public void InserirVenda(PetMarketDTO dados)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_Venda", Conexao.obterConexao());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new MySqlParameter("@pVenProCodigo", dados.CodigoProduto));
                cmd.Parameters.Add(new MySqlParameter("@pVenPreco ", dados.PrecoVenda));
                cmd.Parameters.Add(new MySqlParameter("@pVenValidade", dados.ValidadeVenda));
                cmd.Parameters.Add(new MySqlParameter("@pVenQuantidade", dados.QuantidadeVenda));
                cmd.Parameters.Add(new MySqlParameter("@pVenTotal", dados.TotalVenda));

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
                dados.Mensagem = "ERRO - SalvarPetMarket - InserirVenda: " +
                erro.Message.ToString();
            }
        }
    }
    public class ConsultarPetMarket
    {
        public void BuscarCodigoProduto(PetMarketDTO dados)
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
                        dados.CodigoProduto = dr.GetInt32(0);
                    }//11 + 1 = 12
                }
                Conexao.fecharConexao();

            }
            catch (MySqlException erro)
            {

                dados.Mensagem = "ERRO - ConsultarPetMarket - BuscarCodigoProduto -" + erro.ErrorCode + erro.Message;
            }
        }
        public void VerificarQuantidadeEstoque(PetMarketDTO dados)
        {
            try
            {
                string sql = "SELECT EsQuantidade FROM tb_estoque WHERE EsProCodigo=@codigo";
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new MySqlParameter("@codigo", dados.CodigoProduto));

                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (dr.GetInt32(0) < dados.QuantidadeEstoque)
                        {
                            dados.Situacao = false;
                        }
                        else
                        {
                            dados.Situacao = true;
                        }
                    }
                }
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "ERRO - SalvarVenda - VerificarQtde -" + erro.ErrorCode + erro.Message;
            }
        }
        // --------------------------------------------------------------- //
        // Listar produtos na DataGridVIew
        public DataTable ListarDadosProduto(PetMarketDTO dados)
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
                dados.Mensagem = "Erro - ConsultarPetMarket - ListarDadosProduto " +
                erro.Message.ToString();
            }
            //O comando SELECT sempre precisa retornar algum dado
            //Este retorno será no formato de tabela, sendo aplicado ao DataGridView
            return tabela;
        }
        public DataTable ListarDadosFiltro(PetMarketDTO dados)
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
                dados.Mensagem = "Erro - ConsultarPetMarket - ListarDadosFiltro " +
                erro.Message.ToString();
            }
            return tabela;
        }
        // --------------------------------------------------------------- //
        // Listar vendas na DataGridVIew
        public DataTable ListarDadosVenda(PetMarketDTO dados)
        {
            //Declaração da variável que receberá os dados no formato de tabela.
            DataTable tabela = new DataTable();
            try
            {
                //Intrução de comando SELECT para o BD
                string sql = "SELECT * FROM tb_venda";
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
                dados.Mensagem = "Erro - ConsultarPetMarket - ListarDadosVenda " +
                erro.Message.ToString();
            }
            //O comando SELECT sempre precisa retornar algum dado
            //Este retorno será no formato de tabela, sendo aplicado ao DataGridView
            return tabela;
        }
        // --------------------------------------------------------------- //
        // Listar Compras pelo Fornecedor na DataGridVIew
        public DataTable ListarDadosCompra(PetMarketDTO dados)
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
                dados.Mensagem = "Erro - ConsultarPetMarket - ListarDadosCompra " +
                erro.Message.ToString();
            }
            //O comando SELECT sempre precisa retornar algum dado
            //Este retorno será no formato de tabela, sendo aplicado ao DataGridView
            return tabela;

        }
        // --------------------------------------------------------------- //
        // Listar estoque na DataGridVIew
        public DataTable ListarDadosEstoque(PetMarketDTO dados)
        {
            DataTable tabela = new DataTable();
            try
            {
                //Intrução de comando SELECT para o BD
                string sql = "SELECT es.EsCodigo, pro.ProNome, es.EsQuantidade " +
                    "FROM tb_estoque as es" +
                    "INNER JOIN tb_produto as pro" +
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
                dados.Mensagem = "Erro - ConsultarPetMarket - ListarDadosEstoque " +
                erro.Message.ToString();
            }
            //O comando SELECT sempre precisa retornar algum dado
            //Este retorno será no formato de tabela, sendo aplicado ao DataGridView
            return tabela;

        }
        public DataTable ListarDadosProdutoFiltro(PetMarketDTO dados)
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
                cmd.Parameters.Add(new MySqlParameter("@nome", "%" + dados.Nome + "%"));
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
                dados.Mensagem = "Erro - ConsultarClientes - ListarDadosClientes " +
                erro.Message.ToString();
            }
            //O comando SELECT sempre precisa retornar algum dado
            //Este retorno será no formato de tabela, sendo aplicado ao DataGridView
            return tabela;
        }
    }
    public class AtualizarPetMarket
    {
        public void AtualizarDadosProduto(PetMarketDTO dados)
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
                cmd.Parameters.Add(new MySqlParameter("@codigo", dados.CodigoProduto));
                cmd.Parameters.Add(new MySqlParameter("@nome", dados.Nome));
                cmd.Parameters.Add(new MySqlParameter("@tipo", dados.Tipo));
                cmd.Parameters.Add(new MySqlParameter("@marca", dados.Marca));
                cmd.Parameters.Add(new MySqlParameter("@registro", dados.RegistroProduto));
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
                dados.Mensagem = "ERRO - AtualizarPetMarket - AtualizarDadosProduto - " +
                erro.Message.ToString();
            }
        }
        public void AtualizarDadosVenda(PetMarketDTO dados)
        {
            try
            {
                //String com o comando de atualização
                string sql = "UPDATE tb_venda SET " +
                "VenPreco=@preco, VenValidade=@validade, VenQuantidade=@qtde, VenTotal=@total" +
                " WHERE VenProCodigo=@codigo";
                //Uso da abertura de Conexão e da string sql
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Tipo de comando: Text ou Stored Procedure
                cmd.CommandType = CommandType.Text;
                //Parâmetros que serão substituídos (@) por variáveis
                cmd.Parameters.Add(new MySqlParameter("@preco", dados.PrecoVenda));
                cmd.Parameters.Add(new MySqlParameter("@validade", dados.ValidadeVenda));
                cmd.Parameters.Add(new MySqlParameter("@qtde", dados.QuantidadeVenda));
                cmd.Parameters.Add(new MySqlParameter("@total", dados.TotalVenda));
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
                dados.Mensagem = "ERRO - AtualizarVenda - AtualizarDados - " +
                erro.Message.ToString();
            }
        }
        public void AtualizarDadosFornecedor(PetMarketDTO dados)
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
                cmd.Parameters.Add(new MySqlParameter("@codigo", dados.CodigoFornecedor));
                cmd.Parameters.Add(new MySqlParameter("@fornecedor", dados.Fornecedor));
                cmd.Parameters.Add(new MySqlParameter("@validade", dados.ValidadeFornecedor));
                cmd.Parameters.Add(new MySqlParameter("@qtde", dados.QuantidadeFornecedor));
                cmd.Parameters.Add(new MySqlParameter("@preco", dados.PrecoFornecedor));
                cmd.Parameters.Add(new MySqlParameter("@registro", dados.RegistroFornecedor));
                cmd.Parameters.Add(new MySqlParameter("@produto", dados.RegistroFornecedor));
                cmd.Parameters.Add(new MySqlParameter("@total", dados.TotalFornecedor));
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
                dados.Mensagem = "ERRO - AtualizarPetMarket - AtualizarDadosFornecedor - " +
                erro.Message.ToString();
            }

        }
    }
    public class DeletarPetMarket
    {
        public void DeletarDadosFornecedor(PetMarketDTO dados)
        {
            //Comando Delete para o BD
            string sql = "DELETE FROM tb_fornecedor WHERE FoCodigo=@codigo";
            //Variável que receberá o resultado da Conexão e Delete
            MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
            //Declarar o tipo de comando: Text ou Procedure
            cmd.CommandType = CommandType.Text;
            //Parâmetros que serão substituídos
            cmd.Parameters.Add(new MySqlParameter("@codigo", dados.CodigoFornecedor));
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
        public void DeletarDadosVenda(PetMarketDTO dados)
        {
            try
            {
                string sql = "DELETE FROM tb_venda WHERE VenCodigo=@codigo";
                //Variável que receberá o resultado da Conexão e Delete
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Declarar o tipo de comando: Text ou Procedure
                cmd.CommandType = CommandType.Text;
                //Parâmetros que serão substituídos
                cmd.Parameters.Add(new MySqlParameter("@codigo", dados.CodigoVenda));
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
            catch (MySqlException erro)
            {

                dados.Mensagem = "ERRO - DeletarPetMarket - DeletarDadosVenda -" + erro.ErrorCode + erro.Message;
            }
        }
    }
}
