using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using CobbleStoneAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace CobbleStoneAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Employees")]
    public class EmployeeController : Controller
    {//hooking controls to the models of the API

        private readonly CobbleStoneEmployeeDBContext _context;//contain reference to DbContext
        public EmployeeController(CobbleStoneEmployeeDBContext context)
        {//Db conext injected into readonly variable here
            _context = context;
        }


        private bool EmployeesExists(int id)
        {//check the dBContext if a certain id is present. return a bool after query result
            return _context.Employees.Any(c => c.id == id);
        }


        [HttpGet]
        [Produces(typeof(DbSet<Employees>))]
        public IActionResult GetEmployees()
        {
            var results = new ObjectResult(_context.Employees)
            {
                StatusCode = (int)HttpStatusCode.OK
                //maybe modify birthdate here to dd/mm/yyyy....
            };

            //add the number of employess being returned inside the header of the HttpResponse Object
            Request.HttpContext.Response.Headers.Add("X-Total-Count", _context.Employees.Count().ToString());
            
            return results;
        }

        [HttpGet("{id}", Name = "GetEmployee")]
        [Produces(typeof(DbSet<Employees>))]
        public async Task<IActionResult> GetEmployee([FromRoute] int id)
        {//async call to get an employee by id
         
            //run this method to check if you got back the Employee you were looking for, or even at all
            if (EmployeesExists(id))
            {
                //find emplyee based on id from query
                var employee = await _context.Employees.SingleOrDefaultAsync(e => e.id == id); 
                return Ok(employee);
            }
            else
                return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> PostEmployee([FromBody] Employees employee)//take in employee obj through API
        {
            //determine if all ModelState validations are correct
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return CreatedAtAction("getEmployee", new { id = employee.id }, employee);
        } 

        [HttpPut("{id}")]
        [Produces(typeof(DbSet<Employees>))]
        public async Task<IActionResult> PutEmployee([FromRoute] int id, [FromBody] Employees employee)
        {
            _context.Entry(employee).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(employee);
        }

        [HttpDelete("{id}")]
        [Produces(typeof(DbSet<Employees>))]
        public async Task<IActionResult> DeleteEmployee([FromRoute] int id)
        {
            var employee = await _context.Employees.SingleOrDefaultAsync(e => e.id == id);
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();//save changes
            return Ok(employee);//returns back employee that was deleted
        }

    }//end class
}
