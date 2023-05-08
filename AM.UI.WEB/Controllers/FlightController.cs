using AM.Core.Domain;
using AM.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AM.UI.WEB.Controllers
{
    public class FlightController : Controller
    {
        readonly IFlightService flightService;
        readonly IPlaneService planeService;
        public FlightController(IFlightService flightService, IPlaneService planeService) //injection de service
        {
            this.planeService = planeService;
            this.flightService = flightService;
        }
        // GET: FlightController
        public ActionResult Index(string filter)
        {
            DateTime date;
            if(string.IsNullOrEmpty(filter)||!DateTime.TryParse(filter, out date))
                return View(flightService.GetAll());
            return View(flightService.GetAll().Where(f=>f.FlightDate.CompareTo(DateTime.Parse(filter)) == 0));
        }

        public ActionResult SortFlight()
        {
            
            return View("Index",flightService.SortFlights());
        }


        // GET: FlightController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FlightController/Create
        public ActionResult Create()
        {
            var planes = planeService.GetAll();
            //ViewBag => relation entre contr et la vue
            ViewBag.Planes = new SelectList(planes, "PlaneId", "Capacity");
            return View();
        }

        // POST: FlightController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Flight flight)

        {
            try
            {
                flightService.Add(flight);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FlightController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FlightController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FlightController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FlightController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
