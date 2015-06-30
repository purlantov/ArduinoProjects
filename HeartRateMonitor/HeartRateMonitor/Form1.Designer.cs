namespace HeartRateMonitor
{
    partial class HeartRateMonitor
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.textBox_PortName = new System.Windows.Forms.TextBox();
            this.label_HeartBeat = new System.Windows.Forms.Label();
            this.label_value = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonSave = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1000, 500);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(1043, 53);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(1043, 82);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // textBox_PortName
            // 
            this.textBox_PortName.Location = new System.Drawing.Point(1030, 12);
            this.textBox_PortName.Name = "textBox_PortName";
            this.textBox_PortName.Size = new System.Drawing.Size(100, 20);
            this.textBox_PortName.TabIndex = 3;
            // 
            // label_HeartBeat
            // 
            this.label_HeartBeat.AutoSize = true;
            this.label_HeartBeat.BackColor = System.Drawing.Color.White;
            this.label_HeartBeat.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label_HeartBeat.Location = new System.Drawing.Point(861, 28);
            this.label_HeartBeat.Name = "label_HeartBeat";
            this.label_HeartBeat.Size = new System.Drawing.Size(133, 28);
            this.label_HeartBeat.TabIndex = 4;
            this.label_HeartBeat.Text = "Heart Rate";
            // 
            // label_value
            // 
            this.label_value.AutoSize = true;
            this.label_value.Location = new System.Drawing.Point(1040, 153);
            this.label_value.Name = "label_value";
            this.label_value.Size = new System.Drawing.Size(60, 13);
            this.label_value.TabIndex = 5;
            this.label_value.Text = "Input value";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 518);
            this.progressBar.Maximum = 1024;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1000, 23);
            this.progressBar.TabIndex = 6;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(1043, 112);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // timer
            // 
            this.timer.Interval = 5000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // HeartRateMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1151, 559);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label_value);
            this.Controls.Add(this.label_HeartBeat);
            this.Controls.Add(this.textBox_PortName);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureBox);
            this.Name = "HeartRateMonitor";
            this.Text = "Heart Rate Monitor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TextBox textBox_PortName;
        private System.Windows.Forms.Label label_HeartBeat;
        private System.Windows.Forms.Label label_value;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Timer timer;

    }
}

