using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.IO;
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
    /// Interaction logic for Ylesanded.xaml
    /// </summary>
    public partial class Ylesanded : Window
    {
        static DatabaseService _databaseService;
        string userName;
        public Ylesanded(string userName)
        {
            this.userName = userName;
            InitializeComponent();
            _databaseService = new DatabaseService();
            //CheckConnection();
            _databaseService.ConnectToDatabase("users");
            ShowData();
        }

        //private void LoadData()
        //{
        //    SQLiteConnection sql_con = new SQLiteConnection("data source=users");
        //    sql_con.Open();
        //    SQLiteCommand sql_cmd = sql_con.CreateCommand();
        //    sql_cmd.CommandText = "SELECT * FROM ylesanded";
        //    SQLiteDataAdapter DB = new SQLiteDataAdapter(sql_cmd.CommandText, sql_con);
        //    sql_con.Close();
        //    DataSet DS = new DataSet();
        //    DB.Fill(DS);
        //    ListYlesanded.DataContext = DS.Tables[0].DefaultView;
        //}

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
        //        }
        //        catch (SQLiteException e)
        //        {
        //            _databaseService.CreateTable("userinfo");
        //        }
        //    }

        //}

        private void ButtonLisaYl_Click(object sender, RoutedEventArgs e)
        {
            LisaYl ly = new LisaYl(userName);
            ly.Show();
        }

        private void ShowData()
        {
            try
            {
                SQLiteConnection sql_con = new SQLiteConnection("data source=users");
                sql_con.Open();
                SQLiteCommand sql_cmd = sql_con.CreateCommand();
                sql_cmd.CommandText = "SELECT * FROM ylesanded";
                SQLiteDataAdapter DB1 = new SQLiteDataAdapter(sql_cmd.CommandText, sql_con);
                sql_con.Close();
                DataSet DS1 = new DataSet();
                DB1.Fill(DS1);
                ListYlesanded.DataContext = DS1.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {

            }
        }

        private void ButtonRefresh_Click(object sender, RoutedEventArgs e)
        {
            ShowData();
        }

        private void ButtonAktiveeri_Click(object sender, RoutedEventArgs e)
        {
            string ylesanne ="";
            try
            {
                var valitud = ListYlesanded.SelectedIndex;
                DataRowView DataRow = ListYlesanded.Items.GetItemAt(valitud) as DataRowView;
                var yl = DataRow["ulesanne"];
                ylesanne = yl.ToString();

                SQLiteConnection sql_con = new SQLiteConnection("data source=users");
                sql_con.Open();
                SQLiteCommand sql_cmd = sql_con.CreateCommand();
                sql_cmd.CommandText = "UPDATE ylesanded SET aktiveeritud = 'Jah', aktiveerija = '" + userName + "' WHERE ulesanne ='" + ylesanne + "'";
                SQLiteDataAdapter DB1 = new SQLiteDataAdapter(sql_cmd.CommandText, sql_con);
                sql_con.Close();
                DataSet DS1 = new DataSet();
                DB1.Fill(DS1);

                ShowData();
            }
            catch(Exception pask)
            {

            }
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                var valitud = ListYlesanded.SelectedIndex;
                DataRowView DataRow = ListYlesanded.Items.GetItemAt(valitud) as DataRowView;
                var yl = DataRow["ulesanne"];
                string ylesanne = yl.ToString();

                SQLiteConnection sqlCon = new SQLiteConnection("Data Source=users");
                string query = "delete from ylesanded where ulesanne ='"+ ylesanne +"'";
                sqlCon.Open();
                SQLiteCommand com = new SQLiteCommand(query, sqlCon);
                com.ExecuteNonQuery();
                sqlCon.Close();

                ShowData();
            }
            catch(Exception ex)
            {

            }
        }

        private void ButtonValmis_Click(object sender, RoutedEventArgs e)
        {
            string ylesanne = "";
            try
            {
                var valitud = ListYlesanded.SelectedIndex;
                DataRowView DataRow = ListYlesanded.Items.GetItemAt(valitud) as DataRowView;
                var yl = DataRow["ulesanne"];
                ylesanne = yl.ToString();

                SQLiteConnection sql_con = new SQLiteConnection("data source=users");
                sql_con.Open();
                SQLiteCommand sql_cmd = sql_con.CreateCommand();
                sql_cmd.CommandText = "UPDATE ylesanded SET valmis = 'Jah' WHERE ulesanne ='" + ylesanne + "'";
                SQLiteDataAdapter DB1 = new SQLiteDataAdapter(sql_cmd.CommandText, sql_con);
                sql_con.Close();
                DataSet DS1 = new DataSet();
                DB1.Fill(DS1);

                ShowData();
            }
            catch (Exception pask)
            {

            }
        }
    }
}
