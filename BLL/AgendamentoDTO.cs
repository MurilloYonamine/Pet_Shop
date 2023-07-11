using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using MySql.Data.MySqlClient;

namespace BLL
{
    public class AgendamentoDTO
    {
        public int Codigo { get; set; }
        public string Responsavel { get; set; }
        public string Telefone { get; set; }
        public string NomeAnimal { get; set; }
        public string Raca { get; set; }
        public DateTime Data { get; set; }
        public string Mensagem { get; set; }
    }
    public class SalvarAgendamento
    {
        public void InserirDadosAgendamento(AgendamentoDTO dados)
        {
            try
            {
                //Instrução de inserção no banco de dados
                string sql = "INSERT INTO tb_agendamento " +
                    "(AgResponsavel, AgTelefone, AgNomeAnimal, AgRaca , AgAgendamento) " +
                    "VALUES (@responsavel, @telefone, @nomeanimal, @raca, @agendamento)";

                //Instância que realizará a conexão e execução do Insert
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Tipo de comando: Text ou Procedure
                cmd.CommandType = CommandType.Text;
                //Parâmetros a serem substituídos
                //Fatal ERROR - caso os parâmetros @ estejam errados
                cmd.Parameters.Add(new MySqlParameter("@responsavel", dados.Responsavel));
                cmd.Parameters.Add(new MySqlParameter("@telefone", dados.Telefone));
                cmd.Parameters.Add(new MySqlParameter("@nomeanimal", dados.NomeAnimal));
                cmd.Parameters.Add(new MySqlParameter("@raca", dados.Raca));
                cmd.Parameters.Add(new MySqlParameter("@agendamento", dados.Data));
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
                dados.Mensagem = "ERRO - SalvarBanho - Agendamento - " +
               erro.ErrorCode +
               erro.Message;
            }
        }

    }
    public class ConsultarAgendamento
    {
        public DataTable ListarDadosBanho(AgendamentoDTO dados)
        {
            //Declaração da variável que receberá os dados no formato de tabela.
            DataTable tabela = new DataTable();
            try
            {
                //Intrução de comando SELECT para o BD
                string sql = "SELECT ag.*, s.SeBanho,s.SeHidratacao,s.SeTosa,s.SeDesembolo,s.SeAlergia, a.AnaPulgas,a.AnaLesoes,a.AnaObservacoes " +
                    "FROM tb_agendamento AS ag " +
                    "INNER JOIN tb_servico AS s " +
                    "ON Agcodigo = SeCodigo " +
                    "INNER JOIN tb_analise AS a " +
                    "ON Agcodigo = AnaCodigo";
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
                dados.Mensagem = "Erro - ConsultarAgendamento - ListarDadosBanho " +
                erro.Message.ToString();
            }
            //O comando SELECT sempre precisa retornar algum dado
            //Este retorno será no formato de tabela, sendo aplicado ao DataGridView
            return tabela;
        }
        public DataTable ListarDadosBanhoFiltro(AgendamentoDTO dados)
        {
            //Declaração da variável que receberá os dados no formato de tabela.
            DataTable tabela = new DataTable();
            try
            {
                //Intrução de comando SELECT para o BD
                string sql = "SELECT * FROM tb_agendamento JOIN tb_servico JOIN tb_analise WHERE AgResponsavel like @responsavel";
                //Comando para o SELECT e a Conexão - MySqlCommand
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                cmd.Parameters.Add(new MySqlParameter("@responsavel", dados.Responsavel + "%"));

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
                dados.Mensagem = "Erro - ConsultarAgendamento - ListarDadosBanhoFiltro " +
                erro.Message.ToString();
            }
            //O comando SELECT sempre precisa retornar algum dado
            //Este retorno será no formato de tabela, sendo aplicado ao DataGridView
            return tabela;
        }
    }
    public class AtualizarAgendamento
    {
        public void AtualizarDadosAgendamento(AgendamentoDTO dados)
        {
            try
            {
                //String com o comando de atualização
                string sql = "UPDATE tb_agendamento SET AgResponsavel=@responsavel," +
                "AgTelefone=@telefone,AgNomeAnimal=@nomeanimal,AgRaca=@raca, AgAgendamento=@agendamento WHERE Agcodigo=@codigo";
                //Uso da abertura de Conexão e da string sql
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Tipo de comando: Text ou Stored Procedure
                cmd.CommandType = CommandType.Text;
                //Parâmetros que serão substituídos (@) por variáveis
                cmd.Parameters.Add(new MySqlParameter("@codigo", dados.Codigo));
                cmd.Parameters.Add(new MySqlParameter("@responsavel", dados.Responsavel));
                cmd.Parameters.Add(new MySqlParameter("@telefone", dados.Telefone));
                cmd.Parameters.Add(new MySqlParameter("@nomeanimal", dados.NomeAnimal));
                cmd.Parameters.Add(new MySqlParameter("@raca", dados.Raca));
                cmd.Parameters.Add(new MySqlParameter("@agendamento", dados.Data));

                //Quantidade de registros atualizados
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
                dados.Mensagem = "ERRO - AtualizarAgendamento - AtualizarBanho - " +
                erro.Message.ToString();

            }
        }
    }
    public class DeletarAgendamento
    {
        public void DeletarDadosAgendamento(AgendamentoDTO dados)
        {
            try
            {
                //Comando Delete para o BD
                string sql = "DELETE from tb_agendamento WHERE Agcodigo=@codigo";
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
            catch (MySqlException erro)
            {
                dados.Mensagem = "ERRO - DeletarBanho - DeletarDados " + erro.Message;
            }

        }
    }
}
