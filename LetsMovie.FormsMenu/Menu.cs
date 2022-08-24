namespace LetsMovie.FormsMenu
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (CloseCancel() == false)
            {
                e.Cancel = true;
            };
        }

        private static bool CloseCancel()
        {
            const string message = "Quer mesmo sair?";
            const string caption = "Fechar";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            for (int intIndex = Application.OpenForms.Count - 1; intIndex >= 0; intIndex--)
            {
                if (Application.OpenForms[intIndex] != this)
                    Application.OpenForms[intIndex].Close();
                else
                    Application.Exit();
            }
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmSobre sobre = new frmSobre();
            sobre.ShowDialog();
            this.Visible = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmCadastrar cadastrar = new frmCadastrar();
            cadastrar.ShowDialog();
            this.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmBuscar buscar = new frmBuscar();
            buscar.ShowDialog();
            this.Visible = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmAtualizar atualizar = new frmAtualizar();
            atualizar.ShowDialog();
            this.Visible = true;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmDeletar deletar = new frmDeletar();
            deletar.ShowDialog();
            this.Visible = true;
        }

        private void btnTopFilmes_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmRanking ranking = new frmRanking();
            ranking.ShowDialog();
            this.Visible = true;
        }
    }
}