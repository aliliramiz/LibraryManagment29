using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptoHelper;
using LibraryManagment.Data;
using LibraryManagment.Models;

namespace LibraryManagment.Forms
{
    public partial class LoginForm : Form
    {
        private readonly LibraryDbContext _context;
        public LoginForm()
        {
            _context = new LibraryDbContext();

            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtEmail.Text))
            {
                MessageBox.Show("E-poçt yazın");
                return;
            }

            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("Şifrə yazın");
                return;
            }

            User user = _context.Users.FirstOrDefault(u => u.Status && u.Email == TxtEmail.Text && u.Password == TxtPassword.Text);

            if (user != null)
            {
                DashboardForm dashboard = new DashboardForm();
                //dashboard.User = user;

                dashboard.Show();

                this.Hide();
                return;

            }

            MessageBox.Show("E-poçt və ya şifrə yalnışdır");
        }
    }
}
