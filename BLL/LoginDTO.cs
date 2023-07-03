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
    public class LoginDTO
    {
        public int Codigo { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public int Logado { get; set; }
        public string Mensagem { get; set; }
    }
    public class AcessoLogin
    {
        public void Acessar(LoginDTO dados)
        {
            try
            {
                //Instrução de comando para o Banco de dados
                string sql = "SELECT UserLogin FROM tb_usuario WHERE " +
                "UserLogin = @usuario AND UserSenha = @senha";
                //Variável que receberá o resultado da Conexão com o comando Select
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Tipo de comando: Text ou Procedure
                cmd.CommandType = CommandType.Text;
                //Parâmetros a serem atribuídos na string sql
                cmd.Parameters.Add(new MySqlParameter("@usuario", dados.Usuario));
                cmd.Parameters.Add(new MySqlParameter("@senha", dados.Senha));
                //Realiza a leitura dos dados
                MySqlDataReader dr = cmd.ExecuteReader();
                //Se houver linhas, pode-se recuperar valores individuais
                if (dr.HasRows)
                {
                    //Atribui o valor 1 à variável logado para o usuário
                    dados.Logado = 1;
                    while (dr.Read())
                    {
                        //Armazena o usuário na posição 0 da linha de registro
                        dados.Usuario = dr.GetValue(0).ToString();
                        dados.Mensagem = "Bem vindo " + dados.Usuario;
                    }
                }
                else
                {
                    dados.Mensagem = "Erro - Usuário ou Senha inválido!";
                    dados.Logado = 0;
                }
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "Erro - AcessoLogin - Acessar " +
                erro.Message;
            }
        }
        public string VerificarLogado(LoginDTO dados)
        {
            try
            {
                //Instrução de comando para o Banco de dados
                string sql = "SELECT UserLogin FROM tb_usuario WHERE UserLogado = 1";
                //Variável que receberá o resultado da Conexão com o comando Select
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Tipo de comando: Text ou Procedure
                cmd.CommandType = CommandType.Text;
                //Realiza a leitura dos dados
                MySqlDataReader dr = cmd.ExecuteReader();
                //Se houver linhas, pode-se recuperar valores individuais
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dados.Usuario = dr.GetValue(0).ToString();
                    }
                }
                else
                {
                    dados.Mensagem = "Erro - Usuário não encontrado!";
                }
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "ERRO - AtualizaLogon - VerificarLogado: " +
                erro.Message.ToString();
            }
            //Retorna o usuário que está com status 1
            return dados.Usuario;
        }
    }
    public class AtualizarLogon
    {
        /*public void AtualizarLogado(LoginDTO dados)
        {
            try
            {
                //Instrução de comando para o Banco de dados
                string sql = "UPDATE tb_usuario SET UserLogado = @logado " +
                "WHERE UserLogin = @usuario";
                //Variável que receberá o resultado da Conexão com o comando Select
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Tipo de comando: Text ou Procedure
                cmd.CommandType = CommandType.Text;
                //Parâmetros a serem atribuído na string sql
                cmd.Parameters.Add(new MySqlParameter("@usuario", dados.Usuario));
                cmd.Parameters.Add(new MySqlParameter("@logado", dados.Logado));
                //Realiza a contagem de registros inseridos.
                int registrosAtualizados = cmd.ExecuteNonQuery();
                //Verifica se algum registro foi inserido no Banco de Dados.
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
                dados.Mensagem = "ERRO - AtualizaLogon - AtualizarLogado: " +
                erro.Message.ToString();
            }
        }*/

        public void AtualizarLogado(LoginDTO dados)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_AtualizarLogon", Conexao.obterConexao());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new MySqlParameter("@pUsuario", dados.Usuario));
                cmd.Parameters.Add(new MySqlParameter("@pStatus", dados.Logado));

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
                dados.Mensagem = "ERRO - AtualizaLogon - AtualizarLogado: " +
                erro.Message.ToString();
            }
        }
    }
}
