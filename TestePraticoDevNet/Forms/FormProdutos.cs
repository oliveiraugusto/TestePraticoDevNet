using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestePraticoDevNet.Classes;
using TestePraticoDevNet.Model;

namespace TestePraticoDevNet.Forms
{
    public partial class FormProdutos : Form
    {
        public string ID_Produto { get; set; }

        public FormProdutos()
        {
            InitializeComponent();
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {
            CarregaGrid();
            CarregaFornecedores();
        }

        private void CarregaFornecedores()
        {
            try
            {
                comboBoxForncedor.Items.Clear();
                var f = new Classes.Fornecedor();
                var data = f.GetNameFornecedores();
                foreach (DataRow linha in data.Rows)
                {
                    foreach (var item in linha.ItemArray)
                    {
                        comboBoxForncedor.Items.Add(item);
                    }
                }                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CarregaGrid()
        {
            dataGridViewProdutos.DataSource = null;
            var p = new Classes.Produto();
            var data = p.SelectAll();
            dataGridViewProdutos.DataSource = data;
            dataGridViewProdutos.Columns["ID"].Visible = false;

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Tem certeza?\n(essa operação não pode ser desfeita)", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialogResult == DialogResult.Yes)
            {
                tabControlProdutos.SelectedTab = this.tabPage1;            
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxNome.Text) |
                    !string.IsNullOrEmpty(comboBoxForncedor.Text))
                {
                    var context = new ApplicationDbContext();

                    if (buttonSalvar.Text == "Salvar")
                    {
                        var query = context.Fornecedores.Where(f => f.Nome == comboBoxForncedor.Text).FirstOrDefault();

                        var produto = new Model.Produto
                        {
                            ID = Guid.NewGuid(),
                            Nome = textBoxNome.Text,
                            Quantidade = (int)numericUpDownQuantidade.Value,
                            Fornecedores = query
                        };

                        context.Produtos.Add(produto);
                        context.SaveChanges();

                        MessageBox.Show("Cadastro realizado com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CarregaGrid();
                        tabControlProdutos.SelectedTab = this.tabPage1;
                    }
                    else if (buttonSalvar.Text == "Atualizar")
                    {
                        var dialogResult = MessageBox.Show("Tem certeza?\n(essa operação não pode ser desfeita)", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.Yes)
                        {
                            var query = from fornecedor in context.Fornecedores
                                        where fornecedor.Nome == comboBoxForncedor.Text
                                        select fornecedor;

                            var produto = context.Produtos.First(p => p.ID == new Guid(ID_Produto));
                            produto.Nome = textBoxNome.Text;
                            produto.Quantidade = (int)numericUpDownQuantidade.Value;
                            produto.Fornecedores = query.First();
                            context.SaveChanges();

                            MessageBox.Show("Atualização realizada com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CarregaGrid();
                            tabControlProdutos.SelectedTab = this.tabPage1;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não deixe os camposem branco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um erro.\nDetalhes:\n{ex.InnerException}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(ID_Produto))
                {
                    var dialogResult = MessageBox.Show("Tem certeza?\n(essa operação não pode ser desfeita)", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        var context = new ApplicationDbContext();
                        var produto = context.Produtos.Where(p => p.ID == new Guid(ID_Produto)).First();
                        context.Produtos.Remove(produto);
                        context.SaveChanges();

                        MessageBox.Show("Produto Excluido com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregaGrid();
                    }
                    else
                    {
                        MessageBox.Show("Selecione um item para excluir", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um erro ao excluir as informações.\nDetalhes:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            textBoxNome.Text = String.Empty;
            comboBoxForncedor.SelectedItem = null;
            numericUpDownQuantidade.Value = 0;

            buttonSalvar.Text = "Salvar";

            tabControlProdutos.SelectedTab = this.tabPage2;
            textBoxNome.Focus();
        }

        private void dataGridViewProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNome.Text = dataGridViewProdutos.CurrentRow.Cells["Nome"].Value.ToString();
            CarregaFornecedores();
            numericUpDownQuantidade.Value = (int)dataGridViewProdutos.CurrentRow.Cells["Quantidade"].Value;
            comboBoxForncedor.SelectedItem = dataGridViewProdutos.CurrentRow.Cells["Fornecedor"].Value.ToString();

            buttonSalvar.Text = "Atualizar";

            tabControlProdutos.SelectedTab = this.tabPage2;
        }

        private void dataGridViewProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_Produto = dataGridViewProdutos.CurrentRow.Cells["ID"].Value.ToString();
        }

        private void textBoxPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                if (!string.IsNullOrEmpty(textBoxPesquisar.Text))
                {
                    var busca = textBoxPesquisar.Text;

                    ((DataTable)dataGridViewProdutos.DataSource).DefaultView.RowFilter = $"{"Nome"} like '%{busca}%' OR {"Fornecedor"} like '%{busca}%'";

                }
                else
                {
                    CarregaGrid();
                }
            }
        }
    }
}
