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
    public partial class frmDiskRacao : Form
    {
        public frmDiskRacao()
        {
            InitializeComponent();
        }
        // ------------------------------------------------------------------------------- //
        // Configuração da GridView
        public void CarregarGrid()
        {
            // Instância da classe ConsultarClientes e ClientesDTO
            RacaoDTO racao = new RacaoDTO();
            ConsultarRacao consultarRacao = new ConsultarRacao();

            // Atribuição dos registros ao DataGridView
            dgvEstoque.DataSource = consultarRacao.ListarEstoqueDataGridView(racao);

            // Procedimento para alterar os títulos e propriedades da coluna
            ConfigurarDataGridView();

            // Verificar se houve erro na estrutura da tabela
            if (!string.IsNullOrEmpty(racao.Mensagem))
            {
                MessageBox.Show(racao.Mensagem);
            }
        }
        public void ConfigurarDataGridView()
        {
            //Verificar se o DataGridView contém linhas
            if (dgvEstoque.Rows.Count != 0)
            {
                //Renomear o cabeçalho das colunas no DataGridView
                dgvEstoque.Columns[0].HeaderText = "Cod";
                dgvEstoque.Columns[1].HeaderText = "Nome";
                dgvEstoque.Columns[2].HeaderText = "QTD";


                //Configurar a largura das colunas no DataGridView
                dgvEstoque.Columns[0].Width = 50;
                dgvEstoque.Columns[1].Width = 150;
                dgvEstoque.Columns[2].Width = 50;
                //Alinhar o conteúdo das colunas
                dgvEstoque.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            }
        }
        // ------------------------------------------------------------------------------- //
        // Configurações dos botões do furmlário
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            RacaoDTO racao = new RacaoDTO();
            InserirRacao inserirRacao = new InserirRacao();

            racao.CodigoFuncionario = Convert.ToInt32(cboFuncionario.SelectedValue);
            racao.Quantidade = Convert.ToInt32(numQuantidade.Text);
            racao.Entrada = Convert.ToDateTime(dtpEntrada.Value);
            racao.Saida = Convert.ToDateTime(dtpSaida.Value);
            racao.Codigo = Convert.ToInt32(txtCodigo.Text);
            inserirRacao.InserirDados(racao);
            CarregarGrid();
            ConfigurarDataGridView();

            MessageBox.Show(racao.Mensagem);
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtRacao.Clear();
            cboFuncionario.Items.Clear();
        }
        // ------------------------------------------------------------------------------- //
        // Métodos
        private void dgvEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Evitar o erro no clique dos títulos (linha -1)
            if (e.RowIndex >= 0)
            {
                RacaoDTO racao = new RacaoDTO();
                //TextBox = DataGridView.LinhaSelecionada.Célula[Posição].Valor.ParaTexto
                racao.CodigoRacao = Convert.ToInt32(dgvEstoque.Rows[e.RowIndex].Cells[0].Value);
                txtRacao.Text = dgvEstoque.Rows[e.RowIndex].Cells[1].Value.ToString();
                numQuantidade.Maximum = Convert.ToInt32(dgvEstoque.Rows[e.RowIndex].Cells[2].Value);
            }
        }
        private void frmDiskRacao_Load(object sender, EventArgs e)
        {
            RacaoDTO racao = new RacaoDTO();
            ConsultarRacao consultarRacao = new ConsultarRacao();

            cboFuncionario.DataSource = consultarRacao.ListarFuncionario(racao);
            cboFuncionario.ValueMember = "FnCodigo";
            cboFuncionario.DisplayMember = "FnNome";

            consultarRacao.NovoCodigo(racao);
            txtCodigo.Text = racao.Codigo.ToString();

            CarregarGrid();

        }
    }
}
