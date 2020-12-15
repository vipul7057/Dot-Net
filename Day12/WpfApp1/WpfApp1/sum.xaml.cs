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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for sum.xaml
    /// </summary>
    public partial class sum : Window
    {
        public sum()
        {
            InitializeComponent();
        }

        private void txtinput_KeyDown(object sender, KeyEventArgs e)
        {
            int n = KeyInterop.VirtualKeyFromKey(e.Key);
            if(n>=48 && n<=57)
            {

            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
