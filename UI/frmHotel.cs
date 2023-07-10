using BLL;
using System;
using System.Collections;
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
    public partial class frmHotel : Form
    {
        public frmHotel()
        {
            InitializeComponent();
        }

        private void frmHotel_Load(object sender, EventArgs e)
        {
            HotelDTO hotel = new HotelDTO();
            ConsultarHospedagem codigo = new ConsultarHospedagem();
            codigo.PegarCodigoHotel(hotel);
            txtCodHotel.Text = hotel.CodigoHotel.ToString();
            CarregarGridHotel();
            ConfigurarDataGrid();
            
        }
        // ------------------------------------------------------------------------------- //
        // Configuração da GridView
        private void dgvListarHospedagens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Evitar o erro no clique dos títulos (linha -1)
            if (e.RowIndex >= 0)
            {
                //TextBox = DataGridView.LinhaSelecionada.Célula[Posição].Valor.ParaTexto]
                txtCodHotel.Text = dgvListarHospedagens.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCodCliente.Text = dgvListarHospedagens.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCodigoAnimal.Text = dgvListarHospedagens.Rows[e.RowIndex].Cells[2].Value.ToString();
                //txt.Text = dgvListarHospedagens.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpEntrada.Value = Convert.ToDateTime(dgvListarHospedagens.Rows[e.RowIndex].Cells[3].Value);
                dtpRetorno.Value = Convert.ToDateTime(dgvListarHospedagens.Rows[e.RowIndex].Cells[4].Value);

                btnEditar.Visible = true; //Ou enable
                btnHospedar.Enabled = true;
                btnHospedar.Enabled = false;
            }
        }
        public void ConfigurarDataGrid()
        {
            //Verificar se o DataGridView contém linhas
            if (dgvListarHospedagens.Rows.Count != 0)
            {
                //Renomear o cabeçalho das colunas no DataGridView
                dgvListarHospedagens.Columns[0].HeaderText = "Hotel";
                dgvListarHospedagens.Columns[1].HeaderText = "Cliente";
                dgvListarHospedagens.Columns[2].HeaderText = "Animal";
                dgvListarHospedagens.Columns[3].HeaderText = "Entrada";
                dgvListarHospedagens.Columns[4].HeaderText = "Retorno";
                //Configurar a largura das colunas no DataGridView
                dgvListarHospedagens.Columns[0].Width = 70;
                dgvListarHospedagens.Columns[1].Width = 70;
                dgvListarHospedagens.Columns[2].Width = 70;
                dgvListarHospedagens.Columns[3].Width = 96;
                dgvListarHospedagens.Columns[4].Width = 96;
                //Alinhar o conteúdo das colunas
                dgvListarHospedagens.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            }
        }
        public void CarregarGridHotel()
        {
            HotelDTO hotel = new HotelDTO();
            ConsultarHospedagem consultarHospedagem = new ConsultarHospedagem();
            dgvListarHospedagens.DataSource = consultarHospedagem.ListarDadosHotel(hotel);
            if (!string.IsNullOrEmpty(hotel.Mensagem))
            {
                MessageBox.Show(hotel.Mensagem);
            }
        }
        // ------------------------------------------------------------------------------- //
        // Configurações dos botões do formulário
        private void btnHospedar_Click(object sender, EventArgs e)
        {
            HotelDTO hotel = new HotelDTO();
            SalvarHospedagem salvarHospedagem = new SalvarHospedagem();
            if (txtNomeCliente.Text == "" || mskCpf.Text == "" || mskTelefone.Text == "" || txtCodCliente.Text == "" || txtTipoAnimal.Text == "" || txtCodigoAnimal.Text == "")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos", "Aviso");
            }
            else
            {
                hotel.Cliente = txtNomeCliente.Text;
                hotel.Cpf = mskCpf.Text;
                hotel.Telefone = mskTelefone.Text;
                hotel.CodigoCliente = Convert.ToInt32(txtCodCliente.Text);
                hotel.NomeAnimal = txtTipoAnimal.Text;
                hotel.Rga = mskRga.Text;
                //hotel.animal = cboAnimal.Text;
                hotel.DtEntrada = dtpEntrada.Value;
                hotel.DtRetorno = dtpRetorno.Value;
                hotel.CodigoAnimal = Convert.ToInt32(txtCodigoAnimal.Text);

                salvarHospedagem.InserirHospedagem(hotel);
                CarregarGridHotel();
                Limpar();

                MessageBox.Show(hotel.Mensagem, "Aviso", MessageBoxButtons.OK);

                Limpar();
            }
        }
        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            frmClientes Tela = new frmClientes();
            Tela.Show();
        }
        private void btnCadastrarAnimal_Click(object sender, EventArgs e)
        {
            frmAnimais Tela = new frmAnimais();
            Tela.Show();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Instância das classes AtualizarClientes e ClientesDTO
            AtualizarHospedagem atualizarHospedagens = new AtualizarHospedagem();
            HotelDTO hotel = new HotelDTO();
            //Verificar se determinados campos foram preenchidos.
            //Repita esta estrutura de IF / ELSE IF para as informações obrigatórias.
            if (txtNomeCliente.Text == string.Empty)
            {
                MessageBox.Show("Campo Nome obrigatório!", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Apontar o ponteiro do mouse para o campo
                txtNomeCliente.Focus();
                //Parar a execução do programa até esta linha
                return;
            }
            else if (mskTelefone.Text == string.Empty)
            {
                MessageBox.Show("Campo Número obrigatório!", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskTelefone.Focus();
                return;
            }
            else if (txtCodCliente.Text == string.Empty)
            {
                MessageBox.Show("Campo Código do Cliente obrigatório!", "Aviso",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Apontar o ponteiro do mouse para o campo
                txtCodCliente.Focus();
                //Parar a execução do programa até esta linha
                return;
            }
            else if (txtCodigoAnimal.Text == string.Empty)
            {
                MessageBox.Show("Campo Código do Animal obrigatório!", "Aviso",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Apontar o ponteiro do mouse para o campo
                txtCodigoAnimal.Focus();
                //Parar a execução do programa até esta linha
                return;
            }
            else if (mskRga.Text == string.Empty)
            {
                MessageBox.Show("Campo Rga do Animal obrigatório!", "Aviso",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Apontar o ponteiro do mouse para o campo
                mskRga.Focus();
                //Parar a execução do programa até esta linha
                return;
            }
            else if (mskCpf.Text == string.Empty)
            {
                MessageBox.Show("Campo Cpf obrigatório!", "Aviso",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Apontar o ponteiro do mouse para o campo
                mskCpf.Focus();
                //Parar a execução do programa até esta linha
                return;
            }
            //Armazenar as informações do formulário
            hotel.CodigoHotel = Convert.ToInt32(txtCodHotel.Text);
            hotel.Cpf = mskCpf.Text.Replace(".", "").Replace("-", "");
            hotel.Cliente = txtNomeCliente.Text;
            hotel.NomeAnimal = cboAnimal.Text;
            hotel.CodigoCliente = Convert.ToInt32(txtCodCliente.Text);
            hotel.CodigoAnimal = Convert.ToInt32(txtCodigoAnimal.Text);
            hotel.Telefone = mskTelefone.Text;
            hotel.DtEntrada = dtpEntrada.Value;
            hotel.DtRetorno = Convert.ToDateTime(dtpRetorno.Value);

            //Utilização do método AtualizarDados com os dados do cliente como parâmetro
            atualizarHospedagens.AtualizarDadosHotel(hotel);
            //Atualizar e configurar o DataGridView após atualização
            CarregarGridHotel();
            ConfigurarDataGrid();
            MessageBox.Show(hotel.Mensagem, "Aviso",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
        }
        // ------------------------------------------------------------------------------- //
        // Configurações dos TextBox do formulário
        private void txtCodCliente_TextChanged(object sender, EventArgs e)
        {
            cboAnimal.Items.Clear();

            if (txtCodCliente.Text == "")
            {
                Limpar();
                return;
            }

            HotelDTO hotel = new HotelDTO();
            ConsultarHospedagem consultarHospedagem = new ConsultarHospedagem();
            hotel.CodigoCliente = Convert.ToInt32(txtCodCliente.Text);
            consultarHospedagem.ConsultarDadosCliente(hotel);


            txtNomeCliente.Text = hotel.Cliente;
            mskCpf.Text = hotel.Cpf;
            mskTelefone.Text = hotel.Telefone;

            ArrayList listarAnimais = consultarHospedagem.ListarDadosHospedagem(hotel);
            foreach (var cbo in listarAnimais)
            {
                cboAnimal.Items.Add(cbo);
            }
        }
        // ------------------------------------------------------------------------------- //
        // Configurações das Cbo's do formulário
        private void cboAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            HotelDTO hotel = new HotelDTO();
            ConsultarHospedagem consultarHospedagem = new ConsultarHospedagem();
            consultarHospedagem.ListarDadosHospedagem(hotel);

            hotel.CodigoCliente = Convert.ToInt32(txtCodCliente.Text);
            hotel.NomeAnimal = cboAnimal.SelectedItem.ToString();

            consultarHospedagem.CompararTabela(hotel);

            txtTipoAnimal.Text = hotel.TipoAnimal;
            mskRga.Text = hotel.Rga;
            txtCodigoAnimal.Text = hotel.CodigoAnimal.ToString();

            /*txtNomeAnimal.Text = hotel.nomeanimal;
            mskRga.Text = hotel.rga;*/
        }
        // ------------------------------------------------------------------------------- //
        // Métodos
        public void Limpar()
        {
            txtCodCliente.Clear();
            txtNomeCliente.Clear();
            mskCpf.Clear();
            mskTelefone.Clear();
            cboAnimal.Items.Clear();
            mskRga.Clear();
            txtTipoAnimal.Clear();
            txtCodigoAnimal.Clear();
            cboAnimal.Items.Clear();
        }

        private void dgvListarHospedagens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
            btnHospedar.Enabled = true;
        }
    }
}
