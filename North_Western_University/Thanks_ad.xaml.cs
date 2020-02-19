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
    /// Interaction logic for Thanks_ad.xaml
    /// </summary>
    public partial class Thanks_ad : Window
    {
        public Thanks_ad()
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
    }
}
