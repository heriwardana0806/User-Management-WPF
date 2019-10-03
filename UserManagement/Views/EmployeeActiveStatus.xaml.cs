using System;
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

namespace UserManagement.Views
{
    /// <summary>
    /// Interaction logic for EmployeeActiveStatus.xaml
    /// </summary>
    public partial class EmployeeActiveStatus : Window
    {
        public EmployeeActiveStatus()
        {
            InitializeComponent();
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

        private void Emp_Active_Click(object sender, RoutedEventArgs e)
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
