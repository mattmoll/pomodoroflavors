namespace PomodoroDesktop
{
    partial class Pomodoro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pomodoro));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnPomodoro = new System.Windows.Forms.Button();
            this.btnShortBreak = new System.Windows.Forms.Button();
            this.btnLongBreak = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPomodoro
            // 
            this.btnPomodoro.Location = new System.Drawing.Point(103, 45);
            this.btnPomodoro.Name = "btnPomodoro";
            this.btnPomodoro.Size = new System.Drawing.Size(75, 23);
            this.btnPomodoro.TabIndex = 0;
            this.btnPomodoro.Text = "Pomodoro";
            this.btnPomodoro.UseVisualStyleBackColor = true;
            // 
            // btnShortBreak
            // 
            this.btnShortBreak.Location = new System.Drawing.Point(230, 45);
            this.btnShortBreak.Name = "btnShortBreak";
            this.btnShortBreak.Size = new System.Drawing.Size(75, 23);
            this.btnShortBreak.TabIndex = 1;
            this.btnShortBreak.Text = "Short Break";
            this.btnShortBreak.UseVisualStyleBackColor = true;
            // 
            // btnLongBreak
            // 
            this.btnLongBreak.Location = new System.Drawing.Point(356, 45);
            this.btnLongBreak.Name = "btnLongBreak";
            this.btnLongBreak.Size = new System.Drawing.Size(75, 23);
            this.btnLongBreak.TabIndex = 2;
            this.btnLongBreak.Text = "Long Break";
            this.btnLongBreak.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 113);
            this.label1.TabIndex = 4;
            this.label1.Text = "00:00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(171, 429);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(77, 40);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(290, 429);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(77, 40);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(171, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 183);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Pomodoro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 532);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLongBreak);
            this.Controls.Add(this.btnShortBreak);
            this.Controls.Add(this.btnPomodoro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pomodoro";
            this.Text = "Pomodoro Clock";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnPomodoro;
        private System.Windows.Forms.Button btnShortBreak;
        private System.Windows.Forms.Button btnLongBreak;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
    }
}

