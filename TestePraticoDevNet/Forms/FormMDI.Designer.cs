namespace TestePraticoDevNet
{
    partial class FormMDI
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
            this.statusStripMDI = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelUsuário = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelNomeUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripMDI = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMDI.SuspendLayout();
            this.menuStripMDI.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripMDI
            // 
            this.statusStripMDI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelUsuário,
            this.toolStripStatusLabelNomeUsuario});
            this.statusStripMDI.Location = new System.Drawing.Point(0, 539);
            this.statusStripMDI.Name = "statusStripMDI";
            this.statusStripMDI.Size = new System.Drawing.Size(884, 22);
            this.statusStripMDI.TabIndex = 0;
            this.statusStripMDI.Text = "statusStrip1";
            // 
            // toolStripStatusLabelUsuário
            // 
            this.toolStripStatusLabelUsuário.Name = "toolStripStatusLabelUsuário";
            this.toolStripStatusLabelUsuário.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabelUsuário.Text = "Usuário: ";
            // 
            // toolStripStatusLabelNomeUsuario
            // 
            this.toolStripStatusLabelNomeUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabelNomeUsuario.Name = "toolStripStatusLabelNomeUsuario";
            this.toolStripStatusLabelNomeUsuario.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabelNomeUsuario.Text = "XXXX";
            // 
            // menuStripMDI
            // 
            this.menuStripMDI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStripMDI.Location = new System.Drawing.Point(0, 0);
            this.menuStripMDI.Name = "menuStripMDI";
            this.menuStripMDI.Size = new System.Drawing.Size(884, 29);
            this.menuStripMDI.TabIndex = 1;
            this.menuStripMDI.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fornecedoresToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(91, 25);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(49, 25);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // FormMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.statusStripMDI);
            this.Controls.Add(this.menuStripMDI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMDI;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMDI";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema";
            this.Load += new System.EventHandler(this.FormMDI_Load);
            this.statusStripMDI.ResumeLayout(false);
            this.statusStripMDI.PerformLayout();
            this.menuStripMDI.ResumeLayout(false);
            this.menuStripMDI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUsuário;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        public System.Windows.Forms.StatusStrip statusStripMDI;
        public System.Windows.Forms.MenuStrip menuStripMDI;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNomeUsuario;
    }
}

