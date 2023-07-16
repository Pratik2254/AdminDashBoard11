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
    public class LoginController : ControllerBase
    {
        private readonly DashboardContext _context;

        public LoginController(DashboardContext context)
        {
            _context = context;
        }

        [HttpGet("GetAllUsers")]
        public IActionResult GetUsers()
        {

            var users = _context.Logins.FromSqlRaw("spGetAllLogins").ToList();
            return Ok(users);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var users = _context.Logins.FirstOrDefault(o => o.UserId == id);
            return Ok(users);
        }
        //Api
        //[HttpDelete("Delete")]
        //public IActionResult Delete(int id)
        //{
        //    var users = _context.Logins.FirstOrDefault(o => o.UserId == id);
        //    if (users != null)
        //    {
        //        _context.Remove(users);
        //        _context.SaveChanges();
        //        return Ok(true);
        //    }
        //    return Ok(false);
        //}
        //Stored proc
        [HttpDelete("Delete")]
        public IActionResult Delete(int User_id)
        {
            var users = _context.Database.ExecuteSqlRaw($"spDeleteLogin {User_id}");
            if (users != null)
            {
                _context.Remove(users);
                _context.SaveChanges();
                return Ok(true);
            }
            return Ok(false);
        }

    [HttpPost("Create")]
        public IActionResult Create(Login _users)
        {
            var users = _context.Logins.FirstOrDefault(o => o.UserId == _users.UserId);
            if (users != null)
            {
                users.Email = _users.Email;
                users.Password = _users.Password;



            }
            else
            {
                _context.Logins.Add(_users);
                _context.SaveChanges();

            }
            return Ok(true);



        }

        [HttpPut("Update")]
        public IActionResult Put(string id, Login login_update)
        {
            // Retrieve the user from the database based on the provided UserId
            var user = _context.Logins.FirstOrDefault(u => u.UserId == login_update.UserId);
            if (user == null)
            {
                return NotFound();
            }

            // Update the user properties with the provided values
            
            user.Email = login_update.Email;
            user.Password = login_update.Password;

            _context.SaveChanges();

            return Ok();
        }
    }
}

