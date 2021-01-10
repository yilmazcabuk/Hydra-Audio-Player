using System.Data;
using System.Windows.Forms;

namespace Hydra_Audio_Player
{
    public class Liste
    {
        public DataSet DataSet;
        public DataTable DataTable;
        public Liste(DataGridView tablo)
        {
            DataSet = new DataSet();
            DataTable = new DataTable();

            foreach (DataGridViewColumn column in tablo.Columns)
            {
                DataTable.Columns.Add(column.HeaderText);
            }

            foreach (DataGridViewRow row in tablo.Rows)
            {
                DataTable.Rows.Add
                    (row.Cells["ParcaColumn"].Value,
                    row.Cells["SanatciColumn"].Value,
                    row.Cells["UzunlukColumn"].Value,
                    row.Cells["YolColumn"].Value);
            }

            DataSet.Tables.Add(DataTable);
        }

        public Liste(string yol)
        {
            DataSet = new DataSet();
            DataSet.ReadXml(yol);
        }
    }
}