using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        private BackgroundWorker myWorker;
        private BackgroundWorker myWorker2;
        private TaskScheduler uiScheduler;
        private List<CancellationTokenSource> cancelObj;
        private readonly SynchronizationContext syncContext;
        private int count;

        public Form1()
        {
            InitializeComponent();
            InitializeComponent2();
            myWorker = new BackgroundWorker();


            cancelObj = new List<CancellationTokenSource>();
            cancelObj = Enumerable.Range(0, 5).Select(x => new CancellationTokenSource()).ToList();
            Label[] items = (new Label[] { tplUpdateLabel1, tplUpdateWhileRunUpdateLabel1, tplUpdateFrequentlyUpdateLabel1, tplUpdateNewTaskUpdateLabel1, asynchronousFunctionsUpdateLabel });
            cancelObj[0].Token.Register(() => CancelNotification(items[0]));
            cancelObj[1].Token.Register(() => CancelNotification(items[1]));
            cancelObj[2].Token.Register(() => CancelNotification(items[2]));
            cancelObj[3].Token.Register(() => CancelNotification(items[3]));
            cancelObj[4].Token.Register(() => CancelNotification(items[4]));

            syncContext = SynchronizationContext.Current;


            //InitializeMyTimer();
        }



        private void InitializeComponent2()
        {
            uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();
            tplProgressBar.Maximum = 100;
            tplProgressBar.Step = 5;
            tplProgressBar.Value = 0;
            tplProgressBar.Style = ProgressBarStyle.Continuous;
            //tplProgressBar.SetState(1);


            tplUpdateWhileRunProgressBar.Maximum = 100;
            tplUpdateWhileRunProgressBar.Step = 20;
            tplUpdateWhileRunProgressBar.Value = 0;
            tplUpdateWhileRunProgressBar.Style = ProgressBarStyle.Blocks;

            tplUpdateFrequentlyProgressBar.Maximum = 100;
            tplUpdateFrequentlyProgressBar.Step = 1;
            tplUpdateFrequentlyProgressBar.Value = 0;
            tplUpdateFrequentlyProgressBar.Style = ProgressBarStyle.Continuous;

            tplUpdateNewTaskProgressBar.Maximum = 100;
            tplUpdateNewTaskProgressBar.Step = 1;
            tplUpdateNewTaskProgressBar.Value = 0;
            tplUpdateNewTaskProgressBar.Style = ProgressBarStyle.Continuous;
        }



        protected void myWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            int j = 0;
            while (!worker.CancellationPending) // true)
            {
                UpdateProgress(j++);
                Thread.Sleep(10);

                if (j == 100)
                {
                    j = 0;
                    ResetProgressbar(1);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myWorker.DoWork += new DoWorkEventHandler(myWorker_DoWork);
            //myWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(myWorker_RunWorkerCompleted);
            //myWorker.ProgressChanged += new ProgressChangedEventHandler(myWorker_ProgressChanged);
            //myWorker.WorkerReportsProgress = true;
            myWorker.WorkerSupportsCancellation = true;
            myWorker.RunWorkerAsync();

            myWorker2 = new BackgroundWorker();
            myWorker2.DoWork += new DoWorkEventHandler(myWorker_DoWork2);
            //myWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(myWorker_RunWorkerCompleted);
            //myWorker.ProgressChanged += new ProgressChangedEventHandler(myWorker_ProgressChanged);
            //myWorker.WorkerReportsProgress = true;
            myWorker2.WorkerSupportsCancellation = true;
            myWorker2.RunWorkerAsync();

        }

        protected void myWorker_DoWork2(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 50000; i++)
            {
                string text = string.Format("{0}", i.ToString());
                RefreshLabel(text);
                Thread.Sleep(50);
            }
        }

        private delegate void RefreshLabelDelegate(string text);

        private void RefreshLabel(string text)
        {
            if (this.InvokeRequired)
            {
                RefreshLabelDelegate d = new RefreshLabelDelegate(RefreshLabel);
                this.Invoke(d, new object[] { text });
                return;
            }

            label2.Text = text;
        }

        private delegate void UpdateProgressDelegate(int percentage);

        private void UpdateProgress(int percentage)
        {
            if (this.InvokeRequired)
            {
                UpdateProgressDelegate d = new UpdateProgressDelegate(UpdateProgress);
                this.Invoke(d, new object[] { percentage });
                return;
            }
            progressBar1.PerformStep();
            //progressBar1.Value = percentage;
        }

        private delegate void ResetProgressBarDelegate(int percentage);

        private void ResetProgressbar(int percentage)
        {
            if (this.InvokeRequired)
            {
                ResetProgressBarDelegate d = new ResetProgressBarDelegate(ResetProgressbar);
                this.Invoke(d, new object[] { percentage });
                return;
            }

            progressBar1.Value = 0;
            progressBar1.PerformStep();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myWorker.CancelAsync();
        }

        //private System.Timers.Timer time = new System.Timers.Timer();

        // Call this method from the constructor of the form. 
        private void InitializeMyTimer()
        {
            // Set the interval for the timer.
            timer1.Interval = 250;
            // Connect the Tick event of the timer to its event handler.
            timer1.Tick += new EventHandler(IncreaseProgressBar);
            // Start the timer.
            timer1.Start();
        }

        private void IncreaseProgressBar(object sender, EventArgs e)
        {
            // Increment the value of the ProgressBar a value of one each time.
            progressBar1.Increment(1);
            // Display the textual value of the ProgressBar in the StatusBar control's first panel.
            statusStrip1.Text = progressBar1.Value.ToString() + "% Completed";
            // Determine if we have completed by comparing the value of the Value property to the Maximum value. 
            if (progressBar1.Value == progressBar1.Maximum)
                // Stop the timer.
                timer1.Stop();
        }





        private void tplStopButton_Click(object sender, EventArgs e)
        {

        }

        private void tplButton_Click(object sender, EventArgs e)
        {
            tplButton.Enabled = false;

            BusinessLayer.ProcessData(count, cancelObj[0].Token, (message) => UpdateTPLProgressBar(message));
            ++count;
        }

        private void tplWhileRunStartButton_Click(object sender, EventArgs e)
        {
            tplWhileRunStartButton.Enabled = false;
            tplUpdateWhileRunProgressBar.Value = 0;
            BusinessLayer.PerformInternalValidationsOnData(new object(), cancelObj[1].Token, (message, enableBtn) => UpdateTPLwhileRunProgressBar(message, enableBtn));
        }

        private void tplUpdateFrequentlyStartButton_Click(object sender, EventArgs e)
        {
            tplUpdateFrequentlyStartButton.Enabled = false;
            tplUpdateFrequentlyProgressBar.Value = 0;
            BusinessLayer.PrepareTransformationsForProcessing(new object(), cancelObj[2].Token, (message, enablebtn) => UpdateTPLFrequentlyProgressBar(message, enablebtn));
        }

        private void UpdateTPLProgressBar(string statusMessage)
        {
            Task.Factory.StartNew(() =>
            {
                tplProgressBar.PerformStep();
                tplUpdateLabel1.Text = statusMessage;
                tplButton.Enabled = true;
            }, cancelObj[0].Token, TaskCreationOptions.None, uiScheduler);
        }

        private void UpdateTPLwhileRunProgressBar(string statusMessage, bool enableStartBtn)
        {
            Task.Factory.StartNew(() =>
            {
                tplUpdateWhileRunProgressBar.PerformStep();
                tplUpdateWhileRunUpdateLabel1.Text = statusMessage;
                if (enableStartBtn)
                {
                    tplWhileRunStartButton.Enabled = true;
                }
            }, cancelObj[1].Token, TaskCreationOptions.None, uiScheduler);
        }

        private void UpdateTPLFrequentlyProgressBar(string statusMessage, bool enableStartBtn)
        {
            Task.Factory.StartNew(() =>
            {
                tplUpdateFrequentlyProgressBar.PerformStep();
                tplUpdateFrequentlyUpdateLabel1.Text = statusMessage;
                if (enableStartBtn)
                {
                    tplUpdateFrequentlyStartButton.Enabled = true;
                }
            }, cancelObj[2].Token, TaskCreationOptions.None, uiScheduler);
        }


        /// <summary>
        /// Method will update UI very frequently with new task while the original task is running
        /// </summary>
        /// <param name="data"></param>
        /// <param name="updateUICallBack"></param>
        private void tplUpdateNewTaskStartButton_Click(object sender, EventArgs e)
        {
            tplUpdateNewTaskStartButton.Enabled = false;
            tplUpdateNewTaskProgressBar.Value = 0;
            BusinessLayer.PrepareLaunchSequenceForData(new object(), cancelObj[3].Token, (message, enableStartBtn) => UpdateTPLNewTaskProgressBar(message, enableStartBtn));
        }
        private void UpdateTPLNewTaskProgressBar(string statusMessage, bool enableStartBtn)
        {
            Task.Factory.StartNew(() =>
            {
                tplUpdateNewTaskProgressBar.PerformStep();
                tplUpdateNewTaskUpdateLabel1.Text = statusMessage;
                if (enableStartBtn)
                {
                    tplUpdateNewTaskStartButton.Enabled = true;
                }
            }, cancelObj[3].Token, TaskCreationOptions.None, uiScheduler);
        }

        private void tplUpdateNewTaskStopButton_Click(object sender, EventArgs e)
        {
            cancelObj[3].Cancel();
        }

        private void tplWhileRunStopButton_Click(object sender, EventArgs e)
        {
            cancelObj[1].Cancel();
        }

        private void tplUpdateFrequentlyStopButton_Click(object sender, EventArgs e)
        {
            cancelObj[2].Cancel();
        }


        private delegate void CancelNotificationDelegate(Label label);
        private void CancelNotification(Label label)
        {

            if (this.InvokeRequired)
            {
                CancelNotificationDelegate d = new CancelNotificationDelegate(CancelNotification);
                this.Invoke(d);
                return;
            }
            label.Text = "the user operation is cancelled";
            tplUpdateNewTaskStartButton.Enabled = true;
        }

        async void asynchronousFunctionsStartButton_Click(object sender, EventArgs e)
        {
            try
            {
                asynchronousFunctionsStartButton.Enabled = false;
                asynchronousFunctionsProgressBar.Value = 0;
                asynchronousFunctionsUpdateLabel.Text = "Fetching ...";

                IProgress<int> progress = new Progress<int>(value => { asynchronousFunctionsProgressBar.Value = value; });
                await asynchronousVeryFrequently(progress, cancelObj[4].Token);

                asynchronousFunctionsUpdateLabel.Text = "Done";
                asynchronousFunctionsStartButton.Enabled = true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private Task asynchronousVeryFrequently(IProgress<int> progress, CancellationToken token)
        {
            return Task.Run(() =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    if (token.IsCancellationRequested)
                    {
                        return;
                    }
                    Thread.Sleep(50);
                    progress.Report(i);
                    UpdateAsyncLabel(i + "%");
                }
            });
        }

        private void UpdateAsyncLabel(String text)
        {
            syncContext.Post(new SendOrPostCallback(o =>
            {
                asynchronousFunctionsUpdateLabel.Text = text;
            }), text);
        }
        private void asynchronousFunctionsStopButton_Click(object sender, EventArgs e)
        {
            cancelObj[4].Cancel();
        }

    }
}
