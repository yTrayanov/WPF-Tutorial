using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ListControls
{
    /// <summary>
    /// Interaction logic for TreeViewLazyLoading.xaml
    /// </summary>
    public partial class TreeViewLazyLoading : Window
    {
        public TreeViewLazyLoading()
        {
            InitializeComponent();

            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo driveInfo in drives)
            {
                trvStructure.Items.Add(CreateTreeItem(driveInfo));
            }

        }

        private void trvStructure_Expanded(object sender, RoutedEventArgs e)
        {
            TreeViewItem item = e.Source as TreeViewItem;
            if ((item.Items.Count == 1) && (item.Items[0] is string))
            {
                item.Items.Clear();

                DirectoryInfo expandedDir = null;
                if (item.Tag is DriveInfo)
                    expandedDir = (item.Tag as DriveInfo).RootDirectory;
                if (item.Tag is DirectoryInfo)
                    expandedDir = (item.Tag as DirectoryInfo);

                foreach (DirectoryInfo subDir in expandedDir.GetDirectories())
                {
                    item.Items.Add(CreateTreeItem(subDir));
                }
            }
        }

        public TreeViewItem CreateTreeItem(object obj)
        {
            TreeViewItem item = new TreeViewItem();
            item.Header = obj.ToString();
            item.Tag = obj;
            item.Items.Add("Loading...");
            return item;
        }
    }
}
