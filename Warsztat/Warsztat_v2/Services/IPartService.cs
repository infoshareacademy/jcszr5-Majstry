using Warsztat_v2.Models;

namespace Warsztat_v2.Services
{
    public interface IPartService
    {
        void Update(Part model);
        List<Part> GetAll();
        void Delete(int id);
        Part GetById(int id);
        void Create(Part part);
        void SaveToFile();
        int GetNextId();



    }
}