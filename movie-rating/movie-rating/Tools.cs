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

        public static void BestAndWorstMovies() {
            string[] movies = new string[5] { "Movie1", "Movie2", "Movie3", "Movie4", "Movie5" };
            List<int> ranks = new List<int>();
            for(int i = 0;i < movies.Length; i++)
            {
                Console.WriteLine("Rate from 1 to 10: " + movies[i]);
                int rank = Convert.ToInt32(Console.ReadLine());
                ranks.Add(rank);
            }
            MinAndMax(ranks, movies);
            Console.ReadKey();

        }
        private static void MinAndMax(List<int> userRanks , string[] movies)
        {
            int minIndex = 0;
            int maxIndex = 0;
            for (int i = 0; i < userRanks.Count; i++)
            {
                if(userRanks[i]< userRanks[minIndex])
                {
                    minIndex = i;
                }
                if(userRanks [i]> userRanks[maxIndex]) { maxIndex = i; }
            }
            Console.WriteLine("best Movie: " + movies[maxIndex] + " with rank: " + userRanks[maxIndex]);
            Console.WriteLine("worst Movie: " + movies[minIndex] + " with rank: " + userRanks[minIndex]);
        }
    }
}
