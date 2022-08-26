using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using LetsMovie.FormsDomain;

namespace LetsMovie.FormsMenu
{
    public partial class frmDeletar : Form
    {
        private ListBox listaFilmes = new ListBox();
        public frmDeletar()
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

        private void frmDeletar_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            CarregarFilmes();

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            string filme = Convert.ToString(this.listaFilmes.SelectedItem);
            DeletarDaLista(filme);

        }

        private void CarregarFilmes()
        {
            listaFilmes.Items.Clear();
            listaFilmes.Size = new System.Drawing.Size(250, 200);
            listaFilmes.Location = new System.Drawing.Point(380, 160);

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

        private void DeletarDaLista(string filme)
        {
            
            Movies filmesDeletar = MovieCollections.ListCatalogMovies.Find(p => p.Title == filme);
            MovieCollections.ListCatalogMovies.Remove(filmesDeletar);
            MovieCollections.AtualizaCollections();
            CarregarFilmes();
        }

    }
}
