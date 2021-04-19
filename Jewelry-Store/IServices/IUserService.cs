using Jewelry_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jewelry_Store.IServices
{
    public interface IUserService
    {
        Users GetUser(string Username,string Password);
        void Register(Users user);
        void UpdateUser(Users users);
        void DeleteUser(int Id);
        IEnumerable<Users> GetAll();
        Users GetById(int id);

    }
}
