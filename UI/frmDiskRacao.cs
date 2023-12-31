﻿using BLL;
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
        // ------------------------------------------------------------------------------- //
        // Configuração da GridView
        public void CarregarGrid()
        {
            // Instância da classe ConsultarClientes e ClientesDTO
            RacaoDTO racao = new RacaoDTO();
            ConsultarRacao consultarRacao = new ConsultarRacao();

            // Atribuição dos registros ao DataGridView
            dgvEstoque.DataSource = consultarRacao.ListarEstoqueDataGridView(racao);
            dgvDiskRacao.DataSource = consultarRacao.ListarDiskRacaoDataGridView(racao);

            // Procedimento para alterar os títulos e propriedades da coluna
            ConfigurarDataGridView();
            ConfigurarDataGridViewListarDiskRacao();

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
        public void ConfigurarDataGridViewListarDiskRacao()
        {
            //Verificar se o DataGridView contém linhas
            if (dgvDiskRacao.Rows.Count != 0)
            {
                //Renomear o cabeçalho das colunas no DataGridView
                dgvDiskRacao.Columns[0].HeaderText = "Código";
                dgvDiskRacao.Columns[1].HeaderText = "Ração";
                dgvDiskRacao.Columns[2].HeaderText = "Funcionário";
                dgvDiskRacao.Columns[3].HeaderText = "QTD";
                dgvDiskRacao.Columns[4].HeaderText = "Entrada";
                dgvDiskRacao.Columns[5].HeaderText = "Saída";


                //Configurar a largura das colunas no DataGridView
                dgvDiskRacao.Columns[0].Width = 70;
                dgvDiskRacao.Columns[1].Width = 180;
                dgvDiskRacao.Columns[2].Width = 120;
                dgvDiskRacao.Columns[3].Width = 50;
                //Alinhar o conteúdo das colunas
                dgvDiskRacao.Columns[0].DefaultCellStyle.Alignment =
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
            racao.CodigoRacao = Convert.ToInt32(txtCodigoRacao.Text);



            inserirRacao.InserirDados(racao);
            CarregarGrid();
            ConfigurarDataGridView();
            LimparCampos();
            


            MessageBox.Show(racao.Mensagem);


        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        public void LimparCampos()
        {
            RacaoDTO racao = new RacaoDTO();
            ConsultarRacao consultarRacao = new ConsultarRacao();

            txtCodigo.Clear();
            txtRacao.Clear();
            numQuantidade.Value = 0;
            cboFuncionario.SelectedIndex = -1;
            dtpEntrada.Value = DateTime.Now;
            dtpSaida.Value = DateTime.Now;
            consultarRacao.NovoCodigo(racao);
            txtCodigo.Text = racao.Codigo.ToString();
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
                txtCodigoRacao.Text = dgvEstoque.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtRacao.Text = dgvEstoque.Rows[e.RowIndex].Cells[1].Value.ToString();
                numQuantidade.Maximum = Convert.ToInt32(dgvEstoque.Rows[e.RowIndex].Cells[2].Value);

                if (numQuantidade.Maximum <= 0)
                {
                    btnEnviar.Enabled = false;
                }
                else
                {
                    btnEnviar.Enabled = true;
                }
            }
        }

        private void numQuantidade_ValueChanged(object sender, EventArgs e)
        {
            if(Convert.ToInt32(numQuantidade.Value) > numQuantidade.Maximum)
            {
                numQuantidade.Value = 0;
            }
        }

        private void dgvDiskRacao_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
