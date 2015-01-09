using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _04.DownloadFile
{
    class DownloadFile
    {
        static void Main(string[] args)
        {
            Console.Write("The file is download in root folder on this prodject");
            try
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", @"../../../picture.jpg");
            }
            catch (Exception er)
            {
                Console.WriteLine("Error!\n{0}:{1}", er.GetType().Name, er.Message);
            }
        }
    }
}
