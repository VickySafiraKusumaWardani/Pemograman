using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namaspace P2_1_1184110
{
    class productTest_1184110
    {
        static void Main(string[] args)
        {
            Book Product1 = new Book ("Book", "C# Object Oriented Sulution", "300");
            DVD Product2 = new DVD("Enternal Sunshine of The Spoless Mind", "145");

            Console.WriteLine("Product 1 is a {0} called \"{1}\" and has {2} pages", Product1.MyType, Product1.myTitle, Product1.PageCount);
            Console.WriteLine("Product 2 is a {0} called \"{1}\" and has {2} minutes duration",Product2.MyType, Product2.MyTitle, Product2.Duration);
        }
    }
}