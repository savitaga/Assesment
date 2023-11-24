using EmployeeManagement.Business.Interfaces;
using EmployeeManagement.Business.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {        
        private readonly IUserService _userservice;

        public UserController(IUserService userservice)
        {
            _userservice = userservice;
        }

        [HttpGet("GetUsersByRole")]
        public async Task<IActionResult> GetUsersByRole()
        {
            var user = await _userservice.GetUsersByRole();
            return Ok(user);
        }

        [HttpGet("GetUsersWithNoRole")]
        public async Task<IActionResult> GetUsersWithNoRole()
        {
            var employees = await _userservice.GetUsersWithNoRole();
            return Ok(employees);
        }

    }
}
