
namespace UI
{
    partial class frmDiskRacao
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblRacao = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblFuncionário = new System.Windows.Forms.Label();
            this.lblSaida = new System.Windows.Forms.Label();
            this.dtpSaida = new System.Windows.Forms.DateTimePicker();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.cboFuncionario = new System.Windows.Forms.ComboBox();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.txtRacao = new System.Windows.Forms.TextBox();
            this.lblCodigoRacao = new System.Windows.Forms.Label();
            this.txtCodigoRacao = new System.Windows.Forms.TextBox();
            this.dgvDiskRacao = new System.Windows.Forms.DataGridView();
            this.lblDiskRacao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBgDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiskRacao)).BeginInit();
            this.SuspendLayout();
            // 
            // picBgDog
            // 
            this.picBgDog.Image = global::UI.Properties.Resources.bg_girl;
            this.picBgDog.Location = new System.Drawing.Point(-3, -42);
            this.picBgDog.Name = "picBgDog";
            this.picBgDog.Size = new System.Drawing.Size(464, 680);
            this.picBgDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBgDog.TabIndex = 1;
            this.picBgDog.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(662, 51);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(59, 26);
            this.txtCodigo.TabIndex = 40;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(479, 54);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(177, 18);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código do Atendimento:";
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrada.Location = new System.Drawing.Point(581, 162);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(140, 26);
            this.dtpEntrada.TabIndex = 3;
            this.dtpEntrada.Value = new System.DateTime(2023, 7, 10, 0, 0, 0, 0);
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(479, 168);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(67, 18);
            this.lblEntrada.TabIndex = 5;
            this.lblEntrada.Text = "Entrada:";
            // 
            // lblRacao
            // 
            this.lblRacao.AutoSize = true;
            this.lblRacao.Location = new System.Drawing.Point(479, 109);
            this.lblRacao.Name = "lblRacao";
            this.lblRacao.Size = new System.Drawing.Size(58, 18);
            this.lblRacao.TabIndex = 7;
            this.lblRacao.Text = "Ração:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.White;
            this.btnEnviar.Image = global::UI.Properties.Resources.save_fill;
            this.btnEnviar.Location = new System.Drawing.Point(920, 287);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(99, 81);
            this.btnEnviar.TabIndex = 10;
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblFuncionário
            // 
            this.lblFuncionário.AutoSize = true;
            this.lblFuncionário.Location = new System.Drawing.Point(479, 228);
            this.lblFuncionário.Name = "lblFuncionário";
            this.lblFuncionário.Size = new System.Drawing.Size(94, 18);
            this.lblFuncionário.TabIndex = 12;
            this.lblFuncionário.Text = "Funcionario:";
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.Location = new System.Drawing.Point(809, 168);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(53, 18);
            this.lblSaida.TabIndex = 14;
            this.lblSaida.Text = "Saída:";
            // 
            // dtpSaida
            // 
            this.dtpSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSaida.Location = new System.Drawing.Point(868, 162);
            this.dtpSaida.Name = "dtpSaida";
            this.dtpSaida.Size = new System.Drawing.Size(151, 26);
            this.dtpSaida.TabIndex = 4;
            this.dtpSaida.Value = new System.DateTime(2023, 7, 10, 0, 0, 0, 0);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Image = global::UI.Properties.Resources.eraser_fill;
            this.btnLimpar.Location = new System.Drawing.Point(778, 287);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(99, 81);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(825, 109);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(37, 18);
            this.lblQuantidade.TabIndex = 17;
            this.lblQuantidade.Text = "Qtd:";
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.AllowUserToAddRows = false;
            this.dgvEstoque.AllowUserToDeleteRows = false;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Location = new System.Drawing.Point(1051, 33);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.ReadOnly = true;
            this.dgvEstoque.Size = new System.Drawing.Size(295, 335);
            this.dgvEstoque.TabIndex = 19;
            this.dgvEstoque.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstoque_CellClick);
            // 
            // cboFuncionario
            // 
            this.cboFuncionario.FormattingEnabled = true;
            this.cboFuncionario.ItemHeight = 18;
            this.cboFuncionario.Location = new System.Drawing.Point(581, 225);
            this.cboFuncionario.Name = "cboFuncionario";
            this.cboFuncionario.Size = new System.Drawing.Size(140, 26);
            this.cboFuncionario.TabIndex = 5;
            // 
            // numQuantidade
            // 
            this.numQuantidade.Location = new System.Drawing.Point(868, 106);
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(151, 26);
            this.numQuantidade.TabIndex = 2;
            this.numQuantidade.ValueChanged += new System.EventHandler(this.numQuantidade_ValueChanged);
            // 
            // txtRacao
            // 
            this.txtRacao.Location = new System.Drawing.Point(581, 106);
            this.txtRacao.Name = "txtRacao";
            this.txtRacao.ReadOnly = true;
            this.txtRacao.Size = new System.Drawing.Size(140, 26);
            this.txtRacao.TabIndex = 1;
            // 
            // lblCodigoRacao
            // 
            this.lblCodigoRacao.AutoSize = true;
            this.lblCodigoRacao.Location = new System.Drawing.Point(817, 54);
            this.lblCodigoRacao.Name = "lblCodigoRacao";
            this.lblCodigoRacao.Size = new System.Drawing.Size(136, 18);
            this.lblCodigoRacao.TabIndex = 24;
            this.lblCodigoRacao.Text = "Código da Ração:";
            // 
            // txtCodigoRacao
            // 
            this.txtCodigoRacao.Location = new System.Drawing.Point(959, 51);
            this.txtCodigoRacao.Name = "txtCodigoRacao";
            this.txtCodigoRacao.ReadOnly = true;
            this.txtCodigoRacao.Size = new System.Drawing.Size(59, 26);
            this.txtCodigoRacao.TabIndex = 23;
            // 
            // dgvDiskRacao
            // 
            this.dgvDiskRacao.AllowUserToAddRows = false;
            this.dgvDiskRacao.AllowUserToDeleteRows = false;
            this.dgvDiskRacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiskRacao.Location = new System.Drawing.Point(483, 427);
            this.dgvDiskRacao.Name = "dgvDiskRacao";
            this.dgvDiskRacao.ReadOnly = true;
            this.dgvDiskRacao.Size = new System.Drawing.Size(863, 196);
            this.dgvDiskRacao.TabIndex = 41;
            this.dgvDiskRacao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiskRacao_CellClick);
            // 
            // lblDiskRacao
            // 
            this.lblDiskRacao.AutoSize = true;
            this.lblDiskRacao.Location = new System.Drawing.Point(480, 406);
            this.lblDiskRacao.Name = "lblDiskRacao";
            this.lblDiskRacao.Size = new System.Drawing.Size(160, 18);
            this.lblDiskRacao.TabIndex = 42;
            this.lblDiskRacao.Text = "Histórico Disk Ração:";
            // 
            // frmDiskRacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(1358, 635);
            this.Controls.Add(this.lblDiskRacao);
            this.Controls.Add(this.dgvDiskRacao);
            this.Controls.Add(this.lblCodigoRacao);
            this.Controls.Add(this.txtCodigoRacao);
            this.Controls.Add(this.txtRacao);
            this.Controls.Add(this.numQuantidade);
            this.Controls.Add(this.cboFuncionario);
            this.Controls.Add(this.dgvEstoque);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblSaida);
            this.Controls.Add(this.dtpSaida);
            this.Controls.Add(this.lblFuncionário);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblRacao);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.dtpEntrada);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.picBgDog);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDiskRacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disk Ração";
            this.Load += new System.EventHandler(this.frmDiskRacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBgDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiskRacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBgDog;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblRacao;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblFuncionário;
        private System.Windows.Forms.Label lblSaida;
        private System.Windows.Forms.DateTimePicker dtpSaida;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.ComboBox cboFuncionario;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.TextBox txtRacao;
        private System.Windows.Forms.Label lblCodigoRacao;
        private System.Windows.Forms.TextBox txtCodigoRacao;
        private System.Windows.Forms.DataGridView dgvDiskRacao;
        private System.Windows.Forms.Label lblDiskRacao;
    }
}