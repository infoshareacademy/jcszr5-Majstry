using Microsoft.AspNetCore.Mvc;
using Warsztat.BLL.Services;
using Warsztat.BLL.Models;
using Warsztat.BLL.Enums;

namespace Warsztat_v2.Views.Order.Components
{
    public class OrderStatisticsViewComponent : ViewComponent
    {
        private readonly IOrderService _orderService;

        //private OrderStatisticViewModel _orderStatisticViewModel;
        public OrderStatisticsViewComponent(IOrderService orderService /*OrderStatisticViewModel orderStatisticViewModel*/)
        {
            //_orderStatisticViewModel = new OrderStatisticViewModel(orderService);
        
            _orderService= orderService;    
        }


        public IViewComponentResult Invoke( )
        {

            var viewModel = new OrderStatisticViewModel/*(_orderService)*/
            {
                //_waitingOrders =_orderStatisticViewModel.CalculateWaitingOrders(),
                //_inProgressOrders = _orderStatisticViewModel.CalculateInProgresOrders(),
                //_inVerivicationOrders = _orderStatisticViewModel.CalculateInVerivicationOrders(),
                //_finishedOrders = _orderStatisticViewModel.CalculateFinishedOrders(),
                //_cacncelledOrders = _orderStatisticViewModel.CalculateCanceledOrders(),
                _waitingOrders = _orderService.GetAll().Count(s=>s.Status == Status.Waiting),
                _inProgressOrders = _orderService.GetAll().Count(s => s.Status == Status.InProgress),
                _inVerivicationOrders = _orderService.GetAll().Count(s => s.Status == Status.Verification),
                _finishedOrders = _orderService.GetAll().Count(s => s.Status == Status.Finished),
                _cacncelledOrders = _orderService.GetAll().Count(s => s.Status == Status.Cancelled),

            };
            //viewModel._cacncelledOrders = viewModel.CalculateCanceledOrders();
            return View(viewModel);
        }
    }
}
