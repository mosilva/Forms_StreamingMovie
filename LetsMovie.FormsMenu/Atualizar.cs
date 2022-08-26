using LetsMovie.FormsDomain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LetsMovie.FormsMenu;

namespace LetsMovie.FormsMenu
{
    public partial class frmAtualizar : Form
    {
        ListBox listaFilmes = new ListBox();
        public frmAtualizar()
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

        private async void btnList_Click(object sender, EventArgs e)
        {
            listaFilmes.Size = new System.Drawing.Size(250, 180);
            listaFilmes.Location = new System.Drawing.Point(380, 145);
            listaFilmes.Items.Clear();

            btnList.Enabled = false;
            lblAparecer.ForeColor = Color.DarkSeaGreen;
            lblAparecer.Text = "Carregando Lista...";

            await Task.Delay(4000);
            lblAparecer.Text = "";
            btnList.Enabled = true;

            ShowMovies();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string filme = Convert.ToString(this.listaFilmes.SelectedItem);
            string novoTitulo = txbNovoTitulo.Text;
            MessageBox.Show($"Título atualizado. Novo Título: {novoTitulo}");

            if (!string.IsNullOrEmpty(novoTitulo))
            {
                Movies filmeAtual = MovieCollections.ListCatalogMovies.Find(p => p.Title == filme);
                filmeAtual.Title = filmeAtual.Title.Replace(filme, novoTitulo);
            }
            ShowMovies();
        }

        public void ShowMovies()
        {
            listaFilmes.Items.Clear();
            foreach (var movie in MovieCollections.ListCatalogMovies)
            {
                listaFilmes.Items.Add(movie.Title.ToString());
            }
            this.Controls.Add(listaFilmes);
            for (int i = 0; i < MovieCollections.ListCatalogMovies.Count; i++)
            {
                Debug.WriteLine(i);
            }
        }

        private void frmAtualizar_Load(object sender, EventArgs e)
        {

        }
    }
}
