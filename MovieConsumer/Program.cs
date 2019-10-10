using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (IISMovieServiceReference.MovieServiceClient client = new IISMovieServiceReference.MovieServiceClient())
            {
                IISMovieServiceReference.MovieModelDTO[] result =  client.GetMovies();
                foreach (IISMovieServiceReference.MovieModelDTO item in result)
                {
                    Console.WriteLine(item.Title);
                }
                Console.ReadLine();
            }
        }
    }
}
