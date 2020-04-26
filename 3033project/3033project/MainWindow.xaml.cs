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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            quiz res = new quiz();
            res.setFruit(1);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            quiz res = new quiz();
            res.setFruit(2);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            quiz res = new quiz();
            res.setFruit(3);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            quiz res = new quiz();
            res.setFruit(4);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            quiz res = new quiz();
            res.setActivity(1);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            quiz res = new quiz();
            res.setActivity(2);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            quiz res = new quiz();
            res.setActivity(3);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            quiz res = new quiz();
            res.setActivity(4);
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            quiz res = new quiz();
            res.setRoof(1);
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            quiz res = new quiz();
            res.setRoof(2);
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            quiz res = new quiz();
            res.setRoof(3);
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            quiz res = new quiz();
            res.setRoof(4);
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            quiz res = new quiz();
            res.setWorker(1);
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            quiz res = new quiz();
            res.setWorker(2);
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            quiz res = new quiz();
            res.setWorker(3);
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            quiz res = new quiz();
            res.setWorker(4);
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("this character");
        }

        

        
    }
}

