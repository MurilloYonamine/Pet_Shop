
namespace UI
{
    partial class frmAnimais
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
            this.picBgDog = new System.Windows.Forms.PictureBox();
            this.txtCodigoPet = new System.Windows.Forms.TextBox();
            this.lblCodigoPet = new System.Windows.Forms.Label();
            this.lblNomePet = new System.Windows.Forms.Label();
            this.txtNomePet = new System.Windows.Forms.TextBox();
            this.lblCodigoDono = new System.Windows.Forms.Label();
            this.cboCodigoDono = new System.Windows.Forms.ComboBox();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.lblRaca = new System.Windows.Forms.Label();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.lblCor = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblRga = new System.Windows.Forms.Label();
            this.lblPedigree = new System.Windows.Forms.Label();
            this.txtPedigree = new System.Windows.Forms.TextBox();
            this.mskRga = new System.Windows.Forms.MaskedTextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.dgvListaAnimais = new System.Windows.Forms.DataGridView();
            this.lblPesquisaPet = new System.Windows.Forms.Label();
            this.txtPesquisaPet = new System.Windows.Forms.TextBox();
            this.lblPesquisaDono = new System.Windows.Forms.Label();
            this.txtPesquisaDono = new System.Windows.Forms.TextBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBgDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAnimais)).BeginInit();
            this.SuspendLayout();
            // 
            // picBgDog
            // 
            this.picBgDog.Image = global::UI.Properties.Resources.bg_dog2;
            this.picBgDog.Location = new System.Drawing.Point(-3, -11);
            this.picBgDog.Name = "picBgDog";
            this.picBgDog.Size = new System.Drawing.Size(488, 684);
            this.picBgDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBgDog.TabIndex = 1;
            this.picBgDog.TabStop = false;
            // 
            // txtCodigoPet
            // 
            this.txtCodigoPet.Location = new System.Drawing.Point(700, 58);
            this.txtCodigoPet.Name = "txtCodigoPet";
            this.txtCodigoPet.ReadOnly = true;
            this.txtCodigoPet.Size = new System.Drawing.Size(154, 26);
            this.txtCodigoPet.TabIndex = 2;
            // 
            // lblCodigoPet
            // 
            this.lblCodigoPet.AutoSize = true;
            this.lblCodigoPet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(208)))), ((int)(((byte)(205)))));
            this.lblCodigoPet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.lblCodigoPet.Location = new System.Drawing.Point(697, 37);
            this.lblCodigoPet.Name = "lblCodigoPet";
            this.lblCodigoPet.Size = new System.Drawing.Size(114, 18);
            this.lblCodigoPet.TabIndex = 4;
            this.lblCodigoPet.Text = "Código do Pet:";
            // 
            // lblNomePet
            // 
            this.lblNomePet.AutoSize = true;
            this.lblNomePet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.lblNomePet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.lblNomePet.Location = new System.Drawing.Point(697, 87);
            this.lblNomePet.Name = "lblNomePet";
            this.lblNomePet.Size = new System.Drawing.Size(104, 18);
            this.lblNomePet.TabIndex = 6;
            this.lblNomePet.Text = "Nome do Pet:";
            // 
            // txtNomePet
            // 
            this.txtNomePet.Location = new System.Drawing.Point(700, 108);
            this.txtNomePet.Name = "txtNomePet";
            this.txtNomePet.Size = new System.Drawing.Size(154, 26);
            this.txtNomePet.TabIndex = 4;
            // 
            // lblCodigoDono
            // 
            this.lblCodigoDono.AutoSize = true;
            this.lblCodigoDono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.lblCodigoDono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.lblCodigoDono.Location = new System.Drawing.Point(503, 37);
            this.lblCodigoDono.Name = "lblCodigoDono";
            this.lblCodigoDono.Size = new System.Drawing.Size(128, 18);
            this.lblCodigoDono.TabIndex = 7;
            this.lblCodigoDono.Text = "Código do Dono:";
            // 
            // cboCodigoDono
            // 
            this.cboCodigoDono.FormattingEnabled = true;
            this.cboCodigoDono.Location = new System.Drawing.Point(506, 58);
            this.cboCodigoDono.Name = "cboCodigoDono";
            this.cboCodigoDono.Size = new System.Drawing.Size(154, 26);
            this.cboCodigoDono.TabIndex = 1;
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.lblFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.lblFuncionario.Location = new System.Drawing.Point(697, 137);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(94, 18);
            this.lblFuncionario.TabIndex = 10;
            this.lblFuncionario.Text = "Funcionário:";
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Location = new System.Drawing.Point(700, 158);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(154, 26);
            this.txtFuncionario.TabIndex = 6;
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.lblRaca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.lblRaca.Location = new System.Drawing.Point(502, 87);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(49, 18);
            this.lblRaca.TabIndex = 12;
            this.lblRaca.Text = "Raça:";
            // 
            // txtRaca
            // 
            this.txtRaca.Location = new System.Drawing.Point(505, 108);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(154, 26);
            this.txtRaca.TabIndex = 11;
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.lblCor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.lblCor.Location = new System.Drawing.Point(697, 241);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(38, 18);
            this.lblCor.TabIndex = 14;
            this.lblCor.Text = "Cor:";
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(700, 262);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(154, 26);
            this.txtCor.TabIndex = 13;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.lblTipo.Location = new System.Drawing.Point(697, 307);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(42, 18);
            this.lblTipo.TabIndex = 16;
            this.lblTipo.Text = "Tipo:";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(700, 328);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(154, 26);
            this.txtTipo.TabIndex = 10;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.lblPeso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.lblPeso.Location = new System.Drawing.Point(503, 241);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(49, 18);
            this.lblPeso.TabIndex = 18;
            this.lblPeso.Text = "Peso:";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(506, 262);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(154, 26);
            this.txtPeso.TabIndex = 9;
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(506, 208);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(125, 26);
            this.dtpNascimento.TabIndex = 7;
            this.dtpNascimento.Value = new System.DateTime(2023, 6, 25, 0, 0, 0, 0);
            this.dtpNascimento.ValueChanged += new System.EventHandler(this.dtpNascimento_ValueChanged);
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.lblNascimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.lblNascimento.Location = new System.Drawing.Point(503, 187);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(95, 18);
            this.lblNascimento.TabIndex = 20;
            this.lblNascimento.Text = "Nascimento:";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.lblIdade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.lblIdade.Location = new System.Drawing.Point(659, 187);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(51, 18);
            this.lblIdade.TabIndex = 22;
            this.lblIdade.Text = "Idade:";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(662, 208);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(77, 26);
            this.txtIdade.TabIndex = 8;
            // 
            // lblRga
            // 
            this.lblRga.AutoSize = true;
            this.lblRga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.lblRga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.lblRga.Location = new System.Drawing.Point(765, 187);
            this.lblRga.Name = "lblRga";
            this.lblRga.Size = new System.Drawing.Size(46, 18);
            this.lblRga.TabIndex = 24;
            this.lblRga.Text = "RGA:";
            // 
            // lblPedigree
            // 
            this.lblPedigree.AutoSize = true;
            this.lblPedigree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.lblPedigree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.lblPedigree.Location = new System.Drawing.Point(502, 137);
            this.lblPedigree.Name = "lblPedigree";
            this.lblPedigree.Size = new System.Drawing.Size(77, 18);
            this.lblPedigree.TabIndex = 27;
            this.lblPedigree.Text = "Pedigree:";
            // 
            // txtPedigree
            // 
            this.txtPedigree.Location = new System.Drawing.Point(505, 158);
            this.txtPedigree.Name = "txtPedigree";
            this.txtPedigree.Size = new System.Drawing.Size(154, 26);
            this.txtPedigree.TabIndex = 5;
            // 
            // mskRga
            // 
            this.mskRga.Location = new System.Drawing.Point(768, 208);
            this.mskRga.Mask = "0,000,000";
            this.mskRga.Name = "mskRga";
            this.mskRga.Size = new System.Drawing.Size(86, 26);
            this.mskRga.TabIndex = 3;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.lblObservacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.lblObservacao.Location = new System.Drawing.Point(503, 368);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(97, 18);
            this.lblObservacao.TabIndex = 30;
            this.lblObservacao.Text = "Observação:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(506, 389);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(361, 99);
            this.txtObservacao.TabIndex = 12;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Image = global::UI.Properties.Resources.box_arrow_right;
            this.btnSair.Location = new System.Drawing.Point(770, 520);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(97, 92);
            this.btnSair.TabIndex = 15;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Image = global::UI.Properties.Resources.eraser_fill;
            this.btnLimpar.Location = new System.Drawing.Point(638, 520);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(97, 92);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Image = global::UI.Properties.Resources.save_fill;
            this.btnSalvar.Location = new System.Drawing.Point(506, 520);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(97, 92);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.lblSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.lblSexo.Location = new System.Drawing.Point(503, 307);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(48, 18);
            this.lblSexo.TabIndex = 32;
            this.lblSexo.Text = "Sexo:";
            // 
            // cboSexo
            // 
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "Macho",
            "Fêmea"});
            this.cboSexo.Location = new System.Drawing.Point(506, 328);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(154, 26);
            this.cboSexo.TabIndex = 11;
            // 
            // dgvListaAnimais
            // 
            this.dgvListaAnimais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaAnimais.Location = new System.Drawing.Point(901, 141);
            this.dgvListaAnimais.Name = "dgvListaAnimais";
            this.dgvListaAnimais.ReadOnly = true;
            this.dgvListaAnimais.Size = new System.Drawing.Size(483, 347);
            this.dgvListaAnimais.TabIndex = 33;
            this.dgvListaAnimais.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaAnimais_CellClick);
            this.dgvListaAnimais.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaAnimais_CellContentClick);
            // 
            // lblPesquisaPet
            // 
            this.lblPesquisaPet.AutoSize = true;
            this.lblPesquisaPet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.lblPesquisaPet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.lblPesquisaPet.Location = new System.Drawing.Point(898, 112);
            this.lblPesquisaPet.Name = "lblPesquisaPet";
            this.lblPesquisaPet.Size = new System.Drawing.Size(106, 18);
            this.lblPesquisaPet.TabIndex = 35;
            this.lblPesquisaPet.Text = "Pesquisa Pet:";
            // 
            // txtPesquisaPet
            // 
            this.txtPesquisaPet.Location = new System.Drawing.Point(1010, 108);
            this.txtPesquisaPet.Name = "txtPesquisaPet";
            this.txtPesquisaPet.Size = new System.Drawing.Size(154, 26);
            this.txtPesquisaPet.TabIndex = 34;
            this.txtPesquisaPet.TextChanged += new System.EventHandler(this.txtPesquisaPet_TextChanged);
            // 
            // lblPesquisaDono
            // 
            this.lblPesquisaDono.AutoSize = true;
            this.lblPesquisaDono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.lblPesquisaDono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.lblPesquisaDono.Location = new System.Drawing.Point(1174, 112);
            this.lblPesquisaDono.Name = "lblPesquisaDono";
            this.lblPesquisaDono.Size = new System.Drawing.Size(50, 18);
            this.lblPesquisaDono.TabIndex = 37;
            this.lblPesquisaDono.Text = "Dono:";
            // 
            // txtPesquisaDono
            // 
            this.txtPesquisaDono.Location = new System.Drawing.Point(1230, 108);
            this.txtPesquisaDono.Name = "txtPesquisaDono";
            this.txtPesquisaDono.Size = new System.Drawing.Size(154, 26);
            this.txtPesquisaDono.TabIndex = 36;
            this.txtPesquisaDono.TextChanged += new System.EventHandler(this.txtPesquisaDono_TextChanged);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.White;
            this.btnDeletar.Image = global::UI.Properties.Resources.trash;
            this.btnDeletar.Location = new System.Drawing.Point(1186, 514);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(97, 91);
            this.btnDeletar.TabIndex = 39;
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Visible = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.White;
            this.btnAtualizar.Image = global::UI.Properties.Resources.pencil;
            this.btnAtualizar.Location = new System.Drawing.Point(1000, 513);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(97, 92);
            this.btnAtualizar.TabIndex = 38;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Visible = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // frmAnimais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(1412, 667);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.lblPesquisaDono);
            this.Controls.Add(this.txtPesquisaDono);
            this.Controls.Add(this.lblPesquisaPet);
            this.Controls.Add(this.txtPesquisaPet);
            this.Controls.Add(this.dgvListaAnimais);
            this.Controls.Add(this.cboSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.mskRga);
            this.Controls.Add(this.lblPedigree);
            this.Controls.Add(this.txtPedigree);
            this.Controls.Add(this.lblRga);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.lblRaca);
            this.Controls.Add(this.txtRaca);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.txtFuncionario);
            this.Controls.Add(this.cboCodigoDono);
            this.Controls.Add(this.lblCodigoDono);
            this.Controls.Add(this.lblNomePet);
            this.Controls.Add(this.txtNomePet);
            this.Controls.Add(this.lblCodigoPet);
            this.Controls.Add(this.txtCodigoPet);
            this.Controls.Add(this.picBgDog);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAnimais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Animais";
            this.Load += new System.EventHandler(this.frmAnimais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBgDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAnimais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBgDog;
        private System.Windows.Forms.TextBox txtCodigoPet;
        private System.Windows.Forms.Label lblCodigoPet;
        private System.Windows.Forms.Label lblNomePet;
        private System.Windows.Forms.TextBox txtNomePet;
        private System.Windows.Forms.Label lblCodigoDono;
        private System.Windows.Forms.ComboBox cboCodigoDono;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lblRga;
        private System.Windows.Forms.Label lblPedigree;
        private System.Windows.Forms.TextBox txtPedigree;
        private System.Windows.Forms.MaskedTextBox mskRga;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.DataGridView dgvListaAnimais;
        private System.Windows.Forms.Label lblPesquisaPet;
        private System.Windows.Forms.TextBox txtPesquisaPet;
        private System.Windows.Forms.Label lblPesquisaDono;
        private System.Windows.Forms.TextBox txtPesquisaDono;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAtualizar;
    }
}