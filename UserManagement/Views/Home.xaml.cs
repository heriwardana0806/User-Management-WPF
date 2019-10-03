﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using UserManagement.Views;

namespace UserManagement
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        
        public Home()
        {
            InitializeComponent();
        }


        private void Add_Btn_Click_1(object sender, RoutedEventArgs e)
        {
            //this.Hide();
            AddEmployee calling = new AddEmployee();
            calling.ShowDialog();
        }

        private void Setting_Btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Man_Emp_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Home calling = new Home();
            calling.ShowDialog();

        }

        private void Man_App_Emp_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ManageApplicationEmployee calling = new ManageApplicationEmployee();
            calling.ShowDialog();

        }

        private void Man_Role_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ManageRole calling = new ManageRole();
            calling.ShowDialog();

        }

        private void Active_Status_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            EmployeeActiveStatus calling = new EmployeeActiveStatus();
            calling.ShowDialog();
        }

        private void View_Click(object sender, RoutedEventArgs e)
        {
            //this.Hide();
            ViewEmployee calling = new ViewEmployee();
            calling.ShowDialog();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            //this.Hide();
            EditEmployee calling = new EditEmployee();
            calling.ShowDialog();

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
