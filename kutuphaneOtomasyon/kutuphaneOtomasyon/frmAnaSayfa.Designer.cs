namespace kutuphaneOtomasyon
{
    partial class frmAnaSayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaSayfa));
            this.btnUyeListele = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnUyeEkle = new System.Windows.Forms.Button();
            this.btnKitapListele = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.btnEmanetIade = new System.Windows.Forms.Button();
            this.btnEmanetListele = new System.Windows.Forms.Button();
            this.btnEmanetVerme = new System.Windows.Forms.Button();
            this.btnGrafik = new System.Windows.Forms.Button();
            this.btnSiralama = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUyeListele
            // 
            this.btnUyeListele.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUyeListele.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUyeListele.ImageIndex = 1;
            this.btnUyeListele.ImageList = this.ımageList1;
            this.btnUyeListele.Location = new System.Drawing.Point(92, 175);
            this.btnUyeListele.Margin = new System.Windows.Forms.Padding(2);
            this.btnUyeListele.Name = "btnUyeListele";
            this.btnUyeListele.Size = new System.Drawing.Size(297, 66);
            this.btnUyeListele.TabIndex = 1;
            this.btnUyeListele.Text = "Üye Listele";
            this.btnUyeListele.UseVisualStyleBackColor = false;
            this.btnUyeListele.Click += new System.EventHandler(this.btnUyeListele_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "uyeekle.png");
            this.ımageList1.Images.SetKeyName(1, "uyelistele.png");
            this.ımageList1.Images.SetKeyName(2, "kitapekle.png");
            this.ımageList1.Images.SetKeyName(3, "kitaplistele.png");
            this.ımageList1.Images.SetKeyName(4, "emanetiade.png");
            this.ımageList1.Images.SetKeyName(5, "emanetkitapverme.png");
            this.ımageList1.Images.SetKeyName(6, "emanetlisteleme.png");
            this.ımageList1.Images.SetKeyName(7, "grafik.png");
            this.ımageList1.Images.SetKeyName(8, "sıralama.png");
            // 
            // btnUyeEkle
            // 
            this.btnUyeEkle.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUyeEkle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUyeEkle.ImageIndex = 0;
            this.btnUyeEkle.ImageList = this.ımageList1;
            this.btnUyeEkle.Location = new System.Drawing.Point(92, 63);
            this.btnUyeEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnUyeEkle.Name = "btnUyeEkle";
            this.btnUyeEkle.Size = new System.Drawing.Size(297, 66);
            this.btnUyeEkle.TabIndex = 0;
            this.btnUyeEkle.Text = "Üye Ekleme İşlemleri";
            this.btnUyeEkle.UseVisualStyleBackColor = false;
            this.btnUyeEkle.Click += new System.EventHandler(this.btnUyeEkle_Click);
            // 
            // btnKitapListele
            // 
            this.btnKitapListele.BackColor = System.Drawing.Color.Gainsboro;
            this.btnKitapListele.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKitapListele.ImageIndex = 3;
            this.btnKitapListele.ImageList = this.ımageList1;
            this.btnKitapListele.Location = new System.Drawing.Point(494, 175);
            this.btnKitapListele.Margin = new System.Windows.Forms.Padding(2);
            this.btnKitapListele.Name = "btnKitapListele";
            this.btnKitapListele.Size = new System.Drawing.Size(297, 66);
            this.btnKitapListele.TabIndex = 1;
            this.btnKitapListele.Text = "Kitap Listeleme İşlemleri";
            this.btnKitapListele.UseVisualStyleBackColor = false;
            this.btnKitapListele.Click += new System.EventHandler(this.btnKitapListele_Click);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.BackColor = System.Drawing.Color.Gainsboro;
            this.btnKitapEkle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKitapEkle.ImageIndex = 2;
            this.btnKitapEkle.ImageList = this.ımageList1;
            this.btnKitapEkle.Location = new System.Drawing.Point(494, 63);
            this.btnKitapEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(297, 66);
            this.btnKitapEkle.TabIndex = 0;
            this.btnKitapEkle.Text = "Kitap Ekleme İşlemleri";
            this.btnKitapEkle.UseVisualStyleBackColor = false;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // btnEmanetIade
            // 
            this.btnEmanetIade.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEmanetIade.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetIade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmanetIade.ImageIndex = 5;
            this.btnEmanetIade.ImageList = this.ımageList1;
            this.btnEmanetIade.Location = new System.Drawing.Point(92, 496);
            this.btnEmanetIade.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmanetIade.Name = "btnEmanetIade";
            this.btnEmanetIade.Size = new System.Drawing.Size(295, 50);
            this.btnEmanetIade.TabIndex = 2;
            this.btnEmanetIade.Text = "Emanet Kitap İade İşlemleri";
            this.btnEmanetIade.UseVisualStyleBackColor = false;
            this.btnEmanetIade.Click += new System.EventHandler(this.btnEmanetIade_Click);
            // 
            // btnEmanetListele
            // 
            this.btnEmanetListele.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEmanetListele.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmanetListele.ImageIndex = 4;
            this.btnEmanetListele.ImageList = this.ımageList1;
            this.btnEmanetListele.Location = new System.Drawing.Point(92, 425);
            this.btnEmanetListele.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmanetListele.Name = "btnEmanetListele";
            this.btnEmanetListele.Size = new System.Drawing.Size(295, 50);
            this.btnEmanetListele.TabIndex = 1;
            this.btnEmanetListele.Text = "Emanet Listeleme İşlemleri";
            this.btnEmanetListele.UseVisualStyleBackColor = false;
            this.btnEmanetListele.Click += new System.EventHandler(this.btnEmanetListele_Click);
            // 
            // btnEmanetVerme
            // 
            this.btnEmanetVerme.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEmanetVerme.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetVerme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmanetVerme.ImageIndex = 6;
            this.btnEmanetVerme.ImageList = this.ımageList1;
            this.btnEmanetVerme.Location = new System.Drawing.Point(92, 357);
            this.btnEmanetVerme.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmanetVerme.Name = "btnEmanetVerme";
            this.btnEmanetVerme.Size = new System.Drawing.Size(295, 50);
            this.btnEmanetVerme.TabIndex = 0;
            this.btnEmanetVerme.Text = "Emanet Kitap Verme İşlemleri";
            this.btnEmanetVerme.UseVisualStyleBackColor = false;
            this.btnEmanetVerme.Click += new System.EventHandler(this.btnEmanetVerme_Click);
            // 
            // btnGrafik
            // 
            this.btnGrafik.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGrafik.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGrafik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrafik.ImageIndex = 7;
            this.btnGrafik.ImageList = this.ımageList1;
            this.btnGrafik.Location = new System.Drawing.Point(494, 464);
            this.btnGrafik.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrafik.Name = "btnGrafik";
            this.btnGrafik.Size = new System.Drawing.Size(297, 66);
            this.btnGrafik.TabIndex = 1;
            this.btnGrafik.Text = "Grafikler";
            this.btnGrafik.UseVisualStyleBackColor = false;
            this.btnGrafik.Click += new System.EventHandler(this.btnGrafik_Click);
            // 
            // btnSiralama
            // 
            this.btnSiralama.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSiralama.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiralama.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiralama.ImageIndex = 8;
            this.btnSiralama.ImageList = this.ımageList1;
            this.btnSiralama.Location = new System.Drawing.Point(494, 377);
            this.btnSiralama.Margin = new System.Windows.Forms.Padding(2);
            this.btnSiralama.Name = "btnSiralama";
            this.btnSiralama.Size = new System.Drawing.Size(297, 66);
            this.btnSiralama.TabIndex = 0;
            this.btnSiralama.Text = "Sıralama";
            this.btnSiralama.UseVisualStyleBackColor = false;
            this.btnSiralama.Click += new System.EventHandler(this.btnSiralama_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(986, 588);
            this.Controls.Add(this.btnKitapListele);
            this.Controls.Add(this.btnUyeListele);
            this.Controls.Add(this.btnKitapEkle);
            this.Controls.Add(this.btnEmanetIade);
            this.Controls.Add(this.btnUyeEkle);
            this.Controls.Add(this.btnGrafik);
            this.Controls.Add(this.btnEmanetListele);
            this.Controls.Add(this.btnEmanetVerme);
            this.Controls.Add(this.btnSiralama);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUyeListele;
        private System.Windows.Forms.Button btnUyeEkle;
        private System.Windows.Forms.Button btnKitapListele;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Button btnEmanetIade;
        private System.Windows.Forms.Button btnEmanetListele;
        private System.Windows.Forms.Button btnEmanetVerme;
        private System.Windows.Forms.Button btnGrafik;
        private System.Windows.Forms.Button btnSiralama;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

