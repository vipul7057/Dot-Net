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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lstNames.Items.Add("abc");
            lstNames.Items.Add("abc1");
            lstNames.Items.Add("abc2");
            lstNames.Items.Add("abc3");
        }

        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(lstNames.Items.Count.ToString());
            //MessageBox.Show(lstNames.SelectedItem.ToString());
            //MessageBox.Show(lstNames.SelectedIndex.ToString());

            foreach (var item in lstNames.SelectedItems)
            {
                MessageBox.Show(item.ToString());
            }
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lstNames.Items.RemoveAt(lstNames.SelectedIndex);
            }
            catch(Exception)
            {
                MessageBox.Show("Item not selected");
            }
        }

        
    }
}
