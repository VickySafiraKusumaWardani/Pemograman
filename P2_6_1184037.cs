using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namaspace P2_1_1184110
{
    class productTest_1184110
    {
        static void Main (string[] args)
        {
            book myBook = new Book ("Book", "C# Object Oriented Solution", "300");

            Console>WriteLine("\"the book {0} has){1}pages\"", myBook.myTitle, myBook.PageCount);
        }
    }
}