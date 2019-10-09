using MovieServiceClient.MovieServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieServiceReference.MovieServiceClient client = new MovieServiceReference.MovieServiceClient();
            var result = client.GetMovies();
        }
    }
}
