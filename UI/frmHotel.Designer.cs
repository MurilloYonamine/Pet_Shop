
namespace UI
{
    partial class frmHotel
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
            this.txtCodHotel = new System.Windows.Forms.TextBox();
            this.lblCodigoHotel = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvListarHospedagens = new System.Windows.Forms.DataGridView();
            this.txtCodigoAnimal = new System.Windows.Forms.TextBox();
            this.lblCodigoAnimal = new System.Windows.Forms.Label();
            this.cboAnimal = new System.Windows.Forms.ComboBox();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblDataDeRetorno = new System.Windows.Forms.Label();
            this.dtpRetorno = new System.Windows.Forms.DateTimePicker();
            this.lblDataDeEntrada = new System.Windows.Forms.Label();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.mskRga = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblRga = new System.Windows.Forms.Label();
            this.lblTipoAnimal = new System.Windows.Forms.Label();
            this.txtTipoAnimal = new System.Windows.Forms.TextBox();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.btnCadastrarAnimal = new System.Windows.Forms.Button();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.btnHospedar = new System.Windows.Forms.Button();
            this.picBottom = new System.Windows.Forms.PictureBox();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarHospedagens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodHotel
            // 
            this.txtCodHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodHotel.Location = new System.Drawing.Point(525, 45);
            this.txtCodHotel.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodHotel.Name = "txtCodHotel";
            this.txtCodHotel.ReadOnly = true;
            this.txtCodHotel.Size = new System.Drawing.Size(126, 26);
            this.txtCodHotel.TabIndex = 57;
            // 
            // lblCodigoHotel
            // 
            this.lblCodigoHotel.AutoSize = true;
            this.lblCodigoHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoHotel.Location = new System.Drawing.Point(390, 48);
            this.lblCodigoHotel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoHotel.Name = "lblCodigoHotel";
            this.lblCodigoHotel.Size = new System.Drawing.Size(127, 20);
            this.lblCodigoHotel.TabIndex = 56;
            this.lblCodigoHotel.Text = "Código do Hotel:";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(1298, 51);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(94, 42);
            this.btnEditar.TabIndex = 55;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvListarHospedagens
            // 
            this.dgvListarHospedagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarHospedagens.Location = new System.Drawing.Point(712, 105);
            this.dgvListarHospedagens.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListarHospedagens.Name = "dgvListarHospedagens";
            this.dgvListarHospedagens.ReadOnly = true;
            this.dgvListarHospedagens.Size = new System.Drawing.Size(680, 208);
            this.dgvListarHospedagens.TabIndex = 54;
            this.dgvListarHospedagens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarHospedagens_CellClick);
            this.dgvListarHospedagens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarHospedagens_CellContentClick);
            // 
            // txtCodigoAnimal
            // 
            this.txtCodigoAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoAnimal.Location = new System.Drawing.Point(568, 211);
            this.txtCodigoAnimal.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoAnimal.Name = "txtCodigoAnimal";
            this.txtCodigoAnimal.ReadOnly = true;
            this.txtCodigoAnimal.Size = new System.Drawing.Size(83, 26);
            this.txtCodigoAnimal.TabIndex = 53;
            // 
            // lblCodigoAnimal
            // 
            this.lblCodigoAnimal.AutoSize = true;
            this.lblCodigoAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAnimal.Location = new System.Drawing.Point(445, 214);
            this.lblCodigoAnimal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoAnimal.Name = "lblCodigoAnimal";
            this.lblCodigoAnimal.Size = new System.Drawing.Size(115, 20);
            this.lblCodigoAnimal.TabIndex = 52;
            this.lblCodigoAnimal.Text = "Código Animal:";
            // 
            // cboAnimal
            // 
            this.cboAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAnimal.FormattingEnabled = true;
            this.cboAnimal.Location = new System.Drawing.Point(141, 208);
            this.cboAnimal.Margin = new System.Windows.Forms.Padding(4);
            this.cboAnimal.Name = "cboAnimal";
            this.cboAnimal.Size = new System.Drawing.Size(296, 28);
            this.cboAnimal.TabIndex = 51;
            this.cboAnimal.SelectedIndexChanged += new System.EventHandler(this.cboAnimal_SelectedIndexChanged);
            // 
            // mskCpf
            // 
            this.mskCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCpf.Location = new System.Drawing.Point(442, 89);
            this.mskCpf.Margin = new System.Windows.Forms.Padding(4);
            this.mskCpf.Mask = "000,000,000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.ReadOnly = true;
            this.mskCpf.Size = new System.Drawing.Size(209, 26);
            this.mskCpf.TabIndex = 50;
            // 
            // lblDataDeRetorno
            // 
            this.lblDataDeRetorno.AutoSize = true;
            this.lblDataDeRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDeRetorno.Location = new System.Drawing.Point(354, 339);
            this.lblDataDeRetorno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataDeRetorno.Name = "lblDataDeRetorno";
            this.lblDataDeRetorno.Size = new System.Drawing.Size(132, 20);
            this.lblDataDeRetorno.TabIndex = 49;
            this.lblDataDeRetorno.Text = "Data de Retorno:";
            // 
            // dtpRetorno
            // 
            this.dtpRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRetorno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRetorno.Location = new System.Drawing.Point(494, 339);
            this.dtpRetorno.Margin = new System.Windows.Forms.Padding(4);
            this.dtpRetorno.Name = "dtpRetorno";
            this.dtpRetorno.Size = new System.Drawing.Size(157, 26);
            this.dtpRetorno.TabIndex = 48;
            // 
            // lblDataDeEntrada
            // 
            this.lblDataDeEntrada.AutoSize = true;
            this.lblDataDeEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDeEntrada.Location = new System.Drawing.Point(34, 339);
            this.lblDataDeEntrada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataDeEntrada.Name = "lblDataDeEntrada";
            this.lblDataDeEntrada.Size = new System.Drawing.Size(131, 20);
            this.lblDataDeEntrada.TabIndex = 47;
            this.lblDataDeEntrada.Text = "Data de Entrada:";
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrada.Location = new System.Drawing.Point(176, 339);
            this.dtpEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(157, 26);
            this.dtpEntrada.TabIndex = 45;
            // 
            // mskRga
            // 
            this.mskRga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskRga.Location = new System.Drawing.Point(423, 257);
            this.mskRga.Margin = new System.Windows.Forms.Padding(4);
            this.mskRga.Mask = "0,000,000";
            this.mskRga.Name = "mskRga";
            this.mskRga.ReadOnly = true;
            this.mskRga.Size = new System.Drawing.Size(228, 26);
            this.mskRga.TabIndex = 44;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefone.Location = new System.Drawing.Point(141, 133);
            this.mskTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.mskTelefone.Mask = "(00) 00000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.ReadOnly = true;
            this.mskTelefone.Size = new System.Drawing.Size(217, 26);
            this.mskTelefone.TabIndex = 43;
            // 
            // lblRga
            // 
            this.lblRga.AutoSize = true;
            this.lblRga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRga.Location = new System.Drawing.Point(366, 257);
            this.lblRga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRga.Name = "lblRga";
            this.lblRga.Size = new System.Drawing.Size(49, 20);
            this.lblRga.TabIndex = 42;
            this.lblRga.Text = "RGA:";
            // 
            // lblTipoAnimal
            // 
            this.lblTipoAnimal.AutoSize = true;
            this.lblTipoAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoAnimal.Location = new System.Drawing.Point(32, 251);
            this.lblTipoAnimal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoAnimal.Name = "lblTipoAnimal";
            this.lblTipoAnimal.Size = new System.Drawing.Size(43, 20);
            this.lblTipoAnimal.TabIndex = 41;
            this.lblTipoAnimal.Text = "Tipo:";
            // 
            // txtTipoAnimal
            // 
            this.txtTipoAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoAnimal.Location = new System.Drawing.Point(141, 254);
            this.txtTipoAnimal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoAnimal.Name = "txtTipoAnimal";
            this.txtTipoAnimal.ReadOnly = true;
            this.txtTipoAnimal.Size = new System.Drawing.Size(217, 26);
            this.txtTipoAnimal.TabIndex = 40;
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimal.Location = new System.Drawing.Point(32, 211);
            this.lblAnimal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(61, 20);
            this.lblAnimal.TabIndex = 39;
            this.lblAnimal.Text = "Animal:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(32, 136);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(75, 20);
            this.lblTelefone.TabIndex = 38;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(390, 92);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(44, 20);
            this.lblCpf.TabIndex = 37;
            this.lblCpf.Text = "CPF:";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(32, 86);
            this.lblNomeCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(55, 20);
            this.lblNomeCliente.TabIndex = 36;
            this.lblNomeCliente.Text = "Nome:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(141, 89);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(217, 26);
            this.txtNomeCliente.TabIndex = 35;
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCliente.Location = new System.Drawing.Point(176, 48);
            this.txtCodCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(182, 26);
            this.txtCodCliente.TabIndex = 34;
            this.txtCodCliente.TextChanged += new System.EventHandler(this.txtCodCliente_TextChanged);
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCliente.Location = new System.Drawing.Point(32, 48);
            this.lblIdCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(138, 20);
            this.lblIdCliente.TabIndex = 33;
            this.lblIdCliente.Text = "Código do Cliente:";
            // 
            // btnCadastrarAnimal
            // 
            this.btnCadastrarAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarAnimal.Location = new System.Drawing.Point(1074, 339);
            this.btnCadastrarAnimal.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrarAnimal.Name = "btnCadastrarAnimal";
            this.btnCadastrarAnimal.Size = new System.Drawing.Size(139, 92);
            this.btnCadastrarAnimal.TabIndex = 60;
            this.btnCadastrarAnimal.Text = "CADASTRAR ANIMAL";
            this.btnCadastrarAnimal.UseVisualStyleBackColor = true;
            this.btnCadastrarAnimal.Click += new System.EventHandler(this.btnCadastrarAnimal_Click);
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCliente.Location = new System.Drawing.Point(1263, 339);
            this.btnCadastrarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(129, 92);
            this.btnCadastrarCliente.TabIndex = 59;
            this.btnCadastrarCliente.Text = "CADASTRAR CLIENTE";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // btnHospedar
            // 
            this.btnHospedar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHospedar.Location = new System.Drawing.Point(887, 339);
            this.btnHospedar.Margin = new System.Windows.Forms.Padding(4);
            this.btnHospedar.Name = "btnHospedar";
            this.btnHospedar.Size = new System.Drawing.Size(133, 92);
            this.btnHospedar.TabIndex = 58;
            this.btnHospedar.Text = "HOSPEDAR";
            this.btnHospedar.UseVisualStyleBackColor = true;
            this.btnHospedar.Click += new System.EventHandler(this.btnHospedar_Click);
            // 
            // picBottom
            // 
            this.picBottom.Image = global::UI.Properties.Resources.bg_blue;
            this.picBottom.Location = new System.Drawing.Point(-14, 396);
            this.picBottom.Name = "picBottom";
            this.picBottom.Size = new System.Drawing.Size(1458, 201);
            this.picBottom.TabIndex = 61;
            this.picBottom.TabStop = false;
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Image = global::UI.Properties.Resources.eraser_fill;
            this.btnLimpar.Location = new System.Drawing.Point(732, 339);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(121, 92);
            this.btnLimpar.TabIndex = 62;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(1415, 502);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrarAnimal);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.btnHospedar);
            this.Controls.Add(this.txtCodHotel);
            this.Controls.Add(this.lblCodigoHotel);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvListarHospedagens);
            this.Controls.Add(this.txtCodigoAnimal);
            this.Controls.Add(this.lblCodigoAnimal);
            this.Controls.Add(this.cboAnimal);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.lblDataDeRetorno);
            this.Controls.Add(this.dtpRetorno);
            this.Controls.Add(this.lblDataDeEntrada);
            this.Controls.Add(this.dtpEntrada);
            this.Controls.Add(this.mskRga);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.lblRga);
            this.Controls.Add(this.lblTipoAnimal);
            this.Controls.Add(this.txtTipoAnimal);
            this.Controls.Add(this.lblAnimal);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.txtCodCliente);
            this.Controls.Add(this.lblIdCliente);
            this.Controls.Add(this.picBottom);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel";
            this.Load += new System.EventHandler(this.frmHotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarHospedagens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodHotel;
        private System.Windows.Forms.Label lblCodigoHotel;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvListarHospedagens;
        private System.Windows.Forms.TextBox txtCodigoAnimal;
        private System.Windows.Forms.Label lblCodigoAnimal;
        private System.Windows.Forms.ComboBox cboAnimal;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.Label lblDataDeRetorno;
        private System.Windows.Forms.DateTimePicker dtpRetorno;
        private System.Windows.Forms.Label lblDataDeEntrada;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.MaskedTextBox mskRga;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Label lblRga;
        private System.Windows.Forms.Label lblTipoAnimal;
        private System.Windows.Forms.TextBox txtTipoAnimal;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.Button btnCadastrarAnimal;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.Button btnHospedar;
        private System.Windows.Forms.PictureBox picBottom;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.Button btnLimpar;
    }
}