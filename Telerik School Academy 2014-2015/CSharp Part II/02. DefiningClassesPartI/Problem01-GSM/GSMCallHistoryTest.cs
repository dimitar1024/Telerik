using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_GSM
{
    class GSMCallHistoryTest : GSM
    {

        private int countNumbers;

        public void AddCalls(int countNumbers)
        {
            this.countNumbers = countNumbers;
            Random rand = new Random();


            for (int i = 0; i < this.countNumbers; i++)
            {
                AddCalls(DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ("08" + rand.Next(11111111, 100000000)), (long)rand.Next(0, 200));
            }
        }

        public override string ToString()
        {
            if (CallHistory.Count > 0)
            {
                StringBuilder str = new StringBuilder();
                for (int i = 0; i < this.CallHistory.Count; i++)
                {
                    str.Append("\n");
                    str.Append("Date: " + this.CallHistory[i].Date);
                    str.Append("\n");
                    str.Append("Time: " + this.CallHistory[i].Time);
                    str.Append("\n");
                    str.Append("Tel. Number: " + this.CallHistory[i].DialedPhoneNumber);
                    str.Append("\n");
                    str.Append("Duration: " + this.CallHistory[i].Duration + " sec.");
                    str.Append("\n");
                    // make new line in new str.append to be more readable
                }
                return str.ToString();
            }
            else
            {
                return ("History is empty !").ToString();
            }
        }

        public void DeleteLongestCall()
        {
            long longestCallDuration = 0;
            Call longestCall = new Call();
            foreach (var item in this.CallHistory)
            {
                if (item.Duration >= longestCallDuration)
                {
                    longestCall = item;
                }
            }
            this.DeleteCalls(longestCall);
        }

    }

}

