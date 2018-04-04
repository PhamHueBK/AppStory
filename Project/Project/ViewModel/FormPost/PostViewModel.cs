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
using Project.Model;
using MySql.Data.MySqlClient;

namespace Project.ViewModel.FormPost
{
    public class PostViewModel
    {
        
        public DataTable loadData()
        {
            string connecting = "datasource=localhost;database=storyapp;username=root;password=";
            MySqlConnection connection = new MySqlConnection(connecting);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `posts`", connection);
            connection.Open();
            DataTable data = new DataTable();
            data.Load(cmd.ExecuteReader());
            connection.Close();
            Console.Write(data);
            return data;
        }
    }
}
