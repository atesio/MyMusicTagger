using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMusicTagger
{
    public delegate void MyButtonEventHandler(object sender, System.ComponentModel.BackgroundWorker worker);
    public delegate void MyProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e);

    public class MyButton : System.Windows.Controls.Button
    {
        public event MyButtonEventHandler MyOnClick;
        public event MyProgressChanged MyOnProgress;

        private System.ComponentModel.BackgroundWorker _worker;
        private object _previousContent;

        public MyButton()
            : base()
        {
            this.Click += MyButton_Click;
        }

        void MyButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (_worker != null)
            {
                _worker.CancelAsync();
                _worker = null;
                this.Content = _previousContent;
            }
            else if (MyOnClick != null)
            {
                _previousContent = this.Content;
                _worker = new System.ComponentModel.BackgroundWorker();
                _worker.WorkerSupportsCancellation = true;
                _worker.WorkerReportsProgress = (MyOnProgress != null);
                _worker.ProgressChanged += worker_ProgressChanged;
                _worker.RunWorkerCompleted += worker_RunWorkerCompleted;
                _worker.DoWork += delegate(object s, System.ComponentModel.DoWorkEventArgs args)
                {
                    try
                    {
                        MyOnClick(this, _worker);
                    }
                    catch (Exception ex)
                    {
                        System.Windows.MessageBox.Show(ex.ToString(), ex.Message);
                    }
                };
                this.Content = "Cancel";
                _worker.RunWorkerAsync();
            }
        }

        void worker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            this.Content = _previousContent;
            _worker = null;
        }

        void worker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            if (MyOnProgress != null)
                MyOnProgress(this, e);
        }
    }
}

