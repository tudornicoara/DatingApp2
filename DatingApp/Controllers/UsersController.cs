using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.Data;
using DatingApp.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            if (!_context.Users.Any())
                return NotFound();

            var users = await _context.Users.ToListAsync();
            return Ok(users);
        }
        
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<AppUser>> GetUser(Guid id)
        {
            var user = await _context.Users.FindAsync(id);
            
            if (user == null)
                return NotFound();
            
            return Ok(user);
        }
    }
}
