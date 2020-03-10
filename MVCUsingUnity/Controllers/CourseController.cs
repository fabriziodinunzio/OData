using ServiciesCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUsingUnity.Controllers
{
    public class CourseController : Controller
    {
        ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        // GET: Course
        public ActionResult Index()
        {
            return View(_courseService.GetCourseById(1));
        }
    }
}