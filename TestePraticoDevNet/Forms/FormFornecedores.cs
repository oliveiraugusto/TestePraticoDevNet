using Maoli;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TestePraticoDevNet.Classes;
using TestePraticoDevNet.Model;

namespace TestePraticoDevNet.Forms
{
    public partial class FormFornecedores : Form
    {
        public string ID_Fornecedor { get; set; }

        public FormFornecedores()
        {
            InitializeComponent();
        }

        private void FormFornecedores_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Tem certeza?\n(essa operação não pode ser desfeita)", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                LimpaBox();
                tabControlFornecedor.SelectedTab = this.tabPage1;
            }
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            buttonSalvar.Text = "Salvar";
            LimpaBox();
            tabControlFornecedor.SelectedTab = this.tabPage2;            
        }

        private void buttonExcluir_Click_1(object sender, EventArgs e)
        {
            try
            {
                var context = new ApplicationDbContext();
                if (!string.IsNullOrEmpty(ID_Fornecedor))
                {
                    var vinculo = from produto in context.Produtos
                                  where produto.Fornecedores.ID == new Guid(ID_Fornecedor)
                                  select produto;

                    if(vinculo.Count() == 0)
                    {
                        var dialogResult = MessageBox.Show("Tem certeza?\n(essa operação não pode ser desfeita)", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.Yes)
                        {
                            var fornecedor = context.Fornecedores.Where(p => p.ID == new Guid(ID_Fornecedor)).First();
                            context.Fornecedores.Remove(fornecedor);
                            context.SaveChanges();

                            MessageBox.Show("Produto excluido com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpaBox();
                            CarregaGrid();
                        }
                    }                    
                    else
                    {
                        MessageBox.Show($"Existem {vinculo.Count().ToString()} produtos cadastrados com esse fornecedor vinculado.\nExclua ou atualize esse produtos antes de excluir esse fornecedor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um item para excluir", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um erro ao excluir as informações.\nDetalhes:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewFornecedores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex != dataGridViewFornecedores.NewRowIndex)
            {
                try
                {
                    long valor = Convert.ToInt64(dataGridViewFornecedores.Rows[e.RowIndex].Cells["Cnpj"].Value);
                    string cnpj = string.Format(@"{0:00\.000\.000\/0000\-00}", valor);
                    dataGridViewFornecedores.Rows[e.RowIndex].Cells["Cnpj"].Value = cnpj;
                }
                catch
                {
                    return;
                }
            }
        }

        private void CarregaGrid()
        {
            dataGridViewFornecedores.AutoSize = true;
            dataGridViewFornecedores.DataSource = null;
            var f = new Classes.Fornecedor();
            var data = f.SelectAll();
            dataGridViewFornecedores.DataSource = data;

            dataGridViewFornecedores.Columns["ID"].Visible = false;
            dataGridViewFornecedores.Columns["Cnpj"].Visible = true;
            dataGridViewFornecedores.Columns["Cnpj"].Width = 200;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            maskedTextBoxCNPJ.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            var cnpj = maskedTextBoxCNPJ.Text;
            maskedTextBoxCNPJ.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            try
            {                
                if (!string.IsNullOrEmpty(textBoxNome.Text) ||
                    !string.IsNullOrEmpty(maskedTextBoxCNPJ.Text) ||
                    !string.IsNullOrEmpty(textBoxEndereco.Text))
                    {
                        var context = new ApplicationDbContext();

                        // valida CNPJ
                        var valida = Cnpj.Validate(maskedTextBoxCNPJ.Text);
                        if (valida == true)
                        {
                            if (buttonSalvar.Text == "Salvar")
                            {
                                //verifica se o CNPJ ja esta cadastrado
                                int existe = context.Fornecedores.Where(x => x.Cnpj == cnpj).Count();

                                if (existe >= 1)
                                {
                                    MessageBox.Show($"O CNPJ {maskedTextBoxCNPJ.Text} já esta cadastrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    maskedTextBoxCNPJ.Focus();
                                }
                                else
                                {
                                    var fornecedor = new Model.Fornecedor
                                    {
                                        ID = Guid.NewGuid(),
                                        Nome = textBoxNome.Text,
                                        Cnpj = cnpj,
                                        Endereco = textBoxEndereco.Text,
                                        Ativo = checkBoxAtivo.Checked
                                    };

                                    context.Fornecedores.Add(fornecedor);
                                    context.SaveChanges();
                                    MessageBox.Show("Cadastro realizado com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LimpaBox();
                                    CarregaGrid();
                                    tabControlFornecedor.SelectedTab = this.tabPage1;
                                }
                            }
                            else if (buttonSalvar.Text == "Atualizar")
                            {
                                var dialogResult = MessageBox.Show("Tem certeza?\n(essa operação não pode ser desfeita)", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (dialogResult == DialogResult.Yes)
                                {
                                            var fornecedor = context.Fornecedores.First(x => x.ID == new Guid(ID_Fornecedor));
                                            fornecedor.Nome = textBoxNome.Text;
                                            fornecedor.Cnpj = cnpj;
                                            fornecedor.Endereco = textBoxEndereco.Text;
                                            fornecedor.Ativo = checkBoxAtivo.Checked;

                                            context.SaveChanges();
                                            MessageBox.Show("Atualização realizada com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            CarregaGrid();
                                            LimpaBox();
                                            tabControlFornecedor.SelectedTab = this.tabPage1;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("CNPJ Invalido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            maskedTextBoxCNPJ.Focus();
                        }                        
                    }
                    else
                    {
                        MessageBox.Show("Não deixe os campos em branco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBoxNome.Focus();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um erro.\nDetalhes:\n{ex.InnerException}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void dataGridViewFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_Fornecedor = dataGridViewFornecedores.CurrentRow.Cells["ID"].Value.ToString();
        }

        private void dataGridViewFornecedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNome.Text = dataGridViewFornecedores.CurrentRow.Cells["Nome"].Value.ToString();
            maskedTextBoxCNPJ.Text = dataGridViewFornecedores.CurrentRow.Cells["Cnpj"].Value.ToString();
            textBoxEndereco.Text = dataGridViewFornecedores.CurrentRow.Cells["Endereco"].Value.ToString();
            checkBoxAtivo.Checked  = (bool)dataGridViewFornecedores.CurrentRow.Cells["Ativo"].Value;

            buttonSalvar.Text = "Atualizar";

            tabControlFornecedor.SelectedTab = this.tabPage2;
        }
        private void LimpaBox()
        {
            textBoxNome.Text = String.Empty;
            textBoxEndereco.Text = String.Empty;
            maskedTextBoxCNPJ.Text = String.Empty;
            checkBoxAtivo.Checked = false;
        }

        private void textBoxPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode  == System.Windows.Forms.Keys.Enter)
            {
                if(!string.IsNullOrEmpty(textBoxPesquisar.Text))
                {
                    var busca = textBoxPesquisar.Text;

                    ((DataTable)dataGridViewFornecedores.DataSource).DefaultView.RowFilter = $"{"Nome"} like '%{busca}%' OR {"Endereco"} like '%{busca}%'";

                }
                else
                {
                    CarregaGrid();
                }
            }
        }
    }
}
