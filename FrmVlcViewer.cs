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

namespace WindowsFormsApp1 {

    public enum enumColumns {
        Watched = 1,
        Filename = 2
    }

    public enum enumSettings {
        [Description("VlcPath")]
        VlcPath = 1,
        [Description("CurrentlyWatchedFolder")]
        CurrentlyWatchedFolder = 2
    }

    public partial class FrmVlcViewer : Form {

        private Dictionary<string, DateTime> _videosWatched;
        private readonly Dictionary<string, string> _settings;

        // Execution path
        private readonly string _watchedVideosPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "WatchedVideos.json");
        private readonly string _settingsPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "Settings.json");

        public FrmVlcViewer() {
            InitializeComponent();

            if (File.Exists(_watchedVideosPath)) {
                using (StreamReader file = File.OpenText(_watchedVideosPath)) {
                    JsonSerializer serializer = new JsonSerializer();
                    _videosWatched = (Dictionary<string, DateTime>)serializer.Deserialize(file, typeof(Dictionary<string, DateTime>));
                }
            } else {
                _videosWatched = new Dictionary<string, DateTime>();
            }

            if (File.Exists(_settingsPath)) {
                using (StreamReader file = File.OpenText(_settingsPath)) {
                    JsonSerializer serializer = new JsonSerializer();
                    _settings = (Dictionary<string, string>)serializer.Deserialize(file, typeof(Dictionary<string, string>));
                }
            } else {
                _settings = new Dictionary<string, string>() {
                    {  "CurrentlyWatchedFolder", string.Empty},
                    {  "VlcPath", @"C:\Program Files\VideoLAN\VLC\vlc.exe"},
                };
            }

            if (Directory.Exists(_settings["CurrentlyWatchedFolder"])) {
                LblFileName.Text = _settings["CurrentlyWatchedFolder"];
                LoadFileNames(LblFileName.Text);
            }
        }

        #region File Operations
        private void LoadFileNames(string path) {
            String[] files = Directory.GetFiles(path);

            DataTable table = new DataTable();

            table.Columns.Add("Watched");

            table.Columns.Add("File Name");
            foreach(var file in files) {
                FileInfo info = new FileInfo(file);
                if (info.Extension == ".mkv" || info.Extension == ".vlc") {
                    DataRow dr = table.NewRow();
                    dr["File Name"] = info.Name;
                    table.Rows.Add(dr);
                }
            }

            RefreshWatched(table);

            DgFiles.DataSource = table;
        }

        private void UpdateDictionary(string videoName) {
            if (!string.IsNullOrWhiteSpace(videoName)) {
                if (_videosWatched.ContainsKey(videoName)) {
                    _videosWatched[videoName] = DateTime.Now;
                } else {
                    _videosWatched.Add(videoName, DateTime.Now);
                }
            }
            SaveDictAsJson();
            RefreshWatched((DataTable)DgFiles.DataSource);
        }


        private void RemoveFromDictionary(string videoName) {
            if (_videosWatched.ContainsKey(videoName)) {
                _videosWatched.Remove(videoName);
                SaveDictAsJson();
                RefreshWatched((DataTable)DgFiles.DataSource);
            }
        }
        private void SaveDictAsJson() {
            var json = JsonConvert.SerializeObject(_videosWatched);
            File.WriteAllText(_watchedVideosPath, json);
        }

        #endregion

        #region Table Operations

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
            if (DgFiles.SelectedRows.Count == 0) {
                ShowError("No Video selected.");
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
                    p.StartInfo.Arguments = "\"" + videoPath + "\"";
                    p.Start();
                } else {
                    ShowError("Video was not found.");
                    return;
                }

                UpdateDictionary(videoName);

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

                _settings["CurrentlyWatchedFolder"] = dialog.SelectedPath;
                var json = JsonConvert.SerializeObject(_settings);
                File.WriteAllText(_settingsPath, json);
                
                LoadFileNames(LblFileName.Text);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e) {
            if(MessageBox.Show("Do you really want to delete all the history?", "Really?",
               MessageBoxButtons.YesNo) == DialogResult.Yes) {

                _videosWatched = new Dictionary<string, DateTime>();
                UpdateDictionary(null);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e) {
            LoadFileNames(LblFileName.Text);
        }

        private void BtnWatched_Click(object sender, EventArgs e) {
            string name = GetSelectedName();
            if (name != null) {
                UpdateDictionary(name);
            }
        }

        private void BtnUnwatched_Click(object sender, EventArgs e) {
            string name = GetSelectedName();
            if (name != null) {
                RemoveFromDictionary(name);
            }
        }

        private void DgFiles_DoubleClick(object sender, EventArgs e) {
            BtnVlc_Click(sender, e);
        }

        #endregion


        private void ShowError(string message) {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK);
        }
    }
}
