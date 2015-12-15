using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UserTasks
{
    /// <summary>
    /// Interaction logic for UserManager.xaml
    /// </summary>
    public partial class UserManager : Window
    {
        static DatabaseService _dbService;
        static string UserID = null;
        public UserManager()
        {
            InitializeComponent();
            _dbService = new DatabaseService();
            //CheckConnection();
            _dbService.ConnectToDatabase("users");
            ShowData();
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
        //        }
        //        catch (SQLiteException e)
        //        {
        //            _dbService.CreateTable("userinfo");
        //        }
        //    }
        //}

        private void ShowData()
        {
            try
            {
                SQLiteConnection sql_con = new SQLiteConnection("data source=users");
                sql_con.Open();
                SQLiteCommand sql_cmd = sql_con.CreateCommand();
                sql_cmd.CommandText = "SELECT * FROM userinfo";
                SQLiteDataAdapter DB = new SQLiteDataAdapter(sql_cmd.CommandText, sql_con);
                sql_con.Close();
                DataSet DS = new DataSet();
                DB.Fill(DS);
                listView.DataContext = DS.Tables[0].DefaultView;
            }
            catch(Exception ex)
            {

            }
        }

        private void ButtonAddUser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                long ik = Convert.ToInt64(TextBoxIsikukood.Text);
                string eesnimi = TextBoxEesnimi.Text;
                string perekonnanimi = TextBoxPerekonnanimi.Text;
                string kasutaja = TextBoxKasutaja.Text;
                string parool = TextBoxParool.Text;

                _dbService.AddData(ik, eesnimi, perekonnanimi, kasutaja, parool, "userinfo");
                ShowData();
            }
            catch (Exception ex)
            {

            }

            TextBoxPerekonnanimi.Text = "";
            TextBoxEesnimi.Text = "";
            TextBoxIsikukood.Text = "";
            TextBoxKasutaja.Text = "";
            TextBoxParool.Text = "";
        }

        //private void ButtonViewUsers_Click(object sender, RoutedEventArgs e)
        //{
        //    ShowData();
        //}

        private void ButtonRemoveUser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                long id = (long)((DataRowView)listView.SelectedItems[0])["isikukood"];
                _dbService.DeleteData(id, "userinfo");
                ShowData();
            }
            catch (Exception ex)
            {
                
            }

        }

        private void listView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataRowView DataRow;
            int row;
            long ID;
            string nimi;
            string pere;
            string kasutaja;
            string parool;

            try
            {
                row = listView.SelectedIndex;
                DataRow = listView.Items.GetItemAt(row) as DataRowView;
                ID = Convert.ToInt64(DataRow["Isikukood"]);
                TextBoxIsikukood.Text = ID.ToString();

                nimi = DataRow["eesnimi"].ToString();
                TextBoxEesnimi.Text = nimi;

                pere = DataRow["Perekonnanimi"].ToString();
                TextBoxPerekonnanimi.Text = pere;

                kasutaja = DataRow["Kasutajanimi"].ToString();
                TextBoxKasutaja.Text = kasutaja;

                parool = DataRow["Parool"].ToString();
                TextBoxParool.Text = parool;
            }
            catch (Exception ex)
            {

            }
        }

        private void ButtonUuenda_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int row = listView.SelectedIndex;
                DataRowView DataRow = listView.Items.GetItemAt(row) as DataRowView;
                var ID = DataRow["userid"];
                UserID = ID.ToString();
            }
            catch (Exception ex)
            {
                
            }

            SQLiteConnection sql_con = new SQLiteConnection("data source=users");
            sql_con.Open();
            string query = "UPDATE userinfo SET isikukood ='" + TextBoxIsikukood.Text + "', eesnimi ='" + TextBoxEesnimi.Text + "', perekonnanimi ='" + TextBoxPerekonnanimi.Text + "', kasutajanimi = '" + TextBoxKasutaja.Text + "', parool ='"
                                + TextBoxParool.Text + "' WHERE userid ='" + UserID + "'";
            SQLiteCommand command = new SQLiteCommand(query, sql_con);
            command.ExecuteNonQuery();
            sql_con.Close();

            UserID = null;
            TextBoxPerekonnanimi.Text = "";
            TextBoxEesnimi.Text = "";
            TextBoxIsikukood.Text = "";
            TextBoxKasutaja.Text = "";
            TextBoxParool.Text = "";

            ShowData();
        }
    }
}
