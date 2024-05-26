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

namespace Holistic_Exam
{
    public partial class Sign_Up : Page
    {
        ProfileEntities pr = new ProfileEntities();

        public Sign_Up()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            user_information user_Information = new user_information();

            
            if (string.IsNullOrEmpty(textbox1.Text))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }

           
            if (string.IsNullOrEmpty(textbox2.Text))
            {
                MessageBox.Show("Please enter a password.");
                return;
            }

            int age;
          
            try
            {
                age = int.Parse(textbox3.Text);
                if (age <= 0)
                {
                    MessageBox.Show("Please enter a valid age ");
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid age ");
                return;
            }

            int phone;
            try
            {
                phone = int.Parse(textbox4.Text);
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid phone number (number format).");
                return;
            }

            var emp = pr.user_information.FirstOrDefault(x => x.username == textbox1.Text);
            if (emp != null)
            {
                MessageBox.Show("This username is already taken.");
                return;
            }

            user_Information.username = textbox1.Text;
            user_Information.passwordd = textbox2.Text;
            user_Information.age = age;
            user_Information.phonenumber = phone;
            if (male.IsChecked == true)
            {
                user_Information.Gender = "Male";
            }
            else if (female.IsChecked == true)
            {
                user_Information.Gender = "Female";
            }
            else
            {
                user_Information.Gender = "";
            }

            user_Information.city = combox.SelectedItem.ToString();
            try
            {
                pr.user_information.Add(user_Information);
                pr.SaveChanges();
                MessageBox.Show("Sign Up Successfully");
                Profile_Page profile_Page = new Profile_Page(user_Information);
                this.NavigationService.Navigate(profile_Page);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }

        private static bool checknuber(int phone)
        {
            return phone == 11; 
        }

        private void textbox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Sign_in sign_In = new Sign_in();
            this.NavigationService.Navigate(sign_In);
        }
    }
}
