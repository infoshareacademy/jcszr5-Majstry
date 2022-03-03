﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Warsztat_v2.Models;
using Warsztat_v2.Services;

namespace Warsztat_v2.Controllers
{
    public class CarrController : Controller
    {
        private CarrService _carrService;
        public CarrController()
        {
            _carrService = new CarrService();
            SelectList list = new SelectList(_carrService.GetAll(), "CarModel", "CarMark");
            ViewBag.Roles = list;
        }
        // GET: CarrController
        public ActionResult Index()
        {
            var model = _carrService.GetAll();
            return View(model);
        }

        // GET: PartController1/Details/5
        public ActionResult Details(int id)
        {
            var model = _carrService.GetById(id);
            return View(model);
        }

        // GET: PartController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PartController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Carr model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                _carrService.Create(model);

                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return View();
            }
        }

        // GET: PartController1/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _carrService.GetById(id);
            return View(model);
        }

        // POST: PartController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Carr model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                _carrService.Update(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PartController1/Delete/5
        public ActionResult Delete(int id)
        {
            var model = _carrService.GetById(id);
            return View(model);
        }

        // POST: PartController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Carr model)
        {
            try
            {
                _carrService.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
