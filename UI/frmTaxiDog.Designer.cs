﻿
namespace UI
{
    partial class frmTaxiDog
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
            this.lblTaxiDog = new System.Windows.Forms.Label();
            this.txtCodTaxi = new System.Windows.Forms.TextBox();
            this.chkPetVet = new System.Windows.Forms.CheckBox();
            this.chkPetCare = new System.Windows.Forms.CheckBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvAgendamentos = new System.Windows.Forms.DataGridView();
            this.lblHorario = new System.Windows.Forms.Label();
            this.cboHorario = new System.Windows.Forms.ComboBox();
            this.lblServiços = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.dtpAgendamento = new System.Windows.Forms.DateTimePicker();
            this.mskRga = new System.Windows.Forms.MaskedTextBox();
            this.lblRga = new System.Windows.Forms.Label();
            this.txtCodAnimal = new System.Windows.Forms.TextBox();
            this.lblCodAnimal = new System.Windows.Forms.Label();
            this.txtTipoAnimal = new System.Windows.Forms.TextBox();
            this.lblTipoAnimal = new System.Windows.Forms.Label();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.cboAnimal = new System.Windows.Forms.ComboBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.btnCadastrarAnimal = new System.Windows.Forms.Button();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.btnAgendar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTaxiDog
            // 
            this.lblTaxiDog.AutoSize = true;
            this.lblTaxiDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxiDog.Location = new System.Drawing.Point(17, 25);
            this.lblTaxiDog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaxiDog.Name = "lblTaxiDog";
            this.lblTaxiDog.Size = new System.Drawing.Size(125, 20);
            this.lblTaxiDog.TabIndex = 86;
            this.lblTaxiDog.Text = "Código TaxiDog:";
            // 
            // txtCodTaxi
            // 
            this.txtCodTaxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodTaxi.Location = new System.Drawing.Point(145, 25);
            this.txtCodTaxi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodTaxi.Name = "txtCodTaxi";
            this.txtCodTaxi.ReadOnly = true;
            this.txtCodTaxi.Size = new System.Drawing.Size(84, 26);
            this.txtCodTaxi.TabIndex = 85;
            // 
            // chkPetVet
            // 
            this.chkPetVet.AutoSize = true;
            this.chkPetVet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPetVet.Location = new System.Drawing.Point(21, 410);
            this.chkPetVet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkPetVet.Name = "chkPetVet";
            this.chkPetVet.Size = new System.Drawing.Size(172, 24);
            this.chkPetVet.TabIndex = 84;
            this.chkPetVet.Text = "Pet Vet (Veterinário)";
            this.chkPetVet.UseVisualStyleBackColor = true;
            // 
            // chkPetCare
            // 
            this.chkPetCare.AutoSize = true;
            this.chkPetCare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPetCare.Location = new System.Drawing.Point(21, 378);
            this.chkPetCare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkPetCare.Name = "chkPetCare";
            this.chkPetCare.Size = new System.Drawing.Size(203, 24);
            this.chkPetCare.TabIndex = 83;
            this.chkPetCare.Text = "Pet Care (Banho e Tosa)";
            this.chkPetCare.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(612, 673);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(130, 91);
            this.btnEditar.TabIndex = 82;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvAgendamentos
            // 
            this.dgvAgendamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgendamentos.Location = new System.Drawing.Point(19, 442);
            this.dgvAgendamentos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAgendamentos.Name = "dgvAgendamentos";
            this.dgvAgendamentos.ReadOnly = true;
            this.dgvAgendamentos.Size = new System.Drawing.Size(706, 208);
            this.dgvAgendamentos.TabIndex = 81;
            this.dgvAgendamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgendamentos_CellClick);
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(365, 289);
            this.lblHorario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(65, 20);
            this.lblHorario.TabIndex = 80;
            this.lblHorario.Text = "Horário:";
            // 
            // cboHorario
            // 
            this.cboHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHorario.FormattingEnabled = true;
            this.cboHorario.Items.AddRange(new object[] {
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30"});
            this.cboHorario.Location = new System.Drawing.Point(438, 285);
            this.cboHorario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboHorario.Name = "cboHorario";
            this.cboHorario.Size = new System.Drawing.Size(287, 28);
            this.cboHorario.TabIndex = 79;
            // 
            // lblServiços
            // 
            this.lblServiços.AutoSize = true;
            this.lblServiços.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiços.Location = new System.Drawing.Point(15, 346);
            this.lblServiços.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiços.Name = "lblServiços";
            this.lblServiços.Size = new System.Drawing.Size(134, 20);
            this.lblServiços.TabIndex = 78;
            this.lblServiços.Text = "Serviço desejado:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(15, 288);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(175, 20);
            this.lblData.TabIndex = 77;
            this.lblData.Text = "Data do Agendamento:";
            // 
            // dtpAgendamento
            // 
            this.dtpAgendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAgendamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAgendamento.Location = new System.Drawing.Point(189, 285);
            this.dtpAgendamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpAgendamento.Name = "dtpAgendamento";
            this.dtpAgendamento.Size = new System.Drawing.Size(164, 26);
            this.dtpAgendamento.TabIndex = 76;
            // 
            // mskRga
            // 
            this.mskRga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskRga.Location = new System.Drawing.Point(145, 238);
            this.mskRga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mskRga.Mask = "0,000,000";
            this.mskRga.Name = "mskRga";
            this.mskRga.ReadOnly = true;
            this.mskRga.Size = new System.Drawing.Size(128, 26);
            this.mskRga.TabIndex = 75;
            // 
            // lblRga
            // 
            this.lblRga.AutoSize = true;
            this.lblRga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRga.Location = new System.Drawing.Point(17, 241);
            this.lblRga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRga.Name = "lblRga";
            this.lblRga.Size = new System.Drawing.Size(49, 20);
            this.lblRga.TabIndex = 74;
            this.lblRga.Text = "RGA:";
            // 
            // txtCodAnimal
            // 
            this.txtCodAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodAnimal.Location = new System.Drawing.Point(650, 133);
            this.txtCodAnimal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodAnimal.Name = "txtCodAnimal";
            this.txtCodAnimal.Size = new System.Drawing.Size(75, 26);
            this.txtCodAnimal.TabIndex = 73;
            // 
            // lblCodAnimal
            // 
            this.lblCodAnimal.AutoSize = true;
            this.lblCodAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodAnimal.Location = new System.Drawing.Point(527, 136);
            this.lblCodAnimal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodAnimal.Name = "lblCodAnimal";
            this.lblCodAnimal.Size = new System.Drawing.Size(115, 20);
            this.lblCodAnimal.TabIndex = 72;
            this.lblCodAnimal.Text = "Código Animal:";
            // 
            // txtTipoAnimal
            // 
            this.txtTipoAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoAnimal.Location = new System.Drawing.Point(388, 188);
            this.txtTipoAnimal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTipoAnimal.Name = "txtTipoAnimal";
            this.txtTipoAnimal.ReadOnly = true;
            this.txtTipoAnimal.Size = new System.Drawing.Size(337, 26);
            this.txtTipoAnimal.TabIndex = 71;
            // 
            // lblTipoAnimal
            // 
            this.lblTipoAnimal.AutoSize = true;
            this.lblTipoAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoAnimal.Location = new System.Drawing.Point(348, 191);
            this.lblTipoAnimal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoAnimal.Name = "lblTipoAnimal";
            this.lblTipoAnimal.Size = new System.Drawing.Size(43, 20);
            this.lblTipoAnimal.TabIndex = 70;
            this.lblTipoAnimal.Text = "Tipo:";
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimal.Location = new System.Drawing.Point(17, 191);
            this.lblAnimal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(61, 20);
            this.lblAnimal.TabIndex = 69;
            this.lblAnimal.Text = "Animal:";
            // 
            // cboAnimal
            // 
            this.cboAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAnimal.FormattingEnabled = true;
            this.cboAnimal.Location = new System.Drawing.Point(146, 188);
            this.cboAnimal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboAnimal.Name = "cboAnimal";
            this.cboAnimal.Size = new System.Drawing.Size(194, 28);
            this.cboAnimal.TabIndex = 68;
            this.cboAnimal.SelectedIndexChanged += new System.EventHandler(this.cboAnimal_SelectedIndexChanged);
            // 
            // mskTelefone
            // 
            this.mskTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefone.Location = new System.Drawing.Point(397, 133);
            this.mskTelefone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mskTelefone.Mask = "(00)00000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.ReadOnly = true;
            this.mskTelefone.Size = new System.Drawing.Size(125, 26);
            this.mskTelefone.TabIndex = 67;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(314, 136);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(75, 20);
            this.lblTelefone.TabIndex = 66;
            this.lblTelefone.Text = "Telefone:";
            // 
            // mskCpf
            // 
            this.mskCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCpf.Location = new System.Drawing.Point(145, 133);
            this.mskCpf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mskCpf.Mask = "000,000,000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.ReadOnly = true;
            this.mskCpf.Size = new System.Drawing.Size(161, 26);
            this.mskCpf.TabIndex = 65;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(17, 136);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(44, 20);
            this.lblCpf.TabIndex = 64;
            this.lblCpf.Text = "CPF:";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCliente.Location = new System.Drawing.Point(585, 79);
            this.txtCodCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(140, 26);
            this.txtCodCliente.TabIndex = 63;
            this.txtCodCliente.TextChanged += new System.EventHandler(this.txtCodCliente_TextChanged);
            // 
            // lblCodigoCliente
            // 
            this.lblCodigoCliente.AutoSize = true;
            this.lblCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCliente.Location = new System.Drawing.Point(461, 82);
            this.lblCodigoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            this.lblCodigoCliente.Size = new System.Drawing.Size(116, 20);
            this.lblCodigoCliente.TabIndex = 62;
            this.lblCodigoCliente.Text = "Código Cliente:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(146, 79);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(307, 26);
            this.txtNomeCliente.TabIndex = 61;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(17, 82);
            this.lblNomeCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(108, 20);
            this.lblNomeCliente.TabIndex = 60;
            this.lblNomeCliente.Text = "Nome Cliente:";
            // 
            // btnCadastrarAnimal
            // 
            this.btnCadastrarAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarAnimal.Location = new System.Drawing.Point(438, 673);
            this.btnCadastrarAnimal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCadastrarAnimal.Name = "btnCadastrarAnimal";
            this.btnCadastrarAnimal.Size = new System.Drawing.Size(130, 91);
            this.btnCadastrarAnimal.TabIndex = 59;
            this.btnCadastrarAnimal.Text = "CADASTRAR ANIMAL";
            this.btnCadastrarAnimal.UseVisualStyleBackColor = true;
            this.btnCadastrarAnimal.Click += new System.EventHandler(this.btnCadastrarAnimal_Click);
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCliente.Location = new System.Drawing.Point(21, 673);
            this.btnCadastrarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(130, 91);
            this.btnCadastrarCliente.TabIndex = 58;
            this.btnCadastrarCliente.Text = "CADASTRAR CLIENTE";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // btnAgendar
            // 
            this.btnAgendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendar.Location = new System.Drawing.Point(223, 673);
            this.btnAgendar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(130, 91);
            this.btnAgendar.TabIndex = 57;
            this.btnAgendar.Text = "AGENDAR";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // frmTaxiDog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(774, 779);
            this.Controls.Add(this.lblTaxiDog);
            this.Controls.Add(this.txtCodTaxi);
            this.Controls.Add(this.chkPetVet);
            this.Controls.Add(this.chkPetCare);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvAgendamentos);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.cboHorario);
            this.Controls.Add(this.lblServiços);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.dtpAgendamento);
            this.Controls.Add(this.mskRga);
            this.Controls.Add(this.lblRga);
            this.Controls.Add(this.txtCodAnimal);
            this.Controls.Add(this.lblCodAnimal);
            this.Controls.Add(this.txtTipoAnimal);
            this.Controls.Add(this.lblTipoAnimal);
            this.Controls.Add(this.lblAnimal);
            this.Controls.Add(this.cboAnimal);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txtCodCliente);
            this.Controls.Add(this.lblCodigoCliente);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.btnCadastrarAnimal);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.btnAgendar);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTaxiDog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTaxiDog";
            this.Load += new System.EventHandler(this.frmTaxiDog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaxiDog;
        private System.Windows.Forms.TextBox txtCodTaxi;
        private System.Windows.Forms.CheckBox chkPetVet;
        private System.Windows.Forms.CheckBox chkPetCare;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvAgendamentos;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.ComboBox cboHorario;
        private System.Windows.Forms.Label lblServiços;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtpAgendamento;
        private System.Windows.Forms.MaskedTextBox mskRga;
        private System.Windows.Forms.Label lblRga;
        private System.Windows.Forms.TextBox txtCodAnimal;
        private System.Windows.Forms.Label lblCodAnimal;
        private System.Windows.Forms.TextBox txtTipoAnimal;
        private System.Windows.Forms.Label lblTipoAnimal;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.ComboBox cboAnimal;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Label lblCodigoCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Button btnCadastrarAnimal;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.Button btnAgendar;
    }
}