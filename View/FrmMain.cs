using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SeriesProgressManager.Helper;
using VideoWatcher.View;

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

            OpenDirectory(_settings["CurrentlyWatchedFolder"]);
        }

        private void OpenDirectory(string path) {
            if (Directory.Exists(path)) {
                FileHelper.UpdateSettingsFolder(_settings, path, _settingsPath);

                LblFileName.Text = path;
                ReloadGrid();
                RefreshTreeview();
            }
        }

        private void RefreshTreeview() {
            try {
                TreeviewHelper.ListUpperDirectory(TvFiles, LblFileName.Text, CbRecursiveSearch.Checked);
                Search();
            } catch (UnauthorizedAccessException ex) {
                ShowError("Missing rights", ex);
                TreeviewHelper.ListUpperDirectory(TvFiles, LblFileName.Text, false);

            } catch (Exception ex) {
                ShowError("Error while loading treeview", ex);
            }
        }

        #region Table Operations
        private void ReloadGrid() {
            try {
                string folder = LblFileName.Text;
                var table = FileHelper.LoadFileNames(folder);
                DgFiles.DataSource = table;
                RefreshWatched();
            } catch (Exception) {
                ShowError("Files not found");
            }
        }

        private void RefreshWatched() {
            var table = (DataTable) DgFiles.DataSource;

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
            StartVideo();   
        }

        private void BtnOpenFile_Click(object sender, EventArgs e) {
            var dialog = new FolderBrowserDialog() {
                ShowNewFolderButton = false,
                SelectedPath = Directory.Exists(_settings["CurrentlyWatchedFolder"]) ? _settings["CurrentlyWatchedFolder"] : null
            };

            if (dialog.ShowDialog() == DialogResult.OK) {

                OpenDirectory(dialog.SelectedPath);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e) {
            if(MessageBox.Show("Do you really want to delete all history?", "Delete History",
               MessageBoxButtons.YesNo) == DialogResult.Yes) {

                _videosWatched = new Dictionary<string, DateTime>();
                FileHelper.UpdateDictionary(_videosWatched, null, _watchedVideosPath);
                RefreshWatched();
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e) {
            RefreshTreeview();
            ReloadGrid();
        }

        private void BtnWatched_Click(object sender, EventArgs e) {
            string name = GetSelectedName();
            if (name != null) {
                FileHelper.UpdateDictionary(_videosWatched, name, _watchedVideosPath);
                RefreshWatched();
            }
        }

        private void BtnUnwatched_Click(object sender, EventArgs e) {
            string name = GetSelectedName();
            if (name != null) {
                FileHelper.RemoveFromDictionary(_videosWatched, name, _watchedVideosPath);
                RefreshWatched();
            }
        }

        private void DgFiles_DoubleClick(object sender, EventArgs e) {
            BtnVlc_Click(sender, e);
        }

        private void TvFiles_DoubleClick(object sender, EventArgs e) {
            try {
                string curDir = TreeviewHelper.GetDirectoryPath(TvFiles, LblFileName.Text);
                OpenDirectory(curDir);

            } catch (Exception) {
                ShowError("Directory could not be opened.");
            }
        }

        #endregion

        private void StartVideo() {
            try {
                string videoName = GetSelectedName();
                string videoPath = $"{LblFileName.Text}\\{videoName}";

                if (File.Exists(videoPath)) {

                    if (!File.Exists(_settings["VlcPath"])) {
                        ShowError("vlc.exe not found. Make sure that the path in the Settings.json is correct.");
                        return;
                    }

                    ProcessHelper.StartProcess(_settings["VlcPath"], videoPath);
                } else {
                    ShowError("Video was not found.");
                    return;
                }

                FileHelper.UpdateDictionary(_videosWatched, videoName, _watchedVideosPath);
                RefreshWatched();

            } catch (Exception ex) {
                ShowError(ex.Message);
            }
        }

        private void ShowError(string message, Exception ex = null) {
            if (ex == null) {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK);
            } else {
                MessageBox.Show($"{message}{Environment.NewLine}{ex}", "Error", MessageBoxButtons.OK);
            }
        }


        private void DgFiles_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                e.Handled = true;
                StartVideo();
            }
        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                Search();
            }
        }

        private void Search() {
            try {
                TreeviewHelper.SearchRecursive(TvFiles, TvFiles.Nodes[0], TxtSearch.Text);
            } catch (Exception) {
                ShowError("Error while searhcing.");
            }
        }

        private void BtnHistory_Click(object sender, EventArgs e) {
            new FrmHistory(_videosWatched).Show();
        }
    }
}
