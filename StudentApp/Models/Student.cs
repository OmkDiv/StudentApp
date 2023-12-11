using System.ComponentModel.DataAnnotations;

namespace StudentApp.Models;

public class Student
{
    public int Id { get; set; }

    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Names { get; set; }

    [Display(Name = "Join Date")]
    [DataType(DataType.Date)]
    public DateTime JoinDate { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    [Required]
    [StringLength(100)]
    public string? Branch { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
    [Required]
    [StringLength(1)] 
    public string? Division { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
    [StringLength(50)]
    [Required]
    public string? College { get; set; }
}