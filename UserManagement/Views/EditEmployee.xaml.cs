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
using System.Windows.Navigation;
using System.Windows.Shapes;
using UserManagement.Controllers;
//using System.Data.SQLite;

namespace UserManagement.Views
{
    /// <summary>
    /// Interaction logic for EditEmployee.xaml
    /// </summary>
    public partial class EditEmployee : Window
    {
        public EditEmployee()
        {
            InitializeComponent();
        }

        public object ConvertToStringReligion_IdTextBox { get; private set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EmployeeController CallEmployee = new EmployeeController();

            string Id = IdTextBox.Text;
            string First_Name = First_NameTextBox.Text;
            string Last_Name = Last_NameTextBox.Text;
            DateTime Birth_Date = ConvertToString(Birth_DateTextBox.Text);
            string Blood_Type = Blood_TypeTextBox.Text;
            string Gender = GenderTextBox.Text;
            string Phone_Number = Phone_NumberTextBox.Text;
            string Marital_Status = Marital_StatusTextBox.Text;
            string Address = AddressTextBox.Text;
            string Zip_Code = Zip_CodeTextBox.Text;
            string Email = EmailTextBox.Text;
            //bool IsActive = IsActiveTextBox.Text;
            //int Religion_Id = ConvertToStringReligion_IdTextBox.Text;
            string Position_Id = Position_IdTextBox.Text;
            //int Village_Id = Village_IdTextBox.Text;
            string Manager_Id = Manager_IdTextBox.Text;
            //int Birth_Place = Birth_PlaceTextBox.Text;
            

            CallEmployee.AddEmp(Id, First_Name, Last_Name, Birth_Date, Blood_Type, Gender, Phone_Number, Marital_Status, Address, Zip_Code, Email, Position_Id, Manager_Id);
            this.Hide();
            Home main = new Home();
            //main.Show();

        }

        private DateTime ConvertToString(string text)
        {
            throw new NotImplementedException();
        }
    }
}
