using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TreeViewDrivers();
        }

        void TreeViewDrivers()
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                TreeViewItem item = new TreeViewItem();
                item.Tag = drive;
                item.Header = drive.ToString();
                item.Items.Add("*");
                //trw_Products.Items.Add(item);
                treeView1.Items.Add(item);

                item.Expanded += new RoutedEventHandler(item_DirExpanded);
            }
        }

        void item_DirExpanded(object sender, RoutedEventArgs e)
        {
            TreeViewItem item = (TreeViewItem)e.OriginalSource;
            item.Items.Clear();
            DirectoryInfo dir;
            if (item.Tag is DriveInfo)
            {
                DriveInfo drive = (DriveInfo)item.Tag;
                dir = drive.RootDirectory;
            }
            else dir = (DirectoryInfo)item.Tag;
            try
            {
                foreach (DirectoryInfo subDir in dir.GetDirectories())
                {
                    TreeViewItem newItem = new TreeViewItem();
                    newItem.Tag = subDir;
                    newItem.Header = subDir.ToString();
                    newItem.Items.Add("*");
                    item.Items.Add(newItem);

                    newItem.Expanded += new RoutedEventHandler(Item_FileExpanded);
                }
            }
            catch
            { }
        }

        void Item_FileExpanded(object sender, RoutedEventArgs e)
        {
            TreeViewItem item = (TreeViewItem)e.OriginalSource;
            item.Items.Clear();
            DirectoryInfo driv;
            if (item.Tag is DriveInfo)
            {
                DriveInfo dr = (DriveInfo)item.Tag;
                driv = dr.RootDirectory;
            }
            else driv = (DirectoryInfo)item.Tag;

            try
            {
                listBox1.Items.Clear();
                foreach (FileInfo fi in driv.GetFiles())
                {
                    TreeViewItem newItem1 = new TreeViewItem();
                    newItem1.Tag = fi;
                    newItem1.Header = fi.ToString();
                    newItem1.Items.Add("*");
                    item.Items.Add(newItem1);


                    listBox1.Items.Add(fi);
                }
            }
            catch { }
        }

        private void Open_selectItem(object sender, RoutedEventArgs e)
        {
            FileInfo filinf = listBox1.SelectedItem as FileInfo;
            try
            {
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo.FileName = filinf.FullName;
                p.StartInfo.UseShellExecute = true;
                p.Start();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }

    


}
