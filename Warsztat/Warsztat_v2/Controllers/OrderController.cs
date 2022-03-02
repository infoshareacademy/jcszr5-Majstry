using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Warsztat_v2.Models;
using Warsztat_v2.Services;

namespace Warsztat_v2.Controllers
{
    public class OrderController : Controller
    {
        private OrderService _orderService;
        public OrderController()
        {
         _orderService = new OrderService();
        }
        // GET: OrderController
        public ActionResult Index()
        {
           var model = _orderService.GetAll();
           return View(model);
        }

        // GET: OrderController/Details/5
        public ActionResult Details(int id)
        {
            var model = _orderService.GetById(id);
            return View(model);
        }

        // GET: OrderController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Order model)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return View(model);
                }
                _orderService.Create(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderController/Edit/5
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

        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderController/Delete/5
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
