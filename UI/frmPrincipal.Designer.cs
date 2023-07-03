
namespace UI
{
    partial class frmPrincipal
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
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnimais = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuConexao = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDiskRacao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHotel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaxiDog = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Enabled = false;
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArquivo,
            this.mnuDiskRacao,
            this.mnuHotel,
            this.mnuTaxiDog});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(1413, 24);
            this.mnuPrincipal.TabIndex = 1;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuArquivo
            // 
            this.mnuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbrir,
            this.toolStripMenuItem1,
            this.mnuSair});
            this.mnuArquivo.Name = "mnuArquivo";
            this.mnuArquivo.Size = new System.Drawing.Size(61, 20);
            this.mnuArquivo.Text = "A&rquivo";
            // 
            // mnuAbrir
            // 
            this.mnuAbrir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClientes,
            this.mnuAnimais,
            this.toolStripMenuItem2,
            this.mnuConexao});
            this.mnuAbrir.Name = "mnuAbrir";
            this.mnuAbrir.Size = new System.Drawing.Size(100, 22);
            this.mnuAbrir.Text = "&Abrir";
            // 
            // mnuClientes
            // 
            this.mnuClientes.Name = "mnuClientes";
            this.mnuClientes.Size = new System.Drawing.Size(167, 22);
            this.mnuClientes.Text = "Cadastro &Clientes";
            this.mnuClientes.Click += new System.EventHandler(this.mnuClientes_Click);
            // 
            // mnuAnimais
            // 
            this.mnuAnimais.Name = "mnuAnimais";
            this.mnuAnimais.Size = new System.Drawing.Size(167, 22);
            this.mnuAnimais.Text = "Ca&dastro Animais";
            this.mnuAnimais.Click += new System.EventHandler(this.mnuAnimais_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(164, 6);
            // 
            // mnuConexao
            // 
            this.mnuConexao.Name = "mnuConexao";
            this.mnuConexao.Size = new System.Drawing.Size(167, 22);
            this.mnuConexao.Text = "&Teste Conexão";
            this.mnuConexao.Click += new System.EventHandler(this.mnuConexao_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(97, 6);
            // 
            // mnuSair
            // 
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(100, 22);
            this.mnuSair.Text = "&Sair";
            this.mnuSair.Click += new System.EventHandler(this.mnuSair_Click);
            // 
            // mnuDiskRacao
            // 
            this.mnuDiskRacao.Name = "mnuDiskRacao";
            this.mnuDiskRacao.Size = new System.Drawing.Size(73, 20);
            this.mnuDiskRacao.Text = "&DiskRação";
            this.mnuDiskRacao.Click += new System.EventHandler(this.mnuDiskRacao_Click);
            // 
            // mnuHotel
            // 
            this.mnuHotel.Name = "mnuHotel";
            this.mnuHotel.Size = new System.Drawing.Size(48, 20);
            this.mnuHotel.Text = "&Hotel";
            this.mnuHotel.Click += new System.EventHandler(this.mnuHotel_Click);
            // 
            // mnuTaxiDog
            // 
            this.mnuTaxiDog.Name = "mnuTaxiDog";
            this.mnuTaxiDog.Size = new System.Drawing.Size(64, 20);
            this.mnuTaxiDog.Text = "&Taxi &Dog";
            this.mnuTaxiDog.Click += new System.EventHandler(this.mnuTaxiDog_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(136)))), ((int)(((byte)(156)))));
            this.BackgroundImage = global::UI.Properties.Resources.bg_lightGrayBlue;
            this.ClientSize = new System.Drawing.Size(1413, 568);
            this.Controls.Add(this.mnuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pet Shop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuArquivo;
        private System.Windows.Forms.ToolStripMenuItem mnuAbrir;
        private System.Windows.Forms.ToolStripMenuItem mnuClientes;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuSair;
        private System.Windows.Forms.ToolStripMenuItem mnuAnimais;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuConexao;
        private System.Windows.Forms.ToolStripMenuItem mnuDiskRacao;
        private System.Windows.Forms.ToolStripMenuItem mnuHotel;
        private System.Windows.Forms.ToolStripMenuItem mnuTaxiDog;
    }
}