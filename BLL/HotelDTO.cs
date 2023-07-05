using DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HotelDTO
    {
        public int CodigoHotel { get; set; }
        public int CodigoCliente { get; set; }
        public string Cliente { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public int CodigoAnimal { get; set; }
        public string NomeAnimal { get; set; }
        public string TipoAnimal { get; set; }
        public string Rga { get; set; }
        public DateTime DtEntrada { get; set; }
        public DateTime DtRetorno { get; set; }
        public string Mensagem { get; set; }

    }
    public class SalvarHospedagem
    {
        public void InserirHospedagem(HotelDTO dados)
        {
            try
            {
                //Instrução de inserção no banco de dados
                string sql = "INSERT INTO tb_hotel " +
                    "(HoClCodigo, HoAnCodigo, HoEntrada, HoRetorno)" +
                "VALUES (@codcliente, @codanimal, @dtentrada, @dtretorno)";

                //Instância que realizará a conexão e execução do Insert
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());

                //Tipo de comando: Text ou Procedure
                cmd.CommandType = CommandType.Text;

                //Parâmetros a serem substituídos
                //Fatal ERROR - caso os parâmetros @ estejam errados
                cmd.Parameters.Add(new MySqlParameter("@codcliente", dados.CodigoCliente));
                cmd.Parameters.Add(new MySqlParameter("@codanimal", dados.CodigoAnimal));
                cmd.Parameters.Add(new MySqlParameter("@dtentrada", dados.DtEntrada));
                cmd.Parameters.Add(new MySqlParameter("@dtretorno", dados.DtRetorno));


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
                dados.Mensagem = "ERRO - SalvarHospedagem - InserirHospedagem - " +
                erro.ErrorCode +
               erro.Message;
            }
        }

    }
    public class ConsultarHospedagem
    {
        public void PegarCodigoHotel(HotelDTO dados)
        {
            try
            {
                //Instrução de inserção no banco de dados
                string sql = "SELECT HoCodigo FROM tb_hotel ORDER BY HoCodigo DESC LIMIT 1;";

                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dados.CodigoHotel = reader.GetInt32("HoCodigo") + 1;
                    }
                }
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "ERRO - SalvarHospedagens - InserirDadosHotel - " +
                erro.ErrorCode +
                erro.Message;
            }
        }
        public void ConsultarDadosCliente(HotelDTO dados)
        {
            try
            {
                //Instrução de comando para o Banco de Dados
                string sql = "SELECT ClNome, ClCpf, ClTelefone FROM tb_cliente WHERE ClCodigo = @codcliente";
                //Variável que receberá o resultado da Conexão e Comando SELECT
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Define o tipo de comando
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new MySqlParameter("@codcliente", dados.CodigoCliente));
                //Realiza a leitura dos dados - Reader
                //Ignora os títulos da tabela
                MySqlDataReader dr = cmd.ExecuteReader();
                //Verifica se há linhas nesta leitura de dados
                if (dr.HasRows)
                {
                    //Enquanto houver dados
                    while (dr.Read())
                    {
                        dados.Cliente = dr.GetString(0);
                        dados.Cpf = dr.GetString(1);
                        dados.Telefone = dr.GetString(2);

                    }
                }
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "ERRO - SalvarHospedagem - InserirHospedagem " +
                erro.Message.ToString();
            }


        }
        public ArrayList ListarDadosHospedagem(HotelDTO dados)
        {
            ArrayList lista = new ArrayList();
            try
            {
                string sql = "SELECT AnNomePet FROM tb_animal WHERE AnClCodigo = @codcliente;";
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //cmd.Parameters.Add(new MySqlParameter("@nome", "%" + hotel.nomeanimal + "%"));
                cmd.Parameters.Add(new MySqlParameter("@codcliente", dados.CodigoCliente));

                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    dados.NomeAnimal = rdr.GetString(0);
                    lista.Add(dados.NomeAnimal);
                }
                Conexao.fecharConexao();
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "Erro - SalvarHospedagem - ListarDadosHospedagem " +
                erro.Message.ToString();
            }
            return lista;
        }
        public void CompararTabela(HotelDTO dados)
        {
            try
            {
                //Instrução de comando para o Banco de Dados
                string sql = "SELECT AnNomePet, AnRga, AnTipo, AnCodigoPet FROM tb_animal WHERE AnNomePet = @nomepet";
                //Variável que receberá o resultado da Conexão e Comando SELECT
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Define o tipo de comando
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new MySqlParameter("@nomepet", dados.NomeAnimal));

                //Realiza a leitura dos dados - Reader
                //Ignora os títulos da tabela
                MySqlDataReader dr = cmd.ExecuteReader();
                //Verifica se há linhas nesta leitura de dados
                //Enquanto houver dados
                while (dr.Read())
                {
                    dados.NomeAnimal = dr.GetString(0);
                    dados.Rga = dr.GetString(1);
                    dados.TipoAnimal = dr.GetString(2);
                    dados.CodigoAnimal = dr.GetInt32(3);
                }

            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "ERRO - SalvarHospedagem - CompararTabela " +
                erro.Message.ToString();
            }
        }
        public DataTable ListarDadosHotel(HotelDTO dados)
        {
            //Declaração da variável que receberá os dados no formato de tabela.
            DataTable tabela = new DataTable();
            try
            {
                //Intrução de comando SELECT para o BD
                string sql = "SELECT * FROM tb_hotel";
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
                dados.Mensagem = "Erro - SalvarHospedagem - ListarDadosHotel " +
                erro.Message.ToString();
            }
            //O comando SELECT sempre precisa retornar algum dado
            //Este retorno será no formato de tabela, sendo aplicado ao DataGridView
            return tabela;
        }
    }
    public class AtualizarHospedagem
    {
        public void AtualizarDadosHotel(HotelDTO dados)
        {
            try
            {
                //String com o comando de atualização
                string sql = "UPDATE tb_hotel SET " +
                    "HoClCodigo=@codigocliente, " +
                    "HoAnCodigo=@codigoanimal, " +
                    "HoEntrada=@dataentrada, " +
                    "HoRetorno=@dataretorno WHERE HoCodigo=@codigo";
                //Uso da abertura de Conexão e da string sql
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());
                //Tipo de comando: Text ou Stored Procedure
                cmd.CommandType = CommandType.Text;
                //Parâmetros que serão substituídos (@) por variáveis
                cmd.Parameters.Add(new MySqlParameter("@codigocliente", dados.CodigoCliente));
                cmd.Parameters.Add(new MySqlParameter("@codigoanimal", dados.CodigoAnimal));
                cmd.Parameters.Add(new MySqlParameter("@dataentrada", dados.DtEntrada));
                cmd.Parameters.Add(new MySqlParameter("@dataretorno", dados.DtRetorno));
                cmd.Parameters.Add(new MySqlParameter("@codigo", dados.CodigoHotel));
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

                dados.Mensagem = "ERRO - AtualizarHospedagens - AtualizarDadosHotel - " +
                erro.Message.ToString();
            }
        }
    }

}
