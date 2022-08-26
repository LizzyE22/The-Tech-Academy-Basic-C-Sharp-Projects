using System.Data.Entity;

// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

public class Student
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}

namespace FinalChallenge_Assignment
{

    public class StudentContext : DbContext
    {
        public StudentContext() : base()
        {

        }
        public DbSet<Student>? Students { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new StudentContext())
            {
                var stud = new Student() { FirstName = "Lizzy" };

                ctx.Students?.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}