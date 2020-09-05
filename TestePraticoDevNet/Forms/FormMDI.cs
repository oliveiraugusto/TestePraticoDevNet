using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestePraticoDevNet.Forms;


namespace TestePraticoDevNet
{
    public partial class FormMDI : Form
    {
        public FormMDI()
        {
            InitializeComponent();
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMDI_Load(object sender, EventArgs e)
        {
            menuStripMDI.Visible = false;
            statusStripMDI.Visible = false;

            var fLogin = new FormLogin(this);
            fLogin.MdiParent = this;
            fLogin.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fFornecedor = new FormFornecedores();
            fFornecedor.MdiParent = this;
            fFornecedor.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fProduto = new FormProdutos();
            fProduto.MdiParent = this;
            fProduto.Show();
        }
    }
}
