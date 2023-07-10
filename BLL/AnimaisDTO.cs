using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Importar os namespaces para Conexão
using System.Data;
using DAL;
using MySql.Data.MySqlClient;

namespace BLL
{
    public class AnimaisDTO
    {
        // Digite prop e aperte 2x e tecla TAB
        // Altere o tipo conforme a necessidade

        public int CodigoPet { get; set; }
        public string NomePet { get; set; }
        public int CodigoDono { get; set; }
        public string NomeDono { get; set; }
        public int Funcionario { get; set; }
        public string Raca { get; set; }
        public string Cor { get; set; }
        public string Tipo { get; set; }
        public decimal Peso { get; set; }
        public DateTime Nascimento { get; set; }
        public string Pedigree { get; set; }
        public string Rga { get; set; }
        public string Sexo { get; set; }
        public string Observacao { get; set; }
        public string Mensagem { get; set; }
    }
    public class SalvarAnimais
    {
        public void InserirDados(AnimaisDTO dados)
        {
            try
            {
                //String com o comando Insert do Banco
                string sql = "INSERT INTO tb_animal " +
                    "(AnNomePet, AnClCodigo, AnFnNome, AnRaca, AnCor, AnTipo, AnPeso, AnNascimento, AnPedigree, AnRga, AnSexo, AnObservacao) " +
                    "VALUES (@nomePet, @codigoDono, @nomeFuncionario, @raca, @cor, @tipo, @peso, @nascimento, @pedigree, @rga, @sexo, @observacao)";
                //Variável que receberá o resultado da Conexão com o comando Insert
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Tipo de comando: Text ou Procedure
                cmd.CommandType = CommandType.Text;
                //Parâmetros que serão substiruídos
                cmd.Parameters.Add(new MySqlParameter("@nomePet", dados.NomePet));
                cmd.Parameters.Add(new MySqlParameter("@codigoDono", dados.CodigoDono));
                cmd.Parameters.Add(new MySqlParameter("@nomeFuncionario", dados.Funcionario));
                cmd.Parameters.Add(new MySqlParameter("@raca", dados.Raca));
                cmd.Parameters.Add(new MySqlParameter("@cor", dados.Cor));
                cmd.Parameters.Add(new MySqlParameter("@tipo", dados.Tipo));
                cmd.Parameters.Add(new MySqlParameter("@peso", dados.Peso));
                cmd.Parameters.Add(new MySqlParameter("@nascimento", dados.Nascimento));
                cmd.Parameters.Add(new MySqlParameter("@pedigree", dados.Pedigree));
                cmd.Parameters.Add(new MySqlParameter("@rga", dados.Rga));
                cmd.Parameters.Add(new MySqlParameter("@sexo", dados.Sexo));
                cmd.Parameters.Add(new MySqlParameter("@observacao", dados.Observacao));
                //Realiza a contagem de registros inseridos.
                int registrosInseridos = cmd.ExecuteNonQuery();
                // Verificar se algum registro foi inserido no Banco de Dados.
                if(registrosInseridos >= 1)
                {
                    dados.Mensagem = "Registo Inserido com Sucesso!";
                }
                else
                {
                    dados.Mensagem = "Falha ao Inserir com Sucesso!";
                }
                // Fecher a Conexão com o Banco de Dados
                Conexao.fecharConexao();
            }
            catch(MySqlException erro)
            {
                dados.Mensagem = "ERRO - SalvarAnimais - InserirDados" + erro.Message;
            }
        }
    }
    public class ConsultarAnimais
    {
        public DataTable ListarDadosAnimais(AnimaisDTO dados)
        {
            //Declaração da variável que receberá os dados no formato de tabela.
            DataTable tabela = new DataTable();
            try
            {
                //Instrução de comando para o Banco de dados
                string sql = "SELECT tb_animal.*, FnNome FROM tb_animal " +
                    "INNER JOIN tb_funcionario " +
                    "on AnFnNome = FnCodigo";
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
                dados.Mensagem = "ERRO - ConsultarAnimais - ListarDadosAnimais: " +
                erro.Message.ToString();
            }
            //Retorno da tabela para DataGridView do form
            return tabela;
        }
        public DataTable ListarDadosAnimaisPet(AnimaisDTO dados)
        {
            //Declaração da variável que receberá os dados no formato de tabela.
            DataTable tabela = new DataTable();
            try
            {
                //Instrução de comando para o Banco de dados com WHERE e LIKE
                string sql = "SELECT * FROM tb_animal WHERE AnNomePet LIKE @nome";
                //Comando para executar a Conexao e Select
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Parâmetros que serão substituídos na string sql
                cmd.Parameters.Add(new MySqlParameter("@nome", "%" + dados.NomePet + "%"));
                //Adaptação dos dados do Banco de dados para o formato
                //de tabela com a execução da Conexão e Select
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                //Preenchimento da variável em formato de tabela - Fill = preencher
                adaptador.Fill(tabela);
                //Fechamento da conexão
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "Erro - ConsultarClientes - ListarDadosAnimaisPet: " +
                erro.Message.ToString();
            }
            //Retorno da tabela para o DataGridView do form
            return tabela;
        }
        public DataTable ListarDadosAnimaisDono(AnimaisDTO dados)
        {
            DataTable tabela = new DataTable();
            try
            {
                //Instrução de comando para o Banco de dados com WHERE e LIKE
                string sql = "SELECT an.AnCodigoPet, an.AnNomePet, an.AnClCodigo, an.AnFnNome, an.AnRaca, an.AnCor, an.AnTipo, an.AnPeso, an.AnNascimento, an.AnPedigree, " +
                    "an.AnRga, an.AnSexo, an.AnObservacao, cli.ClNome " +
                    "FROM tb_animal as an " +
                    "INNER JOIN tb_cliente as cli " +
                    "ON ClCodigo = AnClCodigo " +
                    "WHERE ClNome like @nome";
                //Comando para executar a Conexao e Select
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Parâmetros que serão substituídos na string sql
                cmd.Parameters.Add(new MySqlParameter("@nome", "%" + dados.NomeDono + "%"));
                //Adaptação dos dados do Banco de dados para o formato
                //de tabela com a execução da Conexão e Select
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                //Preenchimento da variável em formato de tabela - Fill = preencher
                adaptador.Fill(tabela);
                //Fechamento da conexão
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "Erro - ConsultarClientes - ListarDadosAnimaisPet: " +
                erro.Message.ToString();
            }
            //Retorno da tabela para o DataGridView do form
            return tabela;
        }
        public DataTable ListarCodigoDono(AnimaisDTO dados)
        {
            DataTable tabela = new DataTable();
            try
            {
                string sql = "SELECT ClCodigo FROM tb_cliente";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, Conexao.obterConexao());

                adaptador.Fill(tabela);
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "ERRO - ConsultarAnimais - ListarCodigoDono: " + erro.Message.ToString();
            }
            return tabela;
        }
        public DataTable ListarFuncionario(AnimaisDTO dados)
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
                dados.Mensagem = "ERRO - ConsultarAnimais - ListarFuncionario -" + erro.ErrorCode + erro.Message;
            }
            return tabela;
        }
        public void NovoCodigo(AnimaisDTO dados)
        {
            try
            {
                //Instrução de comando para o Banco de Dados
                string sql = "SELECT AnCodigoPet FROM tb_animal ORDER BY " +
                "AnCodigoPet DESC LIMIT 1";
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
                        dados.CodigoPet = dr.GetInt32(0) + 1;
                    }//11 + 1 = 12
                }
                else
                {
                    dados.CodigoPet = 1;
                }
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "ERRO - ConsultarAnimais - NovoCodigo " +
                erro.Message.ToString();
            }
        }
    }
    public class AtualizarAnimais
    {
        public void AtualizarDados(AnimaisDTO dados)
        {
            try
            {
                //String com o comando Insert do Banco
                string sql = "UPDATE tb_animal " +
                "SET AnNomePet=@nomePet, AnClCodigo=@codigoDono, AnFnNome=@funcionario, " +
                "AnRaca=@raca, AnCor=@cor, AnTipo=@tipo, AnPeso=@peso, AnNascimento=@nascimento, " +
                "AnPedigree=@pedigree, AnRga=@rga, AnSexo=@sexo, AnObservacao=@observacao " +
                "WHERE AnCodigoPet = @codigoPet";
                //Variável que receberá o resultado da Conexão com o comando Insert
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Tipo de comando: Text ou Procedure
                cmd.CommandType = CommandType.Text;
                //Parâmetros que serão substituídos
                cmd.Parameters.Add(new MySqlParameter("@codigoPet", dados.CodigoPet));
                cmd.Parameters.Add(new MySqlParameter("@nomePet", dados.NomePet));
                cmd.Parameters.Add(new MySqlParameter("@codigoDono", dados.CodigoDono));
                cmd.Parameters.Add(new MySqlParameter("@funcionario", dados.Funcionario));
                cmd.Parameters.Add(new MySqlParameter("@raca", dados.Raca));
                cmd.Parameters.Add(new MySqlParameter("@cor", dados.Cor));
                cmd.Parameters.Add(new MySqlParameter("@tipo", dados.Tipo));
                cmd.Parameters.Add(new MySqlParameter("@peso", dados.Peso));
                cmd.Parameters.Add(new MySqlParameter("@nascimento", dados.Nascimento));
                cmd.Parameters.Add(new MySqlParameter("@pedigree", dados.Pedigree));
                cmd.Parameters.Add(new MySqlParameter("@rga", dados.Rga));
                cmd.Parameters.Add(new MySqlParameter("@sexo", dados.Sexo));
                cmd.Parameters.Add(new MySqlParameter("@observacao", dados.Observacao));
                //Realiza a contagem de registros inseridos.
                int registrosAtualizados = cmd.ExecuteNonQuery();
                //Verifica se algum registro foi atualizado no Banco de Dados.
                if (registrosAtualizados >= 1)
                {
                    dados.Mensagem = "Registro atualizado com Sucesso!";
                }
                else
                {
                    dados.Mensagem = "Falha ao atualizar registro!";
                }
                //Fecha a conexão com o Banco de Dados.
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "ERRO - AtualizarAnimais - AtualizarDados:" +
                erro.Message.ToString();
            }
        }
    }
    public class DeletarAnimais
    {
        public void DeletarDados(AnimaisDTO dados)
        {
            try
            {
                //String com o comando DELETE do Banco
                string sql = "DELETE FROM tb_animal WHERE AnCodigoPet = @codigoPet";
                //Variável que receberá o resultado da Conexão com o comando Delete
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Tipo de comando: Text ou Procedure
                cmd.CommandType = CommandType.Text;
                //Parâmetros que serão substituídos
                cmd.Parameters.Add(new MySqlParameter("@codigoPet", dados.CodigoPet));
                //Realiza a contagem de registros deletados.
                int registrosDeletados = cmd.ExecuteNonQuery();
                //Verifica se algum registro foi deletado no Banco de Dados.
                if (registrosDeletados >= 1)
                {
                    dados.Mensagem = "Registro deletado com Sucesso!";
                }
                else
                {
                    dados.Mensagem = "Falha ao deletar registro!";
                }
                //Fecha a conexão com o Banco de Dados.
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "ERRO - DeletarAnimais - DeletarDados:" +
                erro.Message.ToString();
            }
        }
    }
}
