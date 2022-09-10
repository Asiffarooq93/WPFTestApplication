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

namespace WPFTestApplication
{
    /// <summary>
    /// Interaction logic for LoadEnscape.xaml
    /// </summary>
    public partial class LoadEnscape : Window
    {
        public LoadEnscape()
        {
            InitializeComponent();
        }

        private void ButtonAddName_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text))
            {
                lstNames.Items.Add(txtName.Text);
                txtName.Clear();
            }

        }

        private void ButtonRemoveName_Click(object sender, RoutedEventArgs e)
        {
            
            if (lstNames.Items.Count != 0)
            { 
            
                lstNames.Items.RemoveAt(lstNames.Items.Count - 1);
            }
        }
    }
}
