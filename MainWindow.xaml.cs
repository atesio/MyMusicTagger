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

namespace MyMusicTagger
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
            GridDiffs.Dispatcher.BeginInvoke((Action)(() => { GridDiffs.ItemsSource = null; }));
            GridErrors.Dispatcher.BeginInvoke((Action)(() => { GridErrors.ItemsSource = null; }));
            var folderPath = (string)FolderPath.Dispatcher.Invoke(new Func<string>(() => FolderPath.Text));
            var filePaths = Scanner.GetFiles(folderPath);
            TagDiffs diffs;
            FileErrors errors;
            Scanner.GetDiffs(filePaths, worker, out diffs, out errors);
            if (worker.CancellationPending) return;
            GridDiffs.Dispatcher.BeginInvoke((Action)(() => { GridDiffs.ItemsSource = diffs; }));
            GridErrors.Dispatcher.BeginInvoke((Action)(() => { GridErrors.ItemsSource = errors; }));
        }

        private void Write_MyOnClick(object sender, System.ComponentModel.BackgroundWorker worker)
        {
            var diffs = (TagDiffs)FolderPath.Dispatcher.Invoke(new Func<TagDiffs>(() => (TagDiffs)GridDiffs.ItemsSource));
            var orderedDiffs = diffs.GetOrderedDiffs();
            FileErrors errors;
            Scanner.WriteDiffs(orderedDiffs, worker, out errors);
            GridErrors.Dispatcher.BeginInvoke((Action)(() => { GridErrors.ItemsSource = errors; }));
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
