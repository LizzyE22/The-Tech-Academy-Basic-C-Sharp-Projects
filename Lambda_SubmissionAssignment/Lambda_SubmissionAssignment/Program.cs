using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_SubmissionAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            
            //List of 10 employees, 2 with same name "Joe"
            List<Employee> EmployeeList = new List<Employee>() {
            new Employee(){Id = 1, FirstName = "Liz", LastName = "Wiz"},
            new Employee(){Id = 2, FirstName = "Bob", LastName = "Nob"},
            new Employee(){Id = 3, FirstName = "James", LastName = "Claims"},
            new Employee(){Id = 4, FirstName = "Lori", LastName = "Story"},
            new Employee(){Id = 5, FirstName = "Joe", LastName = "Blow"},
            new Employee(){Id = 6, FirstName = "Cindy", LastName = "Windy"},
            new Employee(){Id = 7, FirstName = "Jan", LastName = "Fan"},
            new Employee(){Id = 8, FirstName = "Bill", LastName = "Gill"},
            new Employee(){Id = 9, FirstName = "Joe", LastName = "Snow"},
            new Employee(){Id = 10, FirstName = "Mary", LastName = "Scary"}
            };
            //Creating new List
            List<Employee> JoeList1 = new List<Employee>();

            //foreach loop finding first name Joe
            foreach (Employee item in EmployeeList)
            {
                if (item.FirstName == "Joe")
                {
                    JoeList1.Add(item);
                    Console.WriteLine(item.FirstName);
                    Console.ReadLine();
                }


            }

            //Same assignment with Lambda expression
            List<Employee> JoeList2 = EmployeeList.Where(x => x.FirstName == "Joe").ToList();

            foreach (Employee employee1 in JoeList2)
            {
                Console.WriteLine(employee1.FirstName);
                Console.ReadLine();

            }


            //Lambda expression, listing all employees with ID greater than 5
            List<Employee> IdList = EmployeeList.Where(x => x.Id > 5).ToList();

            foreach (Employee employeeId in IdList)
            
                Console.WriteLine(employeeId.Id);
                Console.ReadLine();
            

            
        }


    }
}
        
    

