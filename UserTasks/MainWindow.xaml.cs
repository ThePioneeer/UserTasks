using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SQLite;
using System.IO;

namespace UserTasks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static DatabaseService _databaseService;
        static SQLiteConnection _sqlCon;
        public MainWindow()
        {
            InitializeComponent();
            _databaseService = new DatabaseService();
            //CheckConnection();
            _sqlCon = new SQLiteConnection("Data source=users");
            _databaseService.ConnectToDatabase("users");
            //TODO: Loo ylesannete tabel;
            //string query = "create table ylesanded(kuupaev varchar(20), tahtaeg varchar(20), ulesanne varchar(200), lisaja varchar(20), aktiveerija varchar(20), aktiveeritud varchar(3), valmis varchar(3))";
            //SQLiteCommand command1 = new SQLiteCommand(query, _sqlCon);
            //_sqlCon.Open();
            //command1.ExecuteNonQuery();
            //_sqlCon.Close();
        }

        //private void CheckConnection()
        //{
        //    if (File.Exists("users.db"))
        //    {
        //        try 
        //        {
        //            SQLiteConnection con = new SQLiteConnection();
        //            string query = "select * from userinfo";
        //            SQLiteCommand com = new SQLiteCommand(query, con);
        //            com.ExecuteNonQuery();    
        //        }catch(SQLiteException e)
        //        {
        //            _databaseService.CreateTable("userinfo");
        //        }                
        //    }else
        //    {
        //        _databaseService.CreateDatabase("users");
        //        _databaseService.CreateTable("userinfo");
        //    }
        //}

        private void ButtonLogIn_Click(object sender, RoutedEventArgs e)
        {
            string userName = TextBoxUsername.Text;
            string password = PasswordBoxPassword.Password;

            if(CheckUser(userName, password)) 
            {
                Page1 page1 = new Page1(userName);
                page1.Show();
                this.Close();
            }
        }

        private bool CheckUser(string user, string password)
        {
            string query = "SELECT COUNT(*) FROM userinfo WHERE kasutajanimi ='" + user + "' AND parool ='" + password + "'";
            _sqlCon.Open();
            SQLiteCommand com = new SQLiteCommand(query, _sqlCon);
            int userAmount = Convert.ToInt32(com.ExecuteScalar());
            if (userAmount == 1)
            {
                _sqlCon.Close();
                return true;

            }
            else
                _sqlCon.Close();  return false;
        }
    }
}
