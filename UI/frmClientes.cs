using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Correios;

namespace UI
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }
        private void frmClientes_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            ConfigurarDataGridView();
            BuscarNovoCodigo();
        }
        // ------------------------------------------------------------------------------- //
        // Configuração da GridView
        public void CarregarGrid()
        {
            // Instância da classe ConsultarClientes e ClientesDTO
            ConsultarClientes consultarClientes = new ConsultarClientes();
            ClientesDTO clientes = new ClientesDTO();

            // Atribuição dos registros ao DataGridView
            dgvListaClientes.DataSource = consultarClientes.ListarDadosClientes(clientes);

            // Procedimento para alterar os títulos e propriedades da coluna
            ConfigurarDataGridView();

            // Verificar se houve erro na estrutura da tabela
            if(!string.IsNullOrEmpty(clientes.Mensagem))
            {
                MessageBox.Show(clientes.Mensagem);
            }
        }
        private void dgvListaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Evitar o erro no clique dos títulos (linha -1)
            if (e.RowIndex >= 0)
            {
                //TextBox = DataGridView.LinhaSelecionada.Célula[Posição].Valor.ParaTexto
                txtCodigo.Text = dgvListaClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNome.Text = dgvListaClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
                mskCpf.Text = dgvListaClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
                mskCep.Text = dgvListaClientes.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtEmail.Text = dgvListaClientes.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtEndereco.Text = dgvListaClientes.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtNumero.Text = dgvListaClientes.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtBairro.Text = dgvListaClientes.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtCidade.Text = dgvListaClientes.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtUf.Text = dgvListaClientes.Rows[e.RowIndex].Cells[9].Value.ToString();
                mskTelefone.Text = dgvListaClientes.Rows[e.RowIndex].Cells[10].Value.ToString();
                txtComplemento.Text = dgvListaClientes.Rows[e.RowIndex].Cells[11].Value.ToString();

                if (dgvListaClientes.Rows[e.RowIndex].Cells[12].Value.ToString() == "Feminino")
                {
                    rdoFeminino.Checked = true;
                }
                else if (dgvListaClientes.Rows[e.RowIndex].Cells[12].Value.ToString() == "Masculino")
                {
                    rdoMasculino.Checked = true;
                }
                else
                {
                    rdoOutros.Checked = true;
                    txtOutros.Visible = true;
                    txtOutros.Text = dgvListaClientes.Rows[e.RowIndex].Cells[12].Value.ToString();
                }
                btnAtualizar.Visible = true; //Ou enable
                btnSalvar.Enabled = false;
                btnDeletar.Visible = true;
            }
        }
        public void ConfigurarDataGridView()
        {
            //Verificar se o DataGridView contém linhas
            if (dgvListaClientes.Rows.Count != 0)
            {
                //Renomear o cabeçalho das colunas no DataGridView
                dgvListaClientes.Columns[0].HeaderText = "Cod";
                dgvListaClientes.Columns[1].HeaderText = "Nome";
                dgvListaClientes.Columns[2].HeaderText = "Cpf";
                dgvListaClientes.Columns[3].HeaderText = "CEP";
                dgvListaClientes.Columns[4].HeaderText = "E-mail";
                dgvListaClientes.Columns[5].HeaderText = "Endereço";
                dgvListaClientes.Columns[6].HeaderText = "Nº";
                dgvListaClientes.Columns[7].HeaderText = "Bairro";
                dgvListaClientes.Columns[8].HeaderText = "Cidade";
                dgvListaClientes.Columns[9].HeaderText = "UF";
                dgvListaClientes.Columns[10].HeaderText = "Telefone";
                dgvListaClientes.Columns[11].HeaderText = "Complemento";
                dgvListaClientes.Columns[12].HeaderText = "Gênero";

                //Configurar a largura das colunas no DataGridView
                dgvListaClientes.Columns[0].Width = 50;
                dgvListaClientes.Columns[1].Width = 200;
                dgvListaClientes.Columns[2].Width = 120;
                dgvListaClientes.Columns[3].Width = 80;
                dgvListaClientes.Columns[4].Width = 190;
                dgvListaClientes.Columns[5].Width = 160;
                dgvListaClientes.Columns[6].Width = 40;
                dgvListaClientes.Columns[7].Width = 130;
                dgvListaClientes.Columns[8].Width = 110;
                dgvListaClientes.Columns[9].Width = 50;
                dgvListaClientes.Columns[10].Width = 130;
                dgvListaClientes.Columns[11].Width = 130;
                //Alinhar o conteúdo das colunas
                dgvListaClientes.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            }
        }
        // ------------------------------------------------------------------------------- //
        // Botões do formulário Clientes
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Realizar a instância da classe ClientesDTO.
            // Basicamente, criar o objeto cliente.
            ClientesDTO clientes = new ClientesDTO();
            SalvarClientes salvarClientes = new SalvarClientes();

            // Alimentar as variáveis por meio deste objeto.
            if (txtNome.Text == "" || mskCpf.Text == "" || txtEmail.Text == "" || txtEndereco.Text == "" || txtCidade.Text == "" || txtUf.Text == "" || txtBairro.Text == "" ||
                txtNumero.Text == "" || mskTelefone.Text == "")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos", "Aviso");
            }
            else
            {
                clientes.Nome = txtNome.Text;
                clientes.Cpf = mskCpf.Text.Replace("-", "").Replace(".", "");
                clientes.Email = txtEmail.Text;
                clientes.Cep = mskCep.Text.Replace("-", "");
                clientes.Endereco = txtEndereco.Text;
                clientes.Cidade = txtCidade.Text;
                clientes.Uf = txtUf.Text;
                clientes.Bairro = txtBairro.Text;
                clientes.Numero = Convert.ToInt32(txtNumero.Text);
                clientes.Telefone = mskTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
                clientes.Complemento = txtComplemento.Text;

                if (rdoFeminino.Checked)
                {
                    clientes.Genero = rdoFeminino.Text;
                }
                else if (rdoMasculino.Checked)
                {
                    clientes.Genero = rdoMasculino.Text;
                }
                else
                {
                    clientes.Genero = txtOutros.Text;
                }

                // Chamada do método SalvarClientes
                salvarClientes.InserirDados(clientes);

                // Exibir a mensagem de Sucesso ou Falha
                MessageBox.Show(clientes.Mensagem, "Aviso", MessageBoxButtons.OK);

                // Configurar a Grid após inserir novos dados
                CarregarGrid();
                ConfigurarDataGridView();

                // Limpar os campos após a inserção dos dados
                LimparCampos();
            }
        }
        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            //Instância da classe CorreiosApi
            CorreiosApi correios = new CorreiosApi();
            try
            {
                var retornoCep = correios.consultaCEP(mskCep.Text.Replace("-", ""));
                if (retornoCep != null)
                {
                    txtEndereco.Text = retornoCep.end;
                    txtUf.Text = retornoCep.uf;
                    txtCidade.Text = retornoCep.cidade;
                    txtBairro.Text = retornoCep.bairro;
                    txtComplemento.Text = retornoCep.complemento;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //Instância das classes AtualizarClientes e ClientesDTO
            AtualizarClientes atualizarClientes = new AtualizarClientes();
            ClientesDTO clientes = new ClientesDTO();
            //Verificar se determinados campos foram preenchidos.
            //Repita esta estrutura de IF / ELSE IF para as informações obrigatórias.
            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Campo Nome obrigatório!", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Apontar o ponteiro do mouse para o campo
                txtNome.Focus();
                //Parar a execução do programa até esta linha
                return;
            }
            else if (txtNumero.Text == string.Empty)
            {
                MessageBox.Show("Campo Número obrigatório!", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero.Focus();
                return;
            }
            //Armazenar as informações do formulário
            clientes.Codigo = Convert.ToInt32(txtCodigo.Text);
            clientes.Nome = txtNome.Text;
            clientes.Cpf = mskCpf.Text.Replace("-", "").Replace(".", "");
            clientes.Cep = mskCep.Text.Replace("-", "");
            clientes.Email = txtEmail.Text;
            clientes.Endereco = txtEndereco.Text;
            clientes.Numero = Convert.ToInt32(txtNumero.Text);
            clientes.Bairro = txtBairro.Text;
            clientes.Cidade = txtCidade.Text;
            clientes.Uf = txtUf.Text;
            clientes.Telefone = mskTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            clientes.Complemento = txtComplemento.Text;
            if (rdoFeminino.Checked)
            {
                clientes.Genero = "Feminino";
            }
            else if (rdoMasculino.Checked)
            {
                clientes.Genero = "Masculino";
            }
            else
            {
                clientes.Genero = txtOutros.Text;
            }
            //Utilização do método AtualizarDados com os dados do cliente como parâmetro
            atualizarClientes.AtualizarDados(clientes);
            //Atualizar e configurar o DataGridView após atualização
            CarregarGrid();
            ConfigurarDataGridView();
            LimparCampos();
            MessageBox.Show(clientes.Mensagem, "Aviso",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCampos();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            //Instanciar a Classe DeletarClientes - Método DeletarDados
            DeletarClientes deletarClientes = new DeletarClientes();
            //Instanciar a Classe ClientesDTO - Atributos/Variáveis
            ClientesDTO clientes = new ClientesDTO();
            //Armazenar o código para exclusão
            clientes.Codigo = Convert.ToInt32(txtCodigo.Text);
            //Confirmação para exclusão do registro
            DialogResult confirmacao = MessageBox.Show("Deseja deletar o registro? Código " +
            txtCodigo.Text, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacao == DialogResult.Yes)
            {
                //Executar o método de exclusão
                deletarClientes.DeletarDados(clientes);
                CarregarGrid();
                ConfigurarDataGridView();
                LimparCampos();
                MessageBox.Show(clientes.Mensagem, "Aviso", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        // ------------------------------------------------------------------------------- //
        // Configuração da Radio dos Outros
        private void rdoOutros_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoOutros.Checked)
            {
                txtOutros.Visible = true;
            }
            else
            {
                txtOutros.Visible = false;
            }
        }
        // ------------------------------------------------------------------------------- //
        // Pesquisa do Cliente
        private void txtPesquisaNome_TextChanged(object sender, EventArgs e)
        {
            //Instância da classe ConsultarClientes
            //NomeClasse variavel = new NomeClasse();
            ConsultarClientes consultarClientes = new ConsultarClientes();
            //Instância da classe ClientesDTO
            ClientesDTO clientes = new ClientesDTO();
            //Amazenar o nome do TextBox
            clientes.Nome = txtPesquisaNome.Text;
            //Chamada do método para a pesquisa e preenchimento do DataGridView
            dgvListaClientes.DataSource = consultarClientes.ListarDadosClientesFiltros(clientes);
            //Configurar o DataGridView
            ConfigurarDataGridView();
        }
        // ------------------------------------------------------------------------------- //
        // Métodos
        public void LimparCampos()
        {
            txtCodigo.Clear(); //Função .Clear()
            txtNome.Text = ""; //Vazio ""
            mskCpf.Clear();
            mskCep.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtUf.Clear();
            mskTelefone.Clear();
            txtComplemento.Clear();
            txtPesquisaNome.Clear();
            txtOutros.Clear();
            rdoFeminino.Checked = false;
            rdoMasculino.Checked = false;
            rdoOutros.Checked = false;
            btnAtualizar.Visible = false;
            btnSalvar.Enabled = true;
            btnDeletar.Visible = false;

            BuscarNovoCodigo();
        }
        public void BuscarNovoCodigo()
        {
            // Instância da classe ConsultarClientes e ClientesDTO
            ConsultarClientes consultarClientes = new ConsultarClientes();
            ClientesDTO clientes = new ClientesDTO();

            // Uso do método que busca o último código do BD + 1
            consultarClientes.NovoCodigo(clientes);

            // Atribuição do valor da textbox
            txtCodigo.Text = clientes.Codigo.ToString();
        }
    }
}
