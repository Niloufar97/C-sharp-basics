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
       
        public static bool WrongAnswer = false;
        

        public static int GetNumber(int index)
        {
            int Output = -1;
            try
            {
                Output = Numbers[index];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (Output == -1)
                {
                    WrongAnswer = true;
                }
                else
                {
                    WrongAnswer = false;
                }
            }
            return Output;
        }
    }
}
