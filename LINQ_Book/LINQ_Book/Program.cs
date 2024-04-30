using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Book
{
    //Create a comprehensive library catalog system that includes multiple libraries, each containing various branches.
    //Use Dictionary and List to manage collections of books, authors, and library branches.
    //Implement features such as searching for books by title or author, checking the availability of a specific book, and updating information when new books are added or borrowed.
   // Given a list of customer records, filter out customers who have made purchases in the last month, and create a new list wit Manage a list of orders and group them by product category.Calculate the total sales for each category.
    class Books
    {
        public int Id {  get; set; }
        public string BookName { get; set; }
        public string author {  get; set; }
        public string CustomerName {  get; set; }
        public DateTime DateTime { get; set; }
        public static List<Books> GetAllInfo()
        {
            List<Books> list = new List<Books>()
            {
                new Books() { Id = 1,BookName="Sri",author="ram",CustomerName="Prabhas",DateTime= new DateTime(2024,1,12)},
                new Books() { Id = 2,BookName="sai",author="Author",CustomerName="Allu arjun",DateTime=new DateTime(2024,2,26)},
                new Books() { Id = 3,BookName="ANOTA",author="puri",CustomerName="NTR",DateTime = new DateTime(2024,3,26)}
            };
            return list;
        }
        static void Main(string[] args)
        {
            int count = 0;
            var c = (from books in GetAllInfo() select books).Count();
            Console.WriteLine(c);
            var search = (from books in GetAllInfo() where books.author == "ram" select books);
            foreach (var book in search)
            {
                Console.WriteLine("search the book their author" + " " + book.BookName);
            }
            var a = (from books in GetAllInfo() where books.BookName == "Sri" select books).Count();
            count++;
            if (count == 0)
            {
                Console.WriteLine("no book found");
            }
            else if (count >= 1) 
            {
                Console.WriteLine("books found");
            }
            var b=(from books in GetAllInfo() select books).Count();
            Console.WriteLine(b);
            if (b > 3)
            {
                Console.WriteLine("books are added");
            }
            else if (b <3)
            {
                Console.WriteLine("books are borrowed");
            }
            else if(b==b)
            {
                Console.WriteLine("no books are added or  ");
            }
            
            Console.WriteLine("last month ");
            DateTime res = DateTime.Now.AddMonths(-1);
            Console.WriteLine(res);
        }
    }
}
