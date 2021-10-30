using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Linq;

namespace BasicWinform
{
    public partial class TreeViewApp : Form
    {
        public TreeViewApp()
        {
            InitializeComponent();
            listView.View = View.LargeIcon;
        }

        void addNode(TreeNode parentNode, String parentDir, int level)
        {
            try
            {
                if (level < 5)
                {
                    var directoryInfo = new DirectoryInfo(parentDir);
                    var directories = directoryInfo.GetDirectories();
                    if (directories.Length > 0)
                    {
                        foreach (var directory in directories)
                        {
                            TreeNode node = new TreeNode(directory.Name);
                            node.Tag = directory.FullName;
                            parentNode.Nodes.Add(node);

                            addNode(node, directory.FullName, level + 1);
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox.Visible = true;
            BackgroundWorker worker = new BackgroundWorker();
            List<TreeNode> list = new List<TreeNode>();

            worker.DoWork += (t, w) =>
            {
                var drives = Environment.GetLogicalDrives();
                foreach (var drive in drives)
                {
                    TreeNode nodeDrive = new TreeNode(drive);
                    nodeDrive.Tag = drive.ToString();
                    list.Add(nodeDrive);
                    addNode(nodeDrive, drive, 2);
                }
            };
            worker.RunWorkerCompleted += (t, w) =>
            {
                treeView.Nodes.AddRange(list.ToArray());
                pictureBox.Visible = false;
            };
            worker.RunWorkerAsync();
        }

        public void loadImage(string url)
        {
            listView.Items.Clear();
            imageList.Images.Clear();

            List<string> ext = new List<string> { ".jpg", ".jpeg", ".png", ".gif", ".tif" };
            FileInfo[] files = new DirectoryInfo(url).EnumerateFiles("*.*", SearchOption.AllDirectories)
                .Select(x => new FileInfo(x.FullName)).ToArray();

            //string[] paths = Directory.GetFiles(dir);

            try
            {
                int i = 0;
                foreach(FileInfo file in files)
                {
                    imageList.Images.Add(Image.FromFile(file.FullName));
                    listView.Items.Add(file.Name, i++);
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            loadImage(e.Node.Tag.ToString());
        }
    }
}
