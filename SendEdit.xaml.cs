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


namespace ppcLookupV2
{
    /// <summary>
    /// Interaction logic for SendEdit.xaml
    /// </summary>
    public partial class SendEdit : Window
    {
        public SendEdit()
        {
            InitializeComponent();
            request.Items.Add("Add New Listing");
            request.Items.Add("Add Town");
            request.Items.Add("Change Code");
        }

        private void sendRequest_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
