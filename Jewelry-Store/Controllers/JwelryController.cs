using Jewelry_Store.IServices;
using Jewelry_Store.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jewelry_Store.Helpers;
namespace Jewelry_Store.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class JwelryController : ControllerBase
    {
        private IJwelryService _jwelryService;
        public JwelryController(IJwelryService jwelryService)
        {
            this._jwelryService = jwelryService;
        }

        [HttpGet("GetAllJwelries")]
      
        public IActionResult GetAllJwelries()
        {
            var jwelries= _jwelryService.GetAllJwelries();
            if(!jwelries.Any())
            {
                return NotFound("No Records found");
            }
            return Ok(jwelries);
        }

        [HttpGet("GetJwelryById")]
        public IActionResult GetJwelryById(int Id)
        {
            var jwelry = _jwelryService.GetJwelryById(Id);
            if (jwelry == null)
            {
                return NotFound("No Records found");
            }
            return Ok(jwelry);
        }

        [HttpPost("CreateJwelry")]
        public IActionResult CreateUser(Jwelry model)
        {
              model.TotalPrice= CalculateTotalDiscountPrice.CalculateTotalDiscount(model);
            _jwelryService.CreateJwelry(model);
            return Ok();
        }

        [HttpPut("UpdateJwelry")]
        public IActionResult UpdateJwelry(Jwelry model)
        {
            model.TotalPrice = CalculateTotalDiscountPrice.CalculateTotalDiscount(model);
            _jwelryService.UpdateJwelry(model);
            return Ok();
        }
        [HttpDelete("DeleteJwelry")]
        public IActionResult DeleteJwelry(int Id)
        {
            _jwelryService.DeleteJwelry(Id);
            return Ok();
        }

        [Authorize(Roles = "Privileged")]
        [HttpPost("CalculateTotalPrice")]
        public IActionResult CalculateTotalPrice(Jwelry model)
        {
            model.TotalPrice = CalculateTotalDiscountPrice.CalculateTotalDiscount(model);
            _jwelryService.CreateJwelry(model);
            return Ok(model);
        }
    }
}
