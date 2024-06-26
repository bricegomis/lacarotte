using LaCarotte.API.Models;

namespace LaCarotte.API.Manager
{
    public interface ICarotteManager
    {
        Task<Carotte> GetCarotte(string id);
        Task<List<Carotte>> GetAllCarottes();
        Task FinishCarotte(Carotte carotte);
        Task UpdateCarotte(Carotte carotte);
        Task DeleteCarotte(string id);
        Task CreateCarotte(Carotte carotte);
        Profile? GetProfile();
    }
}