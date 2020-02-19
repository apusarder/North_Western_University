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
using System.Data;
using System.Data.SqlClient;

namespace North_Western_University
{
    /// <summary>
    /// Interaction logic for Insert_Stu_Ad.xaml
    /// </summary>
    public partial class Insert_Stu_Ad : Window
    {
        public Insert_Stu_Ad()
        {
            InitializeComponent();
        }

        private void Button_Exit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("do you really want to log out?", "Log out confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.Yes);
            switch (mr)
            {
                case MessageBoxResult.Yes:
                    Admin ni = new Admin();
                    ni.Show();
                    this.Close();
                    break;
                case MessageBoxResult.No:
                    break;
                default:
                    break;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            string Name = t1.Text;
            var d = (ListBoxItem)l1.SelectedItem;
            string Department = (string)d.Content;
            string ID = t2.Text;
            string DOB = d1.SelectedDate.Value.ToShortDateString();
            string Contact = t3.Text;
            string JD = d2.SelectedDate.Value.ToShortDateString();
            string Gender;
            if (g1.IsChecked == true)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }
            
            string Email = t4.Text;
            int passward = Convert.ToInt32(pf1.Password);


            string connectionstring = @"Data Source=DESKTOP-Q26PUS1;Initial Catalog=North_western_university;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);

            SqlCommand cmd = new SqlCommand("insert into New_instructor(Name,Department,ID,DOB,JD,Gender,Email,Contact,passward) values(@a,@b,@c,@d,@e,@f,@g,@h,@i)", sqlcon);

            cmd.Parameters.Add("@a", SqlDbType.VarChar).Value = Name;
            cmd.Parameters.Add("@b", SqlDbType.VarChar).Value = Department;
            cmd.Parameters.Add("@c", SqlDbType.VarChar).Value = ID;
            cmd.Parameters.Add("@d", SqlDbType.Date).Value = DOB;
            cmd.Parameters.Add("@e", SqlDbType.Date).Value = JD;
            cmd.Parameters.Add("@f", SqlDbType.VarChar).Value = Gender;
            cmd.Parameters.Add("@g", SqlDbType.VarChar).Value = Email;
            
            cmd.Parameters.Add("@h", SqlDbType.VarChar).Value = Contact;
            cmd.Parameters.Add("@i", SqlDbType.Int).Value = passward;
            sqlcon.Open();
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)

                sqlcon.Close();




            Thanks_ad ti = new Thanks_ad();
            ti.Show();
            this.Close();
        }
    
    }
}
