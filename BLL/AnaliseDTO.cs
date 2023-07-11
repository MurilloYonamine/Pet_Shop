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
    public class AnaliseDTO
    {
        public int Codigo { get; set; }
        public string Pulgas { get; set; }
        public string Lesoes { get; set; }
        public string Observacao { get; set; }
        public string Mensagem { get; set; }
    }
    public class SalvarAnalise
    {
        public void InserirDadosAnalise(AnaliseDTO dados)
        {
            try
            {
                //Instrução de inserção no banco de dados
                string sql = "INSERT INTO tb_analise " +
                    "(AnaPulgas, AnaLesoes, AnaObservacoes) " +
                    "VALUES (@pulgas, @lesoes, @observacoes)";

                //Instância que realizará a conexão e execução do Insert
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Tipo de comando: Text ou Procedure
                cmd.CommandType = CommandType.Text;
                //Parâmetros a serem substituídos
                //Fatal ERROR - caso os parâmetros @ estejam errados
                cmd.Parameters.Add(new MySqlParameter("@pulgas", dados.Pulgas));
                cmd.Parameters.Add(new MySqlParameter("@lesoes", dados.Lesoes));
                cmd.Parameters.Add(new MySqlParameter("@observacoes", dados.Observacao));

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
                dados.Mensagem = "ERRO - InserirAnalise - InserirDadosAnalise - " +
               erro.ErrorCode +
               erro.Message;
            }
        }
    }
    public class ConsultarAnalise
    {

    }
    public class AtualizarAnalise
    {
        public void AtualizarDadosAnalise(AnaliseDTO dados)
        {
            try
            {
                //String com o comando de atualização
                string sql = "UPDATE tb_analise SET AnaPulgas=@pulgas," +
                    "AnaLesoes=@lesoes,AnaObservacoes=@observacoes WHERE AnaCodigo=@codigoAnalise ";
                //Uso da abertura de Conexão e da string sql
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Tipo de comando: Text ou Stored Procedure
                cmd.CommandType = CommandType.Text;
                //Parâmetros que serão substituídos (@) por variáveis
                cmd.Parameters.Add(new MySqlParameter("@codigoAnalise", dados.Codigo));
                cmd.Parameters.Add(new MySqlParameter("@pulgas", dados.Pulgas));
                cmd.Parameters.Add(new MySqlParameter("@lesoes", dados.Lesoes));
                cmd.Parameters.Add(new MySqlParameter("@observacao", dados.Observacao));


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
                dados.Mensagem = "ERRO - AtualizarAnalise - AtualizarDadosAnalise - " +
                erro.Message.ToString();

            }
        }
    }
    public class DeletarAnalise
    {
        public void DeletarDadosAnalise(AnaliseDTO dados)
        {
            try
            {
                //Comando Delete para o BD
                string sql = "DELETE from tb_analise where AnaCodigo=@codigoA";
                //Variável que receberá o resultado da Conexão e Delete
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Declarar o tipo de comando: Text ou Procedure
                cmd.CommandType = CommandType.Text;
                //Parâmetros que serão substituídos
                cmd.Parameters.Add(new MySqlParameter("@codigoA", dados.Codigo));

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
                dados.Mensagem = "ERRO - DeletarAnalise - DeletarDadosAnalise " + erro.Message;
            }
        }
    }
}
