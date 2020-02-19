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
    /// Interaction logic for Log_in.xaml
    /// </summary>
    public partial class Log_in : Window
    {
        public Log_in()
        {
            InitializeComponent();
        }

        public static string Id;
        public static string recby
        {
            get { return Id; }
            set { Id = value; }
        }

        private void Button__Click(object sender, RoutedEventArgs e)
        {

            MessageBoxResult mr = MessageBox.Show("do you really want to log out?", "Log out confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            switch (mr)
            {
                case MessageBoxResult.Yes:
                    {
                        MainWindow ni = new MainWindow();
                        ni.Show();
                        System.Environment.Exit(0);
                        break;
                    }
                case MessageBoxResult.No:
                    {
                        Log_in nii = new Log_in();
                        nii.Show();
                        this.Close();
                        break;
                    }
                default:
                    break;

            }
    }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string con = @"Data Source=DESKTOP-Q26PUS1;Initial Catalog=North_western_university;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(con);
            if (c1.IsChecked == true)
            {

                sqlcon.Open();
                string sqlquery = "select * from dbo.Log_in"; 
                 SqlCommand sqlcmd = new SqlCommand(sqlquery, sqlcon);
                SqlDataReader read = sqlcmd.ExecuteReader();


                while (read.Read())
                {

                    if (t1.Text == read[0].ToString() && pf1.Password == read[1].ToString())
                    {
                        Admin im = new Admin();
                        im.Show();
                        this.Close();
                    }

                    
                }

                sqlcon.Close();

            }

           



            else if (c2.IsChecked == true)
            {

                string connection = @"Data Source=DESKTOP-Q26PUS1;Initial Catalog=North_western_university;Integrated Security=True";
                SqlConnection sqlcon2 = new SqlConnection(connection);
                sqlcon2.Open();
                string command = "select * from New_instructor";
                SqlCommand sqlcmd1 = new SqlCommand(command, sqlcon2);
                SqlDataReader read1 = sqlcmd1.ExecuteReader();



                while (read1.Read())
                {


                    if (t1.Text == read1[2].ToString() && pf1.Password == read1[8].ToString())

                    {
                        Student aa = new Student();
                        aa.Show();
                        this.Close();

                    }




                }



                sqlcon2.Close();
            }
            else

            {
                MessageBox.Show("Please Enter all the Fields", "Wrong Process", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
        }
    }
}


        
