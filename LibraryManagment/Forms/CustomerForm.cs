﻿using System;
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
    public partial class CustomerForm : Form
    {
        private int _id;
        private Customer _customer;
        private readonly LibraryDbContext _context;
        public CustomerForm()
        {
            InitializeComponent();
            _context = new LibraryDbContext();
            FillCustomers();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            FillCustomers();
        }

        private void FillCustomers()
        {
            List<Customer> ShowUser = _context.Customers.ToList();
            DgvAddCustomer.Rows.Clear();
            foreach (var item in ShowUser)
            {
                DgvAddCustomer.Rows.Add(item.Id,
                                     item.Name,
                                     item.Surname,
                                     item.Phone);
            }
        }
        private void Clear()
        {
            TxtCustomerName.Clear();
            TxtCustomerSurname.Clear();
            TxtCustomerIdNumber.Clear();


        }
        //Create and Read Method
        private void BtnCustomerAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtCustomerName.Text) ||
             !string.IsNullOrEmpty(TxtCustomerSurname.Text) ||
             !string.IsNullOrEmpty(TxtCustomerIdNumber.Text))
            {
                Customer customer = new Customer//add user to database
                {
                    Name = TxtCustomerName.Text,
                    Surname = TxtCustomerSurname.Text,
                    Phone = TxtCustomerIdNumber.Text,


                };
                _context.Customers.Add(customer);
                _context.SaveChanges();
            }
            else
            {
                MessageBox.Show("Please");
            }
            DgvAddCustomer.Rows.Clear();
            FillCustomers();
            Clear();
        }
        //Update Method
        private void BtnCustomerUpdate_Click(object sender, EventArgs e)
        {
            Customer customer = _context.Customers.Find(_customer.Id);
            customer.Name = TxtCustomerName.Text;
            customer.Surname = TxtCustomerSurname.Text;
            customer.Phone = TxtCustomerIdNumber.Text;

            _context.SaveChanges();
            FillCustomers();
            Clear();
        }
        // Delete Method
        private void BtnCustomerDelete_Click(object sender, EventArgs e)
        {
            _context.Customers.Remove(_customer);
            _context.SaveChanges();
            FillCustomers();
            Clear();
        }

        private void DgvAddCustomer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TxtCustomerName.Text = _customer.Name;
            TxtCustomerSurname.Text = _customer.Surname;
            TxtCustomerIdNumber.Text = _customer.Phone;
        }

        private void DgvAddCustomer_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _id = (int)DgvAddCustomer.Rows[e.RowIndex].Cells[0].Value;
            _customer = _context.Customers.Find(_id);
        }
        //Search Method
        private void BtnCustomerSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCustomerName.Text) &&
           string.IsNullOrEmpty(TxtCustomerSurname.Text) &&
          string.IsNullOrEmpty(TxtCustomerIdNumber.Text))


            {
                MessageBox.Show("Please Add Name, Surname or ID Number ");
                return;
            }
            var customer = _context.Customers
                                    .Where(c => (TxtCustomerName.Text != string.Empty ? c.Name.Contains(TxtCustomerName.Text) : false) ||
                                                            (TxtCustomerSurname.Text != string.Empty ? c.Surname.Contains(TxtCustomerSurname.Text) : false) ||
                                                            (TxtCustomerIdNumber.Text != string.Empty ? c.Phone.Contains(TxtCustomerIdNumber.Text) : false))
                                    .ToList();
            DgvAddCustomer.Rows.Clear();

            foreach (var item in customer)
            {
                DgvAddCustomer.Rows.Add(item.Id,
                                     item.Name,
                                     item.Surname,
                                     item.Phone);

                Clear();
            }
        }
    }
}