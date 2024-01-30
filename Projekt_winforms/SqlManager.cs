using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI.CRUD;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;
using TextBox = System.Windows.Forms.TextBox;

namespace Projekt_winforms
{
    public class SqlManager
    {
        public string username;
        public DateFormatter dateFormatter;
        public SqlManager(string username)
        {
            this.username = username;
        }

        public void AddDate(string date, string description,string loggedusername)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;database=Daty;";
            string addDate = "insert into Daty.dates (date, description, user_id) VALUES ('" + date+ "', '" + description+ "' , (select users.id from users where username = '" + username+"'));";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand command = new MySqlCommand(addDate, myConn); 
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = command.ExecuteReader();
                MessageBox.Show("Data została wpsiana");
                while (myReader.Read())
                {
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void EditDate(string date, string description, string loggedusername)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;database=Daty;";
            string editDate = "update Daty.dates set date = '" + date + "',description =  '" + description + "' ,user_id = (select users.id from users where username = '" + username + "') where id = 9;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand command = new MySqlCommand(editDate, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = command.ExecuteReader();
                MessageBox.Show("Data została zaktualizowana");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteDate(string date, string description, string loggedusername)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;database=Daty;";
            string editDate = "delete from Daty.dates where id = 9;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand command = new MySqlCommand(editDate, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = command.ExecuteReader();
                MessageBox.Show("Data została Usunięta");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void FillCombo(ComboBox comboBox)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;database=Daty;";
            string editDate = "select * from Daty.dates";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand command = new MySqlCommand(editDate, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    string sDesc = myReader.GetString("description");
                    comboBox.Items.Add(sDesc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ComboValuesReader(ComboBox comboBox, TextBox textbox, DateTimePicker dateTimePicker)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;database=Daty;";
            string editDate = "select * from Daty.dates where description = '" + comboBox.Text + "'  ;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand command = new MySqlCommand(editDate, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    int sId = myReader.GetInt32("id");
                    string sDesc = myReader.GetString("description");
                    DateTime sDate = myReader.GetDateTime("date");
                    textbox.Text = sDesc;
                    dateTimePicker.Value = sDate;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
