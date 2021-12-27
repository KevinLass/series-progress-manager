using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeriesProgressManager.Helper {
    public class TreeviewHelper {
        public static void ListUpperDirectory(TreeView treeView, string lowerPath, bool recursive) {
            string path = Directory.GetParent(lowerPath).FullName;

            if (Directory.Exists(path)) {
                treeView.Nodes.Clear();
                var rootDirectoryInfo = new DirectoryInfo(path);
                if (recursive) {
                    treeView.Nodes.Add(CreateDirectoryNodeResursive(rootDirectoryInfo));
                } else {
                    treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
                }
            }
        }

        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo) {
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories()) {
                directoryNode.Nodes.Add(new TreeNode(directory.Name));
            }

            directoryNode.Expand();
            directoryNode.EnsureVisible();
            return directoryNode;
        }

        private static TreeNode CreateDirectoryNodeResursive(DirectoryInfo directoryInfo, int step = 0, bool showFiles = false) {
            // recursion may not run to deep because it would load very long
            if (step > 3) {
                // non recursive version
                return CreateDirectoryNode(directoryInfo);
            }

            var directoryNode = new TreeNode(directoryInfo.Name);
            try {
                foreach (DirectoryInfo directory in directoryInfo.GetDirectories()) {
                    if (directory.GetFiles("*.mkv").Any()) {
                        directoryNode.Nodes.Add(CreateDirectoryNodeResursive(directory, step + 1));
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("Directory could not be loaded: {0}", ex);
            }

            directoryNode.Expand();
            directoryNode.EnsureVisible();

            if (showFiles) {
                foreach (var file in directoryInfo.GetFiles()) {
                    directoryNode.Nodes.Add(new TreeNode(file.Name));
                }
            }

            return directoryNode;
        }

        public static string GetDirectoryPath(TreeView treeView, string baseDir) {
            string upper = Directory.GetParent(baseDir).FullName;

            TreeNode curNode = treeView.SelectedNode;
            string fullPath = curNode.Text;

            if (curNode.Parent == null) {
                return upper;

            } else {
                while (curNode.Parent != treeView.Nodes[0]) {
                    fullPath = Path.Combine(curNode.Parent.Text, fullPath);
                    curNode = curNode.Parent;
                }

                return Path.Combine(upper, fullPath);
            }
        }

        public static void SearchRecursive(TreeView treeView, TreeNode startNode, string text) {
            while (startNode != null) {
                bool marked = startNode.Text.ToLower().Contains(text.ToLower()) && !string.IsNullOrWhiteSpace(text);
                startNode.BackColor = marked ? Color.Yellow : Color.White;

                if (startNode.Nodes.Count > 0) {
                    SearchRecursive(treeView, startNode.Nodes[0], text);
                }
                startNode = startNode.NextNode;
            }
        }
    }
}
