using Warsztat_v2.Models;

namespace Warsztat_v2.Services
{
    public interface IOrderService
    {
        string OrderNumberGenerator(Order order);
        List<Order> GetAll();
        Order GetById(int id);
        void Create(Order order);
        int GetNextId();
        void Update(Order model);
        void Delete(int id);
    }
}