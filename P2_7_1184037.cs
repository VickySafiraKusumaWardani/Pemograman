using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namaspace P2_1_1184110
{
    public class Book: Product 
    {
        Protected string PageCount;
        public Book (string type, string title, string PageCount)
        : base. PageCount = PageCount;
        {
            this.PageCount = PageCount;
        }
        public string PageCount
        {
            get 
            {
                retrun PageCount;
            }
            Set 
            {
                PageCount = value;
            }
        }
    }
}