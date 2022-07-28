using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockApp_2
{
    using Model;
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }
        private Customer _customer;

        public Customer Customer
        {
            get{ return _customer; }
            set{ _customer = value; }
        }
        int id =0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            CustomerSave();
        }

        private Customer selectedCustomer;
        void CustomerSave()
        {
            if (_customer == null)
            {
                _customer = new Customer();
            }
            else
            {
               
            }
            _customer.CustomerName = txtCustomerName.Text;
            _customer.CustomerAdress = txtCustomerAdress.Text;
            _customer.Id = GetId();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        int GetId()
        {
            return ++id;
        }

        void UpdateCustomer()
        {
            if (_customer != null)
            {
                selectedCustomer = Customer;
            }
            selectedCustomer.CustomerName = txtCustomerName.Text;
            selectedCustomer.CustomerAdress = txtCustomerAdress.Text;
        }
    }
}
