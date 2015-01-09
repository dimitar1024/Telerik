using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionStr = "mongodb://localhost";
            var client = new MongoClient(connectionStr);
            var server = client.GetServer();
        }
    }
}
