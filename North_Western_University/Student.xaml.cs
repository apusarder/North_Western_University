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
    /// Interaction logic for Student.xaml
    /// </summary>
    public partial class Student : Window
    {
        public Student()
        {
            InitializeComponent();
        }

        private void Menuiiteam_Info_Click(object sender, RoutedEventArgs e)
        {
            Src_Student ni = new Src_Student();
            ni.Show();
            this.Close();
        }

        private void Menuitem_Update_Click_1(object sender, RoutedEventArgs e)
        {
            Update_student ii = new Update_student();
            ii.Show();
            this.Close();
        }

        private void Menuitem_LogOut_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("do you really want to log out?", "Log out confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.Yes);
            switch (mr)
            {
                case MessageBoxResult.Yes:
                    Log_in li = new Log_in();
                    li.Show();
                    this.Close();
                    break;
                case MessageBoxResult.No:
                    break;
                default:
                    break;
            }
        }
    }
}
