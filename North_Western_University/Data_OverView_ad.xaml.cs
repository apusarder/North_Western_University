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
    /// Interaction logic for Data_OverView_ad.xaml
    /// </summary>
    public partial class Data_OverView_ad : Window
    {
        public Data_OverView_ad()
        {
            InitializeComponent();
        }

        private void Button_Show_Click(object sender, RoutedEventArgs e)
        {
            string connectionstring = @"Data Source=DESKTOP-Q26PUS1;Initial Catalog=North_western_university;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);
            sqlcon.Open();

            string sqlquery = "Select * from dbo.New_instructor";
            SqlCommand sqlcmd = new SqlCommand(sqlquery, sqlcon);

            SqlDataAdapter data_adapter = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable("dbo.Student_information");
            data_adapter.Fill(dt);
            d1.ItemsSource = dt.DefaultView;
            data_adapter.Update(dt);
            sqlcon.Close();
        }

        private void Button_Exit_Click_1(object sender, RoutedEventArgs e)
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
