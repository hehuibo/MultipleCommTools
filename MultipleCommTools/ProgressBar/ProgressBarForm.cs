using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleCommTools
{
    public partial class ProgressBarForm : Form
    {
        public ProgressBar ProgressBar { get { return ToolprogressBar; } }

        public object Argument { get; set; }

        public RunWorkerCompletedEventArgs Result { get; private set; }

        public bool CancellationPending {
            get { return worker.CancellationPending; }
        }

        public String CancellingText { get; set; }

        public String DefaultStatusText { get; set; }

        /// <summary>
        /// 声明
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void DoWorkEventHandler(ProgressBarForm sender, DoWorkEventArgs e);

        public event DoWorkEventHandler DoWork;

        int lastPercent;
        String lastStatus;
        BackgroundWorker worker;

        public ProgressBarForm()
        {
            InitializeComponent();

            DefaultStatusText = "Please wait...";
            CancellingText = "Cancelling operation...";

            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += new System.ComponentModel.DoWorkEventHandler(worker_DoWork);
            worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="status"></param>
        public void SetProgress(String status)
        {
            if (status != lastStatus && !worker.CancellationPending) {
                lastStatus = status;
                worker.ReportProgress(ToolprogressBar.Minimum -1, status);
            }
        }

        public void SetProgress(int percent)
        {
            if (percent != lastPercent) {
                lastPercent = percent;
                worker.ReportProgress(percent);
            }
        }

        public void SetProgress(int percent, String status)
        {
            if ((percent != lastPercent) || (status != lastStatus && !worker.CancellationPending))
            {
                lastPercent = percent;
                lastStatus = status;
                worker.ReportProgress(percent, status);
            }
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (DoWork != null)
            {
                DoWork(this, e);
            }
        }

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if ((e.ProgressPercentage >= ToolprogressBar.Minimum) 
                && (e.ProgressPercentage <= ToolprogressBar.Maximum)) {
                ToolprogressBar.Value = e.ProgressPercentage;
            }

            if (e.UserState != null && !worker.CancellationPending) {
                labelProgressStatus.Text = e.UserState.ToString();
            }
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Result = e;
            if (e.Error != null){
                DialogResult = DialogResult.Abort;
            }
            else if (e.Cancelled){
                DialogResult = DialogResult.Cancel;
            }
            else {
                DialogResult = DialogResult.OK;
            }

            Close();
        }


        private void ToolProgressForm_Load(object sender, EventArgs e)
        {
            Result = null;
            btnCancelProgressBar.Enabled = true;
            ToolprogressBar.Value = ToolprogressBar.Minimum;
            labelProgressStatus.Text = DefaultStatusText;
            lastPercent = ToolprogressBar.Minimum;
            worker.RunWorkerAsync(Argument);
        }

        private void btnCancelProgressBar_Click(object sender, EventArgs e)
        {
            worker.CancelAsync();
            btnCancelProgressBar.Enabled = false;
            labelProgressStatus.Text = CancellingText;

        }

        private void ToolProgressForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            worker.CancelAsync();
        }
    }
}
