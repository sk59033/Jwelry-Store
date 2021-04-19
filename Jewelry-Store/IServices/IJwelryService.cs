using Jewelry_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jewelry_Store.IServices
{
    public interface IJwelryService
    {
        IEnumerable<Jwelry> GetAllJwelries();
        Jwelry GetJwelryById(int Id);
        void CreateJwelry(Jwelry jwelry);
        void UpdateJwelry(Jwelry jwelry);
        void DeleteJwelry(int Id);
    }
}
