using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Hydra_Audio_Player
{
    public partial class Uygulama : Form
    {
        public Uygulama() 
            => InitializeComponent();

        private void ListeyiTemizle_Click(object sender, EventArgs e) 
            => OynatmaListesi.Items.Clear();

        private void Cikis_Click(object sender, EventArgs e) 
            => Close();

        private List<string> _dosyalar, _yol;

        private void DosyaSec_Click(object sender, EventArgs e)
        {
            if (DosyaSecimi.ShowDialog() != DialogResult.OK) return;
            _dosyalar = DosyaSecimi.SafeFileNames.ToList();
            _yol = DosyaSecimi.FileNames.ToList();

            foreach (var dosya in _dosyalar) 
                OynatmaListesi.Items.Add(Path.GetFileNameWithoutExtension(dosya));
        }

        private void OynatmaListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OynatmaListesi.SelectedItem == null) return;

            MedyaOynatici.URL = _yol[OynatmaListesi.SelectedIndex];
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
