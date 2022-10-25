using AppModelo.Controller.Cadastros;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmNaturalidade : Form
    {
        public frmNaturalidade()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var temNumero = 
                Helpers.Componentes.ExisteNumeroNoTexto(txtDescricao.Text);
           
            if (temNumero)
            {
                errorProvider1.SetError(txtDescricao, 
                    "Naturalidades geralmente não tem número");
                txtDescricao.Focus();
                return;
            }

            var controller = new NaturalidadeController();
            var descricaoMaiuscula = txtDescricao.Text.ToUpper();

            var resposta = controller.Cadastrar(descricaoMaiuscula, chkStatus.Checked);

        }
    }
}
