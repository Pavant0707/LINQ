using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQS
{
    public  class Employee
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public string Department {  get; set; }
        public static List<Employee> GetAllEmployee() { 
        List<Employee> employees = new List<Employee>()
        {
            new Employee() { ID = 1,Name="Ram",Department="IT"},
            new Employee() { ID = 2,Name="sai",Department="Doctor"},
            new Employee() { ID = 3,Name="tej",Department="IT"},
            new Employee() { ID = 4,Name="tom",Department="IT"},
            new Employee() { ID = 5,Name="jon",Department="Doctor"},
            new Employee() { ID = 6,Name="prabas",Department="IT"}

        };return employees;
        }
        static void Main(string[] args)
        {
            var order=(from emp in Employee.GetAllEmployee() orderby emp.Department select emp).ToList();
            var orederr1 = Employee.GetAllEmployee().OrderBy(w => w.ID);
              
            // var a = Employee.GetAllEmployee();
            // var b = (from emp in Employee.GetAllEmployee() select emp).ToList();
            // foreach( var emp in a )
            // {
            //    // Console.WriteLine(emp.Name);
            // }
            // var c = Employee.GetAllEmployee().Where(w=>w.Department=="IT").ToList();
            // var d = (from emp in Employee.GetAllEmployee() where emp.Department == "IT" select emp).ToList();
            // foreach ( var emp in c)
            // {
            //    // Console.WriteLine(emp.Name);
            // }
            //var x = Employee.GetAllEmployee().Select(w => w.Department).Distinct();
            //var y = (from emp in Employee.GetAllEmployee() select emp.Department).Distinct().ToList();
            //foreach (var emp in y)
            //{
            //    //Console.WriteLine();
            //}
            // var g = Employee.GetAllEmployee().Single(emp=>emp.ID==3);
            // var a1 = (from emp in Employee.GetAllEmployee() select emp).Single(w=>w.ID==2);
            //// Console.WriteLine(a1.Name);
            // var b1 = Employee.GetAllEmployee().First();
            // var b2=(from emp in Employee.GetAllEmployee() select emp).First();
            // //Console.WriteLine(b1.Name);
            // var c1=Employee.GetAllEmployee().FirstOrDefault(w=>w.Department=="IT");
            // var c2 = (from emp in Employee.GetAllEmployee() select emp).FirstOrDefault(w => w.Department == "IT");
            // Console.WriteLine(c2.Name);
            // var x1 = Employee.GetAllEmployee().Last();
            // var x2=(from emp in Employee.GetAllEmployee() select emp).Last();
            // Console.WriteLine(x1.Name);
            // var y1 = Employee.GetAllEmployee().LastOrDefault();
            // var y2=(from emp in GetAllEmployee() select emp).LastOrDefault();
            // Console.WriteLine(y1.Name);
            // var a = Employee.GetAllEmployee().All(w => w.Department == "IT");
            // var a1 = Employee.GetAllEmployee().All(w => w.ID >= 1);
            // var b = Employee.GetAllEmployee().Any(w => w.Department == "IT" && w.ID <= 2);
            // var  c = Employee.GetAllEmployee().OrderByDescending(w => w.Department);
            // foreach (var e in c) {
            //     Console.WriteLine(e.Name);
            //         }

            // var a2=Employee.GetAllEmployee().OrderBy(w => w.Department).ToList();
           // var a2=(from emp in Employee.GetAllEmployee() select emp).OrderBy(w=>w.Department).ToList();
            //var c2=(from emp in Employee.GetAllEmployee() orderby emp.Department select emp).ToList();
            //foreach (var emp in a2)
           // {
                //Console.WriteLine(emp.Name);
           // }

            // var h=Employee.GetAllEmployee().Select(w=>w.Name).Reverse().ToList();
            // var a4 = (from emp in Employee.GetAllEmployee() select emp.Name).Reverse();  
            // foreach(var emp in h)
            // {
            //     Console.WriteLine(emp);
            // }
            // var i = Employee.GetAllEmployee().Average(s => s.ID);
            //var i=(from emp in Employee.GetAllEmployee() select emp).Average(w => w.ID);
            // Console.WriteLine(i);
            // var i1=Employee.GetAllEmployee().Where(w=>w.Department=="IT").Average(s => s.ID);
            // var i1=(from emp in Employee.GetAllEmployee() where emp.Department=="IT" select emp).Average(w => w.ID);
            // Console.WriteLine(i1);
            //   var sum=Employee.GetAllEmployee().Sum(w=>w.ID);
            //   var sum1 = (from emp in Employee.GetAllEmployee() select emp).Max(w => w.ID); 
            //  Console.WriteLine(sum1);
            //    var skip = Employee.GetAllEmployee().Select(w=>w.ID).Skip(2);
            //    var skip1=Employee.GetAllEmployee().Where(w=>w.Department=="IT").Skip(1);
            //  foreach (var emp in skip1)
            //  {
            //        Console.WriteLine(emp.Name);
            //  }
            //    var take = Employee.GetAllEmployee().Select(w=>w.Department).Take(2);
            //   foreach (var emp in take)
            //    {
            //       Console.WriteLine(emp);
            //    }
            //   var takewhile=Employee.GetAllEmployee().TakeWhile(x=>x.Name.Length>2);
            //    foreach(var emp in takewhile)
            //    {
            //        Console.WriteLine(emp.Name); 
            //    }
            //    var count=Employee.GetAllEmployee().Where(w=>w.Department=="IT").Count();
            //    var c2=(from emp in Employee.GetAllEmployee() where emp.Name.Length>4 select emp).Count();
            //    var c3=(from emp in Employee.GetAllEmployee() where emp.Department=="IT" select emp).Count();   
            //    Console.WriteLine(c2);
        }
    }
}
