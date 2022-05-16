using System;
using System.Linq;

namespace HumanReadableTime
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeFormat.GetReadableTime(4500);
        }
    }

    public static class TimeFormat
    {
        public static string GetReadableTime(int seconds)
        {
            int remainingTheSeconds = seconds % 60;
            int secondsToMinutes = (seconds - remainingTheSeconds) / 60;
            int minutes = secondsToMinutes % 60;
            int hours = secondsToMinutes/60;      
            return string.Format($"{hours:00}:{minutes:00}:{remainingTheSeconds:00}");
        }
    }
}
