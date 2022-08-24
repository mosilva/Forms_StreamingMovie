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
            this.btnSobre = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFilmes)).BeginInit();
            this.SuspendLayout();
            // 
            // picFilmes
            // 
            this.picFilmes.Image = ((System.Drawing.Image)(resources.GetObject("picFilmes.Image")));
            this.picFilmes.Location = new System.Drawing.Point(39, 147);
            this.picFilmes.Name = "picFilmes";
            this.picFilmes.Size = new System.Drawing.Size(265, 199);
            this.picFilmes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFilmes.TabIndex = 12;
            this.picFilmes.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(548, 55);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSobre.Location = new System.Drawing.Point(323, 59);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(75, 23);
            this.btnSobre.TabIndex = 10;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTitulo.Location = new System.Drawing.Point(60, 59);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(129, 30);
            this.txtTitulo.TabIndex = 9;
            this.txtTitulo.Text = "ATUALIZAR";
            // 
            // frmAtualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.picFilmes);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.txtTitulo);
            this.Name = "frmAtualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar";
            this.Load += new System.EventHandler(this.frmAtualizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFilmes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picFilmes;
        private Button btnVoltar;
        private Button btnSobre;
        private Label txtTitulo;
    }
}