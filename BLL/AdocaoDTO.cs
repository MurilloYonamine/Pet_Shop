using DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AdocaoDTO
    {
        public int Codigo { get; set; }
        public int CodigoPet { get; set; }
        public string NomePet { get; set; }
        public int CodigoCliente { get; set; }
        public string Cliente { get; set; }
        public int Funcionario { get; set; }
        public string Raca { get; set; }
        public string Cor { get; set; }
        public string Tipo { get; set; }
        public decimal Peso { get; set; }
        public DateTime Data { get; set; }
        public string Pedigree { get; set; }
        public string Rga { get; set; }
        public string Sexo { get; set; }
        public string Observacao { get; set; }
        public string Mensagem { get; set; }
        public string Pesquisa { get; set; }
    }
    public class InserirAdocao
    {
        /*public void InserirDados(AdocaoDTO dados)
        {
            try
            {
                //Instrução de inserção no banco de dados
                string sql = "INSERT INTO tb_adocao " +
                    "(AdoAnCodigo, AdoFnCodigo, AdoClCodigo, AdoData) " +
                     "VALUES (@animal, @funcionario, @cliente, @data)";
                //Instância que realizará a conexão e execução do Insert
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Tipo de comando: Text ou Procedure
                cmd.CommandType = CommandType.Text;
                //Parâmetros a serem substituídos
                //Fatal ERROR - caso os parâmetros @ estejam errados
                cmd.Parameters.Add(new MySqlParameter("@nome", dados.CodigoPet));
                cmd.Parameters.Add(new MySqlParameter("@funcionario", dados.Funcionario));
                cmd.Parameters.Add(new MySqlParameter("@cliente", dados.CodigoDono));
                cmd.Parameters.Add(new MySqlParameter("@data", dados.Data));
                //Contagem de registros inseridos e execução do Insert
                //ExecuteNonQuery = retorna o número de linhas alteradas
                int registrosInseridos = cmd.ExecuteNonQuery();
                //Verificação de quantos registros foram inseridos
                if (registrosInseridos >= 1)
                {
                    dados.Mensagem = "Registro inserido com Sucesso!";
                }
                else
                {
                    dados.Mensagem = "Falha ao inserir o registro!";
                }
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "ERRO - InserirAdocao - InserirDados - " +
                erro.ErrorCode +
                erro.Message;
            }

           
        }*/
        public void InserirDados(AdocaoDTO dados)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_AtualizarInserirAdocao", Conexao.obterConexao());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new MySqlParameter("@pCodigoFuncionario", dados.Funcionario));
                cmd.Parameters.Add(new MySqlParameter("@pCodigoCliente", dados.CodigoCliente));
                cmd.Parameters.Add(new MySqlParameter("@pCodigoPet", dados.CodigoPet));
                cmd.Parameters.Add(new MySqlParameter("@pData", dados.Data));

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
                dados.Mensagem = "ERRO - InserirAdocao - InserirDados: " +
                erro.Message.ToString();
            }
        }
    }
    public class ConsultarAdocao
    {
        public DataTable ListarDadosAnimaisAdocao(AdocaoDTO dados)
        {
            //Declaração da variável que receberá os dados no formato de tabela.
            DataTable tabela = new DataTable();
            try
            {
                //Instrução de comando para o Banco de dados
                string sql = "SELECT * FROM tb_animal WHERE AnClCodigo = 1";
                //Adaptação dos dados do Banco de dados para o formato
                //de tabela com a execução da Conexão e Select
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, Conexao.obterConexao());
                //Preenchimento da variável em formato de tabela - Fill = preencher
                adaptador.Fill(tabela);
                //Fechamento da conexão
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "ERRO - ConsultarAdocao - ListarDadosAnimais: " +
                erro.Message.ToString();
            }
            //Retorno da tabela para DataGridView do form
            return tabela;
        }
        public DataTable ListarFuncionario(AdocaoDTO dados)
        {
            DataTable tabela = new DataTable();
            try
            {
                string sql = "SELECT FnCodigo, FnNome FROM tb_funcionario";

                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, Conexao.obterConexao());
                adaptador.Fill(tabela);
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "ERRO - ConsultarAdocao - ListarFuncionario -" + erro.ErrorCode + erro.Message;
            }
            return tabela;
        }
        public void NovoCodigo(AdocaoDTO dados)
        {
            try
            {
                //Instrução de comando para o Banco de Dados
                string sql = "SELECT AdoCodigo FROM tb_adocao ORDER BY " +
                "AdoCodigo DESC LIMIT 1";
                //Variável que receberá o resultado da Conexão e Comando SELECT
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
                        dados.Codigo = dr.GetInt32(0) + 1;
                    }//11 + 1 = 12
                }
                else
                {
                    dados.Codigo = 1;
                }
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "ERRO - ConsultarRacao - NovoCodigo " +
                erro.Message.ToString();
            }
        }
        public DataTable PesquisaDadosAdocao(AdocaoDTO dados)
        {
            //Declaração da variável que receberá os dados no formato de tabela.
            DataTable tabela = new DataTable();
            try
            {
                // Declaração da Variável que receberá os dados em formato tabela
                string sql = "SELECT an.*, cli.ClNome FROM tb_animal as an " +
                                "INNER JOIN tb_cliente as cli " +
                                "On ClCodigo = AnClCodigo " +
                                "WHERE AnNomePet LIKE @nomePet OR " +
                                "AnClCodigo LIKE @clienteCodigo OR " +
                                "AnFnNome LIKE @funcionario OR " +
                                "AnRaca LIKE @raca OR " +
                                "AnCor LIKE @cor OR " +
                                "AnTipo LIKE @tipo OR " +
                                "AnPeso LIKE @peso OR " +
                                "AnNascimento LIKE @nascimento OR " +
                                "AnPedigree LIKE @pedigree OR " +
                                "AnRga LIKE @rga OR " +
                                "AnSexo LIKE @sexo OR " +
                                "AnObservacao LIKE @observacao OR " +
                                "ClNome LIKE @nomeCliente; ";

                // Comando para o Select e a conexão = MySqlCommand
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());

                //Substitui o parâmetro @nome para o conteúdo digitado
                cmd.Parameters.Add(new MySqlParameter("@nomePet", "%" + dados.Pesquisa + "%"));
                cmd.Parameters.Add(new MySqlParameter("@nomeCliente", "%" + dados.Pesquisa + "%"));
                cmd.Parameters.Add(new MySqlParameter("@clienteCodigo", "%" + dados.Pesquisa + "%"));
                cmd.Parameters.Add(new MySqlParameter("@funcionario", "%" + dados.Pesquisa + "%"));
                cmd.Parameters.Add(new MySqlParameter("@raca", "%" + dados.Pesquisa + "%"));
                cmd.Parameters.Add(new MySqlParameter("@cor", "%" + dados.Pesquisa + "%"));
                cmd.Parameters.Add(new MySqlParameter("@tipo", "%" + dados.Pesquisa + "%"));
                cmd.Parameters.Add(new MySqlParameter("@peso", "%" + dados.Pesquisa + "%"));
                cmd.Parameters.Add(new MySqlParameter("@nascimento", "%" + dados.Pesquisa + "%"));
                cmd.Parameters.Add(new MySqlParameter("@pedigree", "%" + dados.Pesquisa + "%"));
                cmd.Parameters.Add(new MySqlParameter("@rga", "%" + dados.Pesquisa + "%"));
                cmd.Parameters.Add(new MySqlParameter("@sexo", "%" + dados.Pesquisa + "%"));
                cmd.Parameters.Add(new MySqlParameter("@observacao", "%" + dados.Pesquisa + "%"));

                // Adaptar os dados do BD para o formato de tabela
                // com a execução da CONEXÃO e SELECT
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);

                // Preenchimento da variável em formato de tabela - FILL = preencher
                adaptador.Fill(tabela);

                // Fechar a conexão
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "ERRO - ConsultarClientes - ListarDadosClientesFiltro " + erro.Message.ToString();
            }
            // O comando SELECT sempre precisa retornar algum dado 
            // Este retorno será no formato de tabela, sendo aplicado ao DataGridView
            return tabela;
        }
        public DataTable ListarDadosClientes(AdocaoDTO dados)
        {
            //Declaração da variável que receberá os dados no formato de tabela.
            DataTable tabela = new DataTable();
            try
            {
                //Instrução de comando para o Banco de dados
                string sql = "SELECT ClCodigo, ClNome FROM tb_cliente";
                //Adaptação dos dados do Banco de dados para o formato
                //de tabela com a execução da Conexão e Select
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, Conexao.obterConexao());
                //Preenchimento da variável em formato de tabela - Fill = preencher
                adaptador.Fill(tabela);
                //Fechamento da conexão
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "ERRO - ConsultarAdocao - ListarDadosClientes: " +
                erro.Message.ToString();
            }
            //Retorno da tabela para DataGridView do form
            return tabela;
        }
        public DataTable PesquisaDadosCliente(AdocaoDTO dados)
        {
            //Declaração da variável que receberá os dados no formato de tabela.
            DataTable tabela = new DataTable();
            try
            {
                // Declaração da Variável que receberá os dados em formato tabela
                string sql = "SELECT ClCodigo, ClNome FROM tb_cliente WHERE ClNome LIKE @nome";

                // Comando para o Select e a conexão = MySqlCommand
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());

                //Substitui o parâmetro @nome para o conteúdo digitado
                cmd.Parameters.Add(new MySqlParameter("@nome", "%" + dados.Cliente + "%"));

                // Adaptar os dados do BD para o formato de tabela
                // com a execução da CONEXÃO e SELECT
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);

                // Preenchimento da variável em formato de tabela - FILL = preencher
                adaptador.Fill(tabela);

                // Fechar a conexão
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "ERRO - ConsultarAdocao - ListarDadosClientesFiltros " + erro.Message.ToString();
            }
            // O comando SELECT sempre precisa retornar algum dado 
            // Este retorno será no formato de tabela, sendo aplicado ao DataGridView
            return tabela;
        }
    }
}


