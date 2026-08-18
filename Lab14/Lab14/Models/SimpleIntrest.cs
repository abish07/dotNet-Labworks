using System.ComponentModel.DataAnnotations;

namespace Lab14.Models;

public class SimpleIntrest
{
    [Required(ErrorMessage = "The field {0} is required")]
    public decimal Principal { get; set; }
    [Required(ErrorMessage = "The field {0} is required")]
    public int Time { get; set; }
    [Required(ErrorMessage = "The field {0} is required")]
    public decimal Rate { get; set; }
    public decimal SimpleInterestAmount { get; set; }
}