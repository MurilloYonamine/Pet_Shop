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
    public partial class frmEstoque : Form
    {
        public frmEstoque()
        {
            InitializeComponent();
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            ConfigurarDataGridView();
        }
        private void CarregarGrid()
        {
            EstoqueDTO estoque = new EstoqueDTO();
            ConsultarEstoque consultarEstoque = new ConsultarEstoque();

            dgvListarEstoque.DataSource = consultarEstoque.ListarDadosEstoque(estoque);
            ConfigurarDataGridView();
        }
        private void ConfigurarDataGridView()
        {
            if (dgvListarEstoque.Rows.Count != 0)
            {
                //Renomear o cabeçalho das colunas no DataGridView
                dgvListarEstoque.Columns[0].HeaderText = "Código";
                dgvListarEstoque.Columns[1].HeaderText = "Nome";
                dgvListarEstoque.Columns[2].HeaderText = "Quantidade";
                //Configurar a largura das colunas no DataGridView
                dgvListarEstoque.Columns[0].Width = 100;
                dgvListarEstoque.Columns[1].Width = 300;
                //Alinhar o conteúdo das colunas
                dgvListarEstoque.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            }

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            EstoqueDTO estoque = new EstoqueDTO();
            ConsultarEstoque consultarEstoque = new ConsultarEstoque();

            //Amazenar o nome do TextBox
            estoque.NomeProduto = txtPesquisar.Text;
            //Chamada do método para a pesquisa e preenchimento do DataGridView
            dgvListarEstoque.DataSource = consultarEstoque.ListarDadosProdutoFiltro(estoque);
            //Configurar o DataGridView
            ConfigurarDataGridView();
        }
    }
}
