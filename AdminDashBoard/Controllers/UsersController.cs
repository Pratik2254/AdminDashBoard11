using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AdminDashBoard.Models;

namespace AdminDashBoard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DashboardContext _context;

        public UsersController(DashboardContext context)
        {
            _context = context;
        }

        [HttpGet("GetAllUsers")]
        public IActionResult GetUsers()
        {
            var users = _context.Users.ToList();
            return Ok(users);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var users = _context.Users.FirstOrDefault(o => o.UserId == id);
            return Ok(users);
        }

        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            var users = _context.Users.FirstOrDefault(o => o.UserId == id);
            if (users != null)
            {
                _context.Remove(users);
                _context.SaveChanges();
                return Ok(true);
            }
            return Ok(false);
        }

        [HttpPost("Create")]
        public IActionResult Create(User _users)
        {
            var users = _context.Users.FirstOrDefault(o => o.UserId == _users.UserId);
            if (users != null)
            {
                users.Fname = _users.Fname;
                users.Lname = _users.Lname;
                users.Email = _users.Email;
                users.Password = _users.Password;



            }
            else
            {
                _context.Users.Add(_users);
                _context.SaveChanges();

            }
            return Ok(true);



        }

        [HttpPut("Update")]
        public IActionResult Put(string id, User user_update)
        {
            // Retrieve the user from the database based on the provided UserId
            var user = _context.Users.FirstOrDefault(u => u.UserId == user_update.UserId);
            if (user == null)
            {
                return NotFound();
            }

            // Update the user properties with the provided values
            user.Fname = user_update.Fname;
            user.Lname = user_update.Lname;
            user.Email = user_update.Email;
            user.Password = user_update.Password;

            _context.SaveChanges();

            return Ok();
        }
    }
}

