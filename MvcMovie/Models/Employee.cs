using System.ComponentModel.DataAnnotations;
namespace MvcMovie;
 
public class Employee:Person
{
    public string EmployeeID { get; set; }
    public int Age { get; set; }
}