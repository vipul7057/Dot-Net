using database.DataSet1TableAdapters;
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
using System.Windows.Shapes;

namespace database
{
    /// <summary>
    /// Interaction logic for DatabaseWindow.xaml
    /// </summary>
    public partial class DatabaseWindow : Window
    {
        public DatabaseWindow()
        {
            InitializeComponent();
        }
        DataSet1 ds;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ds = new DataSet1();
            DepartmentsTableAdapter dadeps = new DepartmentsTableAdapter();
            dadeps.Fill(ds.Departments);

            EmployeesTableAdapter daemps = new EmployeesTableAdapter();
            daemps.Fill(ds.Employees);

            dgData.ItemsSource = ds.Employees.DefaultView;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            EmployeesTableAdapter daemps = new EmployeesTableAdapter();
            daemps.Update(ds.Employees);

        }
    }
}
