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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.picFilmes = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTituloFilme = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cmbBoxGenero = new System.Windows.Forms.ComboBox();
            this.lblDateOfRelease = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFilmes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTitulo.ForeColor = System.Drawing.Color.White;
            this.txtTitulo.Location = new System.Drawing.Point(128, 90);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(157, 24);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.Text = "CADASTRAR";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(104, 405);
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
            this.picFilmes.Location = new System.Drawing.Point(39, 159);
            this.picFilmes.Name = "picFilmes";
            this.picFilmes.Size = new System.Drawing.Size(307, 196);
            this.picFilmes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFilmes.TabIndex = 4;
            this.picFilmes.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(391, 135);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(124, 21);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Digite o Título:";
            // 
            // txtTituloFilme
            // 
            this.txtTituloFilme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTituloFilme.Location = new System.Drawing.Point(391, 172);
            this.txtTituloFilme.Name = "txtTituloFilme";
            this.txtTituloFilme.Size = new System.Drawing.Size(253, 29);
            this.txtTituloFilme.TabIndex = 6;
            this.txtTituloFilme.TextChanged += new System.EventHandler(this.txtTituloFilme_TextChanged);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenero.ForeColor = System.Drawing.Color.White;
            this.lblGenero.Location = new System.Drawing.Point(391, 213);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(167, 23);
            this.lblGenero.TabIndex = 7;
            this.lblGenero.Text = "Selecione o Gênero:";
            // 
            // cmbBoxGenero
            // 
            this.cmbBoxGenero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbBoxGenero.FormattingEnabled = true;
            this.cmbBoxGenero.Location = new System.Drawing.Point(391, 250);
            this.cmbBoxGenero.Name = "cmbBoxGenero";
            this.cmbBoxGenero.Size = new System.Drawing.Size(253, 29);
            this.cmbBoxGenero.TabIndex = 8;
            this.cmbBoxGenero.SelectedIndexChanged += new System.EventHandler(this.cmbBoxGenero_SelectedIndexChanged);
            // 
            // lblDateOfRelease
            // 
            this.lblDateOfRelease.AutoSize = true;
            this.lblDateOfRelease.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDateOfRelease.ForeColor = System.Drawing.Color.White;
            this.lblDateOfRelease.Location = new System.Drawing.Point(391, 294);
            this.lblDateOfRelease.Name = "lblDateOfRelease";
            this.lblDateOfRelease.Size = new System.Drawing.Size(231, 42);
            this.lblDateOfRelease.TabIndex = 9;
            this.lblDateOfRelease.Text = "Digite a Data de Lançamento\r\nFormato: AAAA-MM-DD";
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDate.Location = new System.Drawing.Point(391, 350);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(253, 29);
            this.txtDate.TabIndex = 10;
            this.txtDate.TextChanged += new System.EventHandler(this.txtDate_TextChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(412, 405);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(210, 23);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar o novo filme";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LetsMovie.FormsMenu.Properties.Resources.edit;
            this.pictureBox2.Location = new System.Drawing.Point(33, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // frmCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblDateOfRelease);
            this.Controls.Add(this.cmbBoxGenero);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.txtTituloFilme);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.picFilmes);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtTitulo);
            this.Name = "frmCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.frmCadastrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFilmes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txtTitulo;
        private Button btnVoltar;
        private PictureBox picFilmes;
        private Label lblTitulo;
        private TextBox txtTituloFilme;
        private Label lblGenero;
        private ComboBox cmbBoxGenero;
        private Label lblDateOfRelease;
        private TextBox txtDate;
        private Button btnCadastrar;
        private PictureBox pictureBox2;
    }
}