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
    public partial class frmTaxiDog : Form
    {
        // ------------------------------------------------------------------------------- //
        // Inicialização do formulário
        public frmTaxiDog()
        {
            InitializeComponent();
        }
        private void frmTaxiDog_Load(object sender, EventArgs e)
        {
            TaxiDogDTO taxiDog = new TaxiDogDTO();
            ConsultarAgendamento consultarAgendamento = new ConsultarAgendamento();

            consultarAgendamento.ConsultarCodigoTaxi(taxiDog);
            txtCodTaxi.Text = taxiDog.CodigoTaxi.ToString();
            CarregarGridTaxi();
            ConfigurarDataGridTaxi();
        }
        // ------------------------------------------------------------------------------- //
        // Formatação da DataGridView
        private void dgvAgendamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Evitar o erro no clique dos títulos (linha -1)
            if (e.RowIndex >= 0)
            {
                //TextBox = DataGridView.LinhaSelecionada.Célula[Posição].Valor.ParaTexto]
                txtCodTaxi.Text = dgvAgendamentos.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCodCliente.Text = dgvAgendamentos.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCodAnimal.Text = dgvAgendamentos.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpAgendamento.Value = Convert.ToDateTime(dgvAgendamentos.Rows[e.RowIndex].Cells[3].Value);
                /*chkPetCare.Text = dgvAgendamentos.Rows[e.RowIndex].Cells[4].Value.ToString();
                chkPetVet.Text = dgvAgendamentos.Rows[e.RowIndex].Cells[5].Value.ToString();
                cboHorario.Text = dgvAgendamentos.Rows[e.RowIndex].Cells[6].Value.ToString();*/

                btnEditar.Visible = true; //Ou enable
                btnAgendar.Enabled = false;
                
            }
        }
        public void ConfigurarDataGridTaxi()
        {
            //Verificar se o DataGridView contém linhas
            if (dgvAgendamentos.Rows.Count != 0)
            {
                //Renomear o cabeçalho das colunas no DataGridView
                dgvAgendamentos.Columns[0].HeaderText = "TaxiDog";
                dgvAgendamentos.Columns[1].HeaderText = "Cliente";
                dgvAgendamentos.Columns[2].HeaderText = "Animal";
                dgvAgendamentos.Columns[3].HeaderText = "Data de Agendamento";
                dgvAgendamentos.Columns[4].HeaderText = "PetCare";
                dgvAgendamentos.Columns[5].HeaderText = "PetVet";
                dgvAgendamentos.Columns[6].HeaderText = "Horário de Agendamento";
                //Configurar a largura das colunas no DataGridView
                dgvAgendamentos.Columns[0].Width = 70;
                dgvAgendamentos.Columns[1].Width = 70;
                dgvAgendamentos.Columns[2].Width = 70;
                dgvAgendamentos.Columns[3].Width = 96;
                dgvAgendamentos.Columns[4].Width = 96;
                dgvAgendamentos.Columns[5].Width = 96;
                dgvAgendamentos.Columns[6].Width = 96;
                //Alinhar o conteúdo das colunas
                dgvAgendamentos.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            }
        }
        public void CarregarGridTaxi()
        {
            ConsultarAgendamento consultarAgendamento = new ConsultarAgendamento();
            TaxiDogDTO taxiDog = new TaxiDogDTO();
            dgvAgendamentos.DataSource = consultarAgendamento.ListarDadosTaxiDog(taxiDog);
            if (!string.IsNullOrEmpty(taxiDog.Mensagem))
            {
                MessageBox.Show(taxiDog.Mensagem);
            }
        }
        // ------------------------------------------------------------------------------- //
        // TexteBox e ComboBox
        private void txtCodCliente_TextChanged(object sender, EventArgs e)
        {
            cboAnimal.Items.Clear();

            if (txtCodCliente.Text == "")
            {
                Limpar();
                return;
            }
            TaxiDogDTO taxiDog = new TaxiDogDTO();
            ConsultarAgendamento consultarAgendamento = new ConsultarAgendamento();
            taxiDog.CodigoCliente = Convert.ToInt32(txtCodCliente.Text);
            consultarAgendamento.ConsultarDadosCliente(taxiDog);


            txtNomeCliente.Text = taxiDog.Cliente;
            mskCpf.Text = taxiDog.Cpf;
            mskTelefone.Text = taxiDog.Telefone;

            ArrayList listaanimais = consultarAgendamento.ListarDadosAgendamento(taxiDog);
            foreach (var cbo in listaanimais)
            {
                cboAnimal.Items.Add(cbo);
            }
        }
        private void cboAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaxiDogDTO taxiDog = new TaxiDogDTO();
            ConsultarAgendamento consultarAgendamento = new ConsultarAgendamento();

            consultarAgendamento.ListarDadosAgendamento(taxiDog);
            taxiDog.CodigoCliente = Convert.ToInt32(txtCodCliente.Text);
            taxiDog.NomeAnimal = cboAnimal.SelectedItem.ToString();
            consultarAgendamento.CompararTabela(taxiDog);
            txtTipoAnimal.Text = taxiDog.TipoAnimal;
            mskRga.Text = taxiDog.Rga;
            txtCodAnimal.Text = taxiDog.CodigoAnimal.ToString();
        }
        // ------------------------------------------------------------------------------- //
        // Botões
        private void btnAgendar_Click(object sender, EventArgs e)
        {
            TaxiDogDTO taxiDog = new TaxiDogDTO();
            SalvarAgendamento salvarAgendamento = new SalvarAgendamento();

            if (txtNomeCliente.Text == "" || mskCpf.Text == "" || txtCodCliente.Text == "" || txtTipoAnimal.Text == "" || mskRga.Text == "" || txtCodAnimal.Text == "" ||
                cboHorario.Text == "")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos", "Aviso");
            }
            else
            {
                taxiDog.Cliente = txtNomeCliente.Text;
                taxiDog.Cpf = mskCpf.Text;
                taxiDog.Telefone = mskTelefone.Text;
                taxiDog.CodigoCliente = Convert.ToInt32(txtCodCliente.Text);
                taxiDog.NomeAnimal = txtTipoAnimal.Text;
                taxiDog.Rga = mskRga.Text;
                //hotel.animal = cboAnimal.Text;
                taxiDog.DtAgendamento = dtpAgendamento.Value;
                taxiDog.CodigoAnimal = Convert.ToInt32(txtCodAnimal.Text);
                taxiDog.Horario = cboHorario.Text;
                if (chkPetCare.Checked)
                {
                    taxiDog.Petcare = "Sim";
                    salvarAgendamento.InserirAgendamento(taxiDog);
                }
                else
                {
                    taxiDog.Petcare = "Não";
                    salvarAgendamento.InserirAgendamento(taxiDog);
                }

                if (chkPetVet.Checked)
                {
                    taxiDog.Petvet = "Sim";
                    salvarAgendamento.InserirAgendamento(taxiDog);
                }
                else
                {
                    taxiDog.Petvet = "Não";
                    salvarAgendamento.InserirAgendamento(taxiDog);
                }
                MessageBox.Show(taxiDog.Mensagem, "Aviso", MessageBoxButtons.OK);
                CarregarGridTaxi();
            }
        }
        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            frmAnimais Tela = new frmAnimais();
            Tela.Show();
        }
        private void btnCadastrarAnimal_Click(object sender, EventArgs e)
        {
            frmClientes Tela = new frmClientes();
            Tela.Show();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Instância das classes AtualizarClientes e ClientesDTO
            AtualizarAgendamento atualizarAgendamento = new AtualizarAgendamento();
            TaxiDogDTO taxiDog = new TaxiDogDTO();
            SalvarAgendamento salvarAgendamento = new SalvarAgendamento();
            //Verificar se determinados campos foram preenchidos.
            //Repita esta estrutura de IF / ELSE IF para as informações obrigatórias.
            if (txtCodCliente.Text == string.Empty)
            {
                MessageBox.Show("Campo Código do Cliente obrigatório!", "Aviso",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Apontar o ponteiro do mouse para o campo
                txtCodCliente.Focus();
                //Parar a execução do programa até esta linha
                return;
            }
            else if (txtCodAnimal.Text == string.Empty)
            {
                MessageBox.Show("Campo Código do Animal obrigatório!", "Aviso",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Apontar o ponteiro do mouse para o campo
                txtCodAnimal.Focus();
                //Parar a execução do programa até esta linha
                return;
            }
            else if (cboHorario.Text == "")
            {
                MessageBox.Show("Campo do horário obrigatório!", "Aviso",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Apontar o ponteiro do mouse para o campo
                cboHorario.Focus();
                //Parar a execução do programa até esta linha
                return;
            }
            else if (cboAnimal.Text == "")
            {
                MessageBox.Show("Campo do animal obrigatório!", "Aviso",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Apontar o ponteiro do mouse para o campo
                cboAnimal.Focus();
                //Parar a execução do programa até esta linha
                return;
            }


            //Armazenar as informações do formulário
            taxiDog.CodigoTaxi = Convert.ToInt32(txtCodTaxi.Text);
            taxiDog.Cpf = mskCpf.Text.Replace(".", "").Replace("-", "");
            taxiDog.Cliente = txtNomeCliente.Text;
            taxiDog.NomeAnimal = cboAnimal.Text;
            taxiDog.CodigoCliente = Convert.ToInt32(txtCodCliente.Text);
            taxiDog.CodigoAnimal = Convert.ToInt32(txtCodAnimal.Text);
            taxiDog.Telefone = mskTelefone.Text;
            taxiDog.DtAgendamento = dtpAgendamento.Value;
            taxiDog.Horario = cboHorario.Text;
            taxiDog.TipoAnimal = txtTipoAnimal.Text;
            taxiDog.Rga = mskRga.Text;
            if (chkPetCare.Checked)
            {
                taxiDog.Petcare = "Sim";
                salvarAgendamento.InserirAgendamento(taxiDog);
            }
            else
            {
                taxiDog.Petcare = "Não";
                salvarAgendamento.InserirAgendamento(taxiDog);
            }

            if (chkPetVet.Checked)
            {
                taxiDog.Petvet = "Sim";
                salvarAgendamento.InserirAgendamento(taxiDog);
            }
            else
            {
                taxiDog.Petvet = "Não";
                salvarAgendamento.InserirAgendamento(taxiDog);
            }


            //Utilização do método AtualizarDados com os dados do cliente como parâmetro
            atualizarAgendamento.AtualizarDadosTaxiDog(taxiDog);
            //Atualizar e configurar o DataGridView após atualização
            CarregarGridTaxi();
            ConfigurarDataGridTaxi();
            MessageBox.Show(taxiDog.Mensagem, "Aviso",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
        // ------------------------------------------------------------------------------- //
        // Métodos
        public void Limpar()
        {
            txtCodCliente.Clear();
            txtNomeCliente.Clear();
            mskCpf.Clear();
            mskTelefone.Clear();
            cboAnimal.Text = "";
            mskRga.Clear();
            txtTipoAnimal.Clear();
            txtCodAnimal.Clear();
            cboAnimal.Items.Clear();
            cboHorario.Items.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
            btnAgendar.Enabled = true;
        }
    }
}
