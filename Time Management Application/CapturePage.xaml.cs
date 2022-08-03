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
    /// Interaction logic for CapturePage.xaml
    /// </summary>
    public partial class CapturePage : Window
    {
        public CapturePage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ChooseAnoption myOptionChosen = new ChooseAnoption();
            myOptionChosen.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            collection.myModuleDetailsCollection.Add(new library
            {
                moduleCode = txtbx_CourseCode.Text,
                moduleName = txtbx_ModuleName.Text,
                noOfCredits = Convert.ToInt32(txtbox_NumOfCredits.Text),
                hoursPerWeek = Convert.ToInt32(txtbox_numOfhours.Text),
                selfStudy = ((Convert.ToInt32(txtbox_NumOfCredits.Text) * 10) / library.weeksInTheSemester) -
                Convert.ToInt32(txtbox_numOfhours.Text)
            });
            MessageBox.Show("Your data has been stored!!!");
            collection.myModuleNames.Add(txtbx_ModuleName.Text);

            txtbx_CourseCode.Clear();
            txtbx_ModuleName.Clear();
            txtbox_NumOfCredits.Clear();
            txtbox_numOfhours.Clear();
        }

       
    }
}
