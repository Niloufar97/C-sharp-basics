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
    }
}
