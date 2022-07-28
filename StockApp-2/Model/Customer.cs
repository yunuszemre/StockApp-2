using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp_2.Model
{
    public class Customer
    {
        private string _customerName;

        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; }
        }
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _customerAdress;

        public string CustomerAdress
        {
            get { return _customerAdress; }
            set { _customerAdress = value; }
        }
    }
}
