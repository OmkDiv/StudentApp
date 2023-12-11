using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace StudentApp.Models;

public class StudentGenreViewModel
{
    public List<Student>? Students { get; set; }
    public SelectList? Branch { get; set; }
    public string? StudentBranch { get; set; }
    public string? SearchString { get; set; }
}