using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movie_rating
{
    internal static class Tools
    {
        private static double Avg(List<int> userRanks)
        {
            int sum = 0;
            for (int i = 0; i < userRanks.Count; i++)
            {
                sum += userRanks[i];
            }
            double avg = (double)sum / userRanks.Count;
            return avg;
        }
        public static void FindAverage()
        {
            string[] movies = new string[3] { "movie1", "movie2", "movie3" };
            List<int> ranks = new List<int>();
            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine("Rate from 1 to 10: " + movies[i]);
                int rank = Convert.ToInt32(Console.ReadLine());
                ranks.Add(rank);
            }
            double average = Tools.Avg(ranks);
            Console.WriteLine("the average is: ");
            Console.WriteLine(average);
            Console.ReadKey();
        }
    }
}
