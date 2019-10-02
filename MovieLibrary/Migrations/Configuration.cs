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
                }
            );
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
