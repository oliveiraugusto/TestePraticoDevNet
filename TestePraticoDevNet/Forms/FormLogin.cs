using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestePraticoDevNet.Model;

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
            this.Cursor = Cursors.Default;
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
                this.Cursor = Cursors.WaitCursor;

                var dbContext = new ApplicationDbContext();
                string senha = Hash(textBoxSenha.Text);
                int login = dbContext.Usuarios.Count(u => u.Login == textBoxUsuario.Text && u.Senha == senha);

                if(login == 1)
                {
                    var user = dbContext.Usuarios.FirstOrDefault(u => u.Login == textBoxUsuario.Text && u.Senha == senha);

                    FormMDI.statusStripMDI.Items[1].Text = user.Nome;

                    FormMDI.menuStripMDI.Visible = true;
                    FormMDI.statusStripMDI.Visible = true;
                    this.Cursor = Cursors.Default;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário e/ou senha incorretos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }                
            }
            else
            {
                MessageBox.Show("Não deixe os campos em branco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxUsuario.Focus();
            }
        }

        /// <summary>
        /// String para SHA1
        /// </summary>
        /// <param name="text"></param>
        /// <returns>Retorna SHA1 do string</returns>
        public string Hash(string text)
        {
            byte[] buffer = Encoding.Default.GetBytes(text);
            var cryptoTransformSHA1 = new SHA1CryptoServiceProvider();
            string hash = BitConverter.ToString(cryptoTransformSHA1.ComputeHash(buffer)).Replace("-", "");
            return hash;
        }
    }
}
