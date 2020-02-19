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
    /// Interaction logic for Update_student.xaml
    /// </summary>
    public partial class Update_student : Window
    {
        public Update_student()
        {
            InitializeComponent();
        }

        private void Button_Show_Click(object sender, RoutedEventArgs e)
        {
            t2.Clear();
            t2.Clear();
            t3.Clear();
            t4.Clear();
            t5.Clear();
            t6.Clear();
            t7.Clear();
            pf1.Clear();

            string connectionstring = @"Data Source=DESKTOP-Q26PUS1;Initial Catalog=North_western_university;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);
            sqlcon.Open();
            string commandstring = "select * from dbo.New_instructor";
            SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
            SqlDataReader read = sqlcmd.ExecuteReader();
            int f = 0;

            while (read.Read())
            {
                if (read[2].ToString() == t1.Text)
                {
                    t2.Text = read[0].ToString();
                    t3.Text = read[1].ToString();
                    t4.Text = read[3].ToString();
                    t5.Text = read[5].ToString();
                    t6.Text = read[7].ToString();
                    t7.Text = read[7].ToString();
                    pf1.Password = read[8].ToString();

                    f = 1;

                }
            }

            sqlcon.Close();
            if (f == 0)
            {
                MessageBox.Show("Please ! Enter a Valid ID", "There Is no Information", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.Yes);

            }
        }

        private void Button_Update_Click_1(object sender, RoutedEventArgs e)
        {
            string connectionstring = @"Data Source=DESKTOP-Q26PUS1;Initial Catalog=North_western_university;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);

            string commandstring = "update New_instructor set Name=@pat,Dob=@pet,Email=@put,Contact=@pre,Passward=@par  where Id='" + t1.Text + "'";
            SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);


            sqlcmd.Parameters.Add("@pat", SqlDbType.VarChar).Value = t2.Text;
            sqlcmd.Parameters.Add("@pet", SqlDbType.Date).Value = t4.Text;
            sqlcmd.Parameters.Add("@put", SqlDbType.VarChar).Value = t6.Text;
            sqlcmd.Parameters.Add("@pre", SqlDbType.VarChar).Value = t7.Text;
            sqlcmd.Parameters.Add("@par", SqlDbType.VarChar).Value = pf1.Password;

            sqlcon.Open();
            int rows = sqlcmd.ExecuteNonQuery();
            sqlcon.Close();

            if (rows == 1)
                MessageBox.Show("Information Has Updated.");

            t1.Clear();
            t2.Clear();
            t3.Clear();
            t4.Clear();
            t5.Clear();
            t6.Clear();
            t7.Clear();
            pf1.Clear();
        }

        private void Button_Exit_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("do you really want to Exit?", "Exit confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.Yes);
            switch (mr)
            {
                case MessageBoxResult.Yes:
                    Student ni = new Student();
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
