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
    public class ServicoDTO
    {
        public int Codigo { get; set; }
        public string Banho { get; set; }
        public string Hidratacao { get; set; }
        public string Tosa { get; set; }
        public string Desembolo { get; set; }
        public string Alergia { get; set; }
        public string Pulgas { get; set; }
        public string Mensagem { get; set; }
    }
    public class SalvarServico
    {
        public void InserirDadosServico(ServicoDTO dados)
        {
            try
            {
                //Instrução de inserção no banco de dados
                string sql = "INSERT INTO tb_servico " +
                    "(SeBanho, SeHidratacao, SeTosa, SeDesembolo , SeAlergia) VALUES (@banho, @hidratacao, @tosa, @desembolo, @alergia)";

                //Instância que realizará a conexão e execução do Insert
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Tipo de comando: Text ou Procedure
                cmd.CommandType = CommandType.Text;
                //Parâmetros a serem substituídos
                //Fatal ERROR - caso os parâmetros @ estejam errados
                cmd.Parameters.Add(new MySqlParameter("@banho", dados.Banho));
                cmd.Parameters.Add(new MySqlParameter("@hidratacao", dados.Hidratacao));
                cmd.Parameters.Add(new MySqlParameter("@tosa", dados.Tosa));
                cmd.Parameters.Add(new MySqlParameter("@desembolo", dados.Desembolo));
                cmd.Parameters.Add(new MySqlParameter("@alergia", dados.Alergia));
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
                dados.Mensagem = "ERRO - SalvarBanho - Servico - " +
               erro.ErrorCode +
               erro.Message;
            }
        }
    }
    public class ConsultarServico
    {

    }
    public class AtualizarServico
    {
        public void AtualizarDadosServico(ServicoDTO dados)
        {
            try
            {
                //String com o comando de atualização
                string sql = "UPDATE tb_servico SET SeBanho=@banho," +
                "SeHidratacao=@hidratacao,SeTosa=@tosa,SeDesembolo=@desembolo, SeAlergia=@alergia WHERE SeCodigo=@codigoServico";
                //Uso da abertura de Conexão e da string sql
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Tipo de comando: Text ou Stored Procedure
                cmd.CommandType = CommandType.Text;
                //Parâmetros que serão substituídos (@) por variáveis

                cmd.Parameters.Add(new MySqlParameter("@codigoServico", dados.Codigo));
                cmd.Parameters.Add(new MySqlParameter("@banho", dados.Banho));
                cmd.Parameters.Add(new MySqlParameter("@hidratacao", dados.Hidratacao));
                cmd.Parameters.Add(new MySqlParameter("@tosa", dados.Tosa));
                cmd.Parameters.Add(new MySqlParameter("@desembolo", dados.Desembolo));
                cmd.Parameters.Add(new MySqlParameter("@alergia", dados.Alergia));

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
    public class DeletarServico
    {
        public void DeletarDadosServico(ServicoDTO dados)
        {
            try
            {
                //Comando Delete para o BD
                string sql = "DELETE from tb_servico  WHERE SeCodigo=@codigoS";
                //Variável que receberá o resultado da Conexão e Delete
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Declarar o tipo de comando: Text ou Procedure
                cmd.CommandType = CommandType.Text;
                //Parâmetros que serão substituídos
                cmd.Parameters.Add(new MySqlParameter("@codigoS", dados.Codigo));


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
