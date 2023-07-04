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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            LoginUsuario();
        }

        // ------------------------------------------------------------------------------- //
        // Abrir os formulários no MDI
        private void mnuClientes_Click(object sender, EventArgs e)
        {
            // Instância dos formulários
            frmClientes formFilho = new frmClientes();

            // Envia o formulário frmClientes como parâmetro
            AbrirFormulario(formFilho);
            lblTitulo.Text = "Cadastro de Clientes";
        }
        private void mnuAnimais_Click(object sender, EventArgs e)
        {
            // Instância dos formulários
            frmAnimais formFilho = new frmAnimais();

            // Envia o formulário frmClientes como parâmetro
            AbrirFormulario(formFilho);
            lblTitulo.Text = "Cadastro de Animais";
        }
        private void mnuConexao_Click(object sender, EventArgs e)
        {
            // Instância dos formulários
            frmTesteConexao formFilho = new frmTesteConexao();

            // Envia o formulário frmClientes como parâmetro
            AbrirFormulario(formFilho);
            lblTitulo.Text = "Teste de Conexão";
        }
        private void mnuDiskRacao_Click(object sender, EventArgs e)
        {
            // Instância dos formulários
            frmDiskRacao formFilho = new frmDiskRacao();

            // Envia o formulário frmClientes como parâmetro
            AbrirFormulario(formFilho);
            lblTitulo.Text = "Disk Ração";
        }

        private void mnuHotel_Click(object sender, EventArgs e)
        {
            // Instância dos formulários
            frmHotel formFilho = new frmHotel();

            // Envia o formulário frmClientes como parâmetro
            AbrirFormulario(formFilho);
            lblTitulo.Text = "Hotel";
        }
        private void mnuTaxiDog_Click(object sender, EventArgs e)
        {
            // Instância dos formulários
            frmTaxiDog formFilho = new frmTaxiDog();

            // Envia o formulário frmClientes como parâmetro
            AbrirFormulario(formFilho);
            lblTitulo.Text = "Taxi Dog";
        }
        public void LoginUsuario()
        {
            // Instância do frmLogin
            frmLogin formFilho = new frmLogin();

            // Inicia o formulário login
            AbrirFormulario(formFilho);

            // Registra o evento de fechamento do frmLogin
            formFilho.FormClosed += new FormClosedEventHandler(formFilho_FormClosed);
        }
        // ------------------------------------------------------------------------------- //
        //Procedimento para abrir os formulários filhos
        public void AbrirFormulario(Form formFilho)
        {
            //Fechar formulário aberto anteriormente
            fecharFormulario();
            //Definir o formulário passado como parâmetro será
            //filho do formulário principal (this)
            formFilho.MdiParent = this;
            //Define a posição inicial do formulário
            formFilho.StartPosition = FormStartPosition.CenterScreen;
            //Remove a borda do formulário para não ser movimentado
            formFilho.FormBorderStyle = FormBorderStyle.None;
            //Exibe o formulário para o usuário
            formFilho.Show();
        }
        // ------------------------------------------------------------------------------- //
        //Procedimento para fechar os formulários filhos
        public void fecharFormulario()
        {
            //Para cada formulário MDI aberto como formulário filho
            //MdiChildren = histórico de formulário filhos
            //foreach (variável que irá substituir em outra variável
            //Conversão de cada valor do vetor em variável comum
            //Vetor varável[x, y, z]
            foreach (Form formFilhoMdi in MdiChildren)
            {
                formFilhoMdi.Close();
            }
        }
        // ------------------------------------------------------------------------------- //
        // Fechar a aplicação
        private void mnuSair_Click(object sender, EventArgs e)
        {
            // Variável que receberá a escolha do usuário Yes ou No
            DialogResult sair = MessageBox.Show($"Deseja sair da aplicação?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // É verificado se o resultado da escolha é YES
            if (sair == DialogResult.Yes)
            {
                //Instância das Classes
                LoginDTO login = new LoginDTO();
                AcessoLogin acessoLogin = new AcessoLogin();
                AtualizarLogon atualizaLogon = new AtualizarLogon();
                //Armazena o usuário que realizou o login
                login.Usuario = acessoLogin.VerificarLogado(login);
                //Altera o status do usuário para 0 na tabela tb_usuario
                login.Logado = 0;
                atualizaLogon.AtualizarLogado(login);
                //Encerra a aplicação.
                Application.Exit();
            }
        }
        public void formFilho_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Habilita o menu do formulário Principal
            mnuPrincipal.Enabled = true;

            // Instanciar as classes
            AcessoLogin acessoLogin = new AcessoLogin();
            LoginDTO login = new LoginDTO();

            // Verificar e atribuir o usuário logado com data ao cabeçalho do form Principal
            this.Text += " - " + acessoLogin.VerificarLogado(login) + " - " + "Acesso em: " + DateTime.Now.ToString("g");
        }
        // ------------------------------------------------------------------------------- //
        // Ao fechar o formulário de login, executa esse procedimento
        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Instância das Classes
            LoginDTO login = new LoginDTO();
            AcessoLogin acessoLogin = new AcessoLogin();
            AtualizarLogon atualizaLogon = new AtualizarLogon();
            //Armazena o usuário que realizou o login
            login.Usuario = acessoLogin.VerificarLogado(login);
            //Altera o status do usuário para 0 na tabela tb_usuario
            login.Logado = 0;
            atualizaLogon.AtualizarLogado(login);
            //Encerra a aplicação.
            Close();

        }


    }
}
