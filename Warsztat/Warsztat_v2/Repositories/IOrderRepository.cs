using Warsztat_v2.Models;

namespace Warsztat_v2.Repositories
{
    public interface IOrderRepository
    {
        public void SaveToFile(List<Order> orders);
        List<Order> ReadFromFile();
    }
}