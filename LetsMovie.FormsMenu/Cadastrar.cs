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
            this.Visible = false;
            frmMenu telaInicial = new frmMenu();
            telaInicial.ShowDialog();
            this.Visible = true;
        }

        private void frmCadastrar_Load(object sender, EventArgs e)
        {
            cmbBoxGenero.DataSource = Enum.GetValues(typeof(EnumGender));

            //this.cmbBoxGenero.DataSource = Utility.EnumToList<EnumGender>();
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

        private void btnCadastrar_Click(object sender, EventArgs e)
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

            }

            int numId = MovieCollections.ListCatalogMovies.Count + 1;

            Movies newMovie = new Movies(numId, txtTituloFilme.Text, (EnumGender)cmbBoxGenero.SelectedItem, txtDate.Text);
            MovieCollections.ListCatalogMovies.Add(newMovie);

            MovieCollections.AtualizaCollections();

            MessageBox.Show("Filme adicionado com sucesso");
            ClearInputs();
            
        }

        private void cmbBoxGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnumGender filmeGenero = (EnumGender)cmbBoxGenero.SelectedItem;
        }

        private void lblDateOfRelease_Click(object sender, EventArgs e)
        {

        }

        private void ClearInputs()
        {
            txtTituloFilme.Clear();
            txtDate.Clear();
        }
    }
}
