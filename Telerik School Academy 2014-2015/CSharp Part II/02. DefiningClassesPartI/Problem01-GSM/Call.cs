using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_GSM
{
    class Call
    {
        private string date;
        private string time;
        private string dialedPhoneNumber;
        private long duration;
        private string date1;
        private string time1;

        public long Duration
        {
            get { return duration; }
            set { duration = value; }
        }
        

        public string DialedPhoneNumber
        {
            get { return dialedPhoneNumber; }
            set { dialedPhoneNumber = value; }
        }
        
        public string Time
        {
            get { return time; }
            set { time = value; }
        }
        
        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public Call() 
        {
        }

        public Call(string date)
        {
            this.Date = date;
        }

        public Call(string date, string time)
            : this(date)
        {
            this.Time = time;
        }

        public Call(string date, string time, long duration)
            : this(date,time)
        {
            this.Duration = duration;
        }
        public Call(string date, string time,string dialedPhoneNumber, long duration)
            : this(date, time, duration)
        {
            this.dialedPhoneNumber = dialedPhoneNumber;
        }
    }
}
