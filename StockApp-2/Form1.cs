using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockApp_2.Model;

namespace StockApp_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //
        private string _userName;

        public string UserName
        {
            get => _userName;
            set => _userName = value;
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = UserName;
            menuStrip1.BackColor = Color.SteelBlue;
            menuStrip1.ForeColor = Color.AliceBlue;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void yeniMüşteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomer customerForm = new FormCustomer();
            DialogResult res = customerForm.ShowDialog();
            if (res == DialogResult.OK)
            {
                //Sonuç OK ise kayıt işleme devam et
               var customer = customerForm.Customer;
               customers.Add(customer);
            }
        }

        private List<Customer> customers = new List<Customer>();
        private void müşterileriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomerList customerList = new FormCustomerList();
            customerList.Customer = customers;
            customerList.ShowDialog();
        }
    }
}
