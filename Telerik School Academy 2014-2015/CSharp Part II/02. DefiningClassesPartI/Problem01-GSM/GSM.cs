using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_GSM
{
    class GSM
    {
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private Battery Battery = new Battery();
        private Display Display = new Display();
        private static GSM iPhone4s = new GSM("IPhone4S", "Apple",1300,"Ganyo Idiota");

        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public GSM(string model)
        {
            this.Model = model;
        }

        public GSM(string model, string manufacturer) 
            : this(model)
        {
            this.Manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, double price)
            : this(model,manufacturer)
        {
            this.Price = price;
        }

        public GSM(string model, string manufacturer, double price, string owner)
            : this(model, manufacturer,price)
        {
            this.Owner = owner;
        }

        public void toString()
        {
            string toStr = "";
            toStr += "Model: " + this.model + "\n";
            toStr += "Menufacturer: " + this.manufacturer + "\n";
            toStr += "Price: " + this.price + " lv.\n";
            toStr += "Owner: " + this.owner + "\n";

            Console.WriteLine(toStr);
        }

        public static GSM IPhone4s
        {
            get { return iPhone4s; }
        }

        public List<Call> CallHistory = new List<Call>();


        public void AddCalls(string date, string time, string dialedPhoneNumber, long duration) 
        {
            Call call = new Call(date, time, dialedPhoneNumber,duration);
            CallHistory.Add(call);
        }

        public void DeleteCalls(Call call) 
        {
            for (int i = 0; i < CallHistory.Count; i++)
            {
                if (CallHistory[i].Date == call.Date &&
                CallHistory[i].Time == call.Time &&
                CallHistory[i].DialedPhoneNumber == call.DialedPhoneNumber &&
                CallHistory[i].Duration == call.Duration)
                {
                    CallHistory.RemoveAt(i);
                    
                }
            }
            
        }

        public void ClearCalls() 
        {
            CallHistory.Clear();
        }

        public void CalculateTotalPrice(double priceForMinute) 
        {
            double totalTime = 0;

            for (int i = 0; i < CallHistory.Count; i++)
            {
                totalTime += CallHistory[i].Duration;
            }

            double price = priceForMinute * Math.Ceiling(totalTime / 60);

            Console.WriteLine("Total price: " + price);
        }
    }
}
