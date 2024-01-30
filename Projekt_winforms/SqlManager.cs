using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI.CRUD;
using MySql.Data.MySqlClient;

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
            string addDate = "insert into Daty.dates (date, description, user_id) VALUES ('"+date+"', '"+description+"' , (select users.id from users where username = '"+username+"'));";
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
    }
}
