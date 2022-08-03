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
    /// Interaction logic for ChooseAnoption.xaml
    /// </summary>
    public partial class ChooseAnoption : Window
    {
        public ChooseAnoption()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //displaying the semester dates
            
            MessageBox.Show("The semester starts on : " + library.startOfSemester.ToString() +
                "\n Semester Ends on : " + library.endOfSemester);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //creating an object of capturepage
            CapturePage myCapture = new CapturePage();
            //displaying capture page
            myCapture.Show();
            //hiding current page
            this.Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //creating an object of Modules page
            Modules myModules = new Modules();
            //displaying modules page
            myModules.Show();
            //hiding current page
            this.Hide();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //creating an object of moduleinfopage
            MenuInfoPage myInfo = new MenuInfoPage();
            //displaying menuinfopage
            myInfo.Show();
            //hiding current page
            this.Hide();
        }
    }
}
