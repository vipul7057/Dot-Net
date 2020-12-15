using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace database
{
    /// <summary>
    /// Interaction logic for dataReader.xaml
    /// </summary>
    public partial class dataReader : Window
    {
        public dataReader()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    cn = new SqlConnection();
            //    cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=J&KDec20;Integrated Security=true";
            //    cn.Open();
            //    SqlCommand cmd = new SqlCommand("select * from Employees", cn);
            //    cmd.Connection = cn;
            //    SqlDataReader sdr = cmd.ExecuteReader();
            //    while (sdr.Read())
            //    {
            //        lstNames.Items.Add(sdr["Name"]);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{ 
            //        cn.Close();
            //}

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=J&KDec20;Integrated Security=true";
            
            con.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from Departments";

            SqlDataReader dr = command.ExecuteReader();

            while(dr.Read())
            {
                lstNames.Items.Add(dr["DeptName"]);

            }

            dr.Close();
            con.Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=J&KDec20;Integrated Security=true";

            con.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from Employees;select * from Departments";

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                lstNames.Items.Add(dr["Name"]);
            }
            dr.NextResult();
            while (dr.Read())
            {
                lstNames.Items.Add(dr["DeptName"]);
            }

            dr.Close();
            con.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SqlDataReader dr = getdata();
            while(dr.Read())
            {
                lstNames.Items.Add(dr["Name"]);
            }
            dr.Close();
        }

        private SqlDataReader getdata()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=J&KDec20;Integrated Security=true";

            con.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from Employees";
            SqlDataReader dr = command.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }
    }
}
