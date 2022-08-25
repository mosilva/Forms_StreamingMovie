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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picRanking)).BeginInit();
            this.SuspendLayout();
            // 
            // picRanking
            // 
            this.picRanking.Image = ((System.Drawing.Image)(resources.GetObject("picRanking.Image")));
            this.picRanking.Location = new System.Drawing.Point(35, 43);
            this.picRanking.Name = "picRanking";
            this.picRanking.Size = new System.Drawing.Size(331, 139);
            this.picRanking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRanking.TabIndex = 0;
            this.picRanking.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(532, 43);
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
            this.lblTop.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTop.Location = new System.Drawing.Point(230, 207);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(192, 50);
            this.lblTop.TabIndex = 18;
            this.lblTop.Text = "TOP 5\r\nÚltimos adicionados";
            this.lblTop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(244, 289);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(165, 94);
            this.listBox1.TabIndex = 19;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnList.Location = new System.Drawing.Point(257, 260);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(127, 23);
            this.btnList.TabIndex = 21;
            this.btnList.Text = "Aparecer Lista";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // frmRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.picRanking);
            this.Name = "frmRanking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ranking";
            this.Load += new System.EventHandler(this.frmRanking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picRanking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picRanking;
        private Button btnVoltar;
        private Label lblTop;
        private ListBox listBox1;
        private Button btnList;
    }
}