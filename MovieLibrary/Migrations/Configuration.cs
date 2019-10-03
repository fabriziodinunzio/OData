namespace MovieLibrary.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MovieLibrary.MovieDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MovieLibrary.MovieDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Movies.AddOrUpdate(
                new MovieModel[]
                {
                    new MovieModel()
                    {
                         Title="Rambo"
                         , ReleaseDate = new DateTime(2009,12,3)
                         , Reviews = new ReviewModel[]
                         {
                             new ReviewModel()
                             {
                                  Rating = 0.67M
                                  , Reviewer = "Paolo Binni"
                                  , ReviewText = "HHHHHH"
                                  , Summary = "lbòbòjbòjkbòjb"
                             }
                             ,
                             new ReviewModel()
                             {
                                  Rating = 0.67M
                                  , Reviewer = "Carla Gali"
                                  , ReviewText = "NNNNNN"
                                  , Summary = "OOOOOOOOOOO"
                             }
                         }
                    }
                    ,
                    new MovieModel()
                    {
                         Title="The Nun"
                         , ReleaseDate = new DateTime(2017,2,3)
                         , Reviews = new ReviewModel[]
                         {
                             new ReviewModel()
                             {
                                  Rating = 0.90M
                                  , Reviewer = "Carlo Fratini"
                                  , ReviewText = "LLLLLL"
                                  , Summary = "KKKKKKKKKKK"
                             }
                             ,
                             new ReviewModel()
                             {
                                  Rating = 0.80M
                                  , Reviewer = "Gennaro Metelli"
                                  , ReviewText = "JJJJJJ"
                                  , Summary = "kujhvlhvluhvoluhvouhv"
                             }
                             ,
                             new ReviewModel()
                             {
                                  Rating = 0.70M
                                  , Reviewer = "Alma Bertelli"
                                  , ReviewText = "GGGGGG"
                                  , Summary = "SSSSSSSSSSSSSSS"
                             }
                             ,
                             new ReviewModel()
                             {
                                  Rating = 0.50M
                                  , Reviewer = "Davide Cortini"
                                  , ReviewText = "PPPPPP"
                                  , Summary = "MMMMMMMMMMMMMMM"
                             }
                         }
                    }
                    ,
                    new MovieModel()
                    {
                         Title="Star Trek"
                         , ReleaseDate = new DateTime(2009,12,3)
                         , Reviews = new ReviewModel[]
                         {
                             new ReviewModel()
                             {
                                  Rating = 0.67M
                                  , Reviewer = "Paolo Binni"
                                  , ReviewText = "Film di fantascienza"
                                  , Summary = "C'era una volta un popolo su un altro pianeta..."
                             }
                         }
                    }
                }
            );
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
