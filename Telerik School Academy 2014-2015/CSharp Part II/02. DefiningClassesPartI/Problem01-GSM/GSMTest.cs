using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_GSM
{
    class GSMTest
    {
        public GSMTest()
        {
            GSM[] gsmsToArray = new GSM[5];
            string[] models = { "C5-00", "Expiria", "C45", "V3", "T210i" };
            string[] manufacturers = { "Nokia", "Sony", "Simens", "Motorola", "Sony-Ericson" }; // половината марки са вече забравени :D
            double[] prices = { 249.90d, 889.90d, 0.49, 39.90, 29.90 };
            string[] owners = { "Bai Mityo IQ", "Koceto Maimunata ot Sadievo", "Baa Niki", "Diksana", "Rumen Tvardishki s Golemoto garlo" }; // приликата с реални лица и събития е не случайна :Д 

            for (int i = 0; i < gsmsToArray.Length; i++)
            {
                gsmsToArray[i] = new GSM(models[i], manufacturers[i], prices[i], owners[i]);

                gsmsToArray[i].toString();
            }

            Console.WriteLine(GSM.IPhone4s.Model);

            Console.WriteLine(GSM.IPhone4s.Manufacturer);
        }
    }
}
