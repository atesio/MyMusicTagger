using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyMP3Tagger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ProgressHandler(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            ProgressText.Text = (string)e.UserState;
            ProgressBar.Value = e.ProgressPercentage;
        }

        private void Scan_MyOnClick(object sender, System.ComponentModel.BackgroundWorker worker)
        {
            var folderPath = (string)FolderPath.Dispatcher.Invoke(new Func<string>(() => FolderPath.Text));
            var filePaths = Scanner.GetFiles(folderPath);
            var diffs = Scanner.GetDiffs(filePaths, worker);
            GridDiffs.Dispatcher.BeginInvoke((Action)(() => { GridDiffs.ItemsSource = diffs; }));
        }

        private void Write_MyOnClick(object sender, System.ComponentModel.BackgroundWorker worker)
        {
            var diffs = (TagDiffs)FolderPath.Dispatcher.Invoke(new Func<TagDiffs>(() => (TagDiffs)GridDiffs.ItemsSource));
            var orderedDiffs = diffs.GetOrderedDiffs();
            Scanner.WriteDiffs(orderedDiffs, worker);
        }

        private void ButtonBrowse_Click(object sender, RoutedEventArgs e)
        {
            IntPtr mainWindowPtr = new System.Windows.Interop.WindowInteropHelper(this).Handle; // 'this' means WPF Window
            var folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog(new OldWindow(mainWindowPtr)) == System.Windows.Forms.DialogResult.OK)
                FolderPath.Text = folderBrowserDialog.SelectedPath;
        }
    }
    // http://stackoverflow.com/questions/315164/how-to-use-a-folderbrowserdialog-from-a-wpf-application
    public class OldWindow : System.Windows.Forms.IWin32Window
    {
        IntPtr _handle;

        public OldWindow(IntPtr handle)
        {
            _handle = handle;
        }

        #region IWin32Window Members

        IntPtr System.Windows.Forms.IWin32Window.Handle
        {
            get { return _handle; }
        }

        #endregion
    }
}
