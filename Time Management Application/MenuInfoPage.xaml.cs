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

namespace Time_Management_Application
{
    /// <summary>
    /// Interaction logic for MenuInfoPage.xaml
    /// </summary>
    public partial class MenuInfoPage : Window
    {
        public MenuInfoPage()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LoginPage myLog = new LoginPage();
            myLog.Show();
            this.Hide();
        }

        private void btn_Next_Click(object sender, RoutedEventArgs e)
        {
            
            ChooseAnoption myOptionChosen = new ChooseAnoption();
            myOptionChosen.Show();
            this.Hide();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            library.weeksInTheSemester = Convert.ToInt32(txtbox_WeeksInSemester);
            library.startOfSemester = DateTimeStart.SelectedDate.Value;
            library.endOfSemester = library.startOfSemester.AddDays(library.weeksInTheSemester * 7);
        }
    }
}
