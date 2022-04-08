using Data.Servicies;
using FirstAPP.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAPP.Controllers
{
    public class TruckDriverController : Controller
    {
        private readonly ITruckDriver _truckDrivers;
        public TruckDriverController(ITruckDriver truckDriver)
        {
            _truckDrivers = truckDriver;
        }
        // GET: TruckDriverController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TruckDriverController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TruckDriverController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TruckDriverController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: TruckDriverController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TruckDriverController/Edit/5
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

        // GET: TruckDriverController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TruckDriverController/Delete/5
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
