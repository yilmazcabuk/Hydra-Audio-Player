    using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Hydra_Audio_Player
{
    public class Liste
    {
        public DataSet DataSet;
        public DataTable DataTable;

        public Liste(DataGridView tablo, string yol)
        {
            // Dosya adını kullanarak "DataSet" öğesini ve "Liste" adlı "DataTable" öğesini oluşturur.
            DataSet = new DataSet(Path.GetFileNameWithoutExtension(yol));
            DataTable = new DataTable("Liste");

            // Alınan "tablo" öğesinin sütunlarını "DataTable" öğesine aktarır.
            foreach (DataGridViewColumn column in tablo.Columns)
                DataTable.Columns.Add(column.Name);

            // "tablo" öğesinin satırlarını "DataTable" öğesine aktarır.
            foreach (DataGridViewRow row in tablo.Rows)
                DataTable.Rows.Add(
                    row.Cells["ParcaColumn"].Value,
                    row.Cells["SanatciColumn"].Value,
                    row.Cells["UzunlukColumn"].Value,
                    row.Cells["YolColumn"].Value);

            DataSet.Tables.Add(DataTable);
        }

        public Liste(string yol)
        {
            // "yol" dizisinden alınan bilgiyi kullanarak yeni "DataSet" ve "DataTable" nesneleri oluşturur.
            DataSet = new DataSet();
            DataSet.ReadXml(yol, XmlReadMode.ReadSchema);
            DataTable = DataSet.Tables["Liste"];
        }
    }
}