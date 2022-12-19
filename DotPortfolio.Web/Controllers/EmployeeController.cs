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
        private readonly ILogger _logger;

        public EmployeeController(ApplicationDbContext dbContext, ILogger<EmployeeController> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(EmployeeViewModel employeeModel)
        {
            // server side validation
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("EmployeeViewModel state is not valid");
                return View();
            }

            // changes to EmployeeData
            var employeeData = new EmployeeData 
            {
                Name = employeeModel.Name,
                EmployDate = employeeModel.EmployDate,
                CreationDate = employeeModel.CreationDate
            };

            var result = _dbContext.Employees
                .AddAsync(employeeData);

            var changeResult = await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var employee = await _dbContext.Employees
                .Where(item => item.Id == id)
                .Select(item => new EmployeeViewModel
                {
                    Id = item.Id,
                    Name = item.Name,
                    EmployDate = item.EmployDate,
                    CreationDate = item.CreationDate
                })
                .FirstAsync();

            return View(employee);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EmployeeViewModel employee)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Input data is invalid");

                return View();
            }
            
            var employeeData = await _dbContext
                .Employees
                .Where(item => item.Id == employee.Id)
                .FirstAsync();
            
            _dbContext.Entry(employeeData)
                .CurrentValues
                .SetValues(employee);

            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var employee = await _dbContext.Employees
                .Where(item => item.Id == id)
                .FirstAsync();

            _dbContext.Employees.Remove(employee);

            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
