using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Hydra_Audio_Player
{
    public class DosyaBilgisi
    {
        public string ParcaAdi { get; set; }
        public string Sanatci { get; set; }
        public string Yazar { get; set; }
        public string Album { get; set; }
        public string YapimYili { get; set; }
        public string Tur { get; set; }
        public string Uzunluk { get; set; }
        public PictureBox AlbumKapagi { get; set; }
        public DosyaBilgisi(string url)
        {
            var dosya = TagLib.File.Create(url);

            ParcaAdi = dosya.Tag.Title;
            Sanatci = dosya.Tag.FirstPerformer;
            Yazar = dosya.Tag.FirstComposer;
            Album = dosya.Tag.Album;
            YapimYili = dosya.Tag.Year.ToString();
            Tur = dosya.Tag.FirstGenre;
            Uzunluk = dosya.Properties.Duration.ToString();
            
            AlbumKapagi = new PictureBox();
            var mStream = new MemoryStream();
            var albumKapak = dosya.Tag.Pictures.FirstOrDefault();
            switch (albumKapak)
            {
                case null:
                    AlbumKapagi.Image = Properties.Resources._default;
                    break;

                default:
                    var resimBilgisi = albumKapak.Data.Data;
                    mStream.Write(resimBilgisi, 0, Convert.ToInt32(resimBilgisi.Length));
                    var cizim = new Bitmap(mStream, false);
                    mStream.Dispose();
                    AlbumKapagi.Image = cizim;
                    break;
            }
        }
    }
}