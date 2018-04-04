using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
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
using System.Data.SqlClient;
using System.Data;
using System.Data;

namespace Project.Connection
{
    public class connect
    {
        string connecting = "datasource=localhost;database=storyapp1;username=root;password=";
        MySqlConnection connection = new MySqlConnection();
        MySqlConnection sql = new MySqlConnection("datasource=localhost;database=storyapp1;username=root;password=");
        public void query(string sqlQuery)
        {
            MySqlCommand cmd = new MySqlCommand(sqlQuery, this.connection);
            this.connection.Open();
        }
    }
}