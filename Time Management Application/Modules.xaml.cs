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
    /// Interaction logic for Modules.xaml
    /// </summary>
    public partial class Modules : Window
    {
        public Modules()
        {
            InitializeComponent();

            foreach (var mName in collection.myModuleNames.Distinct()) 
            {
                listBox_View.Items.Add(mName);
            }
        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            ChooseAnoption myOptionChosen = new ChooseAnoption();
            myOptionChosen.Show();
            this.Hide();

        }

        private void btn_ViewMod_Click(object sender, RoutedEventArgs e)
        {
            var moduleData = collection.myModuleDetailsCollection.Where(
                tempVar => tempVar.moduleName.Equals(listBox_View.SelectedItem)
                ).ToList<library>();

            txtBlock_ViewWork.Text = "Module_Code\tModule_Name\t\tNumber_of_credits\tNumber_of_hours\tSelf_Study\n";
            foreach(library data in moduleData) 
            {
                txtBlock_ViewWork.Text += data.moduleCode + "\t" + data.moduleName + "\t" + data.noOfCredits
                    + "\t" + data.hoursPerWeek + "\t" + data.selfStudy + "\n";

            }

        }

        
    }
}
