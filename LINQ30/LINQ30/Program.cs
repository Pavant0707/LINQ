using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] a = { 1, 2, 3, 4, 5 };
            //var a2 = a.Where(w=>w%2==0);
            //var a3=(from  x in a  where x%2==0 select x).ToList();
            //foreach(var w in a3)
            //{
            //    Console.WriteLine(w);
            //}

            //int[] a= { 1, 2, 3 ,4,5,-1,-2};
            ////var a1=a.Where(w=>w>0 && w>=12);
            //var a2=(from  x in a  where x>0 && x<12 select x).ToList();
            ////var a3=(from x in a where x>0 where x<12 select x).Tolist();
            //foreach(var w in a2)
            //{
            //    Console.WriteLine(w);
            //}

            //int[] a = { 1, 2, 3, 4, 5 };
            //var b=from emp in a let sq =emp*emp where sq>0 select emp;
            //foreach (var x in b)
            //{ 
            //    Console.WriteLine(x);
            //}
            // var c = (from emp in a group emp by emp into y select y);
            //foreach(var x in c)
            // {
            //     Console.WriteLine(x.Key+" "+x.Count());
            // }

            //String s = "virat";
            //var a = (from emp in s group emp by emp into y select y);
            //foreach (var x in a)
            //{
            //    Console.WriteLine(x.Key + " " + x.Count());
            //}

            //String[] strings = { "Sunday", "Monday", "Tuesday", "wednesday", "Thrusday", "Friday", "saturday" };
            //var d = from emp in strings select emp;
            //foreach ( var x in d )
            //{
            //    Console.WriteLine(x);
            //}

            //int[] a = { 1, 2,2, 3, 4, 5, 6, 7 };
            //var b = (from x in a group x by x into y select y).ToList();
            //foreach (var x in b)
            //{
            //    Console.WriteLine(x.Key + " " + x.Count() + " " + x.Key * x.Count());
            //}

            List<int> list = new List<int>();
            list.Add(80);
            list.Add(85);
            list.Add(90);
            //var a=list.Where(w=>w>80).ToList();
            var b=from emp in list where emp >80 select emp ;
            foreach (int i in b)
            {
                Console.WriteLine(i);
            }
           
            
        }
    }
}
