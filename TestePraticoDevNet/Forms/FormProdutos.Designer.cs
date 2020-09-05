namespace TestePraticoDevNet.Forms
{
    partial class FormProdutos
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
            this.tabControlProdutos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.textBoxPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBoxForncedor = new System.Windows.Forms.ComboBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.numericUpDownQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControlProdutos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlProdutos
            // 
            this.tabControlProdutos.Controls.Add(this.tabPage1);
            this.tabControlProdutos.Controls.Add(this.tabPage2);
            this.tabControlProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlProdutos.Location = new System.Drawing.Point(-2, 0);
            this.tabControlProdutos.Name = "tabControlProdutos";
            this.tabControlProdutos.SelectedIndex = 0;
            this.tabControlProdutos.Size = new System.Drawing.Size(590, 361);
            this.tabControlProdutos.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonNovo);
            this.tabPage1.Controls.Add(this.buttonExcluir);
            this.tabPage1.Controls.Add(this.dataGridViewProdutos);
            this.tabPage1.Controls.Add(this.textBoxPesquisar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(582, 328);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consulta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonNovo
            // 
            this.buttonNovo.Location = new System.Drawing.Point(473, 262);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(83, 32);
            this.buttonNovo.TabIndex = 4;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(48, 262);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(83, 32);
            this.buttonExcluir.TabIndex = 3;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.AllowUserToAddRows = false;
            this.dataGridViewProdutos.AllowUserToDeleteRows = false;
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(48, 51);
            this.dataGridViewProdutos.MaximumSize = new System.Drawing.Size(508, 205);
            this.dataGridViewProdutos.MinimumSize = new System.Drawing.Size(508, 205);
            this.dataGridViewProdutos.MultiSelect = false;
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.ReadOnly = true;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(508, 205);
            this.dataGridViewProdutos.TabIndex = 2;
            this.dataGridViewProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdutos_CellClick);
            this.dataGridViewProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdutos_CellDoubleClick);
            // 
            // textBoxPesquisar
            // 
            this.textBoxPesquisar.Location = new System.Drawing.Point(163, 19);
            this.textBoxPesquisar.Name = "textBoxPesquisar";
            this.textBoxPesquisar.Size = new System.Drawing.Size(288, 26);
            this.textBoxPesquisar.TabIndex = 1;
            this.textBoxPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPesquisar_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBoxForncedor);
            this.tabPage2.Controls.Add(this.buttonSalvar);
            this.tabPage2.Controls.Add(this.buttonCancelar);
            this.tabPage2.Controls.Add(this.numericUpDownQuantidade);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textBoxNome);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(582, 328);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastro";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBoxForncedor
            // 
            this.comboBoxForncedor.FormattingEnabled = true;
            this.comboBoxForncedor.Location = new System.Drawing.Point(193, 71);
            this.comboBoxForncedor.Name = "comboBoxForncedor";
            this.comboBoxForncedor.Size = new System.Drawing.Size(300, 28);
            this.comboBoxForncedor.TabIndex = 2;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(405, 178);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(88, 34);
            this.buttonSalvar.TabIndex = 4;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(99, 178);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(88, 34);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // numericUpDownQuantidade
            // 
            this.numericUpDownQuantidade.Location = new System.Drawing.Point(193, 105);
            this.numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            this.numericUpDownQuantidade.Size = new System.Drawing.Size(39, 26);
            this.numericUpDownQuantidade.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fornecedor";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(192, 41);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(301, 26);
            this.textBoxNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tabControlProdutos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProdutos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.FormProdutos_Load);
            this.tabControlProdutos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlProdutos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.TextBox textBoxPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown numericUpDownQuantidade;
        public System.Windows.Forms.TextBox textBoxNome;
        public System.Windows.Forms.ComboBox comboBoxForncedor;
        //private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn fornecedoresIDDataGridViewTextBoxColumn;
    }
}