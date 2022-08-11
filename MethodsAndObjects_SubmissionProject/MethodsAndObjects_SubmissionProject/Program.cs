using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects_SubmissionProject
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            //instantiating and initializing an Employee object with FirstName and LastName
            Employee employee = new Employee();
            employee.FirstName ="Sample";
            employee.LastName = "Student";
            //calling superclass method SayName() on Employee object
            employee.SayName();

            
            
            
            //public string Sample { get; set; }
            //public string Student { get; set; }

    }
}
}


//TwentyOneGame game = new TwentyOneGame();
////calling super class method, "game"
//game.Players = new List<string>() { "Lizzy", "Bill", "Joe" };
//game.ListPLayers();
//game.Play();
//Console.ReadLine();
