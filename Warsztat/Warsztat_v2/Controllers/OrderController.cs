using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Warsztat.BLL.Services;
using Warsztat.BLL.Models;
using Warsztat.BLL.Enums;
using Warsztat.BLL.Models;

namespace Warsztat_v2.Controllers
{
    public class OrderController : Controller
    {
        private IOrderService _orderService;

        private CarService _carrService;//
        private EmployeeService _employeeService;//
        private IPartService _partService;//

        public OrderController(IOrderService orderService, IPartService partService/*,ICarService carService*/)
        {
            _orderService = orderService;
            _partService = partService;//
            _carrService = new CarService();//
            _employeeService = new EmployeeService();//
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
            ViewBag.Cars = _carrService.GetAll().ToList();
            ViewBag.Parts = _partService.GetAll().ToList();
            ViewBag.Mechanics = _employeeService.GetAll().Where(e => e.Role == Role.Mechanic).ToList();
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
                model.OrderNumber = _orderService.OrderNumberGenerator(model/*.RegistrationNumber, model.StartTime.ToString("yyyy"), model.Id.ToString()*/);
                _orderService.Create(model);
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
            ViewBag.Cars = _carrService.GetAll().ToList();
            ViewBag.Parts = _partService.GetAll().ToList();
            ViewBag.Mechanics = _employeeService.GetAll().Where(m => m.Role == Role.Mechanic).ToList();
           

            var model =_orderService.GetById(id);
            return View(model);
        }

        // POST: OrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Order model)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    return View(model);
                }             
                _orderService.Update(model);
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
            var model = _orderService.GetById(id);
            return View(model);
        }

        // POST: OrderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Order model)
        {
            try
            {
                _orderService.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
