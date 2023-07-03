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
    public partial class frmAdoção : Form
    {
        // ------------------------------------------------------------------------------- //
        // Métodos de inicialização
        public frmAdoção()
        {
            InitializeComponent();
            CarregarGrid();
            ConfigurarDataGridViewAdocao();
            ConfigurarDataGridViewCliente();
        }
        private void frmAdoção_Load(object sender, EventArgs e)
        {
            ConsultarAdocao consultarAdocao = new ConsultarAdocao();
            AdocaoDTO adocao = new AdocaoDTO();
            cboFuncionario.DataSource = consultarAdocao.ListarFuncionario(adocao);
            cboFuncionario.ValueMember = "FnCodigo";
            cboFuncionario.DisplayMember = "FnNome";

            BuscarNovoCodigo();
        }
        // ------------------------------------------------------------------------------- //
        // Configuração do DataGridView do Cliente
        private void ConfigurarDataGridViewCliente()
        {
            if (dgvClientes.Rows.Count != 0)
            {
                //Renomear o cabeçalho das colunas no DataGridView
                dgvClientes.Columns[0].HeaderText = "ID";
                dgvClientes.Columns[1].HeaderText = "Nome";


                //Configurar a largura das colunas no DataGridView
                dgvClientes.Columns[0].Width = 50;
                dgvClientes.Columns[1].Width = 140;

                //Alinhar o conteúdo das colunas
                dgvClientes.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            }
        }
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCliente.Text = dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
        // ------------------------------------------------------------------------------- //
        // Configuração do DataGridView da Adoção
        private void ConfigurarDataGridViewAdocao()
        {
            if (dgvAdocao.Rows.Count != 0)
            {
                //Renomear o cabeçalho das colunas no DataGridView
                dgvAdocao.Columns[0].HeaderText = "Cod";
                dgvAdocao.Columns[1].HeaderText = "Pet";
                dgvAdocao.Columns[2].HeaderText = "Dono";
                dgvAdocao.Columns[3].HeaderText = "Funcionário";
                dgvAdocao.Columns[4].HeaderText = "Raça";
                dgvAdocao.Columns[5].HeaderText = "Cor";
                dgvAdocao.Columns[6].HeaderText = "Tipo";
                dgvAdocao.Columns[7].HeaderText = "Peso";
                dgvAdocao.Columns[8].HeaderText = "Nascimento";
                dgvAdocao.Columns[9].HeaderText = "Pedigree";
                dgvAdocao.Columns[10].HeaderText = "RGA";
                dgvAdocao.Columns[11].HeaderText = "Sexo";
                dgvAdocao.Columns[12].HeaderText = "Observação";

                //Configurar a largura das colunas no DataGridView
                dgvAdocao.Columns[0].Width = 50;
                dgvAdocao.Columns[2].Width = 50;
                dgvAdocao.Columns[4].Width = 150;
                dgvAdocao.Columns[5].Width = 150;
                dgvAdocao.Columns[7].Width = 80;
                dgvAdocao.Columns[11].Width = 80;
                dgvAdocao.Columns[12].Width = 250;

                //Alinhar o conteúdo das colunas
                dgvAdocao.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
                dgvAdocao.Columns[2].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            }
        }
        private void dgvAdocao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            { 
                txtCodigoPet.Text = dgvAdocao.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtPet.Text = dgvAdocao.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
        // ------------------------------------------------------------------------------- //
        // Botões
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            InserirAdocao inserirAdocao = new InserirAdocao();
            AdocaoDTO adocao = new AdocaoDTO();

            adocao.CodigoCliente = Convert.ToInt32(txtCliente.Text);
            adocao.CodigoPet = Convert.ToInt32(txtCodigoPet.Text);
            adocao.Data = dtpData.Value;
            adocao.Funcionario = Convert.ToInt32(cboFuncionario.SelectedValue);
            inserirAdocao.InserirDados(adocao);
            CarregarGrid();
            ConfigurarDataGridViewAdocao();
            MessageBox.Show(adocao.Mensagem.ToString());
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        // ------------------------------------------------------------------------------- //
        // TextBox de pesquisa dos DataGridView
        private void txtPesquisaAnimal_TextChanged(object sender, EventArgs e)
        {
            ConsultarAdocao consultarAdocao = new ConsultarAdocao();
            AdocaoDTO adocao = new AdocaoDTO();

            adocao.Pesquisa = txtPesquisaAnimal.Text;
            //Chamada do método para a pesquisa e preenchimento do DataGridView
            dgvAdocao.DataSource = consultarAdocao.PesquisaDadosAdocao(adocao);
            //Configurar o DataGridView
            ConfigurarDataGridViewAdocao();
        }
        private void txtPesquisaCliente_TextChanged(object sender, EventArgs e)
        {
            ConsultarAdocao consultarAdocao = new ConsultarAdocao();
            AdocaoDTO adocao = new AdocaoDTO();

            adocao.Cliente = txtPesquisaCliente.Text;
            //Chamada do método para a pesquisa e preenchimento do DataGridView
            dgvClientes.DataSource = consultarAdocao.PesquisaDadosCliente(adocao);
            //Configurar o DataGridView
            ConfigurarDataGridViewCliente();
        }
        // ------------------------------------------------------------------------------- //
        // Métodos
        public void LimparCampos()
        {
            txtCodigoAdocao.Clear();
            txtCliente.Clear();
            txtCodigoPet.Clear();
            txtPet.Clear();
            dtpData.Value = DateTime.Now;
            cboFuncionario.SelectedIndex = -1;

            btnSalvar.Enabled = true;

            BuscarNovoCodigo();
        }
        public void BuscarNovoCodigo()
        {
            ConsultarAdocao consultarAdocao = new ConsultarAdocao();
            AdocaoDTO adocao = new AdocaoDTO();

            consultarAdocao.NovoCodigo(adocao);
            txtCodigoAdocao.Text = adocao.Codigo.ToString();
        }
        private void CarregarGrid()
        {
            // Instância da classe ConsultarAnimais e AnimaisDTO
            ConsultarAdocao consultarAdocao = new ConsultarAdocao();
            AdocaoDTO adocao = new AdocaoDTO();

            // Atribuição dos registros ao DataGridView
            dgvAdocao.DataSource = consultarAdocao.ListarDadosAnimaisAdocao(adocao);
            dgvClientes.DataSource = consultarAdocao.ListarDadosClientes(adocao);

            // Verificar se houve na estrutura da tabela
            if (!string.IsNullOrEmpty(adocao.Mensagem))
            {
                MessageBox.Show(adocao.Mensagem);
            }
        }

        private void dgvAdocao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
