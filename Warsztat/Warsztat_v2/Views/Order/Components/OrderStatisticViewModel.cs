using Warsztat.BLL.Services;
using Warsztat.BLL.Enums;

namespace Warsztat_v2.Views.Order.Components
{
    public class OrderStatisticViewModel
    {
        public int _waitingOrders { get; set; }
        public int _inVerivicationOrders { get; set; }
        public int _inProgressOrders { get; set; }
        public int _finishedOrders { get; set; }
        public int _cacncelledOrders { get; set; }

        //IOrderService _orderService;
        //public int _waitingOrders { get; set; }
        //public int _inVerivicationOrders { get; set; }
        //public int _inProgressOrders { get; set; }
        //public int _finishedOrders { get; set; }
        //public int _cacncelledOrders { get; set; }

        //public OrderStatisticViewModel(IOrderService orderService)
        //{
        //    _orderService = orderService;

        //    _waitingOrders = CalculateWaitingOrders();
        //    _inVerivicationOrders = CalculateInVerivicationOrders();
        //    _inProgressOrders = CalculateInProgresOrders();
        //    _finishedOrders = CalculateFinishedOrders();
        //    _cacncelledOrders = CalculateCanceledOrders();
        //}



        //public int CalculateWaitingOrders()
        //{
        //     _waitingOrders = _orderService.GetAll().Select(s => s.Status == Status.Waiting).Count();

        //    return _waitingOrders;
        //}
        //public int CalculateInVerivicationOrders()
        //{
        //     _inVerivicationOrders = _orderService.GetAll().Select(s => s.Status == Status.Verification).Count();

        //    return _inVerivicationOrders;
        //}
        //public int CalculateInProgresOrders()
        //{
        //    _inProgressOrders = _orderService.GetAll().Select(s => s.Status == Status.InProgress).Count();

        //    return _inProgressOrders;
        //}
        //public int CalculateFinishedOrders()
        //{
        //     _finishedOrders = _orderService.GetAll().Select(s => s.Status == Status.Finished).Count();

        //    return _finishedOrders;
        //}
        //public int CalculateCanceledOrders()
        //{
        //     _cacncelledOrders = _orderService.GetAll().Select(s => s.Status == Status.Cancelled).Count();

        //    return _cacncelledOrders;
        //}

    }
}
