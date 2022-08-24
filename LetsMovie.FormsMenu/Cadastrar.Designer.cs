namespace LetsMovie.FormsMenu
{
    partial class frmCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrar));
            this.txtTitulo = new System.Windows.Forms.Label();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.picFilmes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFilmes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTitulo.Location = new System.Drawing.Point(54, 48);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(138, 30);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.Text = "CADASTRAR";
            // 
            // btnSobre
            // 
            this.btnSobre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSobre.Location = new System.Drawing.Point(317, 48);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(75, 23);
            this.btnSobre.TabIndex = 2;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(542, 44);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // picFilmes
            // 
            this.picFilmes.Image = ((System.Drawing.Image)(resources.GetObject("picFilmes.Image")));
            this.picFilmes.Location = new System.Drawing.Point(33, 162);
            this.picFilmes.Name = "picFilmes";
            this.picFilmes.Size = new System.Drawing.Size(265, 199);
            this.picFilmes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFilmes.TabIndex = 4;
            this.picFilmes.TabStop = false;
            // 
            // frmCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.picFilmes);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.txtTitulo);
            this.Name = "frmCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.frmCadastrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFilmes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txtTitulo;
        private Button btnSobre;
        private Button btnVoltar;
        private PictureBox picFilmes;
    }
}