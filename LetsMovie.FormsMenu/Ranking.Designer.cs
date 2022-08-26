namespace LetsMovie.FormsMenu
{
    partial class frmRanking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRanking));
            this.picRanking = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblTop = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picRanking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // picRanking
            // 
            this.picRanking.Image = ((System.Drawing.Image)(resources.GetObject("picRanking.Image")));
            this.picRanking.Location = new System.Drawing.Point(185, 12);
            this.picRanking.Name = "picRanking";
            this.picRanking.Size = new System.Drawing.Size(311, 161);
            this.picRanking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRanking.TabIndex = 0;
            this.picRanking.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(104, 405);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 17;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTop.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTop.Location = new System.Drawing.Point(256, 176);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(170, 42);
            this.lblTop.TabIndex = 18;
            this.lblTop.Text = "TOP 5\r\nFilmes clássicos";
            this.lblTop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnList.Location = new System.Drawing.Point(276, 243);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(127, 23);
            this.btnList.TabIndex = 21;
            this.btnList.Text = "Aparecer Lista";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LetsMovie.FormsMenu.Properties.Resources.Fundo_preto;
            this.pictureBox2.Location = new System.Drawing.Point(-4, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(677, 161);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // frmRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.ControlBox = false;
            this.Controls.Add(this.picRanking);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.btnVoltar);
            this.Name = "frmRanking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ranking";
            this.Load += new System.EventHandler(this.frmRanking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picRanking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picRanking;
        private Button btnVoltar;
        private Label lblTop;
        private Button btnList;
        private PictureBox pictureBox2;
    }
}