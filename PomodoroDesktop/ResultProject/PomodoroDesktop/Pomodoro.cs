using System;
using System.Drawing;
using System.Windows.Forms;

namespace PomodoroDesktop
{
    public partial class Pomodoro : Form
    {
        private const int MINUTES_POMODORO = 25;
        private const int MINUTES_SHORT_BREAK = 5;
        private const int MINUTES_LONG_BREAK= 15;

        private readonly ICountdown _countdownTimer;

        public Pomodoro(ICountdown countdownTimer)
        {
            InitializeComponent();

            _countdownTimer = countdownTimer;
            _countdownTimer.TickHappened += CountdownTimer_TickHappened;
        }

        private void btnPomodoro_Click(object sender, EventArgs e)
        {
            StartCountdownTimer(MINUTES_POMODORO);
        }

        private void btnShortBreak_Click(object sender, EventArgs e)
        {
            StartCountdownTimer(MINUTES_SHORT_BREAK);
        }

        private void btnLongBreak_Click(object sender, EventArgs e)
        {
            StartCountdownTimer(MINUTES_LONG_BREAK);
        }

        private void StartCountdownTimer(int minutesToCountdown)
        {
            _countdownTimer.SetTime(minutesToCountdown);

            UpdateCountdownOnScreen();

            _countdownTimer.StartCountdown();
        }

        private void CountdownTimer_TickHappened(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() => 
            {
                UpdateCountdownOnScreen();

                if (_countdownTimer.IsTimeUp)
                {
                    _countdownTimer.StopCountdown();
                    MessageBox.Show(this, "Time is up!", "Timer");
                }
            }));
        }

        private void btnStart_Click(object sender, EventArgs e) => _countdownTimer.StartCountdown();
        private void btnStop_Click(object sender, EventArgs e) => _countdownTimer.StopCountdown();

        private void UpdateCountdownOnScreen()
        {
            lblMinutes.Text = _countdownTimer.MinutesLeft.ToString("00");
            lblSeconds.Text = _countdownTimer.SecondsLeft.ToString("00");
        }

        #region Hacky stuff for borderless window

        private Point lastPoint;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Minimized;
        }

        private void Pomodoro_Activated(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void menuBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void menuBar_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        #endregion
    }
}
