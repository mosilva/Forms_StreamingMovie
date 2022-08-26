namespace LetsMovie.FormsMenu
{
    partial class frmAtualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAtualizar));
            this.picFilmes = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lblNovoTitulo = new System.Windows.Forms.Label();
            this.txbNovoTitulo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAparecer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFilmes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picFilmes
            // 
            this.picFilmes.Image = ((System.Drawing.Image)(resources.GetObject("picFilmes.Image")));
            this.picFilmes.Location = new System.Drawing.Point(39, 159);
            this.picFilmes.Name = "picFilmes";
            this.picFilmes.Size = new System.Drawing.Size(307, 196);
            this.picFilmes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFilmes.TabIndex = 12;
            this.picFilmes.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(104, 405);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTitulo.ForeColor = System.Drawing.Color.White;
            this.txtTitulo.Location = new System.Drawing.Point(123, 83);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(150, 24);
            this.txtTitulo.TabIndex = 9;
            this.txtTitulo.Text = "ATUALIZAR";
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnList.Location = new System.Drawing.Point(379, 99);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(226, 23);
            this.btnList.TabIndex = 19;
            this.btnList.Text = "Aparecer Lista dos filmes cadastrados";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(456, 405);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 20;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // lblNovoTitulo
            // 
            this.lblNovoTitulo.AutoSize = true;
            this.lblNovoTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNovoTitulo.ForeColor = System.Drawing.Color.White;
            this.lblNovoTitulo.Location = new System.Drawing.Point(410, 334);
            this.lblNovoTitulo.Name = "lblNovoTitulo";
            this.lblNovoTitulo.Size = new System.Drawing.Size(177, 21);
            this.lblNovoTitulo.TabIndex = 21;
            this.lblNovoTitulo.Text = "Novo Titulo Do Filme:";
            // 
            // txbNovoTitulo
            // 
            this.txbNovoTitulo.Location = new System.Drawing.Point(379, 373);
            this.txbNovoTitulo.Name = "txbNovoTitulo";
            this.txbNovoTitulo.PlaceholderText = "Digite o novo titulo aqui...";
            this.txbNovoTitulo.Size = new System.Drawing.Size(236, 23);
            this.txbNovoTitulo.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LetsMovie.FormsMenu.Properties.Resources.updated__1_;
            this.pictureBox1.Location = new System.Drawing.Point(39, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // lblAparecer
            // 
            this.lblAparecer.AutoSize = true;
            this.lblAparecer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAparecer.Location = new System.Drawing.Point(429, 226);
            this.lblAparecer.Name = "lblAparecer";
            this.lblAparecer.Size = new System.Drawing.Size(0, 21);
            this.lblAparecer.TabIndex = 24;
            // 
            // frmAtualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lblAparecer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbNovoTitulo);
            this.Controls.Add(this.lblNovoTitulo);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.picFilmes);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtTitulo);
            this.Name = "frmAtualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar";
            this.Load += new System.EventHandler(this.frmAtualizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFilmes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picFilmes;
        private Button btnVoltar;
        private Label txtTitulo;
        private Button btnList;
        private Button btnAtualizar;
        private Label lblNovoTitulo;
        private TextBox txbNovoTitulo;
        private PictureBox pictureBox1;
        private Label lblAparecer;
    }
}