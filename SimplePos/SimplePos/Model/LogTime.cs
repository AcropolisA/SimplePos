using System;
using System.Collections.Generic;
using System.Text;

namespace SimplePos.Model
{
    public class LogTime
    {
        int month;
        int week;
        int day;
        int hour;
        int minute;
        int second;
            
        DateTime now;

        public LogTime()
        {
            UpdateTime();
        }

        public int Month { get => month; }
        public int Week { get => week; }
        public int Day { get => day; }
        public int Hour { get => hour; }
        public int Minute { get => minute; }
        public int Second { get => second; }
        public DateTime Now { get => now; }

        public void UpdateTime()
        {
            // 인스턴스 생성시각
            now = DateTime.Now;

            month = now.Month;
            week = (month - day) % 7;
            day = now.Day;
            hour = now.Hour;
            minute = now.Minute;
            second = now.Second;
        }
    }
}
