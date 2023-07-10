using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Para uso das classes do projeto BLL
using BLL;
using Microsoft.VisualBasic;

namespace UI
{
    public partial class frmAnimais : Form
    {
        public frmAnimais()
        {
            InitializeComponent();
        }

        private void frmAnimais_Load(object sender, EventArgs e)
        {
            AnimaisDTO animais = new AnimaisDTO();
            ConsultarAnimais consultarAnimais = new ConsultarAnimais();

            cboFuncionario.DataSource = consultarAnimais.ListarFuncionario(animais);
            cboFuncionario.ValueMember = "FnCodigo";
            cboFuncionario.DisplayMember = "FnNome";
            CarregarGrid();
            ConfigurarDataGridView();
            ListarCodigoDono();
            BuscarNovoCodigo();
        }
        // ------------------------------------------------------------------------------- //
        // Configuração da GridView
        private void CarregarGrid()
        {
            // Instância da classe ConsultarAnimais e AnimaisDTO
            ConsultarAnimais consultarAnimais = new ConsultarAnimais();
            AnimaisDTO animais = new AnimaisDTO();

            // Atribuição dos registros ao DataGridView
            dgvListaAnimais.DataSource = consultarAnimais.ListarDadosAnimais(animais);

            // Verificar se houve na estrutura da tabela
            if (!string.IsNullOrEmpty(animais.Mensagem))
            {
                MessageBox.Show(animais.Mensagem);
            }
        }
        private void ConfigurarDataGridView()
        {
            if (dgvListaAnimais.Rows.Count != 0)
            {
                //Renomear o cabeçalho das colunas no DataGridView
                dgvListaAnimais.Columns[0].HeaderText = "Cod";
                dgvListaAnimais.Columns[1].HeaderText = "Pet";
                dgvListaAnimais.Columns[2].HeaderText = "Dono";
                dgvListaAnimais.Columns[3].HeaderText = "Funcionário";
                dgvListaAnimais.Columns[4].HeaderText = "Raça";
                dgvListaAnimais.Columns[5].HeaderText = "Cor";
                dgvListaAnimais.Columns[6].HeaderText = "Tipo";
                dgvListaAnimais.Columns[7].HeaderText = "Peso";
                dgvListaAnimais.Columns[8].HeaderText = "Nascimento";
                dgvListaAnimais.Columns[9].HeaderText = "Pedigree";
                dgvListaAnimais.Columns[10].HeaderText = "RGA";
                dgvListaAnimais.Columns[11].HeaderText = "Sexo";
                dgvListaAnimais.Columns[12].HeaderText = "Observação";
                dgvListaAnimais.Columns[13].HeaderText = "Funcionário";

                //Configurar a largura das colunas no DataGridView
                dgvListaAnimais.Columns[0].Width = 50;
                dgvListaAnimais.Columns[2].Width = 50;
                dgvListaAnimais.Columns[4].Width = 150;
                dgvListaAnimais.Columns[5].Width = 150;
                dgvListaAnimais.Columns[7].Width = 80;
                dgvListaAnimais.Columns[11].Width = 80;
                dgvListaAnimais.Columns[12].Width = 250;

                //Alinhar o conteúdo das colunas
                dgvListaAnimais.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
                dgvListaAnimais.Columns[2].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            }
        }
        private void ConfigurarDataGridViewDono()
        {
            if (dgvListaAnimais.Rows.Count != 0)
            {
                //Renomear o cabeçalho das colunas no DataGridView
                dgvListaAnimais.Columns[0].HeaderText = "Cod";
                dgvListaAnimais.Columns[1].HeaderText = "Pet";
                dgvListaAnimais.Columns[2].HeaderText = "Dono";
                dgvListaAnimais.Columns[3].HeaderText = "Funcionário";
                dgvListaAnimais.Columns[4].HeaderText = "Raça";
                dgvListaAnimais.Columns[5].HeaderText = "Cor";
                dgvListaAnimais.Columns[6].HeaderText = "Tipo";
                dgvListaAnimais.Columns[7].HeaderText = "Peso";
                dgvListaAnimais.Columns[8].HeaderText = "Nascimento";
                dgvListaAnimais.Columns[9].HeaderText = "Pedigree";
                dgvListaAnimais.Columns[10].HeaderText = "RGA";
                dgvListaAnimais.Columns[11].HeaderText = "Sexo";
                dgvListaAnimais.Columns[12].HeaderText = "Observação";
                dgvListaAnimais.Columns[13].HeaderText = "Nome Dono";

                //Configurar a largura das colunas no DataGridView
                dgvListaAnimais.Columns[0].Width = 50;
                dgvListaAnimais.Columns[2].Width = 50;
                dgvListaAnimais.Columns[4].Width = 150;
                dgvListaAnimais.Columns[5].Width = 150;
                dgvListaAnimais.Columns[7].Width = 80;
                dgvListaAnimais.Columns[11].Width = 80;
                dgvListaAnimais.Columns[12].Width = 250;

                //Alinhar o conteúdo das colunas
                dgvListaAnimais.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
                dgvListaAnimais.Columns[2].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            }
        }
        private void dgvListaAnimais_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            { //TextBox = DataGridView.LinhaSelecionada.Célula[Posição].ParaTexto
                txtCodigoPet.Text = dgvListaAnimais.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNomePet.Text = dgvListaAnimais.Rows[e.RowIndex].Cells[1].Value.ToString();
                cboCodigoDono.Text = dgvListaAnimais.Rows[e.RowIndex].Cells[2].Value.ToString();
                cboFuncionario.Text = dgvListaAnimais.Rows[e.RowIndex].Cells[13].Value.ToString();
                txtRaca.Text = dgvListaAnimais.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtCor.Text = dgvListaAnimais.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtTipo.Text = dgvListaAnimais.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtPeso.Text = dgvListaAnimais.Rows[e.RowIndex].Cells[7].Value.ToString();
                dtpNascimento.Value = Convert.ToDateTime(dgvListaAnimais.Rows[e.RowIndex].Cells[8].Value);
                txtPedigree.Text = dgvListaAnimais.Rows[e.RowIndex].Cells[9].Value.ToString();
                mskRga.Text = dgvListaAnimais.Rows[e.RowIndex].Cells[10].Value.ToString();
                cboSexo.Text = dgvListaAnimais.Rows[e.RowIndex].Cells[11].Value.ToString();
                txtObservacao.Text = dgvListaAnimais.Rows[e.RowIndex].Cells[12].Value.ToString();
                //Habilitar os botões de Editar e Excluir
                btnAtualizar.Visible = true;
                btnDeletar.Visible = true;
                btnSalvar.Enabled = false;
                //Desabilitar o campo Código do Dono.
                //A constraint não permite atualizar esta informação.
            }
        }
        // ------------------------------------------------------------------------------- //
        // Configuração dos botôes do Formulário
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Instância da classe AnimaisDTO
            AnimaisDTO animais = new AnimaisDTO();
            //Instância da classe SalvarAnimais
            SalvarAnimais salvarAnimais = new SalvarAnimais();
            //Acesso às variáveis por meio do objeto animais.
            //animais.codigoPet = Convert.ToInt32(txtCodigoPet.Text);
            if (txtNomePet.Text == "" || cboFuncionario.Text == "" || txtRaca.Text == "" || txtCor.Text == "" || txtTipo.Text == "" || txtPeso.Text == "" || txtPedigree.Text == "" || 
                mskRga.Text == "" || txtObservacao.Text == "")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos", "Aviso");
            }
            else
            {
                animais.CodigoDono = Convert.ToInt32(cboCodigoDono.Text);
                animais.NomePet = txtNomePet.Text;
                animais.Funcionario = Convert.ToInt32(cboFuncionario.SelectedValue);         
                animais.Raca = txtRaca.Text;
                animais.Cor = txtCor.Text;
                animais.Tipo = txtTipo.Text;
                animais.Peso = Convert.ToInt32(txtPeso.Text);
                animais.Nascimento = dtpNascimento.Value;
                animais.Pedigree = txtPedigree.Text;
                animais.Rga = mskRga.Text.Replace(".", "");
                animais.Sexo = cboSexo.Text;
                animais.Observacao = txtObservacao.Text;
                //Teste de funcionamento
                //Chamada do método InserirDados por meio do objeto salvarAnimais
                salvarAnimais.InserirDados(animais);
                //Exibir a mensagem de Sucesso ou Falha
                MessageBox.Show(animais.Mensagem, "Aviso", MessageBoxButtons.OK);
                CarregarGrid();
                LimparCampos();
            }
            

        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            string senha, mensagem, titulo, padrao;
            object valor;

            senha = "123";
            mensagem = "Informe a senha:";
            titulo = "Deletar registro.";
            padrao = ""; // Aplicado em caso do inputbox vazio

            //Construção da caixa de mensagem
            valor = Interaction.InputBox(mensagem, titulo, padrao);

            //Verificação de senha
            if(valor.ToString() == "")
            {
                Interaction.MsgBox("ERRO - Senha Inválida!");
            }
            else if(valor.ToString() != senha)
            {
                Interaction.MsgBox("ERRO - Senha Inválida!");
            }
            else
            {
                //Agrupar um conjunto de códigos de forma personalizada
                #region excluir
                //Instânciar das classes
                DeletarAnimais deletarAnimais = new DeletarAnimais();
                AnimaisDTO animais = new AnimaisDTO();
                //Armazenar o código para exclusão
                animais.CodigoPet = Convert.ToInt32(txtCodigoPet.Text);
                //Variável deletar que receberá a escolha do usuário: Yes ou No.
                DialogResult confirmacao = MessageBox.Show(
                "Deseja deletar o registro? Código " + txtCodigoPet.Text,
                "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Verificar se a escolha é Yes.
                if (confirmacao == DialogResult.Yes)
                {
                    //Execução do método de esclusão
                    deletarAnimais.DeletarDados(animais);
                    //Atualização do Grid e Campos de digitação
                    CarregarGrid();
                    ConfigurarDataGridView();
                    LimparCampos();
                    MessageBox.Show(animais.Mensagem, "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                #endregion
            }

            CarregarGrid();
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //Instanciar as classes
            AtualizarAnimais atualizarAnimais = new AtualizarAnimais();
            AnimaisDTO animais = new AnimaisDTO();
            //Alimentar as variáveis
            animais.CodigoPet = Convert.ToInt32(txtCodigoPet.Text);
            animais.NomePet = txtNomePet.Text;
            animais.CodigoDono = Convert.ToInt32(cboCodigoDono.Text);
            animais.Funcionario = Convert.ToInt32(cboFuncionario.SelectedValue);
            animais.Raca = txtRaca.Text;
            animais.Cor = txtCor.Text;
            animais.Tipo = txtTipo.Text;
            animais.Peso = Convert.ToDecimal(txtPeso.Text);
            animais.Nascimento = dtpNascimento.Value;
            animais.Pedigree = txtPedigree.Text;
            animais.Rga = mskRga.Text.Replace(".", "");
            animais.Sexo = cboSexo.Text;
            animais.Observacao = txtObservacao.Text;
            //Execução do método
            atualizarAnimais.AtualizarDados(animais);
            //Reestruturar o grid após atualização
            CarregarGrid();
            ConfigurarDataGridView();
            MessageBox.Show(animais.Mensagem, "Aviso", MessageBoxButtons.OK);
            LimparCampos();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        // ------------------------------------------------------------------------------- //
        // Configuração das TextBox da DataGridView
        private void txtPesquisaPet_TextChanged(object sender, EventArgs e)
        {
            txtPesquisaDono.Text = "";
            //Instância das classes
            ConsultarAnimais consultarAnimais = new ConsultarAnimais();
            AnimaisDTO animais = new AnimaisDTO();
            //Atribuição do nome digitação no TextBox à variável
            animais.NomePet = txtPesquisaPet.Text;
            //Atribuição do retorno como tabela ao DataGridView
            dgvListaAnimais.DataSource = consultarAnimais.ListarDadosAnimaisPet(animais);
            //Verificar se houve erro na estrutura da tabela
            if (!string.IsNullOrEmpty(animais.Mensagem))
            {
                MessageBox.Show(animais.Mensagem);
            }
            //Formatação do Grid
            ConfigurarDataGridView();
        }
        private void txtPesquisaDono_TextChanged(object sender, EventArgs e)
        {
            txtPesquisaPet.Text = "";
            //Instância das classes
            ConsultarAnimais consultarAnimais = new ConsultarAnimais();
            AnimaisDTO animais = new AnimaisDTO();
            //Atribuição do nome digitação no TextBox à variável
            animais.NomeDono = txtPesquisaDono.Text;
            //Atribuição do retorno como tabela ao DataGridView
            dgvListaAnimais.DataSource = consultarAnimais.ListarDadosAnimaisDono(animais);
            //Verificar se houve erro na estrutura da tabela
            if (!string.IsNullOrEmpty(animais.Mensagem))
            {
                MessageBox.Show(animais.Mensagem);
            }
            //Formatação do Grid
            ConfigurarDataGridViewDono();
        }
        // ------------------------------------------------------------------------------- //
        // Métodos
        private void ListarCodigoDono()
        {
            ConsultarAnimais consultarAnimais = new ConsultarAnimais();
            AnimaisDTO animais = new AnimaisDTO();

            cboCodigoDono.DataSource = consultarAnimais.ListarCodigoDono(animais);

            cboCodigoDono.ValueMember = "ClCodigo";

            cboCodigoDono.DisplayMember = "ClCodigo";
        }
        public void LimparCampos()
        {
            txtCodigoPet.Clear();
            txtNomePet.Clear();
            cboCodigoDono.SelectedIndex = -1;
            cboFuncionario.SelectedIndex = -1;
            txtRaca.Clear();
            txtCor.Clear();
            txtTipo.Clear();
            txtPeso.Clear();
            dtpNascimento.Value = DateTime.Now;
            txtPedigree.Clear();
            mskRga.Clear();
            cboSexo.SelectedIndex = -1;
            txtObservacao.Clear();
            txtIdade.Clear();

            btnAtualizar.Visible = false;
            btnSalvar.Enabled = true;
            btnDeletar.Visible = false;

            BuscarNovoCodigo();
        }
        public void BuscarNovoCodigo()
        {
            // Instância da classe ConsultarClientes e ClientesDTO
            ConsultarAnimais consultarAnimais = new ConsultarAnimais();
            AnimaisDTO animais = new AnimaisDTO();

            // Uso do método que busca o último código do BD + 1
            consultarAnimais.NovoCodigo(animais);

            // Atribuição do valor da textbox
            txtCodigoPet.Text = animais.CodigoPet.ToString();
        }
        private void dtpNascimento_ValueChanged(object sender, EventArgs e)
        {
            if(dtpNascimento.Value < DateTime.Now)
            {
                int resultado = CalcularIdade(dtpNascimento.Value);
                txtIdade.Text = resultado.ToString();
            }
            /*else
            {
                MessageBox.Show("Data Inválida", "Aviso");
            }*/
        }
        public int CalcularIdade(DateTime dataNascimento)
        {
            //Realiza a subtração entre o ano atual menos o ano de nascimento
            int idade = DateTime.Now.Year - dataNascimento.Year;

            //Verifica se o dia do ano atual é menor que o de nascimento
            //Assim, verificamos se já ocorreu o aniversário
            if(DateTime.Now.DayOfYear < dataNascimento.DayOfYear)
            {
                idade -= 1; //Equivalente a idade = idade -1
            }
            return idade;
        }

        private void dgvListaAnimais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
