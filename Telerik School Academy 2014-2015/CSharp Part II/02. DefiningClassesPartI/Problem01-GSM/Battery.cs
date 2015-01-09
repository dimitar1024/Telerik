using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_GSM
{
    class Battery
    {
        private string model;
        private int hoursToIdle ;
        private int hoursToTalk;

        public int HoursToTalk
        {
            get { return hoursToTalk; }
            set { hoursToTalk = value; }
        }
        

        public int HoursToIdle 
        {
            get { return hoursToIdle ; }
            set { hoursToIdle  = value; }
        }
        
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public Battery() 
        { 
        }

        public Battery(string model)
        {
            this.model = model;
        }

        public Battery(string model, int hoursToIdle)
            : this(model)
        {
            this.hoursToIdle = hoursToIdle;
        }

        public Battery(string model, int hoursToIdle, int hoursToTalk)
            : this(model,hoursToIdle)
        {
            this.hoursToTalk = hoursToTalk;
        }
        public enum BatteryType {
            LiIon,
            NiMH,
            NiCd
        }

        
        
    }
}
