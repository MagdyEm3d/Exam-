using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
    /// <summary>
    /// Interaction logic for Profile_Page.xaml
    /// </summary>
    public partial class Profile_Page : Page
    {
        public Profile_Page(user_information userr)
        {
            InitializeComponent();
            labelh.Content = "Welcome" + userr.username;
            username.IsEnabled = false; password.IsEnabled = false; age.IsEnabled = false; gender.IsEnabled = false; phonenumber.IsEnabled = false; city.IsEnabled = false;
            username.Text = userr.username.ToString();
            for (int i = 0; i < userr.passwordd.Count(); i++)
            {
                password.Text += "*";
            }
            age.Text = userr.age.ToString();
            gender.Text = userr.Gender.ToString();
            phonenumber.Text = userr.phonenumber.ToString();
            city.Text = userr.city.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}











