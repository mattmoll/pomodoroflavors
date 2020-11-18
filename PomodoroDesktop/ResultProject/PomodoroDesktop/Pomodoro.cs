using System;
using System.Windows.Forms;

namespace PomodoroDesktop
{
    public partial class Pomodoro : Form
    {
        private const int MINUTES_POMODORO = 25;
        private const int MINUTES_SHORT_BREAK = 1;
        private const int MINUTES_LONG_BREAK= 15;

        private ICountdown countdownTimer;

        public Pomodoro()
        {
            InitializeComponent();
            this.countdownTimer = new Countdown();
            this.countdownTimer.TickHappened += CountdownTimer_TickHappened;
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
            countdownTimer.SetTime(minutesToCountdown);

            UpdateCountdownOnScreen();

            countdownTimer.StartCountdown();
        }

        private void CountdownTimer_TickHappened(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() => 
            {
                UpdateCountdownOnScreen();

                if (countdownTimer.IsTimeUp)
                {
                    this.countdownTimer.StopCountdown();
                    MessageBox.Show(this, "Time is up!", "Timer");
                }
            }));
        }

        private void btnStart_Click(object sender, EventArgs e) => this.countdownTimer.StartCountdown();
        private void btnStop_Click(object sender, EventArgs e) => this.countdownTimer.StopCountdown();

        private void UpdateCountdownOnScreen()
        {
            lblMinutes.Text = countdownTimer.MinutesLeft.ToString("00");
            lblSeconds.Text = countdownTimer.SecondsLeft.ToString("00");
        }

    }
}
