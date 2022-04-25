﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Warsztat.BLL.Services;
using Warsztat.BLL.Models;
using Warsztat.BLL.Enums;
//using Warsztat.BLL.Models;

using Warsztat_v2.Repositories.Interfaces;
using Warsztat_v2.Data;

namespace Warsztat_v2.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository _orderRepository;
        private ServiceContext _context;
        private CarService _carrService;//
        private EmployeeService _employeeService;//
        //private IPartRepository _partRepository;//

        public OrderController(ServiceContext context, IOrderRepository orderRepository/*IPartRepository partRepository*//*,ICarService carService*/)
        {
            _context = context;
            _orderRepository = orderRepository;
            //_partRepository = partRepository;//
            _carrService = new CarService();//
            _employeeService = new EmployeeService();//
        }
        // GET: OrderController
        public ActionResult Index(string sortOrder, string searchStringForClient, string searchStringForOrderNumber, string searchStringForMechanic)
        {
            var model = _orderRepository.GetAll();


            //sortowanie po kolumnach
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            ViewBag.WaitingStatus = sortOrder == "Status" ? "WaitingStatus" : "Status";
            ViewBag.VerivicationStatus = sortOrder == "Status" ? "VerivicationStatus" : "Status";
            ViewBag.InProgressStatus = sortOrder == "Status" ? "InProgressStatus" : "Status";
            ViewBag.FinishedStatus = sortOrder == "Status" ? "FinishedStatus" : "Status";
            ViewBag.CancelledStatus = sortOrder == "Status" ? "CancelledStatus" : "Status";
            ViewBag.TotalOrders = sortOrder == "Status" ? "TotalOrders" : "Status";

            var orders = from o in model
                         select o;
            //sortowanie po kolumnach



            //Search box
            if (!String.IsNullOrEmpty(searchStringForClient))
            {
                orders = orders.Where(o => o.Client.ToUpper().Contains(searchStringForClient.ToUpper()));
            }
            if (!String.IsNullOrEmpty(searchStringForOrderNumber))
            {
                orders = orders.Where(o => o.OrderNumber.ToString().ToUpper().Contains(searchStringForOrderNumber.ToUpper()));
            }
            //if (!String.IsNullOrEmpty(searchStringForMechanic))
            //{
            //    orders = orders.Where(o => o.Mechanic.ToUpper().Contains(searchStringForMechanic.ToUpper()));
            //}
            //Search box

            //Switch do sortowania po kolumnach
            switch (sortOrder)
            {
                case "name_desc":
                    orders = orders.OrderByDescending(o => o.Client);
                    break;
                case "Date":
                    orders = orders.OrderBy(o => o.StartTime);
                    break;
                case "date_desc":
                    orders = orders.OrderByDescending(o => o.StartTime);
                    break;
                case "WaitingStatus":
                    orders = orders.Where(o => o.Status == Status.Waiting);
                    break;
                case "VerivicationStatus":
                    orders = orders.Where(o => o.Status == Status.Verification);
                    break;
                case "InProgressStatus":
                    orders = orders.Where(o => o.Status == Status.InProgress);
                    break;
                case "FinishedStatus":
                    orders = orders.Where(o => o.Status == Status.Finished);
                    break;
                case "CancelledStatus":
                    orders = orders.Where(o => o.Status == Status.Cancelled);
                    break;
                case "TotalOrders":
                    orders = _orderRepository.GetAll().ToList();
                    break;

                default:
                    orders = orders.OrderBy(o => o.Client);
                    break;
            }

            return View(orders);
        }

        // GET: OrderController/Details/5
        public ActionResult Details(int id)
        {
            var model = _orderRepository.GetById(id);
            return View(model);
        }

        // GET: OrderController/Create
        public ActionResult Create()
        {
            ViewBag.Cars = _context.Cars.ToList();
            ViewBag.Parts = _context.Parts.ToList();
            ViewBag.Mechanics = _context.Employees.Where(e => e.Role == Role.Mechanic).ToList();
            //ViewBag.Employees = _employeeService.GetAll().ToList();

            //var model = new CreateOrderViewModel()
            //{
            //    Cars = _carrService.GetAll(),
            //    Parts = _partService.GetAll(),
            //    Employees = _employeeService.GetAll().Where(e => e.Role == Role.Mechanic).ToList()
            //};

            return View(/*model*/);

        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Order model)
        {
            try
            {
                model.OrderNumber = _orderRepository.OrderNumberGenerator(model/*.RegistrationNumber, model.StartTime.ToString("yyyy"), model.Id.ToString()*/);
                _orderRepository.Add(model);
                if (ModelState.IsValid)
                {
                    return View(model);
                }
                // _orderService.Create(model);
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
            ViewBag.Cars = _context.Cars.ToList();
            ViewBag.Parts = _context.Parts.ToList();
            ViewBag.Mechanics = _context.Employees.Where(m => m.Role == Role.Mechanic).ToList();


            var model = _orderRepository.GetById(id);
            return View(model);
        }

        // POST: OrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Order model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return View(model);
                }
                _orderRepository.Update(model);
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
            var model = _orderRepository.GetById(id);
            return View(model);
        }

        // POST: OrderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Order model)
        {
            try
            {
                _orderRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
