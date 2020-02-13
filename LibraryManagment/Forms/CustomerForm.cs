using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagment.Data;
using LibraryManagment.Models;


namespace LibraryManagment.Forms
{
    public partial class UserForm : Form
    {
        private readonly LibraryDbContext _context;
        public UserForm()
        {
            _context = new LibraryDbContext();
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            FillCustomers();
        }

        private void FillCustomers()
        {
            var ShowUser = _context.Users.ToList();
            DgvAddCustomer.Rows.Clear();
            foreach (var item in ShowUser)
            {
                DgvAddCustomer.Rows.Add(item.Id,
                                     item.Name,
                                     item.Surname,
                                     item.Phone);
                                     //item.Email,
                                     //item.IdentifyNumber);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCustomerName.Text) &&
           string.IsNullOrEmpty(TxtCustomerSurname.Text))/*&&*/
          //string.IsNullOrEmpty(TxtCustomerIdNumber.Text))


            {
                MessageBox.Show("Please Add Name, Surname or ID Number ");
                return;
            }
            var User = _context.Customers.Where(u => (TxtCustomerName.Text != string.Empty ? u.Name.Contains(TxtCustomerName.Text) : false) ||
                                                            (TxtCustomerSurname.Text != string.Empty ? u.Surname.Contains(TxtCustomerIdNumber.Text) : false) /*||*/
                                                            /*(TxtCustomerIdNumber.Text != string.Empty ? c.Phone.Contains(TxtCustomerIdNumber.Text) : false)*/)
                                    .ToList();

            DgvAddCustomer.Rows.Clear();

            foreach (var item in User)
            {
                DgvAddCustomer.Rows.Add(item.Id,
                                     item.Name,
                                     item.Surname,
                                     item.Phone);
                //                     item.Email,
                //                     item.IdentifyNumber);

                //Clear();
            }
        }
    }
}

