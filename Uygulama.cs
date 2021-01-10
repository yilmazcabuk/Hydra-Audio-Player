using System;
using System.Windows.Forms;
using System.IO;

namespace Hydra_Audio_Player
{
    public partial class Uygulama : Form
    {
        public Uygulama() 
            => InitializeComponent();

        private void ListeyiTemizle_Click(object sender, EventArgs e)
            => OynatmaListesi.Rows.Clear();

        private void Cikis_Click(object sender, EventArgs e)
            => Close();

        private string[] _yol;

        private void DosyaSec_Click(object sender, EventArgs e)
        {
            if (DosyaSecimi.ShowDialog() != DialogResult.OK) return;
            _yol = DosyaSecimi.FileNames;

            foreach (var dosya in _yol)
            {
                var dosyaBilgisi = new DosyaBilgisi(Path.GetFullPath(dosya));
                OynatmaListesi.Rows.Add(dosyaBilgisi.ParcaAdi, dosyaBilgisi.Sanatci, dosyaBilgisi.Uzunluk, Path.GetFullPath(dosya));
            }
        }

        private void OynatmaListesi_SelectionChanged(object sender, EventArgs e)
        {
            MedyaOynatici.URL = OynatmaListesi.CurrentRow?.Cells["Yol"].Value.ToString();
            var dosya = new DosyaBilgisi(MedyaOynatici.URL);

            ParcaAdi.Text = dosya.ParcaAdi;
            Sanatci.Text = dosya.Sanatci;
            Yazar.Text = dosya.Yazar;
            Album.Text = dosya.Album;
            YapimYili.Text = dosya.YapimYili;
            Tur.Text = dosya.Tur;
            Uzunluk.Text = dosya.Uzunluk;
            AlbumKapagi.Image = dosya.AlbumKapagi.Image;
        }
    }
}
