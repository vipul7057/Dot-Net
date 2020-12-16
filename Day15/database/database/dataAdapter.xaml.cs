using System;
using System.Collections.Generic;
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
using System.Data.SqlClient;

namespace database
{
    /// <summary>
    /// Interaction logic for dataAdapter.xaml
    /// </summary>
    public partial class dataAdapter : Window
    {
        public dataAdapter()
        {
            InitializeComponent();
        }
        DataSet dataset;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=J&KDec20;Integrated Security=true";
            con.Open();

            SqlCommand cmdemps = new SqlCommand();
            cmdemps.Connection = con;
            cmdemps.CommandType = CommandType.Text;
            cmdemps.CommandText = "select * from Employees";

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmdemps;
            dataset = new DataSet();

            da.Fill(dataset, "employees");

            dgemps.ItemsSource = dataset.Tables["employees"].DefaultView;

            con.Close();


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=J&KDec20;Integrated Security=true";
            con.Open();

            SqlCommand cmdupdate = new SqlCommand();
            cmdupdate.Connection = con;
            cmdupdate.CommandType = CommandType.Text;
            cmdupdate.CommandText = "update Employees set Name = @Name," +
                "Basic = @Basic,DeptNo = @DeptNo where EmpNo = @EmpNo";
            cmdupdate.Parameters.Add(new SqlParameter { ParameterName = "@Name", SourceColumn = "Name", SourceVersion = DataRowVersion.Current });
            cmdupdate.Parameters.Add(new SqlParameter { ParameterName = "@Basic", SourceColumn = "Basic", SourceVersion = DataRowVersion.Current });
            cmdupdate.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Current });
            cmdupdate.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Original });

            


            SqlCommand cmdinsert = new SqlCommand();
            cmdinsert.Connection = con;
            cmdinsert.CommandType = CommandType.Text;
            cmdinsert.CommandText = "insert into Employees(EmpNo,Name,Basic,DeptNo) " +
                "values(@EmpNo,@Name,@Basic,@DeptNo)";

            cmdinsert.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Current });
            cmdinsert.Parameters.Add(new SqlParameter { ParameterName = "@Name", SourceColumn = "Name", SourceVersion = DataRowVersion.Current });
            cmdinsert.Parameters.Add(new SqlParameter { ParameterName = "@Basic", SourceColumn = "Basic", SourceVersion = DataRowVersion.Current });
            cmdinsert.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Current });
            
            
            SqlCommand cmddelete = new SqlCommand();
            cmddelete.Connection = con;
            cmddelete.CommandType = CommandType.Text;
            cmddelete.CommandText = "delete from Employees where EmpNo = @EmpNo";
            cmddelete.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Original });
           
            
            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = cmdinsert;
            da.UpdateCommand = cmdupdate;
            da.DeleteCommand = cmddelete;


            da.Update(dataset, "employees");
           con.Close();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=J&KDec20;Integrated Security=true";
            con.Open();

            SqlCommand cmdupdate = new SqlCommand();
            cmdupdate.Connection = con;
            cmdupdate.CommandType = CommandType.Text;
            cmdupdate.CommandText = "update Employees set Name = @Name," +
                "Basic = @Basic,DeptNo = @DeptNo where EmpNo = @EmpNo";
            cmdupdate.Parameters.Add(new SqlParameter { ParameterName = "@Name", SourceColumn = "Name", SourceVersion = DataRowVersion.Current });
            cmdupdate.Parameters.Add(new SqlParameter { ParameterName = "@Basic", SourceColumn = "Basic", SourceVersion = DataRowVersion.Current });
            cmdupdate.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Current });
            cmdupdate.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Original });




            SqlCommand cmdinsert = new SqlCommand();
            cmdinsert.Connection = con;
            cmdinsert.CommandType = CommandType.Text;
            cmdinsert.CommandText = "insert into Employees(EmpNo,Name,Basic,DeptNo) " +
                "values(@EmpNo,@Name,@Basic,@DeptNo)";

            cmdinsert.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Current });
            cmdinsert.Parameters.Add(new SqlParameter { ParameterName = "@Name", SourceColumn = "Name", SourceVersion = DataRowVersion.Current });
            cmdinsert.Parameters.Add(new SqlParameter { ParameterName = "@Basic", SourceColumn = "Basic", SourceVersion = DataRowVersion.Current });
            cmdinsert.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Current });


            SqlCommand cmddelete = new SqlCommand();
            cmddelete.Connection = con;
            cmddelete.CommandType = CommandType.Text;
            cmddelete.CommandText = "delete from Employees where EmpNo = @EmpNo";
            cmddelete.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Original });


            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = cmdinsert;
            da.UpdateCommand = cmdupdate;
            da.DeleteCommand = cmddelete;

            da.ContinueUpdateOnError = true;
            da.Update(dataset, "employees");
            con.Close();
        }
    }
}
