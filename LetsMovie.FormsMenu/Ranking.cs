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
    public partial class frmRanking : Form
    {
        ListBox listaFilmes = new ListBox();

        public frmRanking()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmMenu telaInicial = new frmMenu();
            telaInicial.ShowDialog();
            this.Visible = true;
        }

        public void ShowMoviesRanking()
        {
            listaFilmes.Items.Clear();

            do
            {
                listaFilmes.Items.Add(MovieCollections
                    .QueueTopFivesDateOfReleasedMovies
                    .Dequeue().Title.ToString());
            } while (MovieCollections
                    .QueueTopFivesDateOfReleasedMovies
                    .Count != 0);

            MovieCollections.AtualizaCollections();

            this.Controls.Add(listaFilmes);

            for (int i = 0; i < MovieCollections.QueueTopFivesDateOfReleasedMovies.Count; i++)
            {
                Debug.WriteLine(i);
            }

        }
        private void btnList_Click(object sender, EventArgs e)
        {

            listaFilmes.Size = new System.Drawing.Size(140, 100);
            listaFilmes.Location = new System.Drawing.Point(270, 270);
            ShowMoviesRanking();

        }

        private void frmRanking_Load(object sender, EventArgs e)
        {

        }
    }
}
