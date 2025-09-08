using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IDomeService
    {
        Task<Dome> CreateAsync(Dome dome);
        Task<Dome> GetByIdAsync(int id);
        Task<IEnumerable<Dome>> GetAllAsync();
        Task<Dome> UpdateAsync(Dome dome);
        Task<bool> DeleteAsync(int id);
    }
}