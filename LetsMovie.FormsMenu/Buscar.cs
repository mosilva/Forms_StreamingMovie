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

namespace LetsMovie.FormsMenu
{
    public partial class frmBuscar : Form
    {
        ListBox listaFilmes = new ListBox();
        public frmBuscar()
        {
            InitializeComponent();
        }


        public void ShowMovies(List<Movies> listMovies)
        {
            foreach (var movie in listMovies)
            {
                listaFilmes.Items.Add(movie.Title.ToString());
            }

            for (int i = 0; i < MovieCollections.ListCatalogMovies.Count; i++)
            {
                Debug.WriteLine(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaFilmes.Items.Clear();

            MovieCollections.DictionaryGenderMovies.TryGetValue(EnumGender.Action, out List<Movies>? ListAction);

            ShowMovies(ListAction);

        }

        private void BtnSearchAdventure_Click(object sender, EventArgs e)
        {

            listaFilmes.Items.Clear();

            MovieCollections.DictionaryGenderMovies.TryGetValue(EnumGender.Adventure, out List<Movies>? ListAdventure);

            ShowMovies(ListAdventure);

        }

        private void BtnSearchHeroes_Click(object sender, EventArgs e)
        {
            listaFilmes.Items.Clear();

            MovieCollections.DictionaryGenderMovies.TryGetValue(EnumGender.Heroes, out List<Movies>? ListHeroes);

            ShowMovies(ListHeroes);
        }

        private void BtnSearchComedy_Click(object sender, EventArgs e)
        {
            listaFilmes.Items.Clear();

            MovieCollections.DictionaryGenderMovies.TryGetValue(EnumGender.Comedy, out List<Movies>? ListComedy);
            
            ShowMovies(ListComedy);
        }

        private void BtnSearchRomanticComedy_Click(object sender, EventArgs e)
        {
            listaFilmes.Items.Clear();

            MovieCollections.DictionaryGenderMovies.TryGetValue(EnumGender.Romantic_Comedy, out List<Movies>? ListRomanticRomantic);
            
            ShowMovies(ListRomanticRomantic);
        }

        private void BtnSearchRomance_Click(object sender, EventArgs e)
        {
            listaFilmes.Items.Clear();

            MovieCollections.DictionaryGenderMovies.TryGetValue(EnumGender.Romance, out List<Movies>? ListRomance);
            
            ShowMovies(ListRomance);

        }

        private void BtnSearchHorror_Click(object sender, EventArgs e)
        {
            listaFilmes.Items.Clear();

            MovieCollections.DictionaryGenderMovies.TryGetValue(EnumGender.Horror, out List<Movies>? ListHorror);
            
            ShowMovies(ListHorror);
        }

        private void frmBuscar_Load(object sender, EventArgs e)
        {
            this.Controls.Add(listaFilmes);
            listaFilmes.Size = new System.Drawing.Size(250, 200);
            listaFilmes.Location = new System.Drawing.Point(380, 160);
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
    }
}
