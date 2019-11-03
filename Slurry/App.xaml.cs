using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.IO;

namespace Slurry
{
    public static class Util
    {
        public static void ShowDialog(TextBox textBox, string title, bool isFolder = true)
        {
            using (var diag = new CommonOpenFileDialog
            {
                AllowNonFileSystemItems = true,
                IsFolderPicker = isFolder,
                Title = title,
                InitialDirectory = !string.IsNullOrEmpty(textBox.Text) ? Directory.GetParent(textBox.Text).FullName : "C:",
                DefaultExtension = "zip" // how do i only show zips
            })
            {

                if (diag.ShowDialog() == CommonFileDialogResult.Ok)
                    textBox.Text = diag.FileName;
            }
        }
    }

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
    }
}
