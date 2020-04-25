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

namespace _3033project
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

        private void btnPreviousTab_Click(object sender, RoutedEventArgs e)
        {
            //https://www.wpf-tutorial.com/tabcontrol/using-the-tabcontrol/
            int newIndex = Quiz.SelectedIndex - 1;
            if (newIndex < 0)
                newIndex = Quiz.Items.Count - 1;
            Quiz.SelectedIndex = newIndex;
        }

        private void btnNextTab_Click(object sender, RoutedEventArgs e)
        {
        //https://www.wpf-tutorial.com/tabcontrol/using-the-tabcontrol/
            int newIndex = Quiz.SelectedIndex + 1;
            if (newIndex >= Quiz.Items.Count)
                newIndex = 0;
            Quiz.SelectedIndex = newIndex;
        }
    }
}
