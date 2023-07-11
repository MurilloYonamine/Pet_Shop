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
    public partial class frmVenda : Form
    {
        public frmVenda()
        {
            InitializeComponent();
        }
        private void frmVenda_Load(object sender, EventArgs e)
        {
            VendaDTO venda = new VendaDTO();
            ConsultarVenda consultarVenda = new ConsultarVenda();
            cboProduto.DataSource = consultarVenda.ListarProduto(venda);
            cboProduto.ValueMember = "ProCodigo";
            cboProduto.DisplayMember = "ProNome";
            cboProduto.SelectedIndex = -1;

            CarregarGrid();
            ConfigurarDataGridView();
        }
        // -------------------------------------------------------------------------------------------//
        // Configuração da DataGridView
        public void CarregarGrid()
        {
            VendaDTO venda = new VendaDTO();
            ConsultarVenda consultarVenda = new ConsultarVenda();

            dgvListaProduto.DataSource = consultarVenda.ListarDadosVenda(venda);
            ConfigurarDataGridView();
        }
        private void ConfigurarDataGridView()
        {
            if (dgvListaProduto.Rows.Count != 0)
            {
                //Renomear o cabeçalho das colunas no DataGridView
                dgvListaProduto.Columns[0].HeaderText = "Cod";
                dgvListaProduto.Columns[1].HeaderText = "Cod do produto";
                dgvListaProduto.Columns[2].HeaderText = "Preço";
                dgvListaProduto.Columns[3].HeaderText = "Validade";
                dgvListaProduto.Columns[4].HeaderText = "Quantidade";
                //Configurar a largura das colunas no DataGridView
                dgvListaProduto.Columns[0].Width = 50;
                dgvListaProduto.Columns[1].Width = 150;
                //Alinhar o conteúdo das colunas
                dgvListaProduto.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            }
        }
        private void dgvListaProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //TextBox = DataGridView.LinhaSelecionada.Célula[Posição].Valor.ParaTexto
                txtCodigo.Text = dgvListaProduto.Rows[e.RowIndex].Cells[0].Value.ToString();
                cboProduto.SelectedValue = dgvListaProduto.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPreco.Text = dgvListaProduto.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpValidade.Text = dgvListaProduto.Rows[e.RowIndex].Cells[3].Value.ToString();
                numQuantidade.Maximum = Convert.ToInt32(dgvListaProduto.Rows[e.RowIndex].Cells[4].Value.ToString());
                btnAtualizar.Enabled = true;
                btnVender.Enabled = false;
            }
        }
        // -------------------------------------------------------------------------------------------//
        // Botões
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            VendaDTO venda = new VendaDTO();
            AtualizarVenda atualizarVenda = new AtualizarVenda();

            venda.Quantidade = Convert.ToInt32(numQuantidade.Value);
            venda.Preco = txtPreco.Text;
            venda.Validade = dtpValidade.Value;
            venda.Total = Convert.ToDecimal(venda.Quantidade) * Convert.ToDecimal(venda.Preco);

            atualizarVenda.AtualizarDadosVenda(venda);

            CarregarGrid();
            ConfigurarDataGridView();
            MessageBox.Show(venda.Mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCampos();
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            VendaDTO venda = new VendaDTO();
            DeletarVenda deletarVenda = new DeletarVenda();
            //Instanciar a Classe ClientesDTO - Atributos/Variáveis
            //Armazenar o código para exclusão
            venda.Codigo = Convert.ToInt32(txtCodigo.Text);
            venda.CodigoProduto = Convert.ToInt32(cboProduto.SelectedValue);

            //Confirmação para exclusão do registro
            DialogResult confirmacao = MessageBox.Show("Deseja deletar o registro? Código " +
            txtCodigo.Text, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacao == DialogResult.Yes)
            {
                //Executar o método de exclusão
                //deletarVenda.DVEstoque(venda);
                deletarVenda.DeletarDadosVenda(venda);
                CarregarGrid();
                ConfigurarDataGridView();
                LimparCampos();
                MessageBox.Show(venda.Mensagem, "Aviso", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void btnVender_Click(object sender, EventArgs e)
        {
            VendaDTO venda = new VendaDTO();
            SalvarVenda salvarVenda = new SalvarVenda();
            ConsultarVenda consultarVenda = new ConsultarVenda();
            venda.Quantidade = Convert.ToInt32(numQuantidade.Value);
            venda.CodigoProduto = Convert.ToInt32(cboProduto.SelectedValue);

            consultarVenda.VerificarQuantidade(venda);

            if (venda.Situacao == true)
            {
                venda.Preco = txtPreco.Text;
                venda.Validade = dtpValidade.Value;
                venda.Total = Convert.ToDecimal(venda.Quantidade) * Convert.ToDecimal(venda.Preco);

                //MessageBox.Show(produto.codigo);
                salvarVenda.InserirVenda(venda);
                //salvarVenda.VEstoque(venda);
                MessageBox.Show(venda.Mensagem, "Aviso", MessageBoxButtons.OK);
                CarregarGrid();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Estoque do produto insuficiente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                numQuantidade.Value = 0;
            }

        }
        // -------------------------------------------------------------------------------------------//
        // Tratamentos
        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }
        private void numQuantidade_ValueChanged(object sender, EventArgs e)
        {
            if (numQuantidade.Value > numQuantidade.Maximum)
            {
                numQuantidade.Value = 0;
            }
        }
        // -------------------------------------------------------------------------------------------//
        // Métodos
        private void LimparCampos()
        {
            txtCodigo.Clear();
            cboProduto.SelectedIndex = -1;
            txtPreco.Clear();
            dtpValidade.Value = DateTime.Now;
            numQuantidade.Value = 0;
            btnAtualizar.Enabled = false;
        }


    }
}
