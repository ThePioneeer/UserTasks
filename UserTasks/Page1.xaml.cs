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

namespace UserTasks
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Window
    {
        string userName;
        public Page1(string userName)
        {
            InitializeComponent();
            this.userName = userName;
            EnableButton();
        }

        private void EnableButton() 
        {
            if (userName == "uko" || userName == "admin")
                ButtonKasutajad.IsEnabled = true;
        }

        private void ButtonKasutajad_Click(object sender, RoutedEventArgs e)
        {
            UserManager um = new UserManager();
            um.Show();
           
        }

        private void ButtonYlesanded_Click(object sender, RoutedEventArgs e)
        {
            Ylesanded yl = new Ylesanded(userName);
            yl.Show();
        }
    }
}
