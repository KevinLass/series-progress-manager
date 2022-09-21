using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeriesProgressManager.Helper {
    public class FileHelper {

        public static Dictionary<string, DateTime> GetVideoDictionary(string path) {
            try {
                if (File.Exists(path)) {
                    using (StreamReader file = File.OpenText(path)) {
                        JsonSerializer serializer = new JsonSerializer();
                        return (Dictionary<string, DateTime>)serializer.Deserialize(file, typeof(Dictionary<string, DateTime>));
                    }
                }
                else {
                    return new Dictionary<string, DateTime>();
                }
            } catch (Exception) {
                return new Dictionary<string, DateTime>();
            }
        }

        public static Dictionary<string, string> GetSettings(string path) {
            var newDict = new Dictionary<string, string>() {
                {  "CurrentlyWatchedFolder", string.Empty},
                {  "VlcPath", @"C:\Program Files\VideoLAN\VLC\vlc.exe"},
            };

            try { 
                if (File.Exists(path)) {
                    using (StreamReader file = File.OpenText(path)) {
                        JsonSerializer serializer = new JsonSerializer();
                        return (Dictionary<string, string>)serializer.Deserialize(file, typeof(Dictionary<string, string>));
                    }
                } else {
                    return newDict;
                }
            } catch (Exception) {
                return newDict;
            }
        }

        public static DataTable LoadFileNames(string path) {
            String[] files = Directory.GetFiles(path);

            DataTable table = new DataTable();

            table.Columns.Add("Watched");

            table.Columns.Add("File Name");
            foreach (var file in files) {
                FileInfo info = new FileInfo(file);
                if (info.Extension == ".mkv" || info.Extension == ".vlc") {
                    DataRow dr = table.NewRow();
                    dr["File Name"] = info.Name;
                    table.Rows.Add(dr);
                }
            }
            return table;
        }

        public static void UpdateDictionary(Dictionary<string, DateTime> videoDict, string videoName, string path) {
            if (!string.IsNullOrWhiteSpace(videoName)) {
                if (videoDict.ContainsKey(videoName)) {
                    videoDict[videoName] = DateTime.Now;
                } else {
                    videoDict.Add(videoName, DateTime.Now);
                }
            }
            SaveDictAsJson(videoDict, path);
        }

        public static void RemoveFromDictionary(Dictionary<string, DateTime> videoDict, string videoName, string path) {
            if (videoDict.ContainsKey(videoName)) {
                videoDict.Remove(videoName);
                SaveDictAsJson(videoDict, path);
            }
        }

        public static void SaveDictAsJson(Dictionary<string, DateTime> videoDict, string path) {
            var json = JsonConvert.SerializeObject(videoDict);
            File.WriteAllText(path, json);
        }

        public static void SaveSettingDictAsJson(Dictionary<string, string> dict, string path) {
            var json = JsonConvert.SerializeObject(dict);
            File.WriteAllText(path, json);
        }

        public static void UpdateSettingsFolder(Dictionary<string, string> settings, 
                                                string newValue,
                                                string path) {
            settings["CurrentlyWatchedFolder"] = newValue;
            SaveSettingDictAsJson(settings, path);
        }

        public static void SaveSeries(DataTable series, string path) {
            var json = JsonConvert.SerializeObject(series);
            File.WriteAllText(path, json);
        }

        public static DataTable GetSeries(string path) {
            if (!File.Exists(path)) {
                return null;
            }
            using (StreamReader file = File.OpenText(path)) {
                var ser = new JsonSerializer();
                return (DataTable) ser.Deserialize(file, typeof(DataTable));
            }
        }
    }
}
