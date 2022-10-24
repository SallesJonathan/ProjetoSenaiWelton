using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new frmPrincipal();
            form.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            var form = new frmRecuperarSenha();
            form.ShowDialog();
        }
    }
}
