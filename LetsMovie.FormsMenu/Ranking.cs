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

        private void frmRanking_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            var TopFives =
             MovieCollections.ListCatalogMovies
            .OrderBy(p => p.DateOfReleased)
            .Take(5).ToList();

            foreach (var movie in TopFives)
            {
                listaFilmes.Items.Add(movie.Title.ToString());
            }

            this.Controls.Add(listaFilmes);

            for (int i = 0; i < TopFives.Count; i++)
            {
                Debug.WriteLine(i);
            }

        }

        private void btnList_Click(object sender, EventArgs e)
        {

            //var TopFives = new List<Movies>(
            // MovieCollections.ListCatalogMovies
            //.OrderBy(p => p.DateOfReleased)
            //.Take(5).ToList());

            //foreach (var movie in TopFives)
            //{
            //    Debug.WriteLine(movie);
            //}


            //listaFilmes.Size = new System.Drawing.Size(250, 200);
            //listaFilmes.Location = new System.Drawing.Point(340, 145);
        }
    }
}
