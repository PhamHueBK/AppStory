using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Project.Connection;
using Project.Model.FormPost;

namespace Project.ViewModel.FormPost
{
    public class PostViewModel
    {
        public MySqlConnection connection = new connect();
        public MySqlConnection connect = connect.query("SELECT * FROM posts");
        public PostModel[] posts;
        public void loadData()
        {
            DataTable data = new DataTable();
            data.Load(cmd.ExecuteReader());
            this.connect.Close();
            posts = data;
        }
    }
}
