using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyAccountProject.Filters;
using MyAccountProject.Model;
using System;
using System.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyAccountProject.Controllers
{
    [ValidateUserSession]
    public class UserProfileController : Controller
    {
        private DatabaseContext _context;

        public UserProfileController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Profile()
        {
            try
            {
                var profile = Userinformation(Convert.ToInt32(HttpContext.Session.GetString("UserID")));
                return View(profile);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IActionResult LoadUserProfilesData()
        {
            try
            {
                var draw = HttpContext.Request.Form["draw"].FirstOrDefault();
                var start = Request.Form["start"].FirstOrDefault();
                var length = Request.Form["length"].FirstOrDefault();

                var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
                var sortColumnDir = Request.Form["order[0][dir]"].FirstOrDefault();
                var searchValue = Request.Form["search[value]"].FirstOrDefault();

                int pageSize = length != null ? Convert.ToInt32(length) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;
                int recordsTotal = 0;

                var v = UserinformationList(sortColumn, sortColumnDir, searchValue);
                recordsTotal = v.Count();
                var data = v.Skip(skip).Take(pageSize).ToList();
                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AddAdmin(Registration entity)
        {
            _context.Registration.Add(entity);
            _context.SaveChanges();
        }

        public RegistrationViewModel Userinformation(int UserID)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<RegistrationViewModel> UserinformationList(string sortColumn, string sortColumnDir, string Search)
        {
            throw new System.NotImplementedException();
        }
    }
}