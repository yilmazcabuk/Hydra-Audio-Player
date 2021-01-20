using System;
using System.Data;
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

        private void DosyaSec_Click(object sender, EventArgs e)
        {
            if (DosyaSecimi.ShowDialog() != DialogResult.OK) return;
            var yol = DosyaSecimi.FileNames;

            foreach (var dosya in yol)
            {
                var dosyaBilgisi = new DosyaBilgisi(Path.GetFullPath(dosya));

                OynatmaListesi.Rows.Add(
                    dosyaBilgisi.ParcaAdi,
                    dosyaBilgisi.Sanatci,
                    dosyaBilgisi.Uzunluk, 
                    Path.GetFullPath(dosya));
            }
        }

        private void OynatmaListesi_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MedyaOynatici.URL = OynatmaListesi.CurrentRow?.Cells["YolColumn"].Value.ToString();
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

        private void Kaydet_Click(object sender, EventArgs e)
        {
            if (XMLKaydet.ShowDialog() != DialogResult.OK) return;

            var yol = XMLKaydet.FileName;
            var calmaListesi = new Liste(OynatmaListesi, yol);
            calmaListesi.DataTable.WriteXml(yol, XmlWriteMode.WriteSchema);
        }

        private void Yukle_Click(object sender, EventArgs e)
        {
            if (XMLYukle.ShowDialog() != DialogResult.OK) return;
            OynatmaListesi.Rows.Clear();

            var yol = XMLYukle.FileName;
            var veri = new Liste(yol);

            foreach (DataRow row in veri.DataTable.Rows)
            {
                OynatmaListesi.Rows.Add(
                    row["ParcaColumn"],
                    row["SanatciColumn"],
                    row["UzunlukColumn"],
                    row["YolColumn"]);
            }
        }
    }
}
