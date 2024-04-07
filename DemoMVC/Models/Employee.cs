using System.ComponentModel.DataAnnotations;
namespace DemoMVC.Models;
public class Employee : Person
{
    public string Employeeid {get;set;}
    public int Age {get; set;}
    
    

}