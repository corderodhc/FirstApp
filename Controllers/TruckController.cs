using Data.Interface;
using FirstAPP.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAPP.Controllers
{
    public class TruckController : Controller
    {
        private readonly ITruck _truck;
        public TruckController(ITruck truck)
        {
            _truck = truck;
        }

        // GET: Truck
        public ActionResult Index()
        {
            return View();
        }

        

        // GET: Truck/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Truck/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Truck truck)
        {
            
                if (ModelState.IsValid)
                {
                    _truck.AddTruck(truck);
                    return RedirectToAction("Details");
                }                
            
                return RedirectToAction("Create");
            
        }

        // GET: Truck/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _truck.Get(id);
            return View(model);
        }

        // POST: Truck/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Truck truck)
        {
            try
            {
                _truck.UpdateTruck(truck);
                return RedirectToAction("ShowAll");
            }
            catch
            {
                return View();
            }
        }

        // GET: Truck/Delete/5
        public ActionResult Delete(int id)
        {
            var model = _truck.Get(id);
            return View(model);
        }

        // POST: Truck/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Truck truck)
        {
            try
            {
                _truck.DeleteTruck(truck);
                return RedirectToAction("ShowAll");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult ShowAll()
        {
            var model = _truck.GetAll();
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var result = _truck.Get(id);
            return View(result);
        }
    }
}
