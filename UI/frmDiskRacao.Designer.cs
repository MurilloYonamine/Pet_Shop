
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
            ((System.ComponentModel.ISupportInitialize)(this.picBgDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // picBgDog
            // 
            this.picBgDog.Image = global::UI.Properties.Resources.bg_girl;
            this.picBgDog.Location = new System.Drawing.Point(-3, -42);
            this.picBgDog.Name = "picBgDog";
            this.picBgDog.Size = new System.Drawing.Size(281, 410);
            this.picBgDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBgDog.TabIndex = 1;
            this.picBgDog.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(510, 33);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(59, 26);
            this.txtCodigo.TabIndex = 2;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(327, 36);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(177, 18);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código do Atendimento:";
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrada.Location = new System.Drawing.Point(429, 144);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(140, 26);
            this.dtpEntrada.TabIndex = 4;
            this.dtpEntrada.Value = new System.DateTime(2023, 6, 27, 0, 0, 0, 0);
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(327, 150);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(67, 18);
            this.lblEntrada.TabIndex = 5;
            this.lblEntrada.Text = "Entrada:";
            // 
            // lblRacao
            // 
            this.lblRacao.AutoSize = true;
            this.lblRacao.Location = new System.Drawing.Point(327, 91);
            this.lblRacao.Name = "lblRacao";
            this.lblRacao.Size = new System.Drawing.Size(58, 18);
            this.lblRacao.TabIndex = 7;
            this.lblRacao.Text = "Ração:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(686, 264);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(99, 47);
            this.btnEnviar.TabIndex = 10;
            this.btnEnviar.Text = "ENVIAR";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblFuncionário
            // 
            this.lblFuncionário.AutoSize = true;
            this.lblFuncionário.Location = new System.Drawing.Point(327, 210);
            this.lblFuncionário.Name = "lblFuncionário";
            this.lblFuncionário.Size = new System.Drawing.Size(94, 18);
            this.lblFuncionário.TabIndex = 12;
            this.lblFuncionário.Text = "Funcionario:";
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.Location = new System.Drawing.Point(575, 150);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(53, 18);
            this.lblSaida.TabIndex = 14;
            this.lblSaida.Text = "Saída:";
            // 
            // dtpSaida
            // 
            this.dtpSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSaida.Location = new System.Drawing.Point(634, 144);
            this.dtpSaida.Name = "dtpSaida";
            this.dtpSaida.Size = new System.Drawing.Size(151, 26);
            this.dtpSaida.TabIndex = 13;
            this.dtpSaida.Value = new System.DateTime(2023, 6, 27, 0, 0, 0, 0);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(557, 264);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(99, 47);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(591, 91);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(37, 18);
            this.lblQuantidade.TabIndex = 17;
            this.lblQuantidade.Text = "Qtd:";
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Location = new System.Drawing.Point(842, 33);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.ReadOnly = true;
            this.dgvEstoque.Size = new System.Drawing.Size(295, 289);
            this.dgvEstoque.TabIndex = 19;
            this.dgvEstoque.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstoque_CellClick);
            // 
            // cboFuncionario
            // 
            this.cboFuncionario.FormattingEnabled = true;
            this.cboFuncionario.Location = new System.Drawing.Point(429, 207);
            this.cboFuncionario.Name = "cboFuncionario";
            this.cboFuncionario.Size = new System.Drawing.Size(140, 26);
            this.cboFuncionario.TabIndex = 20;
            // 
            // numQuantidade
            // 
            this.numQuantidade.Location = new System.Drawing.Point(634, 88);
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(151, 26);
            this.numQuantidade.TabIndex = 21;
            // 
            // txtRacao
            // 
            this.txtRacao.Location = new System.Drawing.Point(429, 88);
            this.txtRacao.Name = "txtRacao";
            this.txtRacao.Size = new System.Drawing.Size(140, 26);
            this.txtRacao.TabIndex = 22;
            // 
            // frmDiskRacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(1189, 357);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDiskRacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disk Ração";
            this.Load += new System.EventHandler(this.frmDiskRacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBgDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
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
    }
}