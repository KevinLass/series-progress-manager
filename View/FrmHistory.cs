using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoWatcher.View {
    public partial class FrmHistory : Form {

        private Dictionary<string, DateTime> _videosWatched;

        public FrmHistory(Dictionary<string, DateTime> dict) {
            InitializeComponent();
            _videosWatched = dict;
        }

        private void FrmHistory_Load(object sender, EventArgs e) {
            ReloadGrid();
        }

        // TODO move into helper
        private void ReloadGrid() {
            DataTable table = new DataTable();

            table.Columns.Add("Watched");
            table.Columns.Add("File Name");

            var list = new List<DataRow>();
            foreach (KeyValuePair<string, DateTime> video in _videosWatched) {
                DataRow dr = table.NewRow();
                dr["File Name"] = video.Key;
                dr["Watched"] = video.Value;
                list.Add(dr);
            }
            
            // TODO sort smarter
            foreach(var row in list.OrderBy(x => DateTime.Parse(x["Watched"].ToString()))) {
                table.Rows.Add(row);
            }

            var min = list.Min(x => DateTime.Parse(x["Watched"].ToString()));
            var max = list.Max(x => DateTime.Parse(x["Watched"].ToString()));

            LblPerDay.Text = decimal.Round(((decimal)list.Count / (max - min).Days), 3).ToString();
            DgGrid.DataSource = table;
        }
    }
}
