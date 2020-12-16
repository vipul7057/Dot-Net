using database.DataSet2TableAdapters;
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
    /// Interaction logic for practiceDataset.xaml
    /// </summary>
    public partial class practiceDataset : Window
    {
        public practiceDataset()
        {
            InitializeComponent();
        }

        DataSet2 ds;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            departmentsTableAdapter dadeps = new departmentsTableAdapter();
            ds = new DataSet2();
            dadeps.Fill(ds.departments);
            dgdept.ItemsSource = ds.departments.DefaultView;


            employeeTableAdapter daemps = new employeeTableAdapter();
            daemps.Fill(ds.employee);
            dgData.ItemsSource = ds.employee.DefaultView;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            departmentsTableAdapter dadeps = new departmentsTableAdapter();
            dadeps.Update(ds.departments);

            employeeTableAdapter daemps = new employeeTableAdapter();
            daemps.Update(ds.employee);
        }

    }
}
