
namespace Hydra_Audio_Player
{
    partial class Uygulama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uygulama));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MedyaOynatici = new AxWMPLib.AxWindowsMediaPlayer();
            this.DosyaSec = new System.Windows.Forms.Button();
            this.ListeyiTemizle = new System.Windows.Forms.Button();
            this.Cikis = new System.Windows.Forms.Button();
            this.UzunlukLabel = new System.Windows.Forms.Label();
            this.TurLabel = new System.Windows.Forms.Label();
            this.AlbumLabel = new System.Windows.Forms.Label();
            this.YazarLabel = new System.Windows.Forms.Label();
            this.SanatciLabel = new System.Windows.Forms.Label();
            this.ParcaAdiLabel = new System.Windows.Forms.Label();
            this.YapimYiliLabel = new System.Windows.Forms.Label();
            this.Uzunluk = new System.Windows.Forms.TextBox();
            this.Tur = new System.Windows.Forms.TextBox();
            this.YapimYili = new System.Windows.Forms.TextBox();
            this.Album = new System.Windows.Forms.TextBox();
            this.Yazar = new System.Windows.Forms.TextBox();
            this.Sanatci = new System.Windows.Forms.TextBox();
            this.ParcaAdi = new System.Windows.Forms.TextBox();
            this.AlbumKapagi = new System.Windows.Forms.PictureBox();
            this.DosyaSecimi = new System.Windows.Forms.OpenFileDialog();
            this.OynatmaListesi = new System.Windows.Forms.DataGridView();
            this.ParcaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SanatciColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UzunlukColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MedyaOynatici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumKapagi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OynatmaListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // MedyaOynatici
            // 
            this.MedyaOynatici.Enabled = true;
            this.MedyaOynatici.Location = new System.Drawing.Point(-2, 0);
            this.MedyaOynatici.Name = "MedyaOynatici";
            this.MedyaOynatici.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MedyaOynatici.OcxState")));
            this.MedyaOynatici.Size = new System.Drawing.Size(404, 227);
            this.MedyaOynatici.TabIndex = 0;
            // 
            // DosyaSec
            // 
            this.DosyaSec.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DosyaSec.Location = new System.Drawing.Point(12, 611);
            this.DosyaSec.Name = "DosyaSec";
            this.DosyaSec.Size = new System.Drawing.Size(184, 55);
            this.DosyaSec.TabIndex = 17;
            this.DosyaSec.Text = "Dosyaları Seç";
            this.DosyaSec.UseVisualStyleBackColor = true;
            this.DosyaSec.Click += new System.EventHandler(this.DosyaSec_Click);
            // 
            // ListeyiTemizle
            // 
            this.ListeyiTemizle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ListeyiTemizle.Location = new System.Drawing.Point(206, 611);
            this.ListeyiTemizle.Name = "ListeyiTemizle";
            this.ListeyiTemizle.Size = new System.Drawing.Size(184, 55);
            this.ListeyiTemizle.TabIndex = 18;
            this.ListeyiTemizle.Text = "Listeyi Temizle";
            this.ListeyiTemizle.UseVisualStyleBackColor = true;
            this.ListeyiTemizle.Click += new System.EventHandler(this.ListeyiTemizle_Click);
            // 
            // Cikis
            // 
            this.Cikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cikis.Location = new System.Drawing.Point(206, 670);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(184, 55);
            this.Cikis.TabIndex = 19;
            this.Cikis.Text = "Çıkış";
            this.Cikis.UseVisualStyleBackColor = true;
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // UzunlukLabel
            // 
            this.UzunlukLabel.AutoSize = true;
            this.UzunlukLabel.Location = new System.Drawing.Point(10, 393);
            this.UzunlukLabel.Name = "UzunlukLabel";
            this.UzunlukLabel.Size = new System.Drawing.Size(46, 13);
            this.UzunlukLabel.TabIndex = 61;
            this.UzunlukLabel.Text = "Uzunluk";
            // 
            // TurLabel
            // 
            this.TurLabel.AutoSize = true;
            this.TurLabel.Location = new System.Drawing.Point(10, 367);
            this.TurLabel.Name = "TurLabel";
            this.TurLabel.Size = new System.Drawing.Size(23, 13);
            this.TurLabel.TabIndex = 60;
            this.TurLabel.Text = "Tür";
            // 
            // AlbumLabel
            // 
            this.AlbumLabel.AutoSize = true;
            this.AlbumLabel.Location = new System.Drawing.Point(10, 315);
            this.AlbumLabel.Name = "AlbumLabel";
            this.AlbumLabel.Size = new System.Drawing.Size(36, 13);
            this.AlbumLabel.TabIndex = 59;
            this.AlbumLabel.Text = "Albüm";
            // 
            // YazarLabel
            // 
            this.YazarLabel.AutoSize = true;
            this.YazarLabel.Location = new System.Drawing.Point(10, 289);
            this.YazarLabel.Name = "YazarLabel";
            this.YazarLabel.Size = new System.Drawing.Size(34, 13);
            this.YazarLabel.TabIndex = 58;
            this.YazarLabel.Text = "Yazar";
            // 
            // SanatciLabel
            // 
            this.SanatciLabel.AutoSize = true;
            this.SanatciLabel.Location = new System.Drawing.Point(10, 263);
            this.SanatciLabel.Name = "SanatciLabel";
            this.SanatciLabel.Size = new System.Drawing.Size(43, 13);
            this.SanatciLabel.TabIndex = 57;
            this.SanatciLabel.Text = "Sanatçı";
            // 
            // ParcaAdiLabel
            // 
            this.ParcaAdiLabel.AutoSize = true;
            this.ParcaAdiLabel.Location = new System.Drawing.Point(10, 237);
            this.ParcaAdiLabel.Name = "ParcaAdiLabel";
            this.ParcaAdiLabel.Size = new System.Drawing.Size(53, 13);
            this.ParcaAdiLabel.TabIndex = 56;
            this.ParcaAdiLabel.Text = "Parça Adı";
            // 
            // YapimYiliLabel
            // 
            this.YapimYiliLabel.AutoSize = true;
            this.YapimYiliLabel.Location = new System.Drawing.Point(10, 341);
            this.YapimYiliLabel.Name = "YapimYiliLabel";
            this.YapimYiliLabel.Size = new System.Drawing.Size(52, 13);
            this.YapimYiliLabel.TabIndex = 55;
            this.YapimYiliLabel.Text = "Yapım Yılı\r\n";
            // 
            // Uzunluk
            // 
            this.Uzunluk.Location = new System.Drawing.Point(68, 390);
            this.Uzunluk.Name = "Uzunluk";
            this.Uzunluk.ReadOnly = true;
            this.Uzunluk.Size = new System.Drawing.Size(134, 20);
            this.Uzunluk.TabIndex = 54;
            // 
            // Tur
            // 
            this.Tur.Location = new System.Drawing.Point(68, 364);
            this.Tur.Name = "Tur";
            this.Tur.ReadOnly = true;
            this.Tur.Size = new System.Drawing.Size(134, 20);
            this.Tur.TabIndex = 53;
            // 
            // YapimYili
            // 
            this.YapimYili.Location = new System.Drawing.Point(68, 338);
            this.YapimYili.Name = "YapimYili";
            this.YapimYili.ReadOnly = true;
            this.YapimYili.Size = new System.Drawing.Size(134, 20);
            this.YapimYili.TabIndex = 52;
            // 
            // Album
            // 
            this.Album.Location = new System.Drawing.Point(68, 312);
            this.Album.Name = "Album";
            this.Album.ReadOnly = true;
            this.Album.Size = new System.Drawing.Size(134, 20);
            this.Album.TabIndex = 51;
            // 
            // Yazar
            // 
            this.Yazar.Location = new System.Drawing.Point(68, 286);
            this.Yazar.Name = "Yazar";
            this.Yazar.ReadOnly = true;
            this.Yazar.Size = new System.Drawing.Size(134, 20);
            this.Yazar.TabIndex = 50;
            // 
            // Sanatci
            // 
            this.Sanatci.Location = new System.Drawing.Point(68, 260);
            this.Sanatci.Name = "Sanatci";
            this.Sanatci.ReadOnly = true;
            this.Sanatci.Size = new System.Drawing.Size(134, 20);
            this.Sanatci.TabIndex = 49;
            // 
            // ParcaAdi
            // 
            this.ParcaAdi.Location = new System.Drawing.Point(68, 234);
            this.ParcaAdi.Name = "ParcaAdi";
            this.ParcaAdi.ReadOnly = true;
            this.ParcaAdi.Size = new System.Drawing.Size(134, 20);
            this.ParcaAdi.TabIndex = 48;
            // 
            // AlbumKapagi
            // 
            this.AlbumKapagi.Image = global::Hydra_Audio_Player.Properties.Resources._default;
            this.AlbumKapagi.InitialImage = global::Hydra_Audio_Player.Properties.Resources._default;
            this.AlbumKapagi.Location = new System.Drawing.Point(211, 233);
            this.AlbumKapagi.Name = "AlbumKapagi";
            this.AlbumKapagi.Size = new System.Drawing.Size(180, 180);
            this.AlbumKapagi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AlbumKapagi.TabIndex = 47;
            this.AlbumKapagi.TabStop = false;
            // 
            // DosyaSecimi
            // 
            this.DosyaSecimi.AddExtension = false;
            this.DosyaSecimi.Multiselect = true;
            // 
            // OynatmaListesi
            // 
            this.OynatmaListesi.AllowUserToAddRows = false;
            this.OynatmaListesi.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.OynatmaListesi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OynatmaListesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.OynatmaListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OynatmaListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ParcaColumn,
            this.SanatciColumn,
            this.UzunlukColumn,
            this.Yol});
            this.OynatmaListesi.Location = new System.Drawing.Point(13, 420);
            this.OynatmaListesi.MultiSelect = false;
            this.OynatmaListesi.Name = "OynatmaListesi";
            this.OynatmaListesi.ReadOnly = true;
            this.OynatmaListesi.Size = new System.Drawing.Size(378, 185);
            this.OynatmaListesi.TabIndex = 62;
            this.OynatmaListesi.SelectionChanged += new System.EventHandler(this.OynatmaListesi_SelectionChanged);
            // 
            // ParcaColumn
            // 
            this.ParcaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ParcaColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.ParcaColumn.HeaderText = "Parça Adı";
            this.ParcaColumn.Name = "ParcaColumn";
            this.ParcaColumn.ReadOnly = true;
            this.ParcaColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SanatciColumn
            // 
            this.SanatciColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SanatciColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.SanatciColumn.HeaderText = "Sanatçı";
            this.SanatciColumn.Name = "SanatciColumn";
            this.SanatciColumn.ReadOnly = true;
            // 
            // UzunlukColumn
            // 
            this.UzunlukColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.UzunlukColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.UzunlukColumn.HeaderText = "Uzunluk";
            this.UzunlukColumn.Name = "UzunlukColumn";
            this.UzunlukColumn.ReadOnly = true;
            // 
            // Yol
            // 
            this.Yol.HeaderText = "Yol";
            this.Yol.Name = "Yol";
            this.Yol.ReadOnly = true;
            this.Yol.Visible = false;
            // 
            // Uygulama
            // 
            this.AcceptButton = this.DosyaSec;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cikis;
            this.ClientSize = new System.Drawing.Size(402, 737);
            this.Controls.Add(this.OynatmaListesi);
            this.Controls.Add(this.UzunlukLabel);
            this.Controls.Add(this.TurLabel);
            this.Controls.Add(this.AlbumLabel);
            this.Controls.Add(this.YazarLabel);
            this.Controls.Add(this.SanatciLabel);
            this.Controls.Add(this.ParcaAdiLabel);
            this.Controls.Add(this.YapimYiliLabel);
            this.Controls.Add(this.Uzunluk);
            this.Controls.Add(this.Tur);
            this.Controls.Add(this.YapimYili);
            this.Controls.Add(this.Album);
            this.Controls.Add(this.Yazar);
            this.Controls.Add(this.Sanatci);
            this.Controls.Add(this.ParcaAdi);
            this.Controls.Add(this.AlbumKapagi);
            this.Controls.Add(this.Cikis);
            this.Controls.Add(this.ListeyiTemizle);
            this.Controls.Add(this.DosyaSec);
            this.Controls.Add(this.MedyaOynatici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Uygulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hydra Audio Player";
            ((System.ComponentModel.ISupportInitialize)(this.MedyaOynatici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumKapagi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OynatmaListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer MedyaOynatici;
        private System.Windows.Forms.Button DosyaSec;
        private System.Windows.Forms.Button ListeyiTemizle;
        private System.Windows.Forms.Button Cikis;
        private System.Windows.Forms.Label UzunlukLabel;
        private System.Windows.Forms.Label TurLabel;
        private System.Windows.Forms.Label AlbumLabel;
        private System.Windows.Forms.Label YazarLabel;
        private System.Windows.Forms.Label SanatciLabel;
        private System.Windows.Forms.Label ParcaAdiLabel;
        private System.Windows.Forms.Label YapimYiliLabel;
        private System.Windows.Forms.TextBox Uzunluk;
        private System.Windows.Forms.TextBox Tur;
        private System.Windows.Forms.TextBox YapimYili;
        private System.Windows.Forms.TextBox Album;
        private System.Windows.Forms.TextBox Yazar;
        private System.Windows.Forms.TextBox Sanatci;
        private System.Windows.Forms.TextBox ParcaAdi;
        private System.Windows.Forms.PictureBox AlbumKapagi;
        private System.Windows.Forms.OpenFileDialog DosyaSecimi;
        private System.Windows.Forms.DataGridView OynatmaListesi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParcaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanatciColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UzunlukColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yol;
    }
}

