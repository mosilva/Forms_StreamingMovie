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

namespace LetsMovie.FormsMenu
{
    public partial class frmDeletar : Form
    {
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
            ListBox listaFilmes = new ListBox();
            List<Movies> listMovies = new List<Movies>();
            listMovies.Add(new Movies(1, "O Exorcista", "Terror", "1974-06-29"));
            listMovies.Add(new Movies(2, "Um Dia", "Romance", "2011-10-14"));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ListBox listaFilmes = new ListBox();
            listaFilmes.Size = new System.Drawing.Size(200, 100);
            listaFilmes.Location = new System.Drawing.Point(370, 200);
            this.Controls.Add(listaFilmes);

            listaFilmes.Items.Add("O Mágico de Oz");
            listaFilmes.Items.Add("V de Vingança");
            listaFilmes.Items.Add("Diário de uma Paixão");
            listaFilmes.Items.Add("Shrek");
            listaFilmes.Items.Add("Encantado");

            for (int i = 0; i < 5; i++)
            {
                Debug.WriteLine(i);
            }

            //List<Movies> listMovies = new List<Movies>();
            //listMovies.Add(new Movies(1, "O Exorcista", "Terror", "1974-06-29"));
            //listMovies.Add(new Movies(2, "Um Dia", "Romance", "2011-10-14"));
            //listaFilmes.DataSource = listMovies;
        }
    }
}
