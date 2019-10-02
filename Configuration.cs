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
                m => m.Title
                , new MovieModel[]
                {
                    new MovieModel()
                    {
                         Title="Rambo"
                         , ReleaseDate = new DateTime(1998,6,21)
                         , Reviews = new ReviewModel[]
                         {
                             new ReviewModel()
                             {
                                  Reviewer="Andrea Banti"
                                  , Summary="Bel film"
                                  , ReviewText="likbgpigyu087609876"
                             }
                             ,new ReviewModel()
                             {
                                  Reviewer="Giulia Forti"
                                  , Summary="Pessimo"
                                  , ReviewText="luuuuuuuuuuu"
                             }
                             ,new ReviewModel()
                             {
                                  Reviewer="Patrizio Gemma"
                                  , Summary="Film di guerra"
                                  , ReviewText="4444859859859859"
                             }
                         }
                    }
                    ,
                    new MovieModel()
                    {
                         Title="Star Wars"
                         , ReleaseDate = new DateTime(2010,3,8)
                         , Reviews = new ReviewModel[]
                         {
                             new ReviewModel()
                             {
                                  Reviewer="Giovanni Brabante"
                                  , Summary="Capolavoro"
                                  , ReviewText="AAAAAAAAAA"
                             }
                             ,new ReviewModel()
                             {
                                  Reviewer="Giuliano Farini"
                                  , Summary="Fantasia pura"
                                  , ReviewText="nnnnnnnnnn"
                             }
                         }
                    }
                    ,
                    new MovieModel()
                    {
                         Title="The Nun"
                         , ReleaseDate = new DateTime(2017,9,1)
                         , Reviews = new ReviewModel[]
                         {
                             new ReviewModel()
                             {
                                  Reviewer="Fabio Puni"
                                  , Summary="Terribile"
                                  , ReviewText="yitv79tf976"
                             }
                             ,new ReviewModel()
                             {
                                  Reviewer="Carla Basile"
                                  , Summary="Horror"
                                  , ReviewText="ghbdfgvhbliughuy"
                             }
                         }
                    }
                }
                );

            context.Reviews.AddOrUpdate(
                r => r.Reviewer,
                new ReviewModel[]
                {
                             new ReviewModel()
                             {
                                  Reviewer="Giovanni Brabante"
                                  , Summary="Schifezza"
                                  , ReviewText="BUUUUUU"
                             }
                             ,new ReviewModel()
                             {
                                  Reviewer="Giuliano Farini"
                                  , Summary="Ma che bello"
                                  , ReviewText="XXXXXXXXXXX"
                             }
                }
                );
            context.SaveChanges();
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
