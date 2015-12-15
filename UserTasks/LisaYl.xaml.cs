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
using System.Data.SQLite;

namespace UserTasks
{
    /// <summary>
    /// Interaction logic for LisaYl.xaml
    /// </summary>
    public partial class LisaYl : Window
    {
        string userName;
        public LisaYl(string userName)
        {
            this.userName = userName;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string t2htaeg = TextBoxTahtaeg.Text;
            string yl = TextBlockYlesanne.Text;
            string kuupaev = DateTime.Today.ToShortDateString();

            SQLiteConnection sqlCon = new SQLiteConnection("Data Source=users");
            string query = "insert into ylesanded values('" + kuupaev + "','" + t2htaeg + "','" + yl + "','" + userName + "','-','Ei','Ei')";
            sqlCon.Open();
            SQLiteCommand com = new SQLiteCommand(query, sqlCon);
            com.ExecuteNonQuery();
            sqlCon.Close();

            this.Close();
        }
    }
}
