
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lblAgendamento = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarHospedagens)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodHotel
            // 
            this.txtCodHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodHotel.Location = new System.Drawing.Point(456, 15);
            this.txtCodHotel.Name = "txtCodHotel";
            this.txtCodHotel.ReadOnly = true;
            this.txtCodHotel.Size = new System.Drawing.Size(46, 26);
            this.txtCodHotel.TabIndex = 57;
            // 
            // lblCodigoHotel
            // 
            this.lblCodigoHotel.AutoSize = true;
            this.lblCodigoHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoHotel.Location = new System.Drawing.Point(326, 18);
            this.lblCodigoHotel.Name = "lblCodigoHotel";
            this.lblCodigoHotel.Size = new System.Drawing.Size(127, 20);
            this.lblCodigoHotel.TabIndex = 56;
            this.lblCodigoHotel.Text = "Código do Hotel:";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(25, 365);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(63, 30);
            this.btnEditar.TabIndex = 55;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvListarHospedagens
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListarHospedagens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListarHospedagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarHospedagens.Location = new System.Drawing.Point(25, 401);
            this.dgvListarHospedagens.Name = "dgvListarHospedagens";
            this.dgvListarHospedagens.ReadOnly = true;
            this.dgvListarHospedagens.Size = new System.Drawing.Size(453, 150);
            this.dgvListarHospedagens.TabIndex = 54;
            this.dgvListarHospedagens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarHospedagens_CellClick);
            // 
            // txtCodigoAnimal
            // 
            this.txtCodigoAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoAnimal.Location = new System.Drawing.Point(357, 142);
            this.txtCodigoAnimal.Name = "txtCodigoAnimal";
            this.txtCodigoAnimal.ReadOnly = true;
            this.txtCodigoAnimal.Size = new System.Drawing.Size(46, 26);
            this.txtCodigoAnimal.TabIndex = 53;
            // 
            // lblCodigoAnimal
            // 
            this.lblCodigoAnimal.AutoSize = true;
            this.lblCodigoAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAnimal.Location = new System.Drawing.Point(236, 145);
            this.lblCodigoAnimal.Name = "lblCodigoAnimal";
            this.lblCodigoAnimal.Size = new System.Drawing.Size(115, 20);
            this.lblCodigoAnimal.TabIndex = 52;
            this.lblCodigoAnimal.Text = "Código Animal:";
            // 
            // cboAnimal
            // 
            this.cboAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAnimal.FormattingEnabled = true;
            this.cboAnimal.Location = new System.Drawing.Point(94, 148);
            this.cboAnimal.Name = "cboAnimal";
            this.cboAnimal.Size = new System.Drawing.Size(121, 28);
            this.cboAnimal.TabIndex = 51;
            this.cboAnimal.SelectedIndexChanged += new System.EventHandler(this.cboAnimal_SelectedIndexChanged);
            // 
            // mskCpf
            // 
            this.mskCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCpf.Location = new System.Drawing.Point(332, 61);
            this.mskCpf.Mask = "000,000,000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.ReadOnly = true;
            this.mskCpf.Size = new System.Drawing.Size(130, 26);
            this.mskCpf.TabIndex = 50;
            // 
            // lblDataDeRetorno
            // 
            this.lblDataDeRetorno.AutoSize = true;
            this.lblDataDeRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDeRetorno.Location = new System.Drawing.Point(21, 319);
            this.lblDataDeRetorno.Name = "lblDataDeRetorno";
            this.lblDataDeRetorno.Size = new System.Drawing.Size(132, 20);
            this.lblDataDeRetorno.TabIndex = 49;
            this.lblDataDeRetorno.Text = "Data de Retorno:";
            // 
            // dtpRetorno
            // 
            this.dtpRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRetorno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRetorno.Location = new System.Drawing.Point(159, 319);
            this.dtpRetorno.Name = "dtpRetorno";
            this.dtpRetorno.Size = new System.Drawing.Size(106, 26);
            this.dtpRetorno.TabIndex = 48;
            // 
            // lblDataDeEntrada
            // 
            this.lblDataDeEntrada.AutoSize = true;
            this.lblDataDeEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDeEntrada.Location = new System.Drawing.Point(21, 287);
            this.lblDataDeEntrada.Name = "lblDataDeEntrada";
            this.lblDataDeEntrada.Size = new System.Drawing.Size(131, 20);
            this.lblDataDeEntrada.TabIndex = 47;
            this.lblDataDeEntrada.Text = "Data de Entrada:";
            // 
            // lblAgendamento
            // 
            this.lblAgendamento.AutoSize = true;
            this.lblAgendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgendamento.Location = new System.Drawing.Point(21, 250);
            this.lblAgendamento.Name = "lblAgendamento";
            this.lblAgendamento.Size = new System.Drawing.Size(110, 20);
            this.lblAgendamento.TabIndex = 46;
            this.lblAgendamento.Text = "Agendamento";
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrada.Location = new System.Drawing.Point(158, 287);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(106, 26);
            this.dtpEntrada.TabIndex = 45;
            // 
            // mskRga
            // 
            this.mskRga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskRga.Location = new System.Drawing.Point(94, 204);
            this.mskRga.Mask = "0,000,000";
            this.mskRga.Name = "mskRga";
            this.mskRga.ReadOnly = true;
            this.mskRga.Size = new System.Drawing.Size(87, 26);
            this.mskRga.TabIndex = 44;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefone.Location = new System.Drawing.Point(117, 96);
            this.mskTelefone.Mask = "(00) 00000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.ReadOnly = true;
            this.mskTelefone.Size = new System.Drawing.Size(146, 26);
            this.mskTelefone.TabIndex = 43;
            // 
            // lblRga
            // 
            this.lblRga.AutoSize = true;
            this.lblRga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRga.Location = new System.Drawing.Point(21, 204);
            this.lblRga.Name = "lblRga";
            this.lblRga.Size = new System.Drawing.Size(49, 20);
            this.lblRga.TabIndex = 42;
            this.lblRga.Text = "RGA:";
            // 
            // lblTipoAnimal
            // 
            this.lblTipoAnimal.AutoSize = true;
            this.lblTipoAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoAnimal.Location = new System.Drawing.Point(21, 174);
            this.lblTipoAnimal.Name = "lblTipoAnimal";
            this.lblTipoAnimal.Size = new System.Drawing.Size(43, 20);
            this.lblTipoAnimal.TabIndex = 41;
            this.lblTipoAnimal.Text = "Tipo:";
            // 
            // txtTipoAnimal
            // 
            this.txtTipoAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoAnimal.Location = new System.Drawing.Point(94, 176);
            this.txtTipoAnimal.Name = "txtTipoAnimal";
            this.txtTipoAnimal.ReadOnly = true;
            this.txtTipoAnimal.Size = new System.Drawing.Size(169, 26);
            this.txtTipoAnimal.TabIndex = 40;
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimal.Location = new System.Drawing.Point(21, 148);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(61, 20);
            this.lblAnimal.TabIndex = 39;
            this.lblAnimal.Text = "Animal:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(21, 92);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(75, 20);
            this.lblTelefone.TabIndex = 38;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(274, 62);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(44, 20);
            this.lblCpf.TabIndex = 37;
            this.lblCpf.Text = "CPF:";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(21, 62);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(55, 20);
            this.lblNomeCliente.TabIndex = 36;
            this.lblNomeCliente.Text = "Nome:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(94, 64);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(169, 26);
            this.txtNomeCliente.TabIndex = 35;
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCliente.Location = new System.Drawing.Point(165, 24);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(46, 26);
            this.txtCodCliente.TabIndex = 34;
            this.txtCodCliente.TextChanged += new System.EventHandler(this.txtCodCliente_TextChanged);
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCliente.Location = new System.Drawing.Point(21, 24);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(138, 20);
            this.lblIdCliente.TabIndex = 33;
            this.lblIdCliente.Text = "Código do Cliente:";
            // 
            // btnCadastrarAnimal
            // 
            this.btnCadastrarAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarAnimal.Location = new System.Drawing.Point(357, 580);
            this.btnCadastrarAnimal.Name = "btnCadastrarAnimal";
            this.btnCadastrarAnimal.Size = new System.Drawing.Size(121, 66);
            this.btnCadastrarAnimal.TabIndex = 60;
            this.btnCadastrarAnimal.Text = "CADASTRAR ANIMAL";
            this.btnCadastrarAnimal.UseVisualStyleBackColor = true;
            this.btnCadastrarAnimal.Click += new System.EventHandler(this.btnCadastrarAnimal_Click);
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCliente.Location = new System.Drawing.Point(197, 580);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(121, 66);
            this.btnCadastrarCliente.TabIndex = 59;
            this.btnCadastrarCliente.Text = "CADASTRAR CLIENTE";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // btnHospedar
            // 
            this.btnHospedar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHospedar.Location = new System.Drawing.Point(25, 580);
            this.btnHospedar.Name = "btnHospedar";
            this.btnHospedar.Size = new System.Drawing.Size(115, 66);
            this.btnHospedar.TabIndex = 58;
            this.btnHospedar.Text = "HOSPEDAR";
            this.btnHospedar.UseVisualStyleBackColor = true;
            this.btnHospedar.Click += new System.EventHandler(this.btnHospedar_Click);
            // 
            // frmHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 691);
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
            this.Controls.Add(this.lblAgendamento);
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
            this.Name = "frmHotel";
            this.Text = "frmHotel";
            this.Load += new System.EventHandler(this.frmHotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarHospedagens)).EndInit();
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
        private System.Windows.Forms.Label lblAgendamento;
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
    }
}