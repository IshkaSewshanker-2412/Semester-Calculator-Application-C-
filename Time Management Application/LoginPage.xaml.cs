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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, RoutedEventArgs e)
        {
            //adding sql connection
            SqlConnection myCon = new SqlConnection("Data Source=LAPTOP-M90OH3FD;Initial Catalog=Task2DatabaseLogin;Integrated Security=True");
            //Creating string query
            String query = ("SELECT * FROM Task2UserRegistration WHERE UserName='"+txtBox_Username.Text.Trim()+"' AND Password='"+pbx_Password.Password.Trim()+"' ");
            //creating object of sql adapter
            SqlDataAdapter sdaAdapt = new SqlDataAdapter(query, myCon);
            //creating object of datatable
            DataTable dtblTab = new DataTable();
            //filling sqldataadapter with information of datatable
            sdaAdapt.Fill(dtblTab);

            if (dtblTab.Rows.Count == 1)
            {
                //creating object for menuinfopage
                MenuInfoPage menu = new MenuInfoPage();
                //displaying the menuinfopage
                menu.Show();
                //hiding the current page
                this.Hide();
            }
            else 
            {
                //diplaying error message to user if incorrect details are entered
                MessageBox.Show("Enter the correct Username and Password or click on the register button to register new user");
            }
        }

        private void btn_register_Click(object sender, RoutedEventArgs e)
        {
            //creating object for register page
            Register myReg = new Register();
            //displaying register page
            myReg.Show();
            //hiding current page
            this.Hide();
        }
    }
}
