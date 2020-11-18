using System;
using System.Collections.Generic;
using System.Text;

namespace PomodoroDesktop
{
    public interface ICountdown
    {
        public int MinutesLeft { get; }
        public int SecondsLeft { get; }
        public bool IsTimeUp { get; }

        public void SetTime(int minutesToSet);
        public void StartCountdown();
        public void StopCountdown();

        public event EventHandler TickHappened;
    }
}
