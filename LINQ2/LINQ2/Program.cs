using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ2
{
    //Develop a program to manage a catalog of products.Each product has properties like Name, Price, and Category.
    // Implement functionalities to filter products based on price range and category using LINQ.
     
    class Books
    {
        public string Name {  get; set; }
        public int price {  get; set; }
        public string Category { get; set; }
        public static List<Books> GetAllbooks()
        {
            List<Books> books = new List<Books>()
            {
                new Books{Name="Science", price=100,Category="study"},
                new Books{Name="Bagvathgita" ,price=150,Category="knowladge"},
                new Books{Name="Maths",price=200,Category="study"},
            };return books;
        }
        static void Main(string[] args)
        {
            var book = from books in GetAllbooks() where books.Category == "knowladge" where books.price >= 100 select books;
            foreach(var b in book)
            {
                Console.WriteLine(b.Name);
            }
        }
    }
}
