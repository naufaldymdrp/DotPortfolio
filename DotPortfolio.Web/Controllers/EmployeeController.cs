using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DotPortfolio.Web.Data;
using DotPortfolio.Web.Models;

namespace DotPortfolio.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public EmployeeController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var employeeDatas = await _dbContext
                .Employees
                .Select(item => new EmployeeViewModel
                {
                    Id = item.Id,
                    Name = item.Name,
                    EmployDate = item.EmployDate
                })
                .ToListAsync();

            return View(employeeDatas);
        }
    }
}
