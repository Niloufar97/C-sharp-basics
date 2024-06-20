using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.Name = "Asghar";

            Client cl1 = manager.AddClient("Akbar");
            cl1.Buy("Iphone 14 pro");
            Console.WriteLine(cl1.Name);
            Console.WriteLine(cl1.GetPoints());

            cl1.Buy("Iphone 15");
            Console.WriteLine(cl1.GetPoints());

            Console.ReadKey();

        }
        public class Client
        {
            public string Name;
            private int point= 0;

            public int GetPoints () { return point; }

            public void Buy(string product) { 
                point++;
            }
        }

        public class Manager
        {
            public string Name;

            public Client AddClient(string clientName)
            {
                Client client1 = new Client();
                client1.Name = clientName;
                return client1;
            }
        }
    }
}
