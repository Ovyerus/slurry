using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
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
using Slurry;


namespace Slurry.Controls
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class Backup : UserControl
    {
        public Backup()
        {
            InitializeComponent();
        }

        private void FindSteamDirectory_Click(object sender, RoutedEventArgs e)
        {
            Util.ShowDialog(SteamDirectory, "Select Steam Directory");
        }

        private void FindBackupLocation_Click(object sender, RoutedEventArgs e)
        {
            Util.ShowDialog(BackupLocation, "Choose Backup Location");
        }

        private void BackupSteamapps_Confirm(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show(
                "Steamapps could be very large and may make the backup operation take a while.\nAre you sure you want to back it up?",
                "Slurry",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning,
                MessageBoxResult.No
            );

            if (result == MessageBoxResult.No) BackupSteamapps.IsChecked = false;
        }

        private void PerformBackup(object sender, RoutedEventArgs e)
        {

        }
    }
}
