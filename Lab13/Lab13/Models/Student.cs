using System.ComponentModel.DataAnnotations;

namespace Lab13.Models;

public class Student
{
    [Required] public string Name { get; set; } = "";
    [Required(ErrorMessage = "Please enter a Age" )]
    [Range(18,60,ErrorMessage = "Age must be between 18 and 60")]
    public int Age { get; set; }

    [Required(ErrorMessage = "Please enter a Email Address")]
    [EmailAddress(ErrorMessage = "Please enter a valid Email Address")]
    public string Email { get; set; } = "";
    [Required(ErrorMessage = "Please Select a Date of Birth" )]
    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }
    [Required(ErrorMessage = "Please enter a Salary" )]
    [Range(10000,100000, ErrorMessage = "Salary must be between 10000 and 100000")]
    public decimal Salary { get; set; }
    [Required(ErrorMessage = "Please enter a Password" )]
    [MinLength(8,ErrorMessage = "Password must have at least 8 characters")]
    public string Password  { get; set; }
    [Required(ErrorMessage = "Please enter a Confirm Password" )]
    [Compare("Password",ErrorMessage = "Password and Confirm Password do not match")]
    public string ConfirmPassword { get; set; }
}