using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandler
{
    public class ExceptionManager
    {
        static int[] Numbers = { 1, 8, 12 , 5 };

        public static int GetNumber(int index)
        {
            return Numbers[index]; 
        }
    }
}
