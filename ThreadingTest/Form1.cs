using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace ThreadingTest
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            txtThread1.Text = "0";
            txtThread2.Text = "0";
            txtThread3.Text = "0";
            txtThread4.Text = "0";
        }

        private void btnStartThread1_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                // Start the asynchronous operation.
                backgroundWorker1.RunWorkerAsync();
            }

        }

        private void btnStopThread1_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation)
            {
                // Cancel the asynchronous operation.
                backgroundWorker1.CancelAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            int content;

            while (!worker.CancellationPending)
            {
                content = Convert.ToInt32(txtThread1.Text);
                content++;
                worker.ReportProgress(content);
                Thread.Sleep(500);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // not exactly using a percentage here, but still works
            txtThread1.Text = e.ProgressPercentage.ToString();
        }
    }
}
