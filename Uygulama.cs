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
            if (DosyaSecimi.ShowDialog() == DialogResult.OK)
            {
                // "DosyaSecimi" öğesiyle seçilmiş tüm dosyaları "yol" adlı diziye aktarır.
                var yol = DosyaSecimi.FileNames;

                // "yol" adlı dizideki her bir dosya için "OynatmaListesi" öğesine gerekli dosya bilgilerini aktarır.
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
        }

        private void OynatmaListesi_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Çift tıklanan hücrenin bağlı olduğu parçanın oynatılmasını sağlar.
            MedyaOynatici.URL = OynatmaListesi.CurrentRow?.Cells["YolColumn"].Value.ToString();

            /* Çift tıklanan hücrenin bağlı olduğu parçanın dosya bilgisini
            "DosyaBilgisi" sınıfında yeni bir nesne oluşturarak getirir. */
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
            if (XMLKaydet.ShowDialog() == DialogResult.OK)
            {
                // "XMLKaydet" öğesinde seçilmiş yolu "yol" adlı diziye aktarır.
                var yol = XMLKaydet.FileName;

                // "OynatmaListesi" öğesini ve "yol" dizisini kullanarak "Liste" sınıfından yeni bir nesne oluşturur.
                var calmaListesi = new Liste(OynatmaListesi, yol);

                // "Liste" sınıfında oluşturulan nesneyi XML dosyasına yazar.
                calmaListesi.DataTable.WriteXml(yol, XmlWriteMode.WriteSchema);
            }
        }

        private void Yukle_Click(object sender, EventArgs e)
        {
            if (XMLYukle.ShowDialog() == DialogResult.OK)
            {
                OynatmaListesi.Rows.Clear();

                // "XMLYukle" öğesinde seçilen yolu "yol" öğesine aktarır.
                var yol = XMLYukle.FileName;

                // "yol" dizisinden alınan bilgiyi kullanarak "Liste" sınıfından yeni bir nesne oluşturur.
                var veri = new Liste(yol);

                // Oluşturulan nesnedeki bilgileri "OynatmaListesi" öğesine aktarır.
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
}
