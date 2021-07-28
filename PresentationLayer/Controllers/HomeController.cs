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

        public async Task<ActionResult> Details(string MovieId)
        {
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            Movie movie = await SearchCriteria.GetMovieDetails(MovieId);
            return View(movie);
        }

        public async Task<ActionResult> _MoviesFiltred(int filtre, string search = "")
        {
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            MovieListStructure movies;
            if (filtre ==1)
            {
                ViewBag.filter = "MEJOR CALIFICADAS";
                movies = await SearchCriteria.GetTopRated();
                return View(movies);
            }
            if(filtre == 2)
            {
                ViewBag.filter = "MÁS POPULARES";
                movies = await SearchCriteria.GetPopular();
                return View(movies);
            }
            if (filtre == 3)
            {
                ViewBag.filter = "BUSQUEDA";
                movies = await SearchCriteria.GetMoviesByName(search);
                return View(movies);
            }
            return View("Error");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}