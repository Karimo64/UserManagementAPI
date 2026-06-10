using Microsoft.AspNetCore.Mvc;
using UserManagementAPI.Models;
using UserManagementAPI.Services;

namespace UserManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly UserService _service;

        public UsersController(UserService service)
        {
            _service = service;
        }

        // GET api/users
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _service.GetById(id);
            if (user == null)
                return NotFound(new { message = "User not found" });

            return Ok(user);
        }

        // POST api/users
        [HttpPost]
        public IActionResult Create(User user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var created = _service.Create(user);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        // PUT api/users/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, User user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var updated = _service.Update(id, user);
            if (!updated)
                return NotFound(new { message = "User not found" });

            return NoContent();
        }

        // DELETE api/users/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleted = _service.Delete(id);
            if (!deleted)
                return NotFound(new { message = "User not found" });

            return NoContent();
        }
    }
}
