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

        private const short CONTROL_MAX = 4;

        public frmMain()
        {
            InitializeComponent();
            // collecting control refs into lists
            PopulateButtonList("btnStartThread");
            PopulateButtonList("btnStopThread");
            InitTextList();
            PopulateWorkerList();
        }
        
        private void PopulateButtonList(string basename)
        {
            // populate button list based on basename of control
            for (int i = 0; i < CONTROL_MAX; i++)
            {
                Control btn = Controls.Find(basename + (i + 1), false)[0];

                if (basename.Contains("StartThread"))
                    _startBtns.Add((Button)btn);
                else
                    _stopBtns.Add((Button)btn);
            }
        }

        private void InitTextList()
        {
            // populate textbox object refs, also init text to 0
            for (int i = 0; i < CONTROL_MAX; i++)
            {
                Control txt = Controls.Find("txtThread" + (i + 1), false)[0];
                txt.Text = "0";
                _textAreas.Add((TextBox)txt);
            }
        }

        private void PopulateWorkerList()
        {
            // can't seem to do this one with a loop due to lack of public object references
            _bgWorkers.Add(backgroundWorker1);
            _bgWorkers.Add(backgroundWorker2);
            _bgWorkers.Add(backgroundWorker3);
            _bgWorkers.Add(backgroundWorker4);
        }

        private void btnStartThread_Click(object sender, EventArgs e)
        {
            // get master index for controls
            int idx = GetObjectIndex(sender as Button);
            
            if (!_bgWorkers[idx].IsBusy)
            {
                _bgWorkers[idx].RunWorkerAsync(idx);
            }
        }

        private void btnStopThread_Click(object sender, EventArgs e)
        {
            // get master index for controls
            int idx = GetObjectIndex(sender as Button);

            if (_bgWorkers[idx].WorkerSupportsCancellation)
            {
                // Cancel the asynchronous operation.
                _bgWorkers[idx].CancelAsync();
            }
        }

        private int GetObjectIndex(Button caller)
        {
            if (caller.Name.Contains("StopThread"))
                return _stopBtns.FindIndex(btn => btn.Name.Equals(caller.Name));

            return _startBtns.FindIndex(btn => btn.Name.Equals(caller.Name));
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
