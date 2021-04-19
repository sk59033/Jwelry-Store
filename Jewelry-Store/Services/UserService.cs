using Jewelry_Store.Helpers;
using Jewelry_Store.IGenericRepository;
using Jewelry_Store.IServices;
using Jewelry_Store.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Jewelry_Store.Services
{
    public class UserService : IUserService
    {
        private readonly IGenericRepository<Users> _genericRepository;
        private readonly AppSettings _appSettings;
        public UserService(IGenericRepository<Users> genericRepository, IOptions<AppSettings> appSettings)
        {
            _genericRepository = genericRepository;
            _appSettings = appSettings.Value;
        }
        public Users GetUser(string Username,string Password)
        {
            var user= _genericRepository.GetSingleOrDefault(x=>x.Username==Username && x.Password==Password);
            if (user == null)
                return null;

            // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Username.ToString()),
                    new Claim(ClaimTypes.Role, user.UserType)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);
            return user.WithoutPassword();
        }

        public void Register(Users user)
        {
            _genericRepository.Insert(user);
        }

        public IEnumerable<Users> GetAll()
        {
            var users= _genericRepository.GetAll();
            return users.WithoutPasswords();
        }

        public Users GetById(int id)
        {
            var user = _genericRepository.GetSingleOrDefault(x=>x.Id==id);
            return user.WithoutPassword();
        }

        public void UpdateUser(Users users)
        {
            _genericRepository.Update(users);
        }
        public void DeleteUser(int Id)
        {
            _genericRepository.Delete(Id);
        }
    }
}
