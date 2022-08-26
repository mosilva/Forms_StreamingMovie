using LetsMovie.FormsDomain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LetsMovie.FormsMenu
{
    public partial class frmCadastrar : Form
    {
        public frmCadastrar()
        {
            InitializeComponent();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmSobre sobre = new frmSobre();
            sobre.ShowDialog();
            this.Visible = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu telaInicial = new frmMenu();
            telaInicial.ShowDialog();

        }

        private void frmCadastrar_Load(object sender, EventArgs e)
        {
            cmbBoxGenero.DataSource = Enum.GetValues(typeof(EnumGender));
        }

        private void txtTituloFilme_TextChanged(object sender, EventArgs e)
        {
            string titulo = txtTituloFilme.Text;
            
            if(!string.IsNullOrEmpty(titulo))
            {
                Movies filmeExistente = MovieCollections.ListCatalogMovies.Find(p => p.Title == titulo);
               if(filmeExistente != null)
                {
                    MessageBox.Show($"{titulo} já está no catálogo");
                }
                   
            }
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            
        }

        private async void btnCadastrar_Click(object sender, EventArgs e)
        {

            string dataLancamento = txtDate.Text;
            if (!string.IsNullOrEmpty(dataLancamento))
            {
                var pattern = @"([12]\d{3}-(0[1-9]|1[0-2])-(0[1-9]|[12]\d|3[01]))$";
                Regex rgx = new Regex(pattern);

                if (!rgx.IsMatch(dataLancamento))
                {
                    MessageBox.Show("Data incorreta. Digite no formato AAAA-MM-DD");
                }
                else
                {

                    int numId = MovieCollections.ListCatalogMovies.Count + 1;

                    Movies newMovie = new Movies(numId, txtTituloFilme.Text, (EnumGender)cmbBoxGenero.SelectedItem, txtDate.Text);
                    MovieCollections.ListCatalogMovies.Add(newMovie);

                    btnCadastrar.Enabled = false;
                    lblCarregando.ForeColor = Color.White;
                    lblCarregando.Text = "Adicionando...";

                    await Task.Delay(4000);

                    btnCadastrar.Enabled = true;
                    lblCarregando.BackColor = Color.White;
                    lblCarregando.ForeColor = Color.Green;
                    lblCarregando.Text = "Adicionado Com Sucesso!!!";

                    MovieCollections.AtualizaCollections();
                    MessageBox.Show($"{txtTituloFilme.Text} adicionado com sucesso");
                    ClearInputs();
                }

            }
            
        }

        private void cmbBoxGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnumGender filmeGenero = (EnumGender)cmbBoxGenero.SelectedItem;
        }

        private void ClearInputs()
        {
            txtTituloFilme.Clear();
            txtDate.Clear();
        }

        private void lblCarregando_Click(object sender, EventArgs e)
        {

        }
    }
}
