using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TimerMultiTreadBackGroundWorker
{
    /// <summary>
    /// Interaction logic for BackGroundWorkerExample.xaml
    /// </summary>
    public partial class BackGroundWorkerExample : Window
    {
        private BackgroundWorker worker = null;

        public BackGroundWorkerExample()
        {
            InitializeComponent();

            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += Worker_DoWork;
            worker.ProgressChanged += Worker_ProgressChanged;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        }


        private void btnDoSyncCalculation_Click(object sender, RoutedEventArgs e)
        {
            int max = 1000;
            pbCalsulationProgress.Value = 0;
            lbResults.Items.Clear();

            int result = 0;
            for (int i = 0; i < max; i++)
            {
                if (i % 42 == 0)
                {
                    lbResults.Items.Add(i);
                    result++;
                }
                Thread.Sleep(1);
                pbCalsulationProgress.Value = Convert.ToInt32(((double)i / max) * 100);
            }
            MessageBox.Show("Numbers between 0 and 1000 devisible by 42: " + result);
        }

        private void btnDoAsyncCalculation_Click(object sender, RoutedEventArgs e)
        {
            pbCalsulationProgress.Value = 0;
            lbResults.Items.Clear();

            worker.RunWorkerAsync(1000);
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            int max = (int)e.Argument;
            int result = 0;
            for (int i = 0; i < max; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                int progressPercentage = Convert.ToInt32(((double)i / max) * 100);
                if (i % 42 == 0)
                {
                    result++;
                    (sender as BackgroundWorker).ReportProgress(progressPercentage, i);
                }
                else
                {
                    (sender as BackgroundWorker).ReportProgress(progressPercentage);
                }

                Thread.Sleep(1);
            }
            e.Result = result;
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbCalsulationProgress.Value = e.ProgressPercentage;
            if (e.UserState != null)
                lbResults.Items.Add(e.UserState);
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Process has stopped");
            }
            else
                MessageBox.Show("Numbers between 0 and 10000 divisible by 42: " + e.Result);
        }

        private void btnCancelAsync_Click(object sender, RoutedEventArgs e)
        {
            worker.CancelAsync();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            worker.RunWorkerAsync(1000);
        }
    }
}
