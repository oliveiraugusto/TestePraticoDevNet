namespace TestePraticoDevNet.Forms
{
    partial class FormFornecedores
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
            this.tabControlFornecedor = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.dataGridViewFornecedores = new System.Windows.Forms.DataGridView();
            this.textBoxPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.checkBoxAtivo = new System.Windows.Forms.CheckBox();
            this.maskedTextBoxCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControlFornecedor.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedores)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlFornecedor
            // 
            this.tabControlFornecedor.Controls.Add(this.tabPage1);
            this.tabControlFornecedor.Controls.Add(this.tabPage2);
            this.tabControlFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlFornecedor.Location = new System.Drawing.Point(0, -1);
            this.tabControlFornecedor.Name = "tabControlFornecedor";
            this.tabControlFornecedor.SelectedIndex = 0;
            this.tabControlFornecedor.Size = new System.Drawing.Size(605, 361);
            this.tabControlFornecedor.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonNovo);
            this.tabPage1.Controls.Add(this.buttonExcluir);
            this.tabPage1.Controls.Add(this.dataGridViewFornecedores);
            this.tabPage1.Controls.Add(this.textBoxPesquisar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(597, 328);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consulta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonNovo
            // 
            this.buttonNovo.Location = new System.Drawing.Point(485, 270);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(83, 32);
            this.buttonNovo.TabIndex = 3;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(35, 270);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(83, 32);
            this.buttonExcluir.TabIndex = 4;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click_1);
            // 
            // dataGridViewFornecedores
            // 
            this.dataGridViewFornecedores.AllowUserToAddRows = false;
            this.dataGridViewFornecedores.AllowUserToDeleteRows = false;
            this.dataGridViewFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFornecedores.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewFornecedores.Location = new System.Drawing.Point(35, 59);
            this.dataGridViewFornecedores.MaximumSize = new System.Drawing.Size(533, 205);
            this.dataGridViewFornecedores.MinimumSize = new System.Drawing.Size(533, 205);
            this.dataGridViewFornecedores.Name = "dataGridViewFornecedores";
            this.dataGridViewFornecedores.ReadOnly = true;
            this.dataGridViewFornecedores.Size = new System.Drawing.Size(533, 205);
            this.dataGridViewFornecedores.TabIndex = 2;
            this.dataGridViewFornecedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFornecedores_CellClick);
            this.dataGridViewFornecedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFornecedores_CellDoubleClick);
            this.dataGridViewFornecedores.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewFornecedores_CellFormatting);
            // 
            // textBoxPesquisar
            // 
            this.textBoxPesquisar.Location = new System.Drawing.Point(150, 27);
            this.textBoxPesquisar.Name = "textBoxPesquisar";
            this.textBoxPesquisar.Size = new System.Drawing.Size(288, 26);
            this.textBoxPesquisar.TabIndex = 1;
            this.textBoxPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPesquisar_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pesquisar";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonSalvar);
            this.tabPage2.Controls.Add(this.buttonCancelar);
            this.tabPage2.Controls.Add(this.checkBoxAtivo);
            this.tabPage2.Controls.Add(this.maskedTextBoxCNPJ);
            this.tabPage2.Controls.Add(this.textBoxNome);
            this.tabPage2.Controls.Add(this.textBoxEndereco);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(597, 328);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastro";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(367, 190);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(87, 35);
            this.buttonSalvar.TabIndex = 5;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(108, 190);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(87, 35);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.AutoSize = true;
            this.checkBoxAtivo.Location = new System.Drawing.Point(188, 150);
            this.checkBoxAtivo.Name = "checkBoxAtivo";
            this.checkBoxAtivo.Size = new System.Drawing.Size(63, 24);
            this.checkBoxAtivo.TabIndex = 4;
            this.checkBoxAtivo.Text = "Ativo";
            this.checkBoxAtivo.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxCNPJ
            // 
            this.maskedTextBoxCNPJ.Location = new System.Drawing.Point(188, 87);
            this.maskedTextBoxCNPJ.Mask = "99,999,999/9999-99";
            this.maskedTextBoxCNPJ.Name = "maskedTextBoxCNPJ";
            this.maskedTextBoxCNPJ.Size = new System.Drawing.Size(266, 26);
            this.maskedTextBoxCNPJ.TabIndex = 2;
            this.maskedTextBoxCNPJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(188, 56);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(266, 26);
            this.textBoxNome.TabIndex = 1;
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(188, 118);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(266, 26);
            this.textBoxEndereco.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "CNPJ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // FormFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 361);
            this.Controls.Add(this.tabControlFornecedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFornecedores";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedores";
            this.Load += new System.EventHandler(this.FormFornecedores_Load);
            this.tabControlFornecedor.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedores)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlFornecedor;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.DataGridView dataGridViewFornecedores;
        private System.Windows.Forms.TextBox textBoxPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.CheckBox checkBoxAtivo;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCNPJ;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}