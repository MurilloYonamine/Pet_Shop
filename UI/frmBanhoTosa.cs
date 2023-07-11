using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmBanhoTosa : Form
    {
        //Inicialização
        public frmBanhoTosa()
        {
            InitializeComponent();
        }
        private void frmBanhoTosa_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            ConfiguraDataGridView();
        }
        //-----------------------------------------------------------------------//
        //Configuração da DataGridView
        public void CarregarGrid()
        {
            AgendamentoDTO agendamento = new AgendamentoDTO();
            ConsultarAgendamento consultarAgendamento = new ConsultarAgendamento();

            dgvDados.DataSource = consultarAgendamento.ListarDadosBanho(agendamento);

            ConfiguraDataGridView();

            if (!string.IsNullOrEmpty(agendamento.Mensagem))
            {
                {
                    MessageBox.Show(agendamento.Mensagem);
                }

            }
        }
        public void ConfiguraDataGridView()
        {
            //Verificar se o DataGridView contém linhas
            if (dgvDados.Rows.Count != 0)
            {
                //Renomear o cabeçalho das colunas no DataGridView
                dgvDados.Columns[0].HeaderText = "codigo";



                dgvDados.Columns[1].HeaderText = "Responsável";
                dgvDados.Columns[2].HeaderText = "Telefone";
                dgvDados.Columns[3].HeaderText = "Nome do Animal";
                dgvDados.Columns[4].HeaderText = "Raça";
                dgvDados.Columns[5].HeaderText = "Agendamento";

                dgvDados.Columns[6].HeaderText = "Banho";
                dgvDados.Columns[7].HeaderText = "Hidratação";
                dgvDados.Columns[8].HeaderText = "Tosa";
                dgvDados.Columns[9].HeaderText = "Desembolo";
                dgvDados.Columns[10].HeaderText = "Alergia";

                dgvDados.Columns[11].HeaderText = "Pulgas";
                dgvDados.Columns[12].HeaderText = "Lesões";
                dgvDados.Columns[13].HeaderText = "Observações";

                //Configurar a largura das colunas no DataGridView
                dgvDados.Columns[0].Width = 50;
                dgvDados.Columns[1].Width = 150;

                //Alinhar o conteúdo das colunas
                dgvDados.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            }
        }
        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Evitar o erro no clique dos títulos (linha -1)
            if (e.RowIndex >= 0)
            {
                //TextBox = DataGridView.LinhaSelecionada.Célula[Posição].Valor.ParaTexto

                txtCodigoAgendamento.Text = dgvDados.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCodigoAnalise.Text = dgvDados.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCodigoServico.Text = dgvDados.Rows[e.RowIndex].Cells[0].Value.ToString();

                txtResponsavel.Text = dgvDados.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNomeAnimal.Text = dgvDados.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtTelefone.Text = dgvDados.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtRaca.Text = dgvDados.Rows[e.RowIndex].Cells[4].Value.ToString();
                dtpHora.Text = dgvDados.Rows[e.RowIndex].Cells[5].Value.ToString();
                cboBanho.Text = dgvDados.Rows[e.RowIndex].Cells[6].Value.ToString();
                cboHidratacao.Text = dgvDados.Rows[e.RowIndex].Cells[7].Value.ToString();
                cboTosa.Text = dgvDados.Rows[e.RowIndex].Cells[8].Value.ToString();
                cboDesembolo.Text = dgvDados.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtAlergia.Text = dgvDados.Rows[e.RowIndex].Cells[10].Value.ToString();
                cboPulgaCarrapato.Text = dgvDados.Rows[e.RowIndex].Cells[11].Value.ToString();
                cboLesoes.Text = dgvDados.Rows[e.RowIndex].Cells[12].Value.ToString();
                txtObservacao.Text = dgvDados.Rows[e.RowIndex].Cells[13].Value.ToString();

                btnAtualizar.Visible = true; //Ou enable
                btnSalvar.Enabled = false;
                btnExcluir.Visible = true;
            }
        }
        //-----------------------------------------------------------------------//
        //Botões
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            AgendamentoDTO agendamento = new AgendamentoDTO();
            ServicoDTO servico = new ServicoDTO();
            AnaliseDTO analise = new AnaliseDTO();

            SalvarAgendamento salvarAgendamento = new SalvarAgendamento();
            SalvarServico salvarServico = new SalvarServico();
            SalvarAnalise salvarAnalise = new SalvarAnalise();


            //Agendamento
            agendamento.Responsavel = txtResponsavel.Text;
            agendamento.NomeAnimal = txtNomeAnimal.Text;
            agendamento.Telefone = txtTelefone.Text;
            agendamento.Raca = txtRaca.Text;
            agendamento.Data = dtpHora.Value;

            //Servico
            servico.Banho = cboBanho.Text;
            servico.Hidratacao = cboHidratacao.Text;
            servico.Tosa = cboTosa.Text;
            servico.Desembolo = cboDesembolo.Text;
            servico.Alergia = txtAlergia.Text;
            servico.Pulgas = cboPulgaCarrapato.Text;

            //Analise
            analise.Pulgas = cboPulgaCarrapato.Text;
            analise.Lesoes = cboLesoes.Text;
            analise.Observacao = txtObservacao.Text;

            salvarAgendamento.InserirDadosAgendamento(agendamento);
            salvarServico.InserirDadosServico(servico);
            salvarAnalise.InserirDadosAnalise(analise);

            //Exibir a mensagem de Sucesso ou Falha
            if (agendamento.Mensagem != "Registro inserido com Sucesso!")
            {
                MessageBox.Show(agendamento.Mensagem, "Aviso", MessageBoxButtons.OK);
            }
            else if (servico.Mensagem != "Registro inserido com Sucesso!")
            {
                MessageBox.Show(servico.Mensagem, "Aviso", MessageBoxButtons.OK);
            }
            else if (servico.Mensagem != "Registro inserido com Sucesso!")
            {
                MessageBox.Show(analise.Mensagem, "Aviso", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(analise.Mensagem, "Aviso", MessageBoxButtons.OK);
            }
            LimparCampos();
            CarregarGrid();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DeletarAgendamento deletarAgendamento = new DeletarAgendamento();
            DeletarServico deletarServico = new DeletarServico();
            DeletarAnalise deletarAnalise = new DeletarAnalise();

            AgendamentoDTO agendamento = new AgendamentoDTO();
            ServicoDTO servico = new ServicoDTO();
            AnaliseDTO analise = new AnaliseDTO();
            //Armazenar o código para exclusão
            agendamento.Codigo = Convert.ToInt32(txtCodigoAgendamento.Text);
            analise.Codigo = Convert.ToInt32(txtCodigoAnalise.Text);
            servico.Codigo = Convert.ToInt32(txtCodigoServico.Text);

            //Confirmação para exclusão do registro
            DialogResult confirmacao = MessageBox.Show("Deseja deletar o registro? Código " +
            txtCodigoAgendamento.Text, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacao == DialogResult.Yes)
            {
                //Executar o método de exclusão
                deletarAgendamento.DeletarDadosAgendamento(agendamento);
                deletarServico.DeletarDadosServico(servico);
                deletarAnalise.DeletarDadosAnalise(analise);
                CarregarGrid();
                ConfiguraDataGridView();
                LimparCampos();

                //Exibir a mensagem de Sucesso ou Falha
                if (agendamento.Mensagem != "Registro inserido com Sucesso!")
                {
                    MessageBox.Show(agendamento.Mensagem, "Aviso", MessageBoxButtons.OK);
                }
                else if (servico.Mensagem != "Registro inserido com Sucesso!")
                {
                    MessageBox.Show(servico.Mensagem, "Aviso", MessageBoxButtons.OK);
                }
                else if (servico.Mensagem != "Registro inserido com Sucesso!")
                {
                    MessageBox.Show(analise.Mensagem, "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(analise.Mensagem, "Aviso", MessageBoxButtons.OK);
                }
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //Instância das classes AtualizarClientes e ClientesDTO
            AtualizarAgendamento atualizarAgendamento = new AtualizarAgendamento();
            AtualizarServico atualizarServico = new AtualizarServico();
            AtualizarAnalise atualizarAnalise = new AtualizarAnalise();

            AgendamentoDTO agendamento = new AgendamentoDTO();
            ServicoDTO servico = new ServicoDTO();
            AnaliseDTO analise = new AnaliseDTO();
            //Verificar se determinados campos foram preenchidos.
            //Repita esta estrutura de IF / ELSE IF para as informações obrigatórias.
            if (txtResponsavel.Text == string.Empty)
            {
                MessageBox.Show("Campo Nome obrigatório!", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Apontar o ponteiro do mouse para o campo
                txtResponsavel.Focus();
                //Parar a execução do programa até esta linha
                return;
            }
            else if (txtTelefone.Text == string.Empty)
            {
                MessageBox.Show("Campo Número obrigatório!", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefone.Focus();
                return;
            }
            //Armazenar as informações do formulário
            agendamento.Codigo = Convert.ToInt32(txtCodigoAgendamento.Text);
            servico.Codigo = Convert.ToInt32(txtCodigoServico.Text);
            analise.Codigo = Convert.ToInt32(txtCodigoAnalise.Text);

            agendamento.Responsavel = txtResponsavel.Text;
            agendamento.NomeAnimal = txtNomeAnimal.Text;
            agendamento.Telefone = txtTelefone.Text;
            agendamento.Raca = txtRaca.Text;
            agendamento.Data = dtpHora.Value;

            servico.Banho = cboBanho.Text;
            servico.Hidratacao = cboHidratacao.Text;
            servico.Tosa = cboTosa.Text;
            servico.Desembolo = cboDesembolo.Text;
            servico.Alergia = txtAlergia.Text;
            servico.Pulgas = cboPulgaCarrapato.Text;

            analise.Pulgas = cboPulgaCarrapato.Text;
            analise.Lesoes = cboLesoes.Text;
            analise.Observacao = txtObservacao.Text;

            atualizarAgendamento.AtualizarDadosAgendamento(agendamento);
            atualizarServico.AtualizarDadosServico(servico);
            atualizarAnalise.AtualizarDadosAnalise(analise);
            if (agendamento.Mensagem != "Registro inserido com Sucesso!")
            {
                MessageBox.Show(agendamento.Mensagem, "Aviso", MessageBoxButtons.OK);
            }
            else if (servico.Mensagem != "Registro inserido com Sucesso!")
            {
                MessageBox.Show(servico.Mensagem, "Aviso", MessageBoxButtons.OK);
            }
            else if (servico.Mensagem != "Registro inserido com Sucesso!")
            {
                MessageBox.Show(analise.Mensagem, "Aviso", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(analise.Mensagem, "Aviso", MessageBoxButtons.OK);
            }

            CarregarGrid();
            ConfiguraDataGridView();
            LimparCampos();
        }
        //-----------------------------------------------------------------------//
        //Filtro da TextBox no DataGridView
        private void txtPesquisarNome_TextChanged(object sender, EventArgs e)
        {
            AgendamentoDTO agendamento = new AgendamentoDTO();
            ConsultarAgendamento consultarAgendamento = new ConsultarAgendamento();
            agendamento.Responsavel = txtPesquisarNome.Text;
            //Chamada do método para a pesquisa e preenchimento do DataGridView
            dgvDados.DataSource = consultarAgendamento.ListarDadosBanhoFiltro(agendamento);
            //Configurar o DataGridView
            ConfiguraDataGridView();
        }
        //-----------------------------------------------------------------------//
        //Métodos
        public void LimparCampos()
        {
            //Agendamento
            txtTelefone.Clear(); //Função .Clear()
            txtResponsavel.Text = ""; //Vazio ""
            txtPesquisarNome.Clear();
            txtRaca.Clear();
            dtpHora.Value = DateTime.Now;
            txtNomeAnimal.Clear();

            //Códigos
            txtCodigoAgendamento.Clear();
            txtCodigoAnalise.Clear();
            txtCodigoServico.Clear();

            //Serviço
            cboBanho.SelectedIndex = -1;
            cboHidratacao.SelectedIndex = -1;
            cboTosa.SelectedIndex = -1;
            cboDesembolo.SelectedIndex = -1;
            txtAlergia.Clear();

            //Analise Geral
            cboPulgaCarrapato.SelectedIndex = -1;
            cboLesoes.SelectedIndex = -1;
            txtObservacao.Clear();

            //Botões
            btnAtualizar.Visible = false;
            btnSalvar.Enabled = true;
            btnExcluir.Visible = false;
        } 
    }
}
