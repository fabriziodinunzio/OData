using MovieWebApplication.MovieServiceReference;
using System.Web.Mvc;
using Unity;
using Unity.Injection;
using Unity.Mvc5;

namespace MovieWebApplication
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container
                .RegisterType<IMovieService, MovieServiceClient>(new InjectionConstructor("MovieServiceLibrary2.MovieService"));
               
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}