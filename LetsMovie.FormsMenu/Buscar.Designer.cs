namespace LetsMovie.FormsMenu
{
    partial class frmBuscar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.BtnSearchAdventure = new System.Windows.Forms.Button();
            this.BtnSearchHeroes = new System.Windows.Forms.Button();
            this.BtnSearchComedy = new System.Windows.Forms.Button();
            this.BtnSearchRomanticComedy = new System.Windows.Forms.Button();
            this.BtnSearchHorror = new System.Windows.Forms.Button();
            this.BtnSearchRomance = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(104, 405);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LetsMovie.FormsMenu.Properties.Resources.filmes2;
            this.pictureBox1.Location = new System.Drawing.Point(39, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(286, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ação";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTitulo.ForeColor = System.Drawing.Color.White;
            this.txtTitulo.Location = new System.Drawing.Point(130, 77);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(107, 24);
            this.txtTitulo.TabIndex = 10;
            this.txtTitulo.Text = "BUSCAR";
            // 
            // BtnSearchAdventure
            // 
            this.BtnSearchAdventure.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSearchAdventure.Location = new System.Drawing.Point(415, 77);
            this.BtnSearchAdventure.Name = "BtnSearchAdventure";
            this.BtnSearchAdventure.Size = new System.Drawing.Size(110, 23);
            this.BtnSearchAdventure.TabIndex = 4;
            this.BtnSearchAdventure.Text = "Aventura";
            this.BtnSearchAdventure.UseVisualStyleBackColor = true;
            this.BtnSearchAdventure.Click += new System.EventHandler(this.BtnSearchAdventure_Click);
            // 
            // BtnSearchHeroes
            // 
            this.BtnSearchHeroes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSearchHeroes.Location = new System.Drawing.Point(551, 77);
            this.BtnSearchHeroes.Name = "BtnSearchHeroes";
            this.BtnSearchHeroes.Size = new System.Drawing.Size(110, 23);
            this.BtnSearchHeroes.TabIndex = 4;
            this.BtnSearchHeroes.Text = "Super-Heróis";
            this.BtnSearchHeroes.UseVisualStyleBackColor = true;
            this.BtnSearchHeroes.Click += new System.EventHandler(this.BtnSearchHeroes_Click);
            // 
            // BtnSearchComedy
            // 
            this.BtnSearchComedy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSearchComedy.Location = new System.Drawing.Point(286, 77);
            this.BtnSearchComedy.Name = "BtnSearchComedy";
            this.BtnSearchComedy.Size = new System.Drawing.Size(110, 23);
            this.BtnSearchComedy.TabIndex = 4;
            this.BtnSearchComedy.Text = "Comédia";
            this.BtnSearchComedy.UseVisualStyleBackColor = true;
            this.BtnSearchComedy.Click += new System.EventHandler(this.BtnSearchComedy_Click);
            // 
            // BtnSearchRomanticComedy
            // 
            this.BtnSearchRomanticComedy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSearchRomanticComedy.Location = new System.Drawing.Point(392, 116);
            this.BtnSearchRomanticComedy.Name = "BtnSearchRomanticComedy";
            this.BtnSearchRomanticComedy.Size = new System.Drawing.Size(161, 23);
            this.BtnSearchRomanticComedy.TabIndex = 4;
            this.BtnSearchRomanticComedy.Text = "Comédia Romântica";
            this.BtnSearchRomanticComedy.UseVisualStyleBackColor = true;
            this.BtnSearchRomanticComedy.Click += new System.EventHandler(this.BtnSearchRomanticComedy_Click);
            // 
            // BtnSearchHorror
            // 
            this.BtnSearchHorror.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSearchHorror.Location = new System.Drawing.Point(551, 40);
            this.BtnSearchHorror.Name = "BtnSearchHorror";
            this.BtnSearchHorror.Size = new System.Drawing.Size(110, 23);
            this.BtnSearchHorror.TabIndex = 4;
            this.BtnSearchHorror.Text = "Terror";
            this.BtnSearchHorror.UseVisualStyleBackColor = true;
            this.BtnSearchHorror.Click += new System.EventHandler(this.BtnSearchHorror_Click);
            // 
            // BtnSearchRomance
            // 
            this.BtnSearchRomance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSearchRomance.Location = new System.Drawing.Point(415, 40);
            this.BtnSearchRomance.Name = "BtnSearchRomance";
            this.BtnSearchRomance.Size = new System.Drawing.Size(110, 23);
            this.BtnSearchRomance.TabIndex = 4;
            this.BtnSearchRomance.Text = "Romance";
            this.BtnSearchRomance.UseVisualStyleBackColor = true;
            this.BtnSearchRomance.Click += new System.EventHandler(this.BtnSearchRomance_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LetsMovie.FormsMenu.Properties.Resources.magnifier;
            this.pictureBox3.Location = new System.Drawing.Point(39, 54);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(85, 61);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.BtnSearchHorror);
            this.Controls.Add(this.BtnSearchRomanticComedy);
            this.Controls.Add(this.BtnSearchHeroes);
            this.Controls.Add(this.BtnSearchRomance);
            this.Controls.Add(this.BtnSearchComedy);
            this.Controls.Add(this.BtnSearchAdventure);
            this.Controls.Add(this.button1);
            this.Name = "frmBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.frmBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnVoltar;
        private PictureBox pictureBox1;
        private Button button1;
        private Label txtTitulo;
        private Button BtnSearchAdventure;
        private Button BtnSearchHeroes;
        private Button BtnSearchComedy;
        private Button BtnSearchRomanticComedy;
        private Button BtnSearchHorror;
        private Button BtnSearchRomance;
        private PictureBox pictureBox3;
    }
}