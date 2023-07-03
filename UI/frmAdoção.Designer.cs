
namespace UI
{
    partial class frmAdoção
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
            this.picFundo = new System.Windows.Forms.PictureBox();
            this.lblAdoção = new System.Windows.Forms.Label();
            this.dgvAdocao = new System.Windows.Forms.DataGridView();
            this.lblCodigoAdocao = new System.Windows.Forms.Label();
            this.txtCodigoAdocao = new System.Windows.Forms.TextBox();
            this.txtPet = new System.Windows.Forms.TextBox();
            this.lblPet = new System.Windows.Forms.Label();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.cboFuncionario = new System.Windows.Forms.ComboBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.txtCodigoPet = new System.Windows.Forms.TextBox();
            this.lblCodigoPet = new System.Windows.Forms.Label();
            this.txtPesquisaAnimal = new System.Windows.Forms.TextBox();
            this.lblPesquisaAnimal = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txtPesquisaCliente = new System.Windows.Forms.TextBox();
            this.lblPesquisaCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // picFundo
            // 
            this.picFundo.Image = global::UI.Properties.Resources.bg_blue;
            this.picFundo.Location = new System.Drawing.Point(-62, 412);
            this.picFundo.Margin = new System.Windows.Forms.Padding(4);
            this.picFundo.Name = "picFundo";
            this.picFundo.Size = new System.Drawing.Size(1512, 139);
            this.picFundo.TabIndex = 0;
            this.picFundo.TabStop = false;
            // 
            // lblAdoção
            // 
            this.lblAdoção.AutoSize = true;
            this.lblAdoção.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdoção.Location = new System.Drawing.Point(376, 9);
            this.lblAdoção.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdoção.Name = "lblAdoção";
            this.lblAdoção.Size = new System.Drawing.Size(315, 75);
            this.lblAdoção.TabIndex = 1;
            this.lblAdoção.Text = "ADOÇÃO";
            // 
            // dgvAdocao
            // 
            this.dgvAdocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdocao.Location = new System.Drawing.Point(773, 117);
            this.dgvAdocao.Name = "dgvAdocao";
            this.dgvAdocao.ReadOnly = true;
            this.dgvAdocao.Size = new System.Drawing.Size(656, 310);
            this.dgvAdocao.TabIndex = 2;
            this.dgvAdocao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdocao_CellClick);
            this.dgvAdocao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdocao_CellContentClick);
            // 
            // lblCodigoAdocao
            // 
            this.lblCodigoAdocao.AutoSize = true;
            this.lblCodigoAdocao.Location = new System.Drawing.Point(337, 117);
            this.lblCodigoAdocao.Name = "lblCodigoAdocao";
            this.lblCodigoAdocao.Size = new System.Drawing.Size(140, 18);
            this.lblCodigoAdocao.TabIndex = 3;
            this.lblCodigoAdocao.Text = "Código da Adoção";
            // 
            // txtCodigoAdocao
            // 
            this.txtCodigoAdocao.Location = new System.Drawing.Point(340, 138);
            this.txtCodigoAdocao.Name = "txtCodigoAdocao";
            this.txtCodigoAdocao.ReadOnly = true;
            this.txtCodigoAdocao.Size = new System.Drawing.Size(165, 26);
            this.txtCodigoAdocao.TabIndex = 4;
            // 
            // txtPet
            // 
            this.txtPet.Location = new System.Drawing.Point(551, 211);
            this.txtPet.Name = "txtPet";
            this.txtPet.Size = new System.Drawing.Size(165, 26);
            this.txtPet.TabIndex = 6;
            // 
            // lblPet
            // 
            this.lblPet.AutoSize = true;
            this.lblPet.Location = new System.Drawing.Point(548, 190);
            this.lblPet.Name = "lblPet";
            this.lblPet.Size = new System.Drawing.Size(36, 18);
            this.lblPet.TabIndex = 5;
            this.lblPet.Text = "Pet:";
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(548, 258);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(94, 18);
            this.lblFuncionario.TabIndex = 7;
            this.lblFuncionario.Text = "Funcionário:";
            // 
            // cboFuncionario
            // 
            this.cboFuncionario.FormattingEnabled = true;
            this.cboFuncionario.Location = new System.Drawing.Point(551, 279);
            this.cboFuncionario.Name = "cboFuncionario";
            this.cboFuncionario.Size = new System.Drawing.Size(165, 26);
            this.cboFuncionario.TabIndex = 8;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(551, 138);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(165, 26);
            this.txtCliente.TabIndex = 10;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(548, 117);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(61, 18);
            this.lblCliente.TabIndex = 9;
            this.lblCliente.Text = "Cliente:";
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(340, 279);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(165, 26);
            this.dtpData.TabIndex = 11;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(337, 258);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(46, 18);
            this.lblData.TabIndex = 12;
            this.lblData.Text = "Data:";
            // 
            // txtCodigoPet
            // 
            this.txtCodigoPet.Location = new System.Drawing.Point(340, 211);
            this.txtCodigoPet.Name = "txtCodigoPet";
            this.txtCodigoPet.Size = new System.Drawing.Size(165, 26);
            this.txtCodigoPet.TabIndex = 15;
            // 
            // lblCodigoPet
            // 
            this.lblCodigoPet.AutoSize = true;
            this.lblCodigoPet.Location = new System.Drawing.Point(337, 190);
            this.lblCodigoPet.Name = "lblCodigoPet";
            this.lblCodigoPet.Size = new System.Drawing.Size(92, 18);
            this.lblCodigoPet.TabIndex = 14;
            this.lblCodigoPet.Text = "Código Pet:";
            // 
            // txtPesquisaAnimal
            // 
            this.txtPesquisaAnimal.BackColor = System.Drawing.Color.White;
            this.txtPesquisaAnimal.Location = new System.Drawing.Point(855, 85);
            this.txtPesquisaAnimal.Name = "txtPesquisaAnimal";
            this.txtPesquisaAnimal.Size = new System.Drawing.Size(144, 26);
            this.txtPesquisaAnimal.TabIndex = 32;
            this.txtPesquisaAnimal.TextChanged += new System.EventHandler(this.txtPesquisaAnimal_TextChanged);
            // 
            // lblPesquisaAnimal
            // 
            this.lblPesquisaAnimal.AutoSize = true;
            this.lblPesquisaAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.lblPesquisaAnimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.lblPesquisaAnimal.Location = new System.Drawing.Point(771, 87);
            this.lblPesquisaAnimal.Name = "lblPesquisaAnimal";
            this.lblPesquisaAnimal.Size = new System.Drawing.Size(78, 18);
            this.lblPesquisaAnimal.TabIndex = 33;
            this.lblPesquisaAnimal.Text = "Pesquisa:";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Image = global::UI.Properties.Resources.box_arrow_right;
            this.btnSair.Location = new System.Drawing.Point(619, 335);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(97, 92);
            this.btnSair.TabIndex = 42;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Image = global::UI.Properties.Resources.eraser_fill;
            this.btnLimpar.Location = new System.Drawing.Point(478, 335);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(97, 92);
            this.btnLimpar.TabIndex = 41;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Image = global::UI.Properties.Resources.save_fill;
            this.btnSalvar.Location = new System.Drawing.Point(340, 335);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(97, 92);
            this.btnSalvar.TabIndex = 40;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 117);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(225, 310);
            this.dgvClientes.TabIndex = 43;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // txtPesquisaCliente
            // 
            this.txtPesquisaCliente.BackColor = System.Drawing.Color.White;
            this.txtPesquisaCliente.Location = new System.Drawing.Point(93, 87);
            this.txtPesquisaCliente.Name = "txtPesquisaCliente";
            this.txtPesquisaCliente.Size = new System.Drawing.Size(144, 26);
            this.txtPesquisaCliente.TabIndex = 44;
            this.txtPesquisaCliente.TextChanged += new System.EventHandler(this.txtPesquisaCliente_TextChanged);
            // 
            // lblPesquisaCliente
            // 
            this.lblPesquisaCliente.AutoSize = true;
            this.lblPesquisaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.lblPesquisaCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.lblPesquisaCliente.Location = new System.Drawing.Point(9, 90);
            this.lblPesquisaCliente.Name = "lblPesquisaCliente";
            this.lblPesquisaCliente.Size = new System.Drawing.Size(78, 18);
            this.lblPesquisaCliente.TabIndex = 45;
            this.lblPesquisaCliente.Text = "Pesquisa:";
            // 
            // frmAdoção
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(212)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(1441, 468);
            this.Controls.Add(this.txtPesquisaCliente);
            this.Controls.Add(this.lblPesquisaCliente);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtPesquisaAnimal);
            this.Controls.Add(this.lblPesquisaAnimal);
            this.Controls.Add(this.txtCodigoPet);
            this.Controls.Add(this.lblCodigoPet);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cboFuncionario);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.txtPet);
            this.Controls.Add(this.lblPet);
            this.Controls.Add(this.txtCodigoAdocao);
            this.Controls.Add(this.lblCodigoAdocao);
            this.Controls.Add(this.dgvAdocao);
            this.Controls.Add(this.lblAdoção);
            this.Controls.Add(this.picFundo);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdoção";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adoção";
            this.Load += new System.EventHandler(this.frmAdoção_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFundo;
        private System.Windows.Forms.Label lblAdoção;
        private System.Windows.Forms.DataGridView dgvAdocao;
        private System.Windows.Forms.Label lblCodigoAdocao;
        private System.Windows.Forms.TextBox txtCodigoAdocao;
        private System.Windows.Forms.TextBox txtPet;
        private System.Windows.Forms.Label lblPet;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.ComboBox cboFuncionario;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtCodigoPet;
        private System.Windows.Forms.Label lblCodigoPet;
        private System.Windows.Forms.TextBox txtPesquisaAnimal;
        private System.Windows.Forms.Label lblPesquisaAnimal;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txtPesquisaCliente;
        private System.Windows.Forms.Label lblPesquisaCliente;
    }
}