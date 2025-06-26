using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _userService.GetAll();
            return result.Success ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _userService.GetById(id);
            return result.Success ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            var result = _userService.Add(user);
            return result.Success ? Ok(result) : BadRequest(result);
        }
    }
}
