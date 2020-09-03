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
    public partial class FormLogin : Form
    {
        protected FormMDI FormMDI;
        public FormLogin(FormMDI formMDI)
        {
            InitializeComponent();
            FormMDI = formMDI;
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBoxUsuario.Focus();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //Login
            if(!string.IsNullOrEmpty(textBoxUsuario.Text) |
               !string.IsNullOrEmpty(textBoxSenha.Text))
            {
                //login
                FormMDI.menuStripMDI.Visible = true;
                FormMDI.statusStripMDI.Visible = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Não deixe os campos em branco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxUsuario.Focus();
            }
        }
    }
}
