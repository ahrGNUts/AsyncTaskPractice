namespace ThreadingTest
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtThread1 = new System.Windows.Forms.TextBox();
            this.txtThread2 = new System.Windows.Forms.TextBox();
            this.txtThread3 = new System.Windows.Forms.TextBox();
            this.txtThread4 = new System.Windows.Forms.TextBox();
            this.btnStartThread1 = new System.Windows.Forms.Button();
            this.btnStartThread2 = new System.Windows.Forms.Button();
            this.btnStartThread3 = new System.Windows.Forms.Button();
            this.btnStartThread4 = new System.Windows.Forms.Button();
            this.btnStopThread1 = new System.Windows.Forms.Button();
            this.btnStopThread2 = new System.Windows.Forms.Button();
            this.btnStopThread3 = new System.Windows.Forms.Button();
            this.btnStopThread4 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // txtThread1
            // 
            this.txtThread1.Location = new System.Drawing.Point(14, 12);
            this.txtThread1.Multiline = true;
            this.txtThread1.Name = "txtThread1";
            this.txtThread1.Size = new System.Drawing.Size(159, 313);
            this.txtThread1.TabIndex = 0;
            // 
            // txtThread2
            // 
            this.txtThread2.Location = new System.Drawing.Point(179, 12);
            this.txtThread2.Multiline = true;
            this.txtThread2.Name = "txtThread2";
            this.txtThread2.Size = new System.Drawing.Size(159, 313);
            this.txtThread2.TabIndex = 1;
            // 
            // txtThread3
            // 
            this.txtThread3.Location = new System.Drawing.Point(344, 12);
            this.txtThread3.Multiline = true;
            this.txtThread3.Name = "txtThread3";
            this.txtThread3.Size = new System.Drawing.Size(159, 313);
            this.txtThread3.TabIndex = 2;
            // 
            // txtThread4
            // 
            this.txtThread4.Location = new System.Drawing.Point(509, 12);
            this.txtThread4.Multiline = true;
            this.txtThread4.Name = "txtThread4";
            this.txtThread4.Size = new System.Drawing.Size(159, 313);
            this.txtThread4.TabIndex = 3;
            // 
            // btnStartThread1
            // 
            this.btnStartThread1.Location = new System.Drawing.Point(14, 331);
            this.btnStartThread1.Name = "btnStartThread1";
            this.btnStartThread1.Size = new System.Drawing.Size(159, 23);
            this.btnStartThread1.TabIndex = 4;
            this.btnStartThread1.Text = "Start Thread 1";
            this.btnStartThread1.UseVisualStyleBackColor = true;
            this.btnStartThread1.Click += new System.EventHandler(this.btnStartThread1_Click);
            // 
            // btnStartThread2
            // 
            this.btnStartThread2.Location = new System.Drawing.Point(179, 331);
            this.btnStartThread2.Name = "btnStartThread2";
            this.btnStartThread2.Size = new System.Drawing.Size(159, 23);
            this.btnStartThread2.TabIndex = 5;
            this.btnStartThread2.Text = "Start Thread 2";
            this.btnStartThread2.UseVisualStyleBackColor = true;
            this.btnStartThread2.Click += new System.EventHandler(this.btnStartThread2_Click);
            // 
            // btnStartThread3
            // 
            this.btnStartThread3.Location = new System.Drawing.Point(344, 331);
            this.btnStartThread3.Name = "btnStartThread3";
            this.btnStartThread3.Size = new System.Drawing.Size(159, 23);
            this.btnStartThread3.TabIndex = 6;
            this.btnStartThread3.Text = "Start Thread 3";
            this.btnStartThread3.UseVisualStyleBackColor = true;
            // 
            // btnStartThread4
            // 
            this.btnStartThread4.Location = new System.Drawing.Point(509, 331);
            this.btnStartThread4.Name = "btnStartThread4";
            this.btnStartThread4.Size = new System.Drawing.Size(159, 23);
            this.btnStartThread4.TabIndex = 7;
            this.btnStartThread4.Text = "Start Thread 4";
            this.btnStartThread4.UseVisualStyleBackColor = true;
            // 
            // btnStopThread1
            // 
            this.btnStopThread1.Location = new System.Drawing.Point(14, 360);
            this.btnStopThread1.Name = "btnStopThread1";
            this.btnStopThread1.Size = new System.Drawing.Size(159, 54);
            this.btnStopThread1.TabIndex = 8;
            this.btnStopThread1.Text = "Stop Thread 1";
            this.btnStopThread1.UseVisualStyleBackColor = true;
            this.btnStopThread1.Click += new System.EventHandler(this.btnStopThread1_Click);
            // 
            // btnStopThread2
            // 
            this.btnStopThread2.Location = new System.Drawing.Point(179, 360);
            this.btnStopThread2.Name = "btnStopThread2";
            this.btnStopThread2.Size = new System.Drawing.Size(159, 54);
            this.btnStopThread2.TabIndex = 9;
            this.btnStopThread2.Text = "Stop Thread 2";
            this.btnStopThread2.UseVisualStyleBackColor = true;
            this.btnStopThread2.Click += new System.EventHandler(this.btnStopThread2_Click);
            // 
            // btnStopThread3
            // 
            this.btnStopThread3.Location = new System.Drawing.Point(344, 360);
            this.btnStopThread3.Name = "btnStopThread3";
            this.btnStopThread3.Size = new System.Drawing.Size(159, 54);
            this.btnStopThread3.TabIndex = 10;
            this.btnStopThread3.Text = "Stop Thread 3";
            this.btnStopThread3.UseVisualStyleBackColor = true;
            // 
            // btnStopThread4
            // 
            this.btnStopThread4.Location = new System.Drawing.Point(509, 360);
            this.btnStopThread4.Name = "btnStopThread4";
            this.btnStopThread4.Size = new System.Drawing.Size(159, 54);
            this.btnStopThread4.TabIndex = 11;
            this.btnStopThread4.Text = "Stop Thread 4";
            this.btnStopThread4.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.btnStopThread4);
            this.Controls.Add(this.btnStopThread3);
            this.Controls.Add(this.btnStopThread2);
            this.Controls.Add(this.btnStopThread1);
            this.Controls.Add(this.btnStartThread4);
            this.Controls.Add(this.btnStartThread3);
            this.Controls.Add(this.btnStartThread2);
            this.Controls.Add(this.btnStartThread1);
            this.Controls.Add(this.txtThread4);
            this.Controls.Add(this.txtThread3);
            this.Controls.Add(this.txtThread2);
            this.Controls.Add(this.txtThread1);
            this.Name = "frmMain";
            this.Text = "Async Task Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtThread1;
        private System.Windows.Forms.TextBox txtThread2;
        private System.Windows.Forms.TextBox txtThread3;
        private System.Windows.Forms.TextBox txtThread4;
        private System.Windows.Forms.Button btnStartThread1;
        private System.Windows.Forms.Button btnStartThread2;
        private System.Windows.Forms.Button btnStartThread3;
        private System.Windows.Forms.Button btnStartThread4;
        private System.Windows.Forms.Button btnStopThread1;
        private System.Windows.Forms.Button btnStopThread2;
        private System.Windows.Forms.Button btnStopThread3;
        private System.Windows.Forms.Button btnStopThread4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

