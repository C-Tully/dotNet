using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CEMS.Api.Data;
using CEMS.Api.Data.Models;

namespace CEMS.Api.Controllers
{
  [ApiController]
  [Route("api/[controller]")]

  private AppDbContext _context;

  public EmployeesController(AppDbContext context)
  {
    _context = context;
  }

  //Get: api/employees
  [HttpGet]

  public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
  {
    return await _context.Employees.ToListAsync();
  }

  //Get api/Employees/{id}
  public async Task<ActionResult<Employee>> GetEmployee(int id)
  {
    var employee = await _context.Employees.FindAsync(id);

    if (employee == null)
      return NotFound();

    return employee;
  }

  //Post: api/employees
  [HttpPost]
  public async Task<ActionResult<Employee>> CreateEmployee(Employee employee)
  {
    _context.Employees.Add(employee);
    await _context.SaveChangesAsync();

    return CreatedAtAction(nameof(GetEmployee), new { id = employee.EmployeeId }, employee);
  }

  // PUT api/employees/{id}
  public async Task<IActionResult> UpdateEmployee(int id, Employee employee)
  {
    if (id != employee.EmployeeId)
      return BadRequest();

    _context.Entry(employee).State = EntityState.Modified;

    try
    {
      await _context.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
      if (!_context.Employees.Any(e => e.EmployeeId == id))
        return NotFound();
      throw;
    }

    return NoContent();
  }

  //Delete: api/employees/{id}
  [HttpDelete("{id}")]
  public async Task<IActionResult> DeleteEmployee(int id)
  {
    var employee = _context.Employees.FindAsync(id);
    if (employee == null)
      return NotFound();

    _context.Employees.Remove(employee);
    await _context.SaveChangesAsync();

    return NoContent();

  }

}