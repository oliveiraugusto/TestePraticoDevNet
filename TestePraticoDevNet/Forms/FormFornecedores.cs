using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestePraticoDevNet.Forms
{
    public partial class FormFornecedores : Form
    {
        public FormFornecedores()
        {
            InitializeComponent();
        }

        private void FormFornecedores_Load(object sender, EventArgs e)
        {
            tabPage1.Text = "Consulta";
            tabPage2.Text = "Cadastro";
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Tem certeza?\n(essa operação não pode ser desfeita)", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                //DELETE ITEM
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Tem certeza?\n(essa operação não pode ser desfeita)", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                tabControlFornecedor.SelectedTab = this.tabPage1;
            }
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            tabControlFornecedor.SelectedTab = this.tabPage2;
        }

        private void buttonExcluir_Click_1(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Tem certeza?\n(essa operação não pode ser desfeita)", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                //DELETE ITEM 
            }
        }
    }
}
