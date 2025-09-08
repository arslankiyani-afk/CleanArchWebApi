using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    public interface IDomeRepository
    {
        Task<Dome> AddAsync(Dome dome);
        Task<Dome> GetByIdAsync(int id);
        Task<IEnumerable<Dome>> GetAllAsync();
        Task<Dome> UpdateAsync(Dome dome);
        Task<bool> DeleteAsync(int id);
    }
}