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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        
        private string dbUserName = "admin";
        string dbPassword = "123";
        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            if (userName == dbUserName && password == dbPassword)
            {
                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Kulllanıcı adı veya şifre hatalı", "Sistem Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.Enter)
            {
                Login();
            }
        }
    }
}
