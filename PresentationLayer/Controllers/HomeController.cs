using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BussinesLayer;
using EntityLayer;
using System.Threading.Tasks;


namespace PresentationLayer.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index(string page="")
        {
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            MovieListStructure movies = await SearchCriteria.GetlastMovies(page);
            return View(movies);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}