﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsMovie.FormsMenu
{
    public partial class frmRanking : Form
    {
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
    }
}
