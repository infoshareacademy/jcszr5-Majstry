using System.Text.Json;
using Warsztat.BLL.Models;

namespace Warsztat.BLL.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public void SaveToFile(List<Order> orders)
        {
            string json = JsonSerializer.Serialize(orders);
            File.WriteAllText(@"D:\InfoShaREaCADEMY\Projekt\Web App V.r\jcszr5-Majstry\Warsztat\Warsztat_v2\OrderList.json", json);
        }
        //@"D:\InfoShaREaCADEMY\Projekt\Web app v.2\Service WebApp\jcszr5-Majstry\Warsztat\Warsztat_v2\OrderList.json"
        public List<Order> ReadFromFile()
        {
            string jsonFromFile = File.ReadAllText(@"D:\InfoShaREaCADEMY\Projekt\Web App V.r\jcszr5-Majstry\Warsztat\Warsztat_v2\OrderList.json");
            //D:\InfoShaREaCADEMY\Projekt\Web app v.2\Service WebApp\jcszr5-Majstry\Warsztat

            List<Order> orderFromFile = JsonSerializer.Deserialize<List<Order>>(jsonFromFile);

            return orderFromFile;
        }
    }
}



