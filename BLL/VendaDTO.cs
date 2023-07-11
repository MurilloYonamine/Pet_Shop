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
    public class VendaDTO
    {
        public int Codigo { get; set; }
        public int CodigoProduto { get; set; }
        public DateTime Validade { get; set; }
        public string Preco { get; set; }
        public int Quantidade { get; set; }
        public decimal Total { get; set; }
        public Boolean Situacao { get; set; }
        public string Mensagem { get; set; }
    }
    public class SalvarVenda
    {
        public void InserirVenda(VendaDTO dados)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_Venda", Conexao.obterConexao());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new MySqlParameter("@pVenProCodigo", dados.CodigoProduto));
                cmd.Parameters.Add(new MySqlParameter("@pVenPreco", dados.Preco));
                cmd.Parameters.Add(new MySqlParameter("@pVenValidade", dados.Validade));
                cmd.Parameters.Add(new MySqlParameter("@pVenQuantidade", dados.Quantidade));
                cmd.Parameters.Add(new MySqlParameter("@pVenTotal", dados.Total));

                int registrosAtualizados = cmd.ExecuteNonQuery();
                if (registrosAtualizados >= 1)
                {
                    dados.Mensagem = "Venda realizada com Sucesso!";
                }
                else
                {
                    dados.Mensagem = "Falha ao atualizar registro!";
                }
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "ERRO - SalvarVenda - InserirVenda: " +
                erro.Message.ToString();
            }
        }
    }
    public class ConsultarVenda
    {
        // --------------------------------------------------------------- //
        // Listar vendas na DataGridVIew
        public DataTable ListarDadosVenda(VendaDTO dados)
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
        public DataTable ListarProduto(VendaDTO dados)
        {
            DataTable tabela = new DataTable();
            try
            {
                string sql = "SELECT ProCodigo, ProNome FROM tb_produto";

                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, Conexao.obterConexao());
                adaptador.Fill(tabela);
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "ERRO - ConsultarVenda - ListarProduto -" + erro.ErrorCode + erro.Message;
            }
            return tabela;
        }
        public void VerificarQuantidade(VendaDTO dados)
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
                        if (dr.GetInt32(0) < dados.Quantidade)
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
                dados.Mensagem = "ERRO - ConsultarVenda - VerificarQuantidade -" + erro.ErrorCode + erro.Message;
            }
        }

    }
    public class AtualizarVenda
    {
        public void AtualizarDadosVenda(VendaDTO dados)
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
                cmd.Parameters.Add(new MySqlParameter("@codigo", dados.CodigoProduto));
                cmd.Parameters.Add(new MySqlParameter("@preco", dados.Preco));
                cmd.Parameters.Add(new MySqlParameter("@validade", dados.Validade));
                cmd.Parameters.Add(new MySqlParameter("@qtde", dados.Quantidade));
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
                dados.Mensagem = "ERRO - AtualizarVenda - AtualizarDados - " +
                erro.Message.ToString();
            }
        }
    }
    public class DeletarVenda
    {
        public void DeletarDadosVenda(VendaDTO dados)
        {
            try
            {
                string sql = "DELETE FROM tb_venda WHERE VenCodigo=@codigo";
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

                dados.Mensagem = "ERRO - DeletarPetMarket - DeletarDadosVenda -" + erro.ErrorCode + erro.Message;
            }
        }
    }
}
