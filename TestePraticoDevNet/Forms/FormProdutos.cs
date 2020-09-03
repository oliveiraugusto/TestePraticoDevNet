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
    public partial class FormProdutos : Form
    {
        public FormProdutos()
        {
            InitializeComponent();
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {
            tabPage1.Text = "Consulta";
            tabPage2.Text = "Cadastro";
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
            //ADD ITEM
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Tem certeza?\n(essa operação não pode ser desfeita)", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                //DELETE ITEM
            }
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            tabControlProdutos.SelectedTab = this.tabPage2;
        }
    }
}
