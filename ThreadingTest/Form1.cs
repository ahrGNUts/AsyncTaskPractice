using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ThreadingTest
{
    public partial class frmMain : Form
    {
        private List<Button> _startBtns = new List<Button>();
        private List<Button> _stopBtns = new List<Button>();
        private List<TextBox> _textAreas = new List<TextBox>();
        private List<BackgroundWorker> _bgWorkers = new List<BackgroundWorker>();

        public frmMain()
        {
            InitializeComponent();

            // populate _startBtns
            _startBtns.Add(btnStartThread1);
            _startBtns.Add(btnStartThread2);
            _startBtns.Add(btnStartThread3);
            _startBtns.Add(btnStartThread4);

            // populate _stopBtns
            _stopBtns.Add(btnStopThread1);
            _stopBtns.Add(btnStopThread2);
            _stopBtns.Add(btnStopThread3);
            _stopBtns.Add(btnStopThread4);

            // populate _textAreas
            _textAreas.Add(txtThread1);
            _textAreas.Add(txtThread2);
            _textAreas.Add(txtThread3);
            _textAreas.Add(txtThread4);

            // init textarea text
            foreach (var textarea in _textAreas)
                textarea.Text = "0";

            // populate _bgWorkers
            _bgWorkers.Add(backgroundWorker1);
            _bgWorkers.Add(backgroundWorker2);
            _bgWorkers.Add(backgroundWorker3);
            _bgWorkers.Add(backgroundWorker4);
        }

        private void btnStartThread_Click(object sender, EventArgs e)
        {
            // get button that triggered event
            Button caller = (Button)sender;

            // get index of button
            int idx = _startBtns.FindIndex(btn => btn.Name.Equals(caller.Name));
            
            if (!_bgWorkers[idx].IsBusy)
            {
                _bgWorkers[idx].RunWorkerAsync(idx);
            }
        }

        private void btnStopThread_Click(object sender, EventArgs e)
        {
            // get button that triggered event
            Button caller = (Button)sender;

            // get index of button
            int idx = _stopBtns.FindIndex(btn => btn.Name.Equals(caller.Name));

            if (_bgWorkers[idx].WorkerSupportsCancellation)
            {
                // Cancel the asynchronous operation.
                _bgWorkers[idx].CancelAsync();
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            int idx = Convert.ToInt16(e.Argument);
            int content;

            while (!worker.CancellationPending)
            {
                content = Convert.ToInt32(_textAreas[idx].Text);
                content++;
                worker.ReportProgress(content, e.Argument);
                Thread.Sleep(500);
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            int idx = Convert.ToInt16(e.UserState);

            _textAreas[idx].Text = e.ProgressPercentage.ToString();
        }
    }
}
