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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        // ------------------------------------------------------------------------------- //
        // Configurações dos botões do formulário
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            prgLogin.MarqueeAnimationSpeed = 1;
            prgLogin.Maximum = 10000;
            for (int i = 0; i < 10000; i++)
            {
                prgLogin.PerformStep();
                prgLogin.MarqueeAnimationSpeed += i;
            }

            //Instância das Classes
            LoginDTO login = new LoginDTO();
            AcessoLogin acessoLogin = new AcessoLogin();
            //Armazenar Login e Senha do formulário
            login.Usuario = txtUsuario.Text;
            login.Senha = txtSenha.Text;
            //Execução do método Acessar
            acessoLogin.Acessar(login);
            //Verificar se o status é Logado = 1
            if (login.Logado == 1)
            {
                MessageBox.Show(login.Mensagem, "Aviso");

                //Atualizar o Status do usuário em tb_usuario
                AtualizarLogon atualizarLogon = new AtualizarLogon();
                atualizarLogon.AtualizarLogado(login);

                //Fechar Formulário de Login se usuário e senha estiverem corretos
                Close();
            }
            else
            {
                MessageBox.Show(login.Mensagem, "Aviso");
                txtUsuario.Clear();
                txtSenha.Clear();
                txtUsuario.Focus();
            }
        }
    }
}
