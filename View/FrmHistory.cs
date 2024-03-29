﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace VideoWatcher.View {
    public partial class FrmHistory : Form {

        private readonly Dictionary<string, DateTime> _videosWatched;

        public FrmHistory(Dictionary<string, DateTime> dict) {
            InitializeComponent();
            _videosWatched = dict;
        }

        private void FrmHistory_Load(object sender, EventArgs e) {
            ReloadGrid();
            if (Owner != null) {
                Location = new Point(Owner.Location.X + Owner.Width / 2 - Width / 2, Owner.Location.Y + Owner.Height / 2 - Height / 2);
            }

            FillChart();
        }

        private void ReloadGrid() {
            DataTable table = new DataTable();

            table.Columns.Add("Watched");
            table.Columns.Add("File Name");

            List<DataRow> list = new List<DataRow>();
            foreach (KeyValuePair<string, DateTime> video in _videosWatched.OrderByDescending(x => x.Value)) {
                DataRow dr = table.NewRow();
                dr["File Name"] = video.Key;
                dr["Watched"] = video.Value;
                list.Add(dr);
                table.Rows.Add(dr);            
            }
            
            FillStats(list);

            DgGrid.DataSource = table;
        }

        private void FillStats(List<DataRow> list) {
            try {
                DateTime min = list.Min(x => DateTime.Parse(x["Watched"].ToString()));
                DateTime max = list.Max(x => DateTime.Parse(x["Watched"].ToString()));

                IEnumerable<DataRow> week = list.Where(x => DateTime.Parse(x["Watched"].ToString()) > DateTime.Now.AddDays(-7));

                IList<DateTime> times = list.Select(x => DateTime.Parse(x["Watched"].ToString())).ToList();
                IList<DateTime> weekTimes = week.Select(x => DateTime.Parse(x["Watched"].ToString())).ToList();

                DateTime avg = new DateTime((long)times.Select(d => d.TimeOfDay.Ticks).Average());
                IEnumerable<long> ticks = weekTimes.Select(d => d.TimeOfDay.Ticks);
                DateTime avgWeek = DateTime.MinValue;
                if (ticks.Any()) {
                    avgWeek = new DateTime((long)ticks.Average());
                }
                LblPerDay.Text = "Total episodes per day: " + decimal.Round((decimal)list.Count / (max - min).Days, 2).ToString() + Environment.NewLine
                                + "Average time of the day: " + Trim(avg.TimeOfDay) + Environment.NewLine
                                + "Episodes in the last seven days: " + decimal.Round((decimal)week.Count() / 7, 2).ToString() + Environment.NewLine
                                + "Average time of the last seven days: " + (avgWeek != DateTime.MinValue ? Trim(avgWeek.TimeOfDay).ToString() : "-");
            } catch (Exception) {
                LblPerDay.Text = "-";
            }
        }

        private static TimeSpan Trim(TimeSpan date) {
            return new TimeSpan(date.Hours, date.Minutes, date.Seconds);
        }

        private void FillChart() {
            Chart.Series["Episodes"]["PixelPointWidth"] = "20";
            Chart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            Chart.ChartAreas["ChartArea1"].AxisY.Interval = 1;

            var dates = new List<DateTime>();
            for (DateTime i = DateTime.Today.AddDays(-30); i <= DateTime.Today; i = i.AddDays(1)) {
                dates.Add(i);
            }

            foreach (DateTime date in dates) {
                var count = _videosWatched.Where(x => x.Value.Date == date).Count();
                Chart.Series["Episodes"].Points.AddXY(date.ToString("dd.MM"), count);
            }
        }
    }
}
