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
    /// <summary>
    /// Interaction logic for Sign_in.xaml
    /// </summary>
    public partial class Sign_in : Page
    {
        ProfileEntities pr=new ProfileEntities();
        public Sign_in()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            user_information user = new user_information();
            var emp=pr.user_information.FirstOrDefault(x=> x.username==textbox1.Text && x.passwordd==password.Password);
            if (emp!=null)
            {
                MessageBox.Show("Sign In Successfully");
                
               Profile_Page profile_Page=new Profile_Page(user);
                this.NavigationService.Navigate(profile_Page);
            }
            else
            {
                MessageBox.Show("Incorrect Username Or Passwprd");
            }

        }
    }
}
