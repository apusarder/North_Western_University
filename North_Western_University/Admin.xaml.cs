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

namespace North_Western_University
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
        }

       

        private void Dept_instructor1_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("do you really want to log out?", "Log out confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.Yes);
            switch (mr)
            {
                case MessageBoxResult.Yes:
                    Log_in ni = new Log_in();
                    ni.Show();
                    this.Close();

                    break;
                case MessageBoxResult.No:
                    break;
                default:
                    break;
            }
         }

        private void Ins_instructor_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Info_student ni = new Info_student();
            ni.Show();
            this.Close();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Update_ad ni = new Update_ad();
            ni.Show();
            this.Close();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Search_ad ni = new Search_ad();
            ni.Show();
            this.Close();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Delete_ad ni = new Delete_ad();
            ni.Show();
            this.Close();
        }

        private void Insert_Student_Click(object sender, RoutedEventArgs e)
        {
            Insert_Stu_Ad aa = new Insert_Stu_Ad();
            aa.Show();
            this.Close();
        }

        private void Over_View_Click(object sender, RoutedEventArgs e)
        {
            Data_OverView_ad ss = new Data_OverView_ad();
            ss.Show();
            this.Close();
        }
    }
}
