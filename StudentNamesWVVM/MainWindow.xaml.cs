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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentNamesWVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StudentView_Loaded(object sender, RoutedEventArgs e)
        {
            StudentNamesWVVM.ViewModels.StudentViewModel studentViewModelObject = new StudentNamesWVVM.ViewModels.StudentViewModel();
            studentViewModelObject.LoadStudents();

            StudentController.DataContext = studentViewModelObject;
        }
    }
}
