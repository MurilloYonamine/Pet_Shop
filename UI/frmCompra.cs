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
    public partial class frmCompra : Form
    {
        public frmCompra()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtFornecedor.Text != "" || txtPreco.Text != "" || numQuantidade.Value <= 0)
            {
                FornecedorDTO fornecedor = new FornecedorDTO();
                SalvarEstoque salvarEstoque = new SalvarEstoque();
                SalvarFornecedor salvarFornecedor = new SalvarFornecedor();
                EstoqueDTO estoque = new EstoqueDTO();
                estoque.Codigo = Convert.ToInt32(txtCodigo.Text);
                estoque.NomeProduto = txtProduto.Text;
                fornecedor.Registro = dtpRegistro.Value;
                fornecedor.Preco = txtPreco.Text;
                estoque.Quantidade = Convert.ToInt32(numQuantidade.Value);
                fornecedor.Quantidade = Convert.ToInt32(numQuantidade.Value);
                fornecedor.Validade = dtpValidade.Value;
                fornecedor.Fornecedor = txtFornecedor.Text;
                fornecedor.Total = Convert.ToDecimal(estoque.Quantidade) * Convert.ToDecimal(fornecedor.Preco);
                salvarFornecedor.InserirDadosFornecedor(fornecedor);
                salvarEstoque.CEstoque(estoque);
                MessageBox.Show(estoque.Mensagem);
                CarregarGrid();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Preencha todos os espaços vazios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtProduto.Clear();
            txtProduto.Clear();
            txtPreco.Clear();
            numQuantidade.Value = 0;
            txtFornecedor.Clear();
        }
        private void CarregarGrid()
        {
            ConsultarProduto consultarProduto = new ConsultarProduto();
            ProdutoDTO produto = new ProdutoDTO();

            dgvListarProduto.DataSource = consultarProduto.ListarDadosProduto(produto);
            ConfiguraDataGridView();
        }
        private void ConfiguraDataGridView()
        {
            if (dgvListarProduto.Rows.Count != 0)
            {
                //Renomear o cabeçalho das colunas no DataGridView
                dgvListarProduto.Columns[0].HeaderText = "ID";
                dgvListarProduto.Columns[1].HeaderText = "Nome";
                dgvListarProduto.Columns[2].HeaderText = "Tipo";
                dgvListarProduto.Columns[3].HeaderText = "Marca";
                dgvListarProduto.Columns[4].HeaderText = "Registro";
                //Configurar a largura das colunas no DataGridView
                dgvListarProduto.Columns[0].Width = 50;
                dgvListarProduto.Columns[1].Width = 210;
                dgvListarProduto.Columns[2].Width = 100;
                dgvListarProduto.Columns[3].Width = 100;
                dgvListarProduto.Columns[4].Width = 100;
                //Alinhar o conteúdo das colunas
                dgvListarProduto.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            }

        }

        private void frmCompra_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            ConfiguraDataGridView();
        }

        private void dgvListarProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //TextBox = DataGridView.LinhaSelecionada.Célula[Posição].Valor.ParaTexto
                txtCodigo.Text = dgvListarProduto.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtProduto.Text = dgvListarProduto.Rows[e.RowIndex].Cells[1].Value.ToString();

            }
        }
    }
}
