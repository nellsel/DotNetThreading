namespace ProgressBar
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tplUpdateLabel2 = new System.Windows.Forms.Label();
            this.tplStopButton = new System.Windows.Forms.Button();
            this.tplUpdateLabel1 = new System.Windows.Forms.Label();
            this.tplButton = new System.Windows.Forms.Button();
            this.tplProgressBar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorkerLabel = new System.Windows.Forms.Label();
            this.TPLLabel = new System.Windows.Forms.Label();
            this.tplUpdateFrequentlyLabel = new System.Windows.Forms.Label();
            this.tplUpdateFrequentlyUpdateLabel2 = new System.Windows.Forms.Label();
            this.tplUpdateFrequentlyStopButton = new System.Windows.Forms.Button();
            this.tplUpdateFrequentlyUpdateLabel1 = new System.Windows.Forms.Label();
            this.tplUpdateFrequentlyStartButton = new System.Windows.Forms.Button();
            this.tplUpdateFrequentlyProgressBar = new System.Windows.Forms.ProgressBar();
            this.tplUpdateWhileRunUpdateLabel2 = new System.Windows.Forms.Label();
            this.tplWhileRunStopButton = new System.Windows.Forms.Button();
            this.tplUpdateWhileRunUpdateLabel1 = new System.Windows.Forms.Label();
            this.tplWhileRunStartButton = new System.Windows.Forms.Button();
            this.tplUpdateWhileRunProgressBar = new System.Windows.Forms.ProgressBar();
            this.tplUpdateWhileRunLabel = new System.Windows.Forms.Label();
            this.tplUpdateNewTaskLabel = new System.Windows.Forms.Label();
            this.tplUpdateNewTaskStopButton = new System.Windows.Forms.Button();
            this.tplUpdateNewTaskUpdateLabel1 = new System.Windows.Forms.Label();
            this.tplUpdateNewTaskStartButton = new System.Windows.Forms.Button();
            this.tplUpdateNewTaskProgressBar = new System.Windows.Forms.ProgressBar();
            this.asyncrhonousFunctionsLabel = new System.Windows.Forms.Label();
            this.asyncrhonousFunctionsStopButton = new System.Windows.Forms.Button();
            this.asynchronousFunctionsUpdateLabel = new System.Windows.Forms.Label();
            this.asynchronousFunctionsStartButton = new System.Windows.Forms.Button();
            this.asynchronousFunctionsProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(24, 38);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(275, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(111, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 380);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(903, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tplUpdateLabel2
            // 
            this.tplUpdateLabel2.AutoSize = true;
            this.tplUpdateLabel2.Location = new System.Drawing.Point(264, 214);
            this.tplUpdateLabel2.Name = "tplUpdateLabel2";
            this.tplUpdateLabel2.Size = new System.Drawing.Size(35, 13);
            this.tplUpdateLabel2.TabIndex = 11;
            this.tplUpdateLabel2.Text = "label3";
            // 
            // tplStopButton
            // 
            this.tplStopButton.Location = new System.Drawing.Point(111, 198);
            this.tplStopButton.Name = "tplStopButton";
            this.tplStopButton.Size = new System.Drawing.Size(118, 23);
            this.tplStopButton.TabIndex = 10;
            this.tplStopButton.Text = "Stop";
            this.tplStopButton.UseVisualStyleBackColor = true;
            this.tplStopButton.Click += new System.EventHandler(this.tplStopButton_Click);
            // 
            // tplUpdateLabel1
            // 
            this.tplUpdateLabel1.AutoSize = true;
            this.tplUpdateLabel1.Location = new System.Drawing.Point(264, 198);
            this.tplUpdateLabel1.Name = "tplUpdateLabel1";
            this.tplUpdateLabel1.Size = new System.Drawing.Size(35, 13);
            this.tplUpdateLabel1.TabIndex = 9;
            this.tplUpdateLabel1.Text = "label2";
            // 
            // tplButton
            // 
            this.tplButton.Location = new System.Drawing.Point(24, 198);
            this.tplButton.Name = "tplButton";
            this.tplButton.Size = new System.Drawing.Size(81, 23);
            this.tplButton.TabIndex = 8;
            this.tplButton.Text = "Start";
            this.tplButton.UseVisualStyleBackColor = true;
            this.tplButton.Click += new System.EventHandler(this.tplButton_Click);
            // 
            // tplProgressBar
            // 
            this.tplProgressBar.Location = new System.Drawing.Point(24, 155);
            this.tplProgressBar.Name = "tplProgressBar";
            this.tplProgressBar.Size = new System.Drawing.Size(275, 23);
            this.tplProgressBar.TabIndex = 7;
            // 
            // backgroundWorkerLabel
            // 
            this.backgroundWorkerLabel.AutoSize = true;
            this.backgroundWorkerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backgroundWorkerLabel.Location = new System.Drawing.Point(21, 9);
            this.backgroundWorkerLabel.Name = "backgroundWorkerLabel";
            this.backgroundWorkerLabel.Size = new System.Drawing.Size(145, 16);
            this.backgroundWorkerLabel.TabIndex = 12;
            this.backgroundWorkerLabel.Text = "Background Worker";
            // 
            // TPLLabel
            // 
            this.TPLLabel.AutoSize = true;
            this.TPLLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPLLabel.Location = new System.Drawing.Point(21, 118);
            this.TPLLabel.Name = "TPLLabel";
            this.TPLLabel.Size = new System.Drawing.Size(246, 16);
            this.TPLLabel.TabIndex = 13;
            this.TPLLabel.Text = "TPL Update once task is complete";
            // 
            // tplUpdateFrequentlyLabel
            // 
            this.tplUpdateFrequentlyLabel.AutoSize = true;
            this.tplUpdateFrequentlyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tplUpdateFrequentlyLabel.Location = new System.Drawing.Point(362, 118);
            this.tplUpdateFrequentlyLabel.Name = "tplUpdateFrequentlyLabel";
            this.tplUpdateFrequentlyLabel.Size = new System.Drawing.Size(412, 16);
            this.tplUpdateFrequentlyLabel.TabIndex = 25;
            this.tplUpdateFrequentlyLabel.Text = "TPL Update the UI  very frequently while the task is running";
            // 
            // tplUpdateFrequentlyUpdateLabel2
            // 
            this.tplUpdateFrequentlyUpdateLabel2.AutoSize = true;
            this.tplUpdateFrequentlyUpdateLabel2.Location = new System.Drawing.Point(605, 214);
            this.tplUpdateFrequentlyUpdateLabel2.Name = "tplUpdateFrequentlyUpdateLabel2";
            this.tplUpdateFrequentlyUpdateLabel2.Size = new System.Drawing.Size(35, 13);
            this.tplUpdateFrequentlyUpdateLabel2.TabIndex = 23;
            this.tplUpdateFrequentlyUpdateLabel2.Text = "label3";
            // 
            // tplUpdateFrequentlyStopButton
            // 
            this.tplUpdateFrequentlyStopButton.Location = new System.Drawing.Point(452, 198);
            this.tplUpdateFrequentlyStopButton.Name = "tplUpdateFrequentlyStopButton";
            this.tplUpdateFrequentlyStopButton.Size = new System.Drawing.Size(118, 23);
            this.tplUpdateFrequentlyStopButton.TabIndex = 22;
            this.tplUpdateFrequentlyStopButton.Text = "Stop";
            this.tplUpdateFrequentlyStopButton.UseVisualStyleBackColor = true;
            this.tplUpdateFrequentlyStopButton.Click += new System.EventHandler(this.tplUpdateFrequentlyStopButton_Click);
            // 
            // tplUpdateFrequentlyUpdateLabel1
            // 
            this.tplUpdateFrequentlyUpdateLabel1.AutoSize = true;
            this.tplUpdateFrequentlyUpdateLabel1.Location = new System.Drawing.Point(605, 198);
            this.tplUpdateFrequentlyUpdateLabel1.Name = "tplUpdateFrequentlyUpdateLabel1";
            this.tplUpdateFrequentlyUpdateLabel1.Size = new System.Drawing.Size(35, 13);
            this.tplUpdateFrequentlyUpdateLabel1.TabIndex = 21;
            this.tplUpdateFrequentlyUpdateLabel1.Text = "label4";
            // 
            // tplUpdateFrequentlyStartButton
            // 
            this.tplUpdateFrequentlyStartButton.Location = new System.Drawing.Point(365, 198);
            this.tplUpdateFrequentlyStartButton.Name = "tplUpdateFrequentlyStartButton";
            this.tplUpdateFrequentlyStartButton.Size = new System.Drawing.Size(81, 23);
            this.tplUpdateFrequentlyStartButton.TabIndex = 20;
            this.tplUpdateFrequentlyStartButton.Text = "Start";
            this.tplUpdateFrequentlyStartButton.UseVisualStyleBackColor = true;
            this.tplUpdateFrequentlyStartButton.Click += new System.EventHandler(this.tplUpdateFrequentlyStartButton_Click);
            // 
            // tplUpdateFrequentlyProgressBar
            // 
            this.tplUpdateFrequentlyProgressBar.Location = new System.Drawing.Point(365, 155);
            this.tplUpdateFrequentlyProgressBar.Name = "tplUpdateFrequentlyProgressBar";
            this.tplUpdateFrequentlyProgressBar.Size = new System.Drawing.Size(275, 23);
            this.tplUpdateFrequentlyProgressBar.TabIndex = 19;
            // 
            // tplUpdateWhileRunUpdateLabel2
            // 
            this.tplUpdateWhileRunUpdateLabel2.AutoSize = true;
            this.tplUpdateWhileRunUpdateLabel2.Location = new System.Drawing.Point(605, 97);
            this.tplUpdateWhileRunUpdateLabel2.Name = "tplUpdateWhileRunUpdateLabel2";
            this.tplUpdateWhileRunUpdateLabel2.Size = new System.Drawing.Size(35, 13);
            this.tplUpdateWhileRunUpdateLabel2.TabIndex = 18;
            this.tplUpdateWhileRunUpdateLabel2.Text = "label7";
            // 
            // tplWhileRunStopButton
            // 
            this.tplWhileRunStopButton.Location = new System.Drawing.Point(452, 81);
            this.tplWhileRunStopButton.Name = "tplWhileRunStopButton";
            this.tplWhileRunStopButton.Size = new System.Drawing.Size(118, 23);
            this.tplWhileRunStopButton.TabIndex = 17;
            this.tplWhileRunStopButton.Text = "Stop";
            this.tplWhileRunStopButton.UseVisualStyleBackColor = true;
            this.tplWhileRunStopButton.Click += new System.EventHandler(this.tplWhileRunStopButton_Click);
            // 
            // tplUpdateWhileRunUpdateLabel1
            // 
            this.tplUpdateWhileRunUpdateLabel1.AutoSize = true;
            this.tplUpdateWhileRunUpdateLabel1.Location = new System.Drawing.Point(605, 81);
            this.tplUpdateWhileRunUpdateLabel1.Name = "tplUpdateWhileRunUpdateLabel1";
            this.tplUpdateWhileRunUpdateLabel1.Size = new System.Drawing.Size(35, 13);
            this.tplUpdateWhileRunUpdateLabel1.TabIndex = 16;
            this.tplUpdateWhileRunUpdateLabel1.Text = "label3";
            // 
            // tplWhileRunStartButton
            // 
            this.tplWhileRunStartButton.Location = new System.Drawing.Point(365, 81);
            this.tplWhileRunStartButton.Name = "tplWhileRunStartButton";
            this.tplWhileRunStartButton.Size = new System.Drawing.Size(81, 23);
            this.tplWhileRunStartButton.TabIndex = 15;
            this.tplWhileRunStartButton.Text = "Start";
            this.tplWhileRunStartButton.UseVisualStyleBackColor = true;
            this.tplWhileRunStartButton.Click += new System.EventHandler(this.tplWhileRunStartButton_Click);
            // 
            // tplUpdateWhileRunProgressBar
            // 
            this.tplUpdateWhileRunProgressBar.Location = new System.Drawing.Point(365, 38);
            this.tplUpdateWhileRunProgressBar.Name = "tplUpdateWhileRunProgressBar";
            this.tplUpdateWhileRunProgressBar.Size = new System.Drawing.Size(275, 23);
            this.tplUpdateWhileRunProgressBar.TabIndex = 14;
            // 
            // tplUpdateWhileRunLabel
            // 
            this.tplUpdateWhileRunLabel.AutoSize = true;
            this.tplUpdateWhileRunLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tplUpdateWhileRunLabel.Location = new System.Drawing.Point(362, 9);
            this.tplUpdateWhileRunLabel.Name = "tplUpdateWhileRunLabel";
            this.tplUpdateWhileRunLabel.Size = new System.Drawing.Size(233, 16);
            this.tplUpdateWhileRunLabel.TabIndex = 26;
            this.tplUpdateWhileRunLabel.Text = "TPL Update while task is running";
            // 
            // tplUpdateNewTaskLabel
            // 
            this.tplUpdateNewTaskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tplUpdateNewTaskLabel.Location = new System.Drawing.Point(21, 245);
            this.tplUpdateNewTaskLabel.Name = "tplUpdateNewTaskLabel";
            this.tplUpdateNewTaskLabel.Size = new System.Drawing.Size(278, 34);
            this.tplUpdateNewTaskLabel.TabIndex = 32;
            this.tplUpdateNewTaskLabel.Text = "TPL Update UI very frequently with new task while original is running";
            // 
            // tplUpdateNewTaskStopButton
            // 
            this.tplUpdateNewTaskStopButton.Location = new System.Drawing.Point(111, 325);
            this.tplUpdateNewTaskStopButton.Name = "tplUpdateNewTaskStopButton";
            this.tplUpdateNewTaskStopButton.Size = new System.Drawing.Size(118, 23);
            this.tplUpdateNewTaskStopButton.TabIndex = 30;
            this.tplUpdateNewTaskStopButton.Text = "Stop";
            this.tplUpdateNewTaskStopButton.UseVisualStyleBackColor = true;
            this.tplUpdateNewTaskStopButton.Click += new System.EventHandler(this.tplUpdateNewTaskStopButton_Click);
            // 
            // tplUpdateNewTaskUpdateLabel1
            // 
            this.tplUpdateNewTaskUpdateLabel1.Location = new System.Drawing.Point(264, 325);
            this.tplUpdateNewTaskUpdateLabel1.Name = "tplUpdateNewTaskUpdateLabel1";
            this.tplUpdateNewTaskUpdateLabel1.Size = new System.Drawing.Size(95, 44);
            this.tplUpdateNewTaskUpdateLabel1.TabIndex = 29;
            this.tplUpdateNewTaskUpdateLabel1.Text = "label5";
            // 
            // tplUpdateNewTaskStartButton
            // 
            this.tplUpdateNewTaskStartButton.Location = new System.Drawing.Point(24, 325);
            this.tplUpdateNewTaskStartButton.Name = "tplUpdateNewTaskStartButton";
            this.tplUpdateNewTaskStartButton.Size = new System.Drawing.Size(81, 23);
            this.tplUpdateNewTaskStartButton.TabIndex = 28;
            this.tplUpdateNewTaskStartButton.Text = "Start";
            this.tplUpdateNewTaskStartButton.UseVisualStyleBackColor = true;
            this.tplUpdateNewTaskStartButton.Click += new System.EventHandler(this.tplUpdateNewTaskStartButton_Click);
            // 
            // tplUpdateNewTaskProgressBar
            // 
            this.tplUpdateNewTaskProgressBar.Location = new System.Drawing.Point(24, 282);
            this.tplUpdateNewTaskProgressBar.Name = "tplUpdateNewTaskProgressBar";
            this.tplUpdateNewTaskProgressBar.Size = new System.Drawing.Size(275, 23);
            this.tplUpdateNewTaskProgressBar.TabIndex = 27;
            // 
            // asyncrhonousFunctionsLabel
            // 
            this.asyncrhonousFunctionsLabel.AutoSize = true;
            this.asyncrhonousFunctionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asyncrhonousFunctionsLabel.Location = new System.Drawing.Point(362, 245);
            this.asyncrhonousFunctionsLabel.Name = "asyncrhonousFunctionsLabel";
            this.asyncrhonousFunctionsLabel.Size = new System.Drawing.Size(170, 16);
            this.asyncrhonousFunctionsLabel.TabIndex = 37;
            this.asyncrhonousFunctionsLabel.Text = "Asynchronous functions";
            // 
            // asyncrhonousFunctionsStopButton
            // 
            this.asyncrhonousFunctionsStopButton.Location = new System.Drawing.Point(452, 325);
            this.asyncrhonousFunctionsStopButton.Name = "asyncrhonousFunctionsStopButton";
            this.asyncrhonousFunctionsStopButton.Size = new System.Drawing.Size(118, 23);
            this.asyncrhonousFunctionsStopButton.TabIndex = 36;
            this.asyncrhonousFunctionsStopButton.Text = "Stop";
            this.asyncrhonousFunctionsStopButton.UseVisualStyleBackColor = true;
            this.asyncrhonousFunctionsStopButton.Click += new System.EventHandler(this.asynchronousFunctionsStopButton_Click);
            // 
            // asynchronousFunctionsUpdateLabel
            // 
            this.asynchronousFunctionsUpdateLabel.AutoSize = true;
            this.asynchronousFunctionsUpdateLabel.Location = new System.Drawing.Point(605, 325);
            this.asynchronousFunctionsUpdateLabel.Name = "asynchronousFunctionsUpdateLabel";
            this.asynchronousFunctionsUpdateLabel.Size = new System.Drawing.Size(35, 13);
            this.asynchronousFunctionsUpdateLabel.TabIndex = 35;
            this.asynchronousFunctionsUpdateLabel.Text = "label5";
            // 
            // asynchronousFunctionsStartButton
            // 
            this.asynchronousFunctionsStartButton.Location = new System.Drawing.Point(365, 325);
            this.asynchronousFunctionsStartButton.Name = "asynchronousFunctionsStartButton";
            this.asynchronousFunctionsStartButton.Size = new System.Drawing.Size(81, 23);
            this.asynchronousFunctionsStartButton.TabIndex = 34;
            this.asynchronousFunctionsStartButton.Text = "Start";
            this.asynchronousFunctionsStartButton.UseVisualStyleBackColor = true;
            this.asynchronousFunctionsStartButton.Click += new System.EventHandler(this.asynchronousFunctionsStartButton_Click);
            // 
            // asynchronousFunctionsProgressBar
            // 
            this.asynchronousFunctionsProgressBar.Location = new System.Drawing.Point(365, 282);
            this.asynchronousFunctionsProgressBar.Name = "asynchronousFunctionsProgressBar";
            this.asynchronousFunctionsProgressBar.Size = new System.Drawing.Size(275, 23);
            this.asynchronousFunctionsProgressBar.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 402);
            this.Controls.Add(this.asyncrhonousFunctionsLabel);
            this.Controls.Add(this.asyncrhonousFunctionsStopButton);
            this.Controls.Add(this.asynchronousFunctionsUpdateLabel);
            this.Controls.Add(this.asynchronousFunctionsStartButton);
            this.Controls.Add(this.asynchronousFunctionsProgressBar);
            this.Controls.Add(this.tplUpdateNewTaskLabel);
            this.Controls.Add(this.tplUpdateNewTaskStopButton);
            this.Controls.Add(this.tplUpdateNewTaskUpdateLabel1);
            this.Controls.Add(this.tplUpdateNewTaskStartButton);
            this.Controls.Add(this.tplUpdateNewTaskProgressBar);
            this.Controls.Add(this.tplUpdateWhileRunLabel);
            this.Controls.Add(this.tplUpdateFrequentlyLabel);
            this.Controls.Add(this.tplUpdateFrequentlyUpdateLabel2);
            this.Controls.Add(this.tplUpdateFrequentlyStopButton);
            this.Controls.Add(this.tplUpdateFrequentlyUpdateLabel1);
            this.Controls.Add(this.tplUpdateFrequentlyStartButton);
            this.Controls.Add(this.tplUpdateFrequentlyProgressBar);
            this.Controls.Add(this.tplUpdateWhileRunUpdateLabel2);
            this.Controls.Add(this.tplWhileRunStopButton);
            this.Controls.Add(this.tplUpdateWhileRunUpdateLabel1);
            this.Controls.Add(this.tplWhileRunStartButton);
            this.Controls.Add(this.tplUpdateWhileRunProgressBar);
            this.Controls.Add(this.TPLLabel);
            this.Controls.Add(this.backgroundWorkerLabel);
            this.Controls.Add(this.tplUpdateLabel2);
            this.Controls.Add(this.tplStopButton);
            this.Controls.Add(this.tplUpdateLabel1);
            this.Controls.Add(this.tplButton);
            this.Controls.Add(this.tplProgressBar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label tplUpdateLabel2;
        private System.Windows.Forms.Button tplStopButton;
        private System.Windows.Forms.Label tplUpdateLabel1;
        private System.Windows.Forms.Button tplButton;
        private System.Windows.Forms.ProgressBar tplProgressBar;
        private System.Windows.Forms.Label backgroundWorkerLabel;
        private System.Windows.Forms.Label TPLLabel;
        private System.Windows.Forms.Label tplUpdateFrequentlyLabel;
        private System.Windows.Forms.Label tplUpdateFrequentlyUpdateLabel2;
        private System.Windows.Forms.Button tplUpdateFrequentlyStopButton;
        private System.Windows.Forms.Label tplUpdateFrequentlyUpdateLabel1;
        private System.Windows.Forms.Button tplUpdateFrequentlyStartButton;
        private System.Windows.Forms.ProgressBar tplUpdateFrequentlyProgressBar;
        private System.Windows.Forms.Label tplUpdateWhileRunUpdateLabel2;
        private System.Windows.Forms.Button tplWhileRunStopButton;
        private System.Windows.Forms.Label tplUpdateWhileRunUpdateLabel1;
        private System.Windows.Forms.Button tplWhileRunStartButton;
        private System.Windows.Forms.Label tplUpdateWhileRunLabel;
        private System.Windows.Forms.Label tplUpdateNewTaskLabel;
        private System.Windows.Forms.Button tplUpdateNewTaskStopButton;
        private System.Windows.Forms.Label tplUpdateNewTaskUpdateLabel1;
        private System.Windows.Forms.Button tplUpdateNewTaskStartButton;
        private System.Windows.Forms.ProgressBar tplUpdateNewTaskProgressBar;
        protected System.Windows.Forms.ProgressBar tplUpdateWhileRunProgressBar;
        private System.Windows.Forms.Label asyncrhonousFunctionsLabel;
        private System.Windows.Forms.Button asyncrhonousFunctionsStopButton;
        private System.Windows.Forms.Label asynchronousFunctionsUpdateLabel;
        private System.Windows.Forms.Button asynchronousFunctionsStartButton;
        private System.Windows.Forms.ProgressBar asynchronousFunctionsProgressBar;
    }
}

