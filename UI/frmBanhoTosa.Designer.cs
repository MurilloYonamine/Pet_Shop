
namespace UI
{
    partial class frmBanhoTosa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanhoTosa));
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.txtPesquisarNome = new System.Windows.Forms.TextBox();
            this.grpConfirmacao = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.grpAnaliseGeral = new System.Windows.Forms.GroupBox();
            this.txtCodigoAnalise = new System.Windows.Forms.TextBox();
            this.cboLesoes = new System.Windows.Forms.ComboBox();
            this.cboPulgaCarrapato = new System.Windows.Forms.ComboBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblPulgasCarrapatos = new System.Windows.Forms.Label();
            this.lblLesoes = new System.Windows.Forms.Label();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.grpServico = new System.Windows.Forms.GroupBox();
            this.txtCodigoServico = new System.Windows.Forms.TextBox();
            this.txtAlergia = new System.Windows.Forms.TextBox();
            this.lblAlergia = new System.Windows.Forms.Label();
            this.cboDesembolo = new System.Windows.Forms.ComboBox();
            this.cboTosa = new System.Windows.Forms.ComboBox();
            this.cboHidratacao = new System.Windows.Forms.ComboBox();
            this.cboBanho = new System.Windows.Forms.ComboBox();
            this.lblBanho = new System.Windows.Forms.Label();
            this.lblHidratacao = new System.Windows.Forms.Label();
            this.lblTosa = new System.Windows.Forms.Label();
            this.lblDesembolo = new System.Windows.Forms.Label();
            this.grpAgendamento = new System.Windows.Forms.GroupBox();
            this.txtCodigoAgendamento = new System.Windows.Forms.TextBox();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.rdoMasculino = new System.Windows.Forms.RadioButton();
            this.rdoFeminino = new System.Windows.Forms.RadioButton();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.txtNomeAnimal = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.lblResponsavel = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNomeAnimal = new System.Windows.Forms.Label();
            this.lblRaca = new System.Windows.Forms.Label();
            this.labelSexo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpConfirmacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.grpAnaliseGeral.SuspendLayout();
            this.grpServico.SuspendLayout();
            this.grpAgendamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisar.Location = new System.Drawing.Point(603, 264);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(125, 18);
            this.lblPesquisar.TabIndex = 29;
            this.lblPesquisar.Text = "Pesquisar Nome";
            // 
            // txtPesquisarNome
            // 
            this.txtPesquisarNome.Location = new System.Drawing.Point(731, 263);
            this.txtPesquisarNome.Name = "txtPesquisarNome";
            this.txtPesquisarNome.Size = new System.Drawing.Size(202, 20);
            this.txtPesquisarNome.TabIndex = 28;
            this.txtPesquisarNome.TextChanged += new System.EventHandler(this.txtPesquisarNome_TextChanged);
            // 
            // grpConfirmacao
            // 
            this.grpConfirmacao.BackColor = System.Drawing.Color.Linen;
            this.grpConfirmacao.Controls.Add(this.btnExcluir);
            this.grpConfirmacao.Controls.Add(this.btnAtualizar);
            this.grpConfirmacao.Controls.Add(this.btnLimpar);
            this.grpConfirmacao.Controls.Add(this.btnSalvar);
            this.grpConfirmacao.Controls.Add(this.button1);
            this.grpConfirmacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConfirmacao.ForeColor = System.Drawing.Color.Black;
            this.grpConfirmacao.Location = new System.Drawing.Point(754, 583);
            this.grpConfirmacao.Name = "grpConfirmacao";
            this.grpConfirmacao.Size = new System.Drawing.Size(193, 274);
            this.grpConfirmacao.TabIndex = 26;
            this.grpConfirmacao.TabStop = false;
            this.grpConfirmacao.Text = "Confirmação";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(19, 205);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(160, 51);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(19, 148);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(160, 51);
            this.btnAtualizar.TabIndex = 14;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnLimpar.Location = new System.Drawing.Point(19, 90);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(160, 51);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSalvar.Location = new System.Drawing.Point(19, 30);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(160, 51);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(517, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 51);
            this.button1.TabIndex = 12;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.GridColor = System.Drawing.Color.MistyRose;
            this.dgvDados.Location = new System.Drawing.Point(339, 289);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.Size = new System.Drawing.Size(594, 288);
            this.dgvDados.TabIndex = 25;
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellClick);
            // 
            // grpAnaliseGeral
            // 
            this.grpAnaliseGeral.BackColor = System.Drawing.Color.Linen;
            this.grpAnaliseGeral.Controls.Add(this.txtCodigoAnalise);
            this.grpAnaliseGeral.Controls.Add(this.cboLesoes);
            this.grpAnaliseGeral.Controls.Add(this.cboPulgaCarrapato);
            this.grpAnaliseGeral.Controls.Add(this.txtObservacao);
            this.grpAnaliseGeral.Controls.Add(this.lblPulgasCarrapatos);
            this.grpAnaliseGeral.Controls.Add(this.lblLesoes);
            this.grpAnaliseGeral.Controls.Add(this.lblObservacao);
            this.grpAnaliseGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAnaliseGeral.ForeColor = System.Drawing.Color.Black;
            this.grpAnaliseGeral.Location = new System.Drawing.Point(14, 583);
            this.grpAnaliseGeral.Name = "grpAnaliseGeral";
            this.grpAnaliseGeral.Size = new System.Drawing.Size(701, 274);
            this.grpAnaliseGeral.TabIndex = 24;
            this.grpAnaliseGeral.TabStop = false;
            this.grpAnaliseGeral.Text = "Análise Geral";
            // 
            // txtCodigoAnalise
            // 
            this.txtCodigoAnalise.Location = new System.Drawing.Point(668, 0);
            this.txtCodigoAnalise.Name = "txtCodigoAnalise";
            this.txtCodigoAnalise.Size = new System.Drawing.Size(33, 29);
            this.txtCodigoAnalise.TabIndex = 18;
            // 
            // cboLesoes
            // 
            this.cboLesoes.FormattingEnabled = true;
            this.cboLesoes.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cboLesoes.Location = new System.Drawing.Point(184, 107);
            this.cboLesoes.Name = "cboLesoes";
            this.cboLesoes.Size = new System.Drawing.Size(171, 32);
            this.cboLesoes.TabIndex = 11;
            // 
            // cboPulgaCarrapato
            // 
            this.cboPulgaCarrapato.FormattingEnabled = true;
            this.cboPulgaCarrapato.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cboPulgaCarrapato.Location = new System.Drawing.Point(184, 55);
            this.cboPulgaCarrapato.Name = "cboPulgaCarrapato";
            this.cboPulgaCarrapato.Size = new System.Drawing.Size(171, 32);
            this.cboPulgaCarrapato.TabIndex = 10;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(21, 194);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(630, 58);
            this.txtObservacao.TabIndex = 3;
            // 
            // lblPulgasCarrapatos
            // 
            this.lblPulgasCarrapatos.AutoSize = true;
            this.lblPulgasCarrapatos.Location = new System.Drawing.Point(16, 55);
            this.lblPulgasCarrapatos.Name = "lblPulgasCarrapatos";
            this.lblPulgasCarrapatos.Size = new System.Drawing.Size(162, 24);
            this.lblPulgasCarrapatos.TabIndex = 0;
            this.lblPulgasCarrapatos.Text = "Pulgas/Carrapatos";
            // 
            // lblLesoes
            // 
            this.lblLesoes.AutoSize = true;
            this.lblLesoes.Location = new System.Drawing.Point(107, 110);
            this.lblLesoes.Name = "lblLesoes";
            this.lblLesoes.Size = new System.Drawing.Size(71, 24);
            this.lblLesoes.TabIndex = 1;
            this.lblLesoes.Text = "Lesões";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(16, 165);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(122, 24);
            this.lblObservacao.TabIndex = 2;
            this.lblObservacao.Text = "Observações";
            // 
            // grpServico
            // 
            this.grpServico.BackColor = System.Drawing.Color.Linen;
            this.grpServico.Controls.Add(this.txtCodigoServico);
            this.grpServico.Controls.Add(this.txtAlergia);
            this.grpServico.Controls.Add(this.lblAlergia);
            this.grpServico.Controls.Add(this.cboDesembolo);
            this.grpServico.Controls.Add(this.cboTosa);
            this.grpServico.Controls.Add(this.cboHidratacao);
            this.grpServico.Controls.Add(this.cboBanho);
            this.grpServico.Controls.Add(this.lblBanho);
            this.grpServico.Controls.Add(this.lblHidratacao);
            this.grpServico.Controls.Add(this.lblTosa);
            this.grpServico.Controls.Add(this.lblDesembolo);
            this.grpServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpServico.ForeColor = System.Drawing.Color.Black;
            this.grpServico.Location = new System.Drawing.Point(14, 289);
            this.grpServico.Name = "grpServico";
            this.grpServico.Size = new System.Drawing.Size(312, 288);
            this.grpServico.TabIndex = 23;
            this.grpServico.TabStop = false;
            this.grpServico.Text = "Serviço";
            // 
            // txtCodigoServico
            // 
            this.txtCodigoServico.Location = new System.Drawing.Point(279, 0);
            this.txtCodigoServico.Name = "txtCodigoServico";
            this.txtCodigoServico.Size = new System.Drawing.Size(33, 29);
            this.txtCodigoServico.TabIndex = 17;
            // 
            // txtAlergia
            // 
            this.txtAlergia.Location = new System.Drawing.Point(129, 215);
            this.txtAlergia.Multiline = true;
            this.txtAlergia.Name = "txtAlergia";
            this.txtAlergia.Size = new System.Drawing.Size(171, 49);
            this.txtAlergia.TabIndex = 11;
            // 
            // lblAlergia
            // 
            this.lblAlergia.AutoSize = true;
            this.lblAlergia.Location = new System.Drawing.Point(47, 219);
            this.lblAlergia.Name = "lblAlergia";
            this.lblAlergia.Size = new System.Drawing.Size(69, 24);
            this.lblAlergia.TabIndex = 10;
            this.lblAlergia.Text = "Alergia";
            // 
            // cboDesembolo
            // 
            this.cboDesembolo.FormattingEnabled = true;
            this.cboDesembolo.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cboDesembolo.Location = new System.Drawing.Point(129, 169);
            this.cboDesembolo.Name = "cboDesembolo";
            this.cboDesembolo.Size = new System.Drawing.Size(171, 32);
            this.cboDesembolo.TabIndex = 9;
            // 
            // cboTosa
            // 
            this.cboTosa.FormattingEnabled = true;
            this.cboTosa.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cboTosa.Location = new System.Drawing.Point(129, 128);
            this.cboTosa.Name = "cboTosa";
            this.cboTosa.Size = new System.Drawing.Size(171, 32);
            this.cboTosa.TabIndex = 8;
            // 
            // cboHidratacao
            // 
            this.cboHidratacao.FormattingEnabled = true;
            this.cboHidratacao.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cboHidratacao.Location = new System.Drawing.Point(129, 84);
            this.cboHidratacao.Name = "cboHidratacao";
            this.cboHidratacao.Size = new System.Drawing.Size(171, 32);
            this.cboHidratacao.TabIndex = 7;
            // 
            // cboBanho
            // 
            this.cboBanho.FormattingEnabled = true;
            this.cboBanho.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cboBanho.Location = new System.Drawing.Point(129, 38);
            this.cboBanho.Name = "cboBanho";
            this.cboBanho.Size = new System.Drawing.Size(171, 32);
            this.cboBanho.TabIndex = 6;
            // 
            // lblBanho
            // 
            this.lblBanho.AutoSize = true;
            this.lblBanho.Location = new System.Drawing.Point(51, 41);
            this.lblBanho.Name = "lblBanho";
            this.lblBanho.Size = new System.Drawing.Size(65, 24);
            this.lblBanho.TabIndex = 0;
            this.lblBanho.Text = "Banho";
            // 
            // lblHidratacao
            // 
            this.lblHidratacao.AutoSize = true;
            this.lblHidratacao.Location = new System.Drawing.Point(23, 87);
            this.lblHidratacao.Name = "lblHidratacao";
            this.lblHidratacao.Size = new System.Drawing.Size(100, 24);
            this.lblHidratacao.TabIndex = 1;
            this.lblHidratacao.Text = "Hidratação";
            // 
            // lblTosa
            // 
            this.lblTosa.AutoSize = true;
            this.lblTosa.Location = new System.Drawing.Point(64, 131);
            this.lblTosa.Name = "lblTosa";
            this.lblTosa.Size = new System.Drawing.Size(52, 24);
            this.lblTosa.TabIndex = 2;
            this.lblTosa.Text = "Tosa";
            // 
            // lblDesembolo
            // 
            this.lblDesembolo.AutoSize = true;
            this.lblDesembolo.Location = new System.Drawing.Point(9, 172);
            this.lblDesembolo.Name = "lblDesembolo";
            this.lblDesembolo.Size = new System.Drawing.Size(107, 24);
            this.lblDesembolo.TabIndex = 3;
            this.lblDesembolo.Text = "Desembolo";
            // 
            // grpAgendamento
            // 
            this.grpAgendamento.BackColor = System.Drawing.Color.Linen;
            this.grpAgendamento.Controls.Add(this.txtCodigoAgendamento);
            this.grpAgendamento.Controls.Add(this.dtpHora);
            this.grpAgendamento.Controls.Add(this.label14);
            this.grpAgendamento.Controls.Add(this.lblData);
            this.grpAgendamento.Controls.Add(this.rdoMasculino);
            this.grpAgendamento.Controls.Add(this.rdoFeminino);
            this.grpAgendamento.Controls.Add(this.txtRaca);
            this.grpAgendamento.Controls.Add(this.txtNomeAnimal);
            this.grpAgendamento.Controls.Add(this.txtTelefone);
            this.grpAgendamento.Controls.Add(this.txtResponsavel);
            this.grpAgendamento.Controls.Add(this.lblResponsavel);
            this.grpAgendamento.Controls.Add(this.lblTelefone);
            this.grpAgendamento.Controls.Add(this.lblNomeAnimal);
            this.grpAgendamento.Controls.Add(this.lblRaca);
            this.grpAgendamento.Controls.Add(this.labelSexo);
            this.grpAgendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAgendamento.ForeColor = System.Drawing.Color.Black;
            this.grpAgendamento.Location = new System.Drawing.Point(14, 10);
            this.grpAgendamento.Name = "grpAgendamento";
            this.grpAgendamento.Size = new System.Drawing.Size(583, 268);
            this.grpAgendamento.TabIndex = 22;
            this.grpAgendamento.TabStop = false;
            this.grpAgendamento.Text = "Agendamento";
            // 
            // txtCodigoAgendamento
            // 
            this.txtCodigoAgendamento.Location = new System.Drawing.Point(548, 0);
            this.txtCodigoAgendamento.Name = "txtCodigoAgendamento";
            this.txtCodigoAgendamento.Size = new System.Drawing.Size(35, 29);
            this.txtCodigoAgendamento.TabIndex = 16;
            // 
            // dtpHora
            // 
            this.dtpHora.Location = new System.Drawing.Point(160, 219);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(374, 29);
            this.dtpHora.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(417, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 24);
            this.label14.TabIndex = 14;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(97, 223);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(47, 24);
            this.lblData.TabIndex = 12;
            this.lblData.Text = "Data";
            // 
            // rdoMasculino
            // 
            this.rdoMasculino.AutoSize = true;
            this.rdoMasculino.Location = new System.Drawing.Point(407, 130);
            this.rdoMasculino.Name = "rdoMasculino";
            this.rdoMasculino.Size = new System.Drawing.Size(44, 30);
            this.rdoMasculino.TabIndex = 11;
            this.rdoMasculino.TabStop = true;
            this.rdoMasculino.Text = "M";
            this.rdoMasculino.UseVisualStyleBackColor = true;
            // 
            // rdoFeminino
            // 
            this.rdoFeminino.AutoSize = true;
            this.rdoFeminino.Location = new System.Drawing.Point(361, 130);
            this.rdoFeminino.Name = "rdoFeminino";
            this.rdoFeminino.Size = new System.Drawing.Size(40, 30);
            this.rdoFeminino.TabIndex = 10;
            this.rdoFeminino.TabStop = true;
            this.rdoFeminino.Text = "F";
            this.rdoFeminino.UseVisualStyleBackColor = true;
            // 
            // txtRaca
            // 
            this.txtRaca.Location = new System.Drawing.Point(160, 173);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(291, 29);
            this.txtRaca.TabIndex = 9;
            // 
            // txtNomeAnimal
            // 
            this.txtNomeAnimal.Location = new System.Drawing.Point(165, 127);
            this.txtNomeAnimal.Name = "txtNomeAnimal";
            this.txtNomeAnimal.Size = new System.Drawing.Size(120, 29);
            this.txtNomeAnimal.TabIndex = 8;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(165, 81);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(286, 29);
            this.txtTelefone.TabIndex = 7;
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.Location = new System.Drawing.Point(165, 36);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.Size = new System.Drawing.Size(286, 29);
            this.txtResponsavel.TabIndex = 6;
            // 
            // lblResponsavel
            // 
            this.lblResponsavel.AutoSize = true;
            this.lblResponsavel.Location = new System.Drawing.Point(36, 41);
            this.lblResponsavel.Name = "lblResponsavel";
            this.lblResponsavel.Size = new System.Drawing.Size(119, 24);
            this.lblResponsavel.TabIndex = 0;
            this.lblResponsavel.Text = "Responsável";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(64, 86);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(85, 24);
            this.lblTelefone.TabIndex = 1;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblNomeAnimal
            // 
            this.lblNomeAnimal.AutoSize = true;
            this.lblNomeAnimal.Location = new System.Drawing.Point(7, 130);
            this.lblNomeAnimal.Name = "lblNomeAnimal";
            this.lblNomeAnimal.Size = new System.Drawing.Size(152, 24);
            this.lblNomeAnimal.TabIndex = 2;
            this.lblNomeAnimal.Text = "Nome do Animal";
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.Location = new System.Drawing.Point(93, 179);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(53, 24);
            this.lblRaca.TabIndex = 3;
            this.lblRaca.Text = "Raça";
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(301, 130);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(54, 24);
            this.labelSexo.TabIndex = 5;
            this.labelSexo.Text = "Sexo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(693, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 223);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // frmBanhoTosa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 874);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.txtPesquisarNome);
            this.Controls.Add(this.grpConfirmacao);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.grpAnaliseGeral);
            this.Controls.Add(this.grpServico);
            this.Controls.Add(this.grpAgendamento);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBanhoTosa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banho e Tosa";
            this.Load += new System.EventHandler(this.frmBanhoTosa_Load);
            this.grpConfirmacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.grpAnaliseGeral.ResumeLayout(false);
            this.grpAnaliseGeral.PerformLayout();
            this.grpServico.ResumeLayout(false);
            this.grpServico.PerformLayout();
            this.grpAgendamento.ResumeLayout(false);
            this.grpAgendamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TextBox txtPesquisarNome;
        private System.Windows.Forms.GroupBox grpConfirmacao;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.GroupBox grpAnaliseGeral;
        private System.Windows.Forms.TextBox txtCodigoAnalise;
        private System.Windows.Forms.ComboBox cboLesoes;
        private System.Windows.Forms.ComboBox cboPulgaCarrapato;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblPulgasCarrapatos;
        private System.Windows.Forms.Label lblLesoes;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.GroupBox grpServico;
        private System.Windows.Forms.TextBox txtCodigoServico;
        private System.Windows.Forms.TextBox txtAlergia;
        private System.Windows.Forms.Label lblAlergia;
        private System.Windows.Forms.ComboBox cboDesembolo;
        private System.Windows.Forms.ComboBox cboTosa;
        private System.Windows.Forms.ComboBox cboHidratacao;
        private System.Windows.Forms.ComboBox cboBanho;
        private System.Windows.Forms.Label lblBanho;
        private System.Windows.Forms.Label lblHidratacao;
        private System.Windows.Forms.Label lblTosa;
        private System.Windows.Forms.Label lblDesembolo;
        private System.Windows.Forms.GroupBox grpAgendamento;
        private System.Windows.Forms.TextBox txtCodigoAgendamento;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.RadioButton rdoMasculino;
        private System.Windows.Forms.RadioButton rdoFeminino;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.TextBox txtNomeAnimal;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtResponsavel;
        private System.Windows.Forms.Label lblResponsavel;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNomeAnimal;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.Label labelSexo;
    }
}