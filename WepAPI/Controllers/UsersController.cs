using Business.Abstract;
using Core.Entites.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getbymail")]
        public IActionResult GetByMail(string email)
        {
            _userService.GetByMail(email);

            return Ok();

        }
        [HttpPost("add")]
        public IActionResult Add(User user)
        {

            _userService.Add(user);
            return Ok(user);

        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _userService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpGet("getusersbyid")]
        public IActionResult GetCarsByBrandIdDetail(int id)
        {
            var result = _userService.GetUsersById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
