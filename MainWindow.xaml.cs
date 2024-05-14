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

namespace AddChildren
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

        private void btnAddMore_Click(object sender, RoutedEventArgs e)
        {

            System.Windows.Controls.Button newBtn = new Button();

            newBtn.Content = "New Button";

            newBtn.Click += new RoutedEventHandler(newBtn_Click);

            MainStack.Children.Add(newBtn);


        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {


        }


        private void newBtn_Click(object sender, RoutedEventArgs e)

        {

            MessageBox.Show("I got Clicked!", "Whoa!");

        }


    }
}
