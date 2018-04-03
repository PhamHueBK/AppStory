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

namespace Project.View
{
    /// <summary>
    /// Interaction logic for ListPath.xaml
    /// </summary>
    public partial class ListPath : Window
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\DotNet\App\AppStory\Project\Project\Database.mdf;Integrated Security=True");
        SqlCommand cmd;
        public ListPath()
        {
            InitializeComponent();
            //  cmd = new SqlCommand("insert into Paths values(@,@)",con);
            //   cmd.Parameters.AddWithValue("",);
            //   con.Open();
            //    cmd.ExecuteNonQuery();
            //   con.Close();
               LoadData();
        }
        
        public void LoadData()
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from [Paths]";
            cmd.ExecuteNonQuery();
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);
            adapter.FillSchema(data, SchemaType.Source);
            con.Close();


        }
    }
}
