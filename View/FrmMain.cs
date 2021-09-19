using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeriesProgressManager.Helper;

namespace View {
    public partial class FrmMain : Form {

        private Dictionary<string, DateTime> _videosWatched;
        private readonly Dictionary<string, string> _settings;

        // Execution path
        private readonly string _watchedVideosPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "WatchedVideos.json");
        private readonly string _settingsPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "Settings.json");

        public FrmMain() {
            InitializeComponent();

            _videosWatched = FileHelper.GetVideoDictionary(_watchedVideosPath);
            _settings = FileHelper.GetSettings(_settingsPath);
            
            if (Directory.Exists(_settings["CurrentlyWatchedFolder"])) {
                LblFileName.Text = _settings["CurrentlyWatchedFolder"];
                RefreshGrid();
            }
        }

        #region Table Operations
        private void RefreshGrid() {
            try {
                string folder = LblFileName.Text;
                var table = FileHelper.LoadFileNames(folder);
                RefreshWatched(table);
                DgFiles.DataSource = table;
            } catch (Exception) {
                ShowError("Files not found");
            }
        }

        private void RefreshWatched(DataTable table) {
            foreach (DataRow row in table.Rows) {
                string rowData = row["File Name"].ToString();
                if (_videosWatched.ContainsKey(rowData)) {
                    row["Watched"] = _videosWatched[row["File Name"].ToString()].ToString("g");
                } else {
                    row["Watched"] = string.Empty;
                }
            }
        }

        private string GetSelectedName() {
            if (DgFiles.SelectedRows.Count != 1) {
                return null;
            }

            var file = DgFiles.SelectedRows[0];
            return (string)file.Cells["File Name"].Value;
        }

        #endregion

        #region Event Handler

        private void BtnVlc_Click(object sender, EventArgs e) {
            try {

                string videoName = GetSelectedName();
                string videoPath = $"{LblFileName.Text}\\{videoName}";

                if (File.Exists(videoPath)) {

                    if (!File.Exists(_settings["VlcPath"])) {
                        ShowError("vlc.exe not found. Make sure that the path in the Settings.json is correct.");
                        return;
                    }

                    Process p = new Process();
                    p.StartInfo.FileName = _settings["VlcPath"];
                    p.StartInfo.Arguments = $"\"{videoPath}\"";
                    p.Start();
                } else {
                    ShowError("Video was not found.");
                    return;
                }

                FileHelper.UpdateDictionary(_videosWatched, videoName, _watchedVideosPath);
                RefreshGrid();

            } catch (Exception ex) {
                ShowError(ex.Message);
            }
        }

        private void BtnOpenFile_Click(object sender, EventArgs e) {
            var dialog = new FolderBrowserDialog() {
                ShowNewFolderButton = false,
                SelectedPath = Directory.Exists(_settings["CurrentlyWatchedFolder"]) ? _settings["CurrentlyWatchedFolder"] : null
            };

            if (dialog.ShowDialog() == DialogResult.OK) {
                LblFileName.Text = dialog.SelectedPath;

                FileHelper.UpdateSettingsFolder(_settings, dialog.SelectedPath, _settingsPath);

                RefreshGrid();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e) {
            if(MessageBox.Show("Do you really want to delete all history?", "Delete History",
               MessageBoxButtons.YesNo) == DialogResult.Yes) {

                _videosWatched = new Dictionary<string, DateTime>();
                FileHelper.UpdateDictionary(_videosWatched, null, _watchedVideosPath);
                RefreshGrid();
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e) {
            RefreshGrid();
        }

        private void BtnWatched_Click(object sender, EventArgs e) {
            string name = GetSelectedName();
            if (name != null) {
                FileHelper.UpdateDictionary(_videosWatched, name, _watchedVideosPath);
                RefreshGrid();
            }
        }

        private void BtnUnwatched_Click(object sender, EventArgs e) {
            string name = GetSelectedName();
            if (name != null) {
                FileHelper.RemoveFromDictionary(_videosWatched, name, _watchedVideosPath);
                RefreshGrid();
            }
        }

        private void DgFiles_DoubleClick(object sender, EventArgs e) {
            BtnVlc_Click(sender, e);
        }

        #endregion

        private void ShowError(string message, Exception ex = null) {
            if (ex == null) {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK);
            } else {
                MessageBox.Show($"{message}{Environment.NewLine}{ex}", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
