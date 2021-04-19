using Jewelry_Store.IGenericRepository;
using Jewelry_Store.IServices;
using Jewelry_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jewelry_Store.Services
{
    public class JwelryService : IJwelryService
    {
        private readonly IGenericRepository<Jwelry> _genericRepository;
        public JwelryService(IGenericRepository<Jwelry> genericRepository)
        {
            _genericRepository = genericRepository;
            
        }
        public void CreateJwelry(Jwelry jwelry)
        {
            _genericRepository.Insert(jwelry);
        }

        public void DeleteJwelry(int Id)
        {
            _genericRepository.Delete(Id);
        }

        public IEnumerable<Jwelry> GetAllJwelries()
        {
            return _genericRepository.GetAll();
        }

        public Jwelry GetJwelryById(int Id)
        {
            return _genericRepository.GetSingleOrDefault(x=>x.Id==Id);
        }

        public void UpdateJwelry(Jwelry jwelry)
        {
            _genericRepository.Update(jwelry);
        }
    }
}
