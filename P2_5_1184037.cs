using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namaspace P2_1_1184110
{
    class Product_1184110
    {
        private string myType;
        private string myTitle;

        public Product()
        {

        }

        public Product(string type, string title)
        {
            this.myType = type;
            this.myType = title;
        }

        public string MyType
        {
            get 
            {
                return myType;
            }

            set 
            {
                myType = value;
            }
        }
        public string MyType
        {
            get
            {
                return myTitle;
            }
            set 
            {
                myTitle = value;
            }
        }
    }
}