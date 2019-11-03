using System;
using System.Collections.Generic;
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

namespace Slurry.Controls
{
    /// <summary>
    /// Interaction logic for Restore.xaml
    /// </summary>
    public partial class Restore : UserControl
    {
        public Restore()
        {
            InitializeComponent();
        }

        private void FindSteamDirectory_Click(object sender, RoutedEventArgs e)
        {
            Util.ShowDialog(SteamDirectory, "Select Restoration Location");
        }

        private void FindRestoreLocation_Click(object sender, RoutedEventArgs e)
        {
            Util.ShowDialog(RestoreLocation, "Select File", false);
        }

        private void RestoreSteamapps_Confirm(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show(
                "Steamapps could be very large and could make the restoration process take a while\nAre you sure you want to restore it?",
                "Slurry",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning,
                MessageBoxResult.No
            );

            if (result == MessageBoxResult.No) RestoreSteamapps.IsChecked = false;
        }

        private void PerformRestore(object sender, RoutedEventArgs e)
        {

        }
    }
}
