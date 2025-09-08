using Domain.Entities;
using Infrastructure.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class DomeRepository : IDomeRepository
    {
        private static readonly List<Dome> _domes = new();
        private static int _nextId = 1;

        public Task<Dome> AddAsync(Dome dome)
        {
            dome.Id = _nextId++;
            _domes.Add(dome);
            return Task.FromResult(dome);
        }

        public Task<Dome> GetByIdAsync(int id)
        {
            var dome = _domes.FirstOrDefault(d => d.Id == id);
            return Task.FromResult(dome);
        }

        public Task<IEnumerable<Dome>> GetAllAsync()
        {
            return Task.FromResult(_domes.AsEnumerable());
        }

        public Task<Dome> UpdateAsync(Dome dome)
        {
            var existing = _domes.FirstOrDefault(d => d.Id == dome.Id);
            if (existing != null)
            {
                existing.Name = dome.Name;
                existing.Description = dome.Description;
            }
            return Task.FromResult(existing);
        }

        public Task<bool> DeleteAsync(int id)
        {
            var dome = _domes.FirstOrDefault(d => d.Id == id);
            if (dome != null)
            {
                _domes.Remove(dome);
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }
    }
}