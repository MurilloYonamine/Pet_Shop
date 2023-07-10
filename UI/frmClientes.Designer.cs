
namespace UI
{
    partial class frmClientes
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.lblUf = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.rdoFeminino = new System.Windows.Forms.RadioButton();
            this.rdoMasculino = new System.Windows.Forms.RadioButton();
            this.rdoOutros = new System.Windows.Forms.RadioButton();
            this.txtOutros = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.dgvListaClientes = new System.Windows.Forms.DataGridView();
            this.txtPesquisaNome = new System.Windows.Forms.TextBox();
            this.lblPesquisaNome = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnPesquisarCep = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.picBgDog = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBgDog)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.lblCodigo.Location = new System.Drawing.Point(495, 52);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(64, 18);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(498, 73);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(146, 26);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(666, 73);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(270, 26);
            this.txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.lblNome.Location = new System.Drawing.Point(663, 52);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(54, 18);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.lblCep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.lblCep.Location = new System.Drawing.Point(495, 188);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(46, 18);
            this.lblCep.TabIndex = 5;
            this.lblCep.Text = "CEP:";
            // 
            // txtUf
            // 
            this.txtUf.BackColor = System.Drawing.Color.White;
            this.txtUf.Location = new System.Drawing.Point(868, 278);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(68, 26);
            this.txtUf.TabIndex = 8;
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.lblUf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.lblUf.Location = new System.Drawing.Point(865, 257);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(33, 18);
            this.lblUf.TabIndex = 7;
            this.lblUf.Text = "UF:";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.White;
            this.txtNumero.Location = new System.Drawing.Point(860, 344);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(76, 26);
            this.txtNumero.TabIndex = 10;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.lblNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.lblNumero.Location = new System.Drawing.Point(857, 323);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(28, 18);
            this.lblNumero.TabIndex = 9;
            this.lblNumero.Text = "Nº:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(698, 139);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(238, 26);
            this.txtEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.lblEmail.Location = new System.Drawing.Point(695, 118);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 18);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "E-mail:";
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.White;
            this.txtBairro.Location = new System.Drawing.Point(498, 344);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(331, 26);
            this.txtBairro.TabIndex = 9;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.lblBairro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.lblBairro.Location = new System.Drawing.Point(495, 323);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(55, 18);
            this.lblBairro.TabIndex = 13;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.Color.White;
            this.txtCidade.Location = new System.Drawing.Point(498, 278);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(343, 26);
            this.txtCidade.TabIndex = 7;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.lblCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.lblCidade.Location = new System.Drawing.Point(495, 257);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(64, 18);
            this.lblCidade.TabIndex = 15;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.lblTelefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.lblTelefone.Location = new System.Drawing.Point(495, 386);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(70, 18);
            this.lblTelefone.TabIndex = 17;
            this.lblTelefone.Text = "Telefone:";
            // 
            // mskTelefone
            // 
            this.mskTelefone.BackColor = System.Drawing.Color.White;
            this.mskTelefone.Location = new System.Drawing.Point(498, 407);
            this.mskTelefone.Mask = "(00) 00000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(188, 26);
            this.mskTelefone.TabIndex = 11;
            // 
            // mskCep
            // 
            this.mskCep.BackColor = System.Drawing.Color.White;
            this.mskCep.Location = new System.Drawing.Point(498, 209);
            this.mskCep.Mask = "00000-000";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(131, 26);
            this.mskCep.TabIndex = 5;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.lblComplemento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.lblComplemento.Location = new System.Drawing.Point(719, 386);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(110, 18);
            this.lblComplemento.TabIndex = 19;
            this.lblComplemento.Text = "Complemento:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.BackColor = System.Drawing.Color.White;
            this.txtComplemento.Location = new System.Drawing.Point(722, 407);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(214, 26);
            this.txtComplemento.TabIndex = 12;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.lblGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.lblGenero.Location = new System.Drawing.Point(495, 451);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(64, 18);
            this.lblGenero.TabIndex = 21;
            this.lblGenero.Text = "Gênero:";
            // 
            // rdoFeminino
            // 
            this.rdoFeminino.AutoSize = true;
            this.rdoFeminino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.rdoFeminino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.rdoFeminino.Location = new System.Drawing.Point(498, 472);
            this.rdoFeminino.Name = "rdoFeminino";
            this.rdoFeminino.Size = new System.Drawing.Size(91, 22);
            this.rdoFeminino.TabIndex = 13;
            this.rdoFeminino.TabStop = true;
            this.rdoFeminino.Text = "Feminino";
            this.rdoFeminino.UseVisualStyleBackColor = false;
            // 
            // rdoMasculino
            // 
            this.rdoMasculino.AutoSize = true;
            this.rdoMasculino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.rdoMasculino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.rdoMasculino.Location = new System.Drawing.Point(596, 472);
            this.rdoMasculino.Name = "rdoMasculino";
            this.rdoMasculino.Size = new System.Drawing.Size(96, 22);
            this.rdoMasculino.TabIndex = 14;
            this.rdoMasculino.TabStop = true;
            this.rdoMasculino.Text = "Masculino";
            this.rdoMasculino.UseVisualStyleBackColor = false;
            // 
            // rdoOutros
            // 
            this.rdoOutros.AutoSize = true;
            this.rdoOutros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.rdoOutros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.rdoOutros.Location = new System.Drawing.Point(698, 472);
            this.rdoOutros.Name = "rdoOutros";
            this.rdoOutros.Size = new System.Drawing.Size(72, 22);
            this.rdoOutros.TabIndex = 15;
            this.rdoOutros.TabStop = true;
            this.rdoOutros.Text = "Outros";
            this.rdoOutros.UseVisualStyleBackColor = false;
            this.rdoOutros.CheckedChanged += new System.EventHandler(this.rdoOutros_CheckedChanged);
            // 
            // txtOutros
            // 
            this.txtOutros.BackColor = System.Drawing.Color.White;
            this.txtOutros.Location = new System.Drawing.Point(776, 468);
            this.txtOutros.Name = "txtOutros";
            this.txtOutros.Size = new System.Drawing.Size(160, 26);
            this.txtOutros.TabIndex = 16;
            this.txtOutros.Visible = false;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.lblCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.lblCpf.Location = new System.Drawing.Point(495, 118);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(45, 18);
            this.lblCpf.TabIndex = 25;
            this.lblCpf.Text = "CPF:";
            // 
            // mskCpf
            // 
            this.mskCpf.BackColor = System.Drawing.Color.White;
            this.mskCpf.Location = new System.Drawing.Point(498, 139);
            this.mskCpf.Mask = "000,000,000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(188, 26);
            this.mskCpf.TabIndex = 3;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.White;
            this.txtEndereco.Location = new System.Drawing.Point(647, 208);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(289, 26);
            this.txtEndereco.TabIndex = 6;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.lblEndereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.lblEndereco.Location = new System.Drawing.Point(644, 187);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(80, 18);
            this.lblEndereco.TabIndex = 28;
            this.lblEndereco.Text = "Endereço:";
            // 
            // dgvListaClientes
            // 
            this.dgvListaClientes.AllowUserToAddRows = false;
            this.dgvListaClientes.AllowUserToDeleteRows = false;
            this.dgvListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaClientes.Location = new System.Drawing.Point(1115, 139);
            this.dgvListaClientes.Name = "dgvListaClientes";
            this.dgvListaClientes.ReadOnly = true;
            this.dgvListaClientes.Size = new System.Drawing.Size(342, 355);
            this.dgvListaClientes.TabIndex = 29;
            this.dgvListaClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaClientes_CellClick);
            // 
            // txtPesquisaNome
            // 
            this.txtPesquisaNome.BackColor = System.Drawing.Color.White;
            this.txtPesquisaNome.Location = new System.Drawing.Point(1115, 107);
            this.txtPesquisaNome.Name = "txtPesquisaNome";
            this.txtPesquisaNome.Size = new System.Drawing.Size(144, 26);
            this.txtPesquisaNome.TabIndex = 30;
            this.txtPesquisaNome.TextChanged += new System.EventHandler(this.txtPesquisaNome_TextChanged);
            // 
            // lblPesquisaNome
            // 
            this.lblPesquisaNome.AutoSize = true;
            this.lblPesquisaNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.lblPesquisaNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.lblPesquisaNome.Location = new System.Drawing.Point(1112, 86);
            this.lblPesquisaNome.Name = "lblPesquisaNome";
            this.lblPesquisaNome.Size = new System.Drawing.Size(124, 18);
            this.lblPesquisaNome.TabIndex = 31;
            this.lblPesquisaNome.Text = "Pesquisa Nome:";
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.White;
            this.btnDeletar.Image = global::UI.Properties.Resources.trash;
            this.btnDeletar.Location = new System.Drawing.Point(1382, 57);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 79);
            this.btnDeletar.TabIndex = 33;
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Visible = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.White;
            this.btnAtualizar.Image = global::UI.Properties.Resources.pencil;
            this.btnAtualizar.Location = new System.Drawing.Point(1284, 57);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(80, 79);
            this.btnAtualizar.TabIndex = 32;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Visible = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnPesquisarCep
            // 
            this.btnPesquisarCep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPesquisarCep.BackColor = System.Drawing.Color.White;
            this.btnPesquisarCep.BackgroundImage = global::UI.Properties.Resources.search;
            this.btnPesquisarCep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisarCep.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btnPesquisarCep.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowText;
            this.btnPesquisarCep.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btnPesquisarCep.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarCep.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnPesquisarCep.Location = new System.Drawing.Point(596, 209);
            this.btnPesquisarCep.Name = "btnPesquisarCep";
            this.btnPesquisarCep.Size = new System.Drawing.Size(33, 26);
            this.btnPesquisarCep.TabIndex = 23;
            this.btnPesquisarCep.UseVisualStyleBackColor = false;
            this.btnPesquisarCep.Click += new System.EventHandler(this.btnPesquisarCep_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Image = global::UI.Properties.Resources.box_arrow_right;
            this.btnSair.Location = new System.Drawing.Point(978, 402);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(97, 92);
            this.btnSair.TabIndex = 19;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Image = global::UI.Properties.Resources.eraser_fill;
            this.btnLimpar.Location = new System.Drawing.Point(978, 278);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(97, 92);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Image = global::UI.Properties.Resources.save_fill;
            this.btnSalvar.Location = new System.Drawing.Point(978, 150);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(97, 92);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // picBgDog
            // 
            this.picBgDog.Image = global::UI.Properties.Resources.bg_dog;
            this.picBgDog.Location = new System.Drawing.Point(-5, -60);
            this.picBgDog.Name = "picBgDog";
            this.picBgDog.Size = new System.Drawing.Size(437, 603);
            this.picBgDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBgDog.TabIndex = 0;
            this.picBgDog.TabStop = false;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(1469, 538);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txtPesquisaNome);
            this.Controls.Add(this.lblPesquisaNome);
            this.Controls.Add(this.dgvListaClientes);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.btnPesquisarCep);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtOutros);
            this.Controls.Add(this.rdoOutros);
            this.Controls.Add(this.rdoMasculino);
            this.Controls.Add(this.rdoFeminino);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.mskCep);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(this.lblUf);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.picBgDog);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBgDog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBgDog;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.RadioButton rdoFeminino;
        private System.Windows.Forms.RadioButton rdoMasculino;
        private System.Windows.Forms.RadioButton rdoOutros;
        private System.Windows.Forms.TextBox txtOutros;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPesquisarCep;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.DataGridView dgvListaClientes;
        private System.Windows.Forms.TextBox txtPesquisaNome;
        private System.Windows.Forms.Label lblPesquisaNome;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnDeletar;
    }
}