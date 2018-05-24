using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace HelloWorldMvcApp.Models
{
    public class HelloWorldContext : DbContext
    {
        public HelloWorldContext(DbContextOptions<HelloWorldContext> options)
        : base(options)
        { }


        public DbSet<Student> Student { get; set; }
        public DbSet<Grades> Grades { get; set; }
       



    }
}