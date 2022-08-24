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
        public frmBuscar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListBox listaFilmes = new ListBox();
            listaFilmes.Size = new System.Drawing.Size(250, 200);
            listaFilmes.Location = new System.Drawing.Point(340, 160);

            MovieCollections.DictionaryGenderMovies.TryGetValue(EnumGender.Action, out List<Movies>? ListAction);

            foreach (var movie in ListAction)
            {
                listaFilmes.Items.Add(movie.Title.ToString());
            }

            this.Controls.Add(listaFilmes);

            for (int i = 0; i < MovieCollections.ListCatalogMovies.Count; i++)
            {
                Debug.WriteLine(i);
            }
        }

        private void BtnSearchAdventure_Click(object sender, EventArgs e)
        {

            ListBox listaFilmes = new ListBox();
            listaFilmes.Size = new System.Drawing.Size(250, 200);
            listaFilmes.Location = new System.Drawing.Point(340, 160);

            MovieCollections.DictionaryGenderMovies.TryGetValue(EnumGender.Adventure, out List<Movies>? ListAdventure);
           
            foreach (var movie in ListAdventure)
            {
                listaFilmes.Items.Add(movie.Title.ToString());
            }

            this.Controls.Add(listaFilmes);

            for (int i = 0; i < MovieCollections.ListCatalogMovies.Count; i++)
            {
                Debug.WriteLine(i);
            }


        }

        private void BtnSearchHeroes_Click(object sender, EventArgs e)
        {

            ListBox listaFilmes = new ListBox();
            listaFilmes.Size = new System.Drawing.Size(250, 200);
            listaFilmes.Location = new System.Drawing.Point(340, 160);

            MovieCollections.DictionaryGenderMovies.TryGetValue(EnumGender.Heroes, out List<Movies>? ListHeroes);

            foreach (var movie in ListHeroes)
            {
                listaFilmes.Items.Add(movie.Title.ToString());
            }

            this.Controls.Add(listaFilmes);

            for (int i = 0; i < MovieCollections.ListCatalogMovies.Count; i++)
            {
                Debug.WriteLine(i);
            }

        }
    }
}
