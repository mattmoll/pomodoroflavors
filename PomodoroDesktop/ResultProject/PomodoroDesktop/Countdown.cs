using System;
using System.Timers;

namespace PomodoroDesktop
{
    public class Countdown : ICountdown
    {
        public event EventHandler TickHappened;

        private int timeLeft;
        private const int SECONDS_PER_MINUTE = 60;
        private Timer timer;

        public int MinutesLeft { get { return timeLeft / SECONDS_PER_MINUTE; } }
        public int SecondsLeft { get { return timeLeft % SECONDS_PER_MINUTE; } }
        public bool IsTimeUp { get { return timeLeft == 0; } }

        public Countdown()
        {
            this.timer = new Timer();
            this.timer.Interval = 1000;
            this.timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.timeLeft--;

            EventHandler handler = TickHappened;
            handler?.Invoke(this, EventArgs.Empty);
        }

        public void SetTime(int minutesToSet)
        {
            this.timeLeft = minutesToSet * SECONDS_PER_MINUTE;
        }

        public void StartCountdown()
        {
            this.timer.Start();
        }

        public void StopCountdown()
        {
            this.timer.Stop();
        }
    }
}
