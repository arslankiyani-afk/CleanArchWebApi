using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services
{
    public class DomeService : IDomeService
    {
        private readonly IDomeRepository _repository;

        public DomeService(IDomeRepository repository)
        {
            _repository = repository;
        }

        public async Task<Dome> CreateAsync(Dome dome)
        {
            return await _repository.AddAsync(dome);
        }

        public async Task<Dome> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Dome>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Dome> UpdateAsync(Dome dome)
        {
            return await _repository.UpdateAsync(dome);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}