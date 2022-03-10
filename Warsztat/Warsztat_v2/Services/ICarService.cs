using Warsztat_v2.Models;
//Dodane tymczasowo JA
namespace Warsztat_v2.Services
{
    public interface ICarService
    {
        void Update(Carr model);
        public List<Carr> GetAll();
        void Delete(int id);
        Carr GetById(int id);
        void Create(Carr carr);
        void SaveToFile();
        int GetNextId();
    }
}