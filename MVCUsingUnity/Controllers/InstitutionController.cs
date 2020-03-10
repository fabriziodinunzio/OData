using ServiciesCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUsingUnity.Controllers
{
    public class InstitutionController : Controller
    {
        private IInstiutionService _instiutionService;
        public InstitutionController(IInstiutionService instiutionService)
        {
            _instiutionService = instiutionService;
        }
        // GET: Institution
        public ActionResult Index()
        {
            return View(_instiutionService.GetInstitutionById(1));
        }
    }
}