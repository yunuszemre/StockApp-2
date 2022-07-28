using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StockApp_2
{
    using Model;
    public partial class FormCustomerList : Form
    {
        
        public FormCustomerList()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private List<Customer> _customers;

        public List<Customer> Customer
        {
            get => _customers;
            set => _customers = value;
        }
        private void FormCustomerList_Load(object sender, EventArgs e)
        {
            initForm();
        }

        void initForm()
        {
            GridSetDataSource();
        }

        private void GridSetDataSource()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Customer;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
