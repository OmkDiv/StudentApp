using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StudentApp.Data;
using System;
using System.Linq;

namespace StudentApp.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new StudentAppContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<StudentAppContext>>()))
        {
            // Look for any movies.
            if (context.Student.Any())
            {
                return;   // DB has been seeded
            }
            context.Student.AddRange(
                new Student
                {
                    Names = "Omkar Divekar",
                    JoinDate = DateTime.Parse("2014-08-01"),
                    Branch = "Mechanical Engineering",
                    Division = "A",
                    College = "P.E.S MCOE"
                },
                new Student
                {
                    Names = "Anil Dedhe",
                    JoinDate = DateTime.Parse("2016-08-01"),
                    Branch = "Mechanical Engineering",
                    Division = "A",
                    College = "Trinity"
                },
                new Student
                {
                    Names = "Nikhil Phadke",
                    JoinDate = DateTime.Parse("2014-08-01"),
                    Branch = "Computer Engineering",
                    Division = "A",
                    College = "MMCOE"
                },
                new Student
                {
                    Names = "Vaibhav Shetiya",
                    JoinDate = DateTime.Parse("2014-08-01"),
                    Branch = "Mechanical Engineering",
                    Division = "A",
                    College = "BITS PILANI"
                }
            );
            context.SaveChanges();
        }
    }
}