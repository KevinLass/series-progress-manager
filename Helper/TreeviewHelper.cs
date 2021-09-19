using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeriesProgressManager.Helper {
    public class TreeviewHelper {
        public static void ListUpperDirectory(TreeView treeView, string lowerPath) {
            string path = Directory.GetParent(lowerPath).FullName;

            if (Directory.Exists(path)) {
                treeView.Nodes.Clear();
                var rootDirectoryInfo = new DirectoryInfo(path);
                treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
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

        // not used currently
        // Credit: https://stackoverflow.com/questions/6239544/populate-treeview-with-file-system-directory-structure
        private static TreeNode CreateDirectoryNodeResursive(DirectoryInfo directoryInfo) {
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories()) {
                // for recursion
                directoryNode.Nodes.Add(CreateDirectoryNodeResursive(directory));
            }
            directoryNode.Expand();
            directoryNode.EnsureVisible();
            // for files
            foreach (var file in directoryInfo.GetFiles()) {
                directoryNode.Nodes.Add(new TreeNode(file.Name));
            }
            return directoryNode;
        }
    }
}
