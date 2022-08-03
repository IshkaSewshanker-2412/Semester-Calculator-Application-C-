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

namespace Time_Management_Application
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_RegisterHere_Click(object sender, RoutedEventArgs e)
        {
            //adding sql connection
            SqlConnection mycon = new SqlConnection("Data Source=LAPTOP-M90OH3FD;Initial Catalog=Task2DatabaseLogin;Integrated Security=True");
            //adding command object
            SqlCommand myCom = new SqlCommand(@"INSERT INTO [dbo].[Task2UserRegistration]
           ([FirstName]
           ,[LastName]
           ,[Username]
           ,[Email]
           ,[Password])
     
     VALUES
           ('" + txt_firstName.Text+"', '"+txt_lastName.Text+ "', '" + txt_UserName.Text + "', '" + txt_Email.Text+ "', '"+pbx_passwordInsert.Password+"' )", mycon);
           //opening connection
            mycon.Open();
            //command execution non query
            myCom.ExecuteNonQuery();
            //closing connection
            mycon.Close();
            //outputting message that user registered 
            MessageBox.Show("You have registered successfully!!!");
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        { 
            //creating object of login page
            LoginPage myLog = new LoginPage();
            //displaying login page
            myLog.Show();
            //hiding the current page
            this.Hide();
        }
    }
}
