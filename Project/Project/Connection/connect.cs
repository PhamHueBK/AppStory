using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Project.Connection
{
    public class connect
    {
        public string connecting = "datasource=localhost;database=storyapp;username=root;password=";
        public MySqlConnection connection = new MySqlConnection(connecting);
        public void query(sqlQuery)
        {
            MySqlCommand cmd = new MySqlCommand(sqlQuery, this.connection);
            this.connection.Open();
        }
    }
}