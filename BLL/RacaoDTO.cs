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
    public class RacaoDTO
    {
        // Digite prop e aperte 2x e tecla TAB
        // Altere o tipo conforme a necessidade
        public int Codigo { get; set; }
        public int CodigoRacao { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public int Quantidade { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public int CodigoFuncionario { get; set; }
        public string Funcionario { get; set; }
        public string Mensagem { get; set; }

    }
    public class ConsultarRacao
    {
        public DataTable ListarRacao(RacaoDTO dados)
        {
            DataTable tabela = new DataTable();
            try
            {
                string sql = "SELECT RaCodigo, RaNome FROM tb_racao";

                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, Conexao.obterConexao());
                adaptador.Fill(tabela);
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "ERRO - ConsultarRacao - ListarRacao -" + erro.ErrorCode + erro.Message;
            }
            return tabela;
        }
        public DataTable ListarFuncionario(RacaoDTO dados)
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
                dados.Mensagem = "ERRO - ConsultarRacao - ListarFuncionario -" + erro.ErrorCode + erro.Message;
            }
            return tabela;
        }
        public void NovoCodigo(RacaoDTO dados)
        {
            try
            {
                //Instrução de comando para o Banco de Dados
                string sql = "SELECT DrCodigo FROM tb_diskracao ORDER BY " +
                "DrCodigo DESC LIMIT 1";
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
        public DataTable ListarEstoqueDataGridView(RacaoDTO dados)
        {
            //Declaração da variável que receberá os dados no formato de tabela.
            DataTable tabela = new DataTable();
            try
            {
                //Intrução de comando SELECT para o BD
                string sql = "SELECT RaCodigo, RaNome, EsQuantidade FROM tb_estoque INNER JOIN tb_racao ON EsCodigoRacao = RaCodigo";
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
                dados.Mensagem = "Erro - ConsultarRacao - ListarEstoqueDataGridView " +
                erro.Message.ToString();
            }
            //O comando SELECT sempre precisa retornar algum dado
            //Este retorno será no formato de tabela, sendo aplicado ao DataGridView
            return tabela;
        }
    }
    public class InserirRacao
    {
        /*public void InserirDados(RacaoDTO dados)
        {
            //Instrução de inserção no banco de dados
            string sql = "INSERT INTO tb_diskracao " +
                "(DrFnCodigo, DrRaCodigo, DrQuantidade, DrEntrada, DrSaida) " +
                                         "VALUES (@codigoFuncionario, @racao, @quantidade, @entrada, @saida)";
            //Instância que realizará a conexão e execução do Insert
            MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
            //Tipo de comando: Text ou Procedure
            cmd.CommandType = CommandType.Text;
            //Parâmetros a serem substituídos
            //Fatal ERROR - caso os parâmetros @ estejam errados
            cmd.Parameters.Add(new MySqlParameter("@codigoFuncionario", dados.CodigoFuncionario));
            cmd.Parameters.Add(new MySqlParameter("@racao", dados.CodigoRacao));
            cmd.Parameters.Add(new MySqlParameter("@quantidade", dados.Quantidade));
            cmd.Parameters.Add(new MySqlParameter("@entrada", dados.Entrada));
            cmd.Parameters.Add(new MySqlParameter("@saida", dados.Saida));
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
        }*/
        public void InserirDados(RacaoDTO dados)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_InserirSubtrair", Conexao.obterConexao());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new MySqlParameter("@pEsCodigo", dados.Codigo));
                cmd.Parameters.Add(new MySqlParameter("@pFnCodigo", dados.CodigoFuncionario));
                cmd.Parameters.Add(new MySqlParameter("@pDrQuantidade", dados.Quantidade));
                cmd.Parameters.Add(new MySqlParameter("@pDrEntrada", dados.Entrada));
                cmd.Parameters.Add(new MySqlParameter("@pDrSaida", dados.Saida));
                cmd.Parameters.Add(new MySqlParameter("@pCodigoRacao", dados.CodigoRacao));

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
                dados.Mensagem = "ERRO - InserirRacao - InserirDados: " +
                erro.Message.ToString();
            }
        }
    }
} 
