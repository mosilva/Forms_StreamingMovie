namespace LetsMovie.FormsMenu
{
    partial class frmDeletar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeletar));
            this.picFilmes = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picFilmes)).BeginInit();
            this.SuspendLayout();
            // 
            // picFilmes
            // 
            this.picFilmes.Image = ((System.Drawing.Image)(resources.GetObject("picFilmes.Image")));
            this.picFilmes.Location = new System.Drawing.Point(23, 157);
            this.picFilmes.Name = "picFilmes";
            this.picFilmes.Size = new System.Drawing.Size(265, 199);
            this.picFilmes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFilmes.TabIndex = 16;
            this.picFilmes.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(547, 50);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSobre.Location = new System.Drawing.Point(322, 54);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(75, 23);
            this.btnSobre.TabIndex = 14;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTitulo.Location = new System.Drawing.Point(59, 54);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(101, 30);
            this.txtTitulo.TabIndex = 13;
            this.txtTitulo.Text = "DELETAR";
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnList.Location = new System.Drawing.Point(406, 107);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(127, 23);
            this.btnList.TabIndex = 18;
            this.btnList.Text = "Aparecer Lista";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // frmDeletar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.picFilmes);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.txtTitulo);
            this.Name = "frmDeletar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deletar";
            this.Load += new System.EventHandler(this.frmDeletar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFilmes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picFilmes;
        private Button btnVoltar;
        private Button btnSobre;
        private Label txtTitulo;
        private Button btnList;
    }
}