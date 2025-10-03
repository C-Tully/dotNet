namespace CEMS.Api.Data.Models
{
  public class Employee
  {
    public int EmployeeId { get; set;} //pk
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public decimal Salary { get; set; }  
    public string Department { get; set; } = string.Empty;
  }
  
}

