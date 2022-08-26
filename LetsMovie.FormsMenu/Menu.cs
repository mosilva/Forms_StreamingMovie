namespace LetsMovie.FormsMenu
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        public void CloseAll()
        {
            if (MessageBox.Show("Tem certeza que deseja sair da aplicação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
                CloseAll();
        }
        private void btnSobre_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmSobre sobre = new frmSobre();
            sobre.ShowDialog();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCadastrar cadastrar = new frmCadastrar();
            cadastrar.FormBorderStyle = FormBorderStyle.FixedSingle;
            cadastrar.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmBuscar buscar = new frmBuscar();
            buscar.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmAtualizar atualizar = new frmAtualizar();
            atualizar.ShowDialog();

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmDeletar deletar = new frmDeletar();
            deletar.ShowDialog();

        }

        private void btnTopFilmes_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmRanking ranking = new frmRanking();
            ranking.ShowDialog();

        }

    }
}